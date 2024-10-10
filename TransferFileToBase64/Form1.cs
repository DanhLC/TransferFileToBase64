namespace TransferFileToBase64
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private async void btnChoose_Click(object sender, EventArgs e)
		{
			try
			{
				SetAllButtonsEnabled(false);

				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = "All Files (*.*)|*.*";
					openFileDialog.Title = "Select a file to convert to Base64";

					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						pbFileToBase64.Style = ProgressBarStyle.Marquee;
						pbFileToBase64.Visible = true;
						var base64String = string.Empty;

						try
						{
							var fileBytes = await Task.Run(() => System.IO.File.ReadAllBytes(openFileDialog.FileName));
							base64String = await Task.Run(() => Convert.ToBase64String(fileBytes));
						}
						catch
						{
							throw new Exception("File too large to create base 64");
						}
						Clipboard.SetText(base64String);
						rtbBase64View.Text = base64String;
						pbFileToBase64.Visible = false;

						MessageBox.Show("File exported successfully and Base64 data copied to clipboard.");
					}
				}

				SetAllButtonsEnabled(true);
			}
			catch (Exception ex)
			{
				pbFileToBase64.Visible = false;
				SetAllButtonsEnabled(true);
				MessageBox.Show(ex.Message);
			}
		}

		private void SetAllButtonsEnabled(bool enabled)
		{
			foreach (Control control in this.Controls)
			{
				if (control is System.Windows.Forms.Button)
				{
					control.Enabled = enabled;
				}
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtbBase64View.Text);
			MessageBox.Show(this, "Copied", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private async void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(rtbBase64.Text.Trim())) throw new Exception("Please input base 64 data to export");

				if (string.IsNullOrEmpty(tbFileExtension.Text.Trim())) throw new Exception("Please input file extension to export");

				SetAllButtonsEnabled(false);

				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "All Files (*.*)|*.*";
					saveFileDialog.Title = "Save Base64 File";
					saveFileDialog.FileName = string.Format("ExportedFile_{0:ddMMyyyy}_{0:hhMMsss}.{1}", DateTime.Now, tbFileExtension.Text.Trim());

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						pbFileToBase64.Style = ProgressBarStyle.Marquee;
						pbFileToBase64.Visible = true;

						var fileBytes = Convert.FromBase64String(rtbBase64.Text.Trim());

						await Task.Run(() => System.IO.File.WriteAllBytes(saveFileDialog.FileName, fileBytes));

						pbFileToBase64.Visible = false;

						MessageBox.Show("File exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}

				SetAllButtonsEnabled(true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void btnExportTxt_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(rtbBase64View.Text.Trim())) throw new Exception("No data in text box available for export");

				using (var saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
					saveFileDialog.DefaultExt = "txt";
					saveFileDialog.AddExtension = true;
					saveFileDialog.Title = "Choose location to export file";
					saveFileDialog.FileName = string.Format("ExportedHistory_{0:ddMMyyyy}_{0:hhMMsss}.txt", DateTime.Now);

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						SetAllButtonsEnabled(false);

						pbFileToBase64.Style = ProgressBarStyle.Marquee;
						pbFileToBase64.Visible = true;

						await System.IO.File.WriteAllTextAsync(saveFileDialog.FileName, rtbBase64View.Text);

						pbFileToBase64.Visible = false;
						SetAllButtonsEnabled(true);
						MessageBox.Show("Export successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading log: " + ex.Message);
			}
		}
	}
}