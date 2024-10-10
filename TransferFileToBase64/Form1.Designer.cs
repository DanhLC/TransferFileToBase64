namespace TransferFileToBase64
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl = new TabControl();
			tpFileToBase64 = new TabPage();
			panel2 = new Panel();
			rtbBase64View = new RichTextBox();
			panel1 = new Panel();
			panel6 = new Panel();
			btnExportTxt = new Button();
			pbFileToBase64 = new ProgressBar();
			panel4 = new Panel();
			btnCopy = new Button();
			panel3 = new Panel();
			btnChoose = new Button();
			tpBase64ToFile = new TabPage();
			panel8 = new Panel();
			rtbBase64 = new RichTextBox();
			panel5 = new Panel();
			panel10 = new Panel();
			tbFileExtension = new TextBox();
			pbBase64ToFile = new ProgressBar();
			panel9 = new Panel();
			label1 = new Label();
			panel7 = new Panel();
			btnExport = new Button();
			tabControl.SuspendLayout();
			tpFileToBase64.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			panel6.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			tpBase64ToFile.SuspendLayout();
			panel8.SuspendLayout();
			panel5.SuspendLayout();
			panel10.SuspendLayout();
			panel9.SuspendLayout();
			panel7.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tpFileToBase64);
			tabControl.Controls.Add(tpBase64ToFile);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(1138, 710);
			tabControl.TabIndex = 0;
			// 
			// tpFileToBase64
			// 
			tpFileToBase64.Controls.Add(panel2);
			tpFileToBase64.Controls.Add(panel1);
			tpFileToBase64.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
			tpFileToBase64.Location = new Point(4, 31);
			tpFileToBase64.Name = "tpFileToBase64";
			tpFileToBase64.Padding = new Padding(3);
			tpFileToBase64.Size = new Size(1130, 675);
			tpFileToBase64.TabIndex = 0;
			tpFileToBase64.Text = "File to Base 64";
			tpFileToBase64.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(rtbBase64View);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(3, 59);
			panel2.Name = "panel2";
			panel2.Size = new Size(1124, 613);
			panel2.TabIndex = 1;
			// 
			// rtbBase64View
			// 
			rtbBase64View.Dock = DockStyle.Fill;
			rtbBase64View.Location = new Point(0, 0);
			rtbBase64View.Name = "rtbBase64View";
			rtbBase64View.ReadOnly = true;
			rtbBase64View.Size = new Size(1124, 613);
			rtbBase64View.TabIndex = 0;
			rtbBase64View.Text = "";
			// 
			// panel1
			// 
			panel1.Controls.Add(panel6);
			panel1.Controls.Add(pbFileToBase64);
			panel1.Controls.Add(panel4);
			panel1.Controls.Add(panel3);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(1124, 56);
			panel1.TabIndex = 0;
			// 
			// panel6
			// 
			panel6.AutoSize = true;
			panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel6.Controls.Add(btnExportTxt);
			panel6.Dock = DockStyle.Left;
			panel6.Location = new Point(262, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(144, 56);
			panel6.TabIndex = 3;
			// 
			// btnExportTxt
			// 
			btnExportTxt.AutoSize = true;
			btnExportTxt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnExportTxt.BackColor = Color.DodgerBlue;
			btnExportTxt.FlatStyle = FlatStyle.Popup;
			btnExportTxt.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnExportTxt.ForeColor = Color.White;
			btnExportTxt.Location = new Point(9, 12);
			btnExportTxt.Name = "btnExportTxt";
			btnExportTxt.Size = new Size(132, 32);
			btnExportTxt.TabIndex = 2;
			btnExportTxt.Text = "Export to txt";
			btnExportTxt.UseVisualStyleBackColor = false;
			btnExportTxt.Click += btnExportTxt_Click;
			// 
			// pbFileToBase64
			// 
			pbFileToBase64.Location = new Point(924, 12);
			pbFileToBase64.Name = "pbFileToBase64";
			pbFileToBase64.Size = new Size(195, 34);
			pbFileToBase64.TabIndex = 2;
			pbFileToBase64.Visible = false;
			// 
			// panel4
			// 
			panel4.AutoSize = true;
			panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel4.Controls.Add(btnCopy);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(145, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(117, 56);
			panel4.TabIndex = 1;
			// 
			// btnCopy
			// 
			btnCopy.AutoSize = true;
			btnCopy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnCopy.BackColor = Color.DodgerBlue;
			btnCopy.FlatStyle = FlatStyle.Popup;
			btnCopy.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCopy.ForeColor = Color.White;
			btnCopy.Location = new Point(9, 12);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(105, 32);
			btnCopy.TabIndex = 2;
			btnCopy.Text = "Copy text";
			btnCopy.UseVisualStyleBackColor = false;
			btnCopy.Click += btnCopy_Click;
			// 
			// panel3
			// 
			panel3.AutoSize = true;
			panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel3.Controls.Add(btnChoose);
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(145, 56);
			panel3.TabIndex = 0;
			// 
			// btnChoose
			// 
			btnChoose.AutoSize = true;
			btnChoose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnChoose.BackColor = Color.DodgerBlue;
			btnChoose.FlatStyle = FlatStyle.Popup;
			btnChoose.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnChoose.ForeColor = Color.White;
			btnChoose.Location = new Point(5, 12);
			btnChoose.Name = "btnChoose";
			btnChoose.Size = new Size(137, 32);
			btnChoose.TabIndex = 1;
			btnChoose.Text = "Choose file...";
			btnChoose.UseVisualStyleBackColor = false;
			btnChoose.Click += btnChoose_Click;
			// 
			// tpBase64ToFile
			// 
			tpBase64ToFile.Controls.Add(panel8);
			tpBase64ToFile.Controls.Add(panel5);
			tpBase64ToFile.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
			tpBase64ToFile.ForeColor = SystemColors.ControlText;
			tpBase64ToFile.Location = new Point(4, 34);
			tpBase64ToFile.Name = "tpBase64ToFile";
			tpBase64ToFile.Padding = new Padding(3);
			tpBase64ToFile.Size = new Size(1130, 672);
			tpBase64ToFile.TabIndex = 1;
			tpBase64ToFile.Text = "Base64 to File";
			tpBase64ToFile.UseVisualStyleBackColor = true;
			// 
			// panel8
			// 
			panel8.Controls.Add(rtbBase64);
			panel8.Dock = DockStyle.Fill;
			panel8.Location = new Point(3, 59);
			panel8.Name = "panel8";
			panel8.Size = new Size(1124, 610);
			panel8.TabIndex = 2;
			// 
			// rtbBase64
			// 
			rtbBase64.Dock = DockStyle.Fill;
			rtbBase64.Location = new Point(0, 0);
			rtbBase64.Name = "rtbBase64";
			rtbBase64.Size = new Size(1124, 610);
			rtbBase64.TabIndex = 0;
			rtbBase64.Text = "";
			// 
			// panel5
			// 
			panel5.Controls.Add(panel10);
			panel5.Controls.Add(pbBase64ToFile);
			panel5.Controls.Add(panel9);
			panel5.Controls.Add(panel7);
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(3, 3);
			panel5.Name = "panel5";
			panel5.Size = new Size(1124, 56);
			panel5.TabIndex = 1;
			// 
			// panel10
			// 
			panel10.Controls.Add(tbFileExtension);
			panel10.Dock = DockStyle.Left;
			panel10.Location = new Point(277, 0);
			panel10.Name = "panel10";
			panel10.Size = new Size(175, 56);
			panel10.TabIndex = 4;
			// 
			// tbFileExtension
			// 
			tbFileExtension.Location = new Point(6, 10);
			tbFileExtension.Name = "tbFileExtension";
			tbFileExtension.Size = new Size(153, 32);
			tbFileExtension.TabIndex = 0;
			// 
			// pbBase64ToFile
			// 
			pbBase64ToFile.Location = new Point(926, 10);
			pbBase64ToFile.Name = "pbBase64ToFile";
			pbBase64ToFile.Size = new Size(195, 34);
			pbBase64ToFile.TabIndex = 3;
			pbBase64ToFile.Visible = false;
			// 
			// panel9
			// 
			panel9.AutoSize = true;
			panel9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel9.Controls.Add(label1);
			panel9.Dock = DockStyle.Left;
			panel9.Location = new Point(118, 0);
			panel9.Name = "panel9";
			panel9.Size = new Size(159, 56);
			panel9.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 15);
			label1.Name = "label1";
			label1.Size = new Size(150, 24);
			label1.TabIndex = 0;
			label1.Text = "File extension";
			// 
			// panel7
			// 
			panel7.AutoSize = true;
			panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel7.Controls.Add(btnExport);
			panel7.Dock = DockStyle.Left;
			panel7.Location = new Point(0, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(118, 56);
			panel7.TabIndex = 0;
			// 
			// btnExport
			// 
			btnExport.AutoSize = true;
			btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnExport.BackColor = Color.DodgerBlue;
			btnExport.FlatStyle = FlatStyle.Popup;
			btnExport.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnExport.ForeColor = Color.White;
			btnExport.Location = new Point(5, 12);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(110, 32);
			btnExport.TabIndex = 1;
			btnExport.Text = "ExportFile";
			btnExport.UseVisualStyleBackColor = false;
			btnExport.Click += btnExport_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 22F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1138, 710);
			Controls.Add(tabControl);
			Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Transfer file to base64";
			tabControl.ResumeLayout(false);
			tpFileToBase64.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			tpBase64ToFile.ResumeLayout(false);
			panel8.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel10.ResumeLayout(false);
			panel10.PerformLayout();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl;
		private TabPage tpFileToBase64;
		private Panel panel2;
		private RichTextBox rtbBase64View;
		private Panel panel1;
		private Panel panel4;
		private Button btnCopy;
		private Panel panel3;
		private Button btnChoose;
		private TabPage tpBase64ToFile;
		private Panel panel8;
		private RichTextBox rtbBase64;
		private Panel panel5;
		private Panel panel7;
		private Button btnExport;
		private ProgressBar pbFileToBase64;
		private Panel panel10;
		private TextBox tbFileExtension;
		private ProgressBar pbBase64ToFile;
		private Panel panel9;
		private Label label1;
		private Panel panel6;
		private Button btnExportTxt;
	}
}