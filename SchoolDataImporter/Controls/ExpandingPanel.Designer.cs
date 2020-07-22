namespace SchoolDataImporter.Controls
{
    partial class ExpandingPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pbExpand = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.lblHeading);
            this.pnlContainer.Controls.Add(this.pbExpand);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(4, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Size = new System.Drawing.Size(195, 31);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(4, 4);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(167, 21);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "PanelTitle";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // pbExpand
            // 
            this.pbExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExpand.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbExpand.Image = global::SchoolDataImporter.Properties.Resources.ExpandDown_16x;
            this.pbExpand.Location = new System.Drawing.Point(171, 4);
            this.pbExpand.Name = "pbExpand";
            this.pbExpand.Size = new System.Drawing.Size(18, 21);
            this.pbExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExpand.TabIndex = 0;
            this.pbExpand.TabStop = false;
            this.pbExpand.Click += new System.EventHandler(this.pbExpand_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 35);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(195, 128);
            this.pnlContent.TabIndex = 1;
            // 
            // ExpandingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlContainer);
            this.Name = "ExpandingPanel";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(203, 167);
            this.Load += new System.EventHandler(this.ExpandingPanel_Load);
            this.Resize += new System.EventHandler(this.ExpandingPanel_Resize);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExpand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pbExpand;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlContent;
    }
}
