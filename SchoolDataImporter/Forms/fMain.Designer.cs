namespace SchoolDataImporter.Forms
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.cmbPreviousConnections = new System.Windows.Forms.ComboBox();
            this.lblSelectFileToOpen = new System.Windows.Forms.Label();
            this.pnlSelectFile = new System.Windows.Forms.Panel();
            this.pnlSelectFileTextContainer = new System.Windows.Forms.Panel();
            this.txtDbFile = new System.Windows.Forms.TextBox();
            this.cmdBrowseFile = new System.Windows.Forms.Button();
            this.pnlDbSelected = new System.Windows.Forms.Panel();
            this.pnlProgressContainer = new System.Windows.Forms.Panel();
            this.pbProcessing = new System.Windows.Forms.ProgressBar();
            this.pnlStartContainer = new System.Windows.Forms.Panel();
            this.cmdStart = new System.Windows.Forms.Button();
            this.pnlStartContainerPaddingRight = new System.Windows.Forms.Panel();
            this.pnlStartContainerPaddingLeft = new System.Windows.Forms.Panel();
            this.lblLastUseDate = new System.Windows.Forms.Label();
            this.lblLastAccessText = new System.Windows.Forms.Label();
            this.lblCorrectDb = new System.Windows.Forms.Label();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.pnlSelectFile.SuspendLayout();
            this.pnlSelectFileTextContainer.SuspendLayout();
            this.pnlDbSelected.SuspendLayout();
            this.pnlProgressContainer.SuspendLayout();
            this.pnlStartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectFile.Location = new System.Drawing.Point(10, 10);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(784, 20);
            this.lblSelectFile.TabIndex = 0;
            this.lblSelectFile.Text = "Select a previously used database:";
            // 
            // cmbPreviousConnections
            // 
            this.cmbPreviousConnections.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPreviousConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreviousConnections.FormattingEnabled = true;
            this.cmbPreviousConnections.ItemHeight = 13;
            this.cmbPreviousConnections.Location = new System.Drawing.Point(10, 30);
            this.cmbPreviousConnections.Name = "cmbPreviousConnections";
            this.cmbPreviousConnections.Size = new System.Drawing.Size(784, 21);
            this.cmbPreviousConnections.TabIndex = 1;
            this.cmbPreviousConnections.SelectedIndexChanged += new System.EventHandler(this.cmbPreviousConnections_SelectedIndexChanged);
            // 
            // lblSelectFileToOpen
            // 
            this.lblSelectFileToOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectFileToOpen.Location = new System.Drawing.Point(10, 51);
            this.lblSelectFileToOpen.Name = "lblSelectFileToOpen";
            this.lblSelectFileToOpen.Size = new System.Drawing.Size(784, 20);
            this.lblSelectFileToOpen.TabIndex = 2;
            this.lblSelectFileToOpen.Text = "Or select a database file to open:";
            this.lblSelectFileToOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSelectFile
            // 
            this.pnlSelectFile.Controls.Add(this.pnlSelectFileTextContainer);
            this.pnlSelectFile.Controls.Add(this.cmdBrowseFile);
            this.pnlSelectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectFile.Location = new System.Drawing.Point(10, 71);
            this.pnlSelectFile.Name = "pnlSelectFile";
            this.pnlSelectFile.Size = new System.Drawing.Size(784, 21);
            this.pnlSelectFile.TabIndex = 3;
            // 
            // pnlSelectFileTextContainer
            // 
            this.pnlSelectFileTextContainer.Controls.Add(this.txtDbFile);
            this.pnlSelectFileTextContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectFileTextContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectFileTextContainer.Name = "pnlSelectFileTextContainer";
            this.pnlSelectFileTextContainer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlSelectFileTextContainer.Size = new System.Drawing.Size(743, 21);
            this.pnlSelectFileTextContainer.TabIndex = 2;
            // 
            // txtDbFile
            // 
            this.txtDbFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbFile.Location = new System.Drawing.Point(0, 0);
            this.txtDbFile.Name = "txtDbFile";
            this.txtDbFile.ReadOnly = true;
            this.txtDbFile.Size = new System.Drawing.Size(733, 20);
            this.txtDbFile.TabIndex = 3;
            // 
            // cmdBrowseFile
            // 
            this.cmdBrowseFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdBrowseFile.Location = new System.Drawing.Point(743, 0);
            this.cmdBrowseFile.Name = "cmdBrowseFile";
            this.cmdBrowseFile.Size = new System.Drawing.Size(41, 21);
            this.cmdBrowseFile.TabIndex = 1;
            this.cmdBrowseFile.Text = "...";
            this.cmdBrowseFile.UseVisualStyleBackColor = true;
            this.cmdBrowseFile.Click += new System.EventHandler(this.cmdBrowseFile_Click);
            // 
            // pnlDbSelected
            // 
            this.pnlDbSelected.Controls.Add(this.pnlProgressContainer);
            this.pnlDbSelected.Controls.Add(this.pnlStartContainer);
            this.pnlDbSelected.Controls.Add(this.lblLastUseDate);
            this.pnlDbSelected.Controls.Add(this.lblLastAccessText);
            this.pnlDbSelected.Controls.Add(this.lblCorrectDb);
            this.pnlDbSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDbSelected.Location = new System.Drawing.Point(10, 92);
            this.pnlDbSelected.Name = "pnlDbSelected";
            this.pnlDbSelected.Size = new System.Drawing.Size(784, 152);
            this.pnlDbSelected.TabIndex = 8;
            this.pnlDbSelected.Visible = false;
            // 
            // pnlProgressContainer
            // 
            this.pnlProgressContainer.Controls.Add(this.pbProcessing);
            this.pnlProgressContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProgressContainer.Location = new System.Drawing.Point(0, 108);
            this.pnlProgressContainer.Name = "pnlProgressContainer";
            this.pnlProgressContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlProgressContainer.Size = new System.Drawing.Size(784, 44);
            this.pnlProgressContainer.TabIndex = 16;
            // 
            // pbProcessing
            // 
            this.pbProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProcessing.Location = new System.Drawing.Point(0, 10);
            this.pbProcessing.Name = "pbProcessing";
            this.pbProcessing.Size = new System.Drawing.Size(784, 24);
            this.pbProcessing.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbProcessing.TabIndex = 10;
            this.pbProcessing.Visible = false;
            // 
            // pnlStartContainer
            // 
            this.pnlStartContainer.Controls.Add(this.cmdStart);
            this.pnlStartContainer.Controls.Add(this.pnlStartContainerPaddingRight);
            this.pnlStartContainer.Controls.Add(this.pnlStartContainerPaddingLeft);
            this.pnlStartContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStartContainer.Location = new System.Drawing.Point(0, 76);
            this.pnlStartContainer.Name = "pnlStartContainer";
            this.pnlStartContainer.Size = new System.Drawing.Size(784, 32);
            this.pnlStartContainer.TabIndex = 15;
            // 
            // cmdStart
            // 
            this.cmdStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdStart.Location = new System.Drawing.Point(300, 0);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(184, 32);
            this.cmdStart.TabIndex = 2;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // pnlStartContainerPaddingRight
            // 
            this.pnlStartContainerPaddingRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStartContainerPaddingRight.Location = new System.Drawing.Point(484, 0);
            this.pnlStartContainerPaddingRight.Name = "pnlStartContainerPaddingRight";
            this.pnlStartContainerPaddingRight.Size = new System.Drawing.Size(300, 32);
            this.pnlStartContainerPaddingRight.TabIndex = 1;
            // 
            // pnlStartContainerPaddingLeft
            // 
            this.pnlStartContainerPaddingLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStartContainerPaddingLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlStartContainerPaddingLeft.Name = "pnlStartContainerPaddingLeft";
            this.pnlStartContainerPaddingLeft.Size = new System.Drawing.Size(300, 32);
            this.pnlStartContainerPaddingLeft.TabIndex = 0;
            // 
            // lblLastUseDate
            // 
            this.lblLastUseDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastUseDate.Location = new System.Drawing.Point(0, 53);
            this.lblLastUseDate.Name = "lblLastUseDate";
            this.lblLastUseDate.Size = new System.Drawing.Size(784, 23);
            this.lblLastUseDate.TabIndex = 14;
            this.lblLastUseDate.Text = "{8888-88-88 88:88:88}";
            this.lblLastUseDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLastAccessText
            // 
            this.lblLastAccessText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastAccessText.Location = new System.Drawing.Point(0, 30);
            this.lblLastAccessText.Name = "lblLastAccessText";
            this.lblLastAccessText.Size = new System.Drawing.Size(784, 23);
            this.lblLastAccessText.TabIndex = 13;
            this.lblLastAccessText.Text = "The source database was last used/seen on:";
            this.lblLastAccessText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCorrectDb
            // 
            this.lblCorrectDb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCorrectDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectDb.Location = new System.Drawing.Point(0, 0);
            this.lblCorrectDb.Name = "lblCorrectDb";
            this.lblCorrectDb.Size = new System.Drawing.Size(784, 30);
            this.lblCorrectDb.TabIndex = 12;
            this.lblCorrectDb.Text = "Correct database?";
            this.lblCorrectDb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 254);
            this.Controls.Add(this.pnlDbSelected);
            this.Controls.Add(this.pnlSelectFile);
            this.Controls.Add(this.lblSelectFileToOpen);
            this.Controls.Add(this.cmbPreviousConnections);
            this.Controls.Add(this.lblSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import School Data";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pnlSelectFile.ResumeLayout(false);
            this.pnlSelectFileTextContainer.ResumeLayout(false);
            this.pnlSelectFileTextContainer.PerformLayout();
            this.pnlDbSelected.ResumeLayout(false);
            this.pnlProgressContainer.ResumeLayout(false);
            this.pnlStartContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.ComboBox cmbPreviousConnections;
        private System.Windows.Forms.Label lblSelectFileToOpen;
        private System.Windows.Forms.Panel pnlSelectFile;
        private System.Windows.Forms.Panel pnlSelectFileTextContainer;
        private System.Windows.Forms.TextBox txtDbFile;
        private System.Windows.Forms.Button cmdBrowseFile;
        private System.Windows.Forms.Panel pnlDbSelected;
        private System.Windows.Forms.Panel pnlStartContainer;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Panel pnlStartContainerPaddingRight;
        private System.Windows.Forms.Panel pnlStartContainerPaddingLeft;
        private System.Windows.Forms.Label lblLastUseDate;
        private System.Windows.Forms.Label lblLastAccessText;
        private System.Windows.Forms.Label lblCorrectDb;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Panel pnlProgressContainer;
        private System.Windows.Forms.ProgressBar pbProcessing;
    }
}

