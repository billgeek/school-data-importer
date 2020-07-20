namespace SchoolDataImporter.Forms
{
    partial class fExportData
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
            this.optMultipleRecipients = new System.Windows.Forms.RadioButton();
            this.optFindLearner = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // optMultipleRecipients
            // 
            this.optMultipleRecipients.AutoSize = true;
            this.optMultipleRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMultipleRecipients.Location = new System.Drawing.Point(219, 103);
            this.optMultipleRecipients.Name = "optMultipleRecipients";
            this.optMultipleRecipients.Size = new System.Drawing.Size(149, 17);
            this.optMultipleRecipients.TabIndex = 0;
            this.optMultipleRecipients.TabStop = true;
            this.optMultipleRecipients.Text = "A. Multiple Recipients";
            this.optMultipleRecipients.UseVisualStyleBackColor = true;
            // 
            // optFindLearner
            // 
            this.optFindLearner.AutoSize = true;
            this.optFindLearner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFindLearner.Location = new System.Drawing.Point(219, 126);
            this.optFindLearner.Name = "optFindLearner";
            this.optFindLearner.Size = new System.Drawing.Size(174, 17);
            this.optFindLearner.TabIndex = 1;
            this.optFindLearner.TabStop = true;
            this.optFindLearner.Text = "B. Find a Learner / Parent";
            this.optFindLearner.UseVisualStyleBackColor = true;
            // 
            // fExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optFindLearner);
            this.Controls.Add(this.optMultipleRecipients);
            this.Name = "fExportData";
            this.Text = "Export Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optMultipleRecipients;
        private System.Windows.Forms.RadioButton optFindLearner;
    }
}