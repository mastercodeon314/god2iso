using God2Iso.Properties;

namespace God2Iso {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listPackages = new System.Windows.Forms.ListBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelDirectories = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labelIsoProg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton3 = new DarkControls.Controls.MaximizeButton();
            this.closeButton2 = new DarkControls.Controls.MinimizeButton();
            this.closeBtn = new DarkControls.Controls.CloseButton();
            this.textBox1 = new DarkControls.Controls.DarkTextBox();
            this.buttonAbout = new DarkControls.Controls.DarkButton();
            this.cbFix = new DarkControls.Controls.DarkCheckBox();
            this.progressIso = new DarkControls.Controls.ProgressBarEx();
            this.progressTotal = new DarkControls.Controls.ProgressBarEx();
            this.buttonClear = new DarkControls.Controls.DarkButton();
            this.buttonRemove = new DarkControls.Controls.DarkButton();
            this.buttonGo = new DarkControls.Controls.DarkButton();
            this.buttonBrowse = new DarkControls.Controls.DarkButton();
            this.buttonAdd = new DarkControls.Controls.DarkButton();
            this.textOutput = new DarkControls.Controls.DarkTextBox();
            this.formTitleLbl = new DarkControls.Controls.TransparentLabel();
            this.SuspendLayout();
            // 
            // listPackages
            // 
            this.listPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.listPackages.ForeColor = System.Drawing.Color.Silver;
            this.listPackages.FormattingEnabled = true;
            this.listPackages.Location = new System.Drawing.Point(12, 51);
            this.listPackages.Name = "listPackages";
            this.listPackages.Size = new System.Drawing.Size(353, 82);
            this.listPackages.TabIndex = 5;
            this.listPackages.SelectedIndexChanged += new System.EventHandler(this.listPackages_SelectedIndexChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(9, 136);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(85, 13);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output directory:";
            // 
            // labelDirectories
            // 
            this.labelDirectories.AutoSize = true;
            this.labelDirectories.Location = new System.Drawing.Point(9, 35);
            this.labelDirectories.Name = "labelDirectories";
            this.labelDirectories.Size = new System.Drawing.Size(80, 13);
            this.labelDirectories.TabIndex = 7;
            this.labelDirectories.Text = "God packages:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // labelIsoProg
            // 
            this.labelIsoProg.AutoSize = true;
            this.labelIsoProg.Location = new System.Drawing.Point(9, 243);
            this.labelIsoProg.Name = "labelIsoProg";
            this.labelIsoProg.Size = new System.Drawing.Size(67, 13);
            this.labelIsoProg.TabIndex = 12;
            this.labelIsoProg.Text = "Iso progress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total progress:";
            // 
            // closeButton3
            // 
            this.closeButton3.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Maximize;
            this.closeButton3.ClickColor = System.Drawing.Color.DodgerBlue;
            this.closeButton3.ClickIconColor = System.Drawing.Color.Black;
            this.closeButton3.HoverColor = System.Drawing.Color.SkyBlue;
            this.closeButton3.HoverIconColor = System.Drawing.Color.Black;
            this.closeButton3.IconColor = System.Drawing.Color.Black;
            this.closeButton3.IconLineThickness = 2;
            this.closeButton3.Location = new System.Drawing.Point(379, 0);
            this.closeButton3.Name = "closeButton3";
            this.closeButton3.Size = new System.Drawing.Size(40, 40);
            this.closeButton3.TabIndex = 20;
            this.closeButton3.Text = "closeButton3";
            this.closeButton3.UseVisualStyleBackColor = true;
            // 
            // closeButton2
            // 
            this.closeButton2.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Minimize;
            this.closeButton2.ClickColor = System.Drawing.Color.DodgerBlue;
            this.closeButton2.ClickIconColor = System.Drawing.Color.Black;
            this.closeButton2.HoverColor = System.Drawing.Color.SkyBlue;
            this.closeButton2.HoverIconColor = System.Drawing.Color.Black;
            this.closeButton2.IconColor = System.Drawing.Color.Black;
            this.closeButton2.IconLineThickness = 2;
            this.closeButton2.Location = new System.Drawing.Point(339, 0);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(40, 40);
            this.closeButton2.TabIndex = 19;
            this.closeButton2.Text = "closeButton2";
            this.closeButton2.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Close;
            this.closeBtn.ClickColor = System.Drawing.Color.Red;
            this.closeBtn.ClickIconColor = System.Drawing.Color.Black;
            this.closeBtn.HoverColor = System.Drawing.Color.OrangeRed;
            this.closeBtn.HoverIconColor = System.Drawing.Color.Black;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconLineThickness = 2;
            this.closeBtn.Location = new System.Drawing.Point(419, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.Text = "closeButton1";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(12, 330);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 217);
            this.textBox1.TabIndex = 17;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.ForeColor = System.Drawing.Color.Silver;
            this.buttonAbout.Location = new System.Drawing.Point(417, 233);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(29, 23);
            this.buttonAbout.TabIndex = 16;
            this.buttonAbout.Text = "(c)";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // cbFix
            // 
            this.cbFix.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFix.BoxBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.cbFix.BoxFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cbFix.CheckColor = System.Drawing.Color.CornflowerBlue;
            this.cbFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFix.Location = new System.Drawing.Point(12, 178);
            this.cbFix.Name = "cbFix";
            this.cbFix.Size = new System.Drawing.Size(209, 23);
            this.cbFix.TabIndex = 15;
            this.cbFix.Text = "Fix \"CreateIsoGood\" broken header";
            this.cbFix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbFix.UseVisualStyleBackColor = true;
            // 
            // progressIso
            // 
            this.progressIso.Location = new System.Drawing.Point(12, 259);
            this.progressIso.Name = "progressIso";
            this.progressIso.Size = new System.Drawing.Size(434, 23);
            this.progressIso.Step = 1;
            this.progressIso.TabIndex = 11;
            // 
            // progressTotal
            // 
            this.progressTotal.Location = new System.Drawing.Point(12, 301);
            this.progressTotal.Name = "progressTotal";
            this.progressTotal.Size = new System.Drawing.Size(434, 23);
            this.progressTotal.Step = 1;
            this.progressTotal.TabIndex = 10;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.Silver;
            this.buttonClear.Location = new System.Drawing.Point(371, 109);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemove.Location = new System.Drawing.Point(371, 80);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.ForeColor = System.Drawing.Color.Silver;
            this.buttonGo.Location = new System.Drawing.Point(192, 208);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowse.Location = new System.Drawing.Point(371, 150);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.Silver;
            this.buttonAdd.Location = new System.Drawing.Point(371, 51);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOutput.ForeColor = System.Drawing.Color.Silver;
            this.textOutput.Location = new System.Drawing.Point(12, 152);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(353, 20);
            this.textOutput.TabIndex = 1;
            this.textOutput.Text = "D:\\";
            // 
            // formTitleLbl
            // 
            this.formTitleLbl.AutoSize = true;
            this.formTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLbl.Location = new System.Drawing.Point(7, 9);
            this.formTitleLbl.Name = "formTitleLbl";
            this.formTitleLbl.Size = new System.Drawing.Size(55, 20);
            this.formTitleLbl.TabIndex = 8;
            this.formTitleLbl.Text = "Form1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(459, 559);
            this.Controls.Add(this.closeButton3);
            this.Controls.Add(this.closeButton2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.cbFix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIsoProg);
            this.Controls.Add(this.progressIso);
            this.Controls.Add(this.progressTotal);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelDirectories);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.listPackages);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.formTitleLbl);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "God2Iso vX.X.X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkControls.Controls.TransparentLabel formTitleLbl;
        private DarkControls.Controls.DarkTextBox textOutput;
        private DarkControls.Controls.DarkButton buttonAdd;
        private DarkControls.Controls.DarkButton buttonBrowse;
        private DarkControls.Controls.DarkButton buttonGo;
        private System.Windows.Forms.ListBox listPackages;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelDirectories;
        private DarkControls.Controls.DarkButton buttonRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DarkControls.Controls.DarkButton buttonClear;
        private DarkControls.Controls.ProgressBarEx progressTotal;
        private DarkControls.Controls.ProgressBarEx progressIso;
        private System.Windows.Forms.Label labelIsoProg;
        private System.Windows.Forms.Label label1;
        private DarkControls.Controls.DarkCheckBox cbFix;
        private DarkControls.Controls.DarkButton buttonAbout;
        private DarkControls.Controls.DarkTextBox textBox1;
        private DarkControls.Controls.CloseButton closeBtn;
        private DarkControls.Controls.MinimizeButton closeButton2;
        private DarkControls.Controls.MaximizeButton closeButton3;
    }
}

