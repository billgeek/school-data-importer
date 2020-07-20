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
            this.pnlFormContainer = new System.Windows.Forms.Panel();
            this.chkFindFuture = new System.Windows.Forms.CheckBox();
            this.chkFindArchived = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.txtLearnerSurname = new System.Windows.Forms.TextBox();
            this.lblLearnerSurname = new System.Windows.Forms.Label();
            this.pnlFindLearner = new System.Windows.Forms.Panel();
            this.pnlMultiRecipientContainer = new System.Windows.Forms.Panel();
            this.pnlStaffFilter = new System.Windows.Forms.Panel();
            this.clbOtherStaff = new System.Windows.Forms.CheckedListBox();
            this.pnlStaffFilterOptions = new System.Windows.Forms.Panel();
            this.pnlMainFilters = new System.Windows.Forms.Panel();
            this.chkAllGrades = new System.Windows.Forms.CheckBox();
            this.chkStatusFuture = new System.Windows.Forms.CheckBox();
            this.chkStatusArchived = new System.Windows.Forms.CheckBox();
            this.chkStatusCurrent = new System.Windows.Forms.CheckBox();
            this.chkGenderUnassigned = new System.Windows.Forms.CheckBox();
            this.chkGenderFemale = new System.Windows.Forms.CheckBox();
            this.chkGenderMale = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbGrades = new System.Windows.Forms.CheckedListBox();
            this.pnlHostel = new System.Windows.Forms.Panel();
            this.clbHostel = new System.Windows.Forms.CheckedListBox();
            this.pnlHouseFilter = new System.Windows.Forms.Panel();
            this.clbHouse = new System.Windows.Forms.CheckedListBox();
            this.pnlMultipleRecipients = new System.Windows.Forms.Panel();
            this.optFindLearnerParent = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optStaffGoverningBody = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optStaffOther = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optStaffEducators = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optLearners = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optStaff = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optParents = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optHostelSelection = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optHostelNone = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optHostelAny = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optHouseSelection = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optHouseNone = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optHouseAny = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.optMultipleRecipients = new SchoolDataImporter.Controls.GroupedRadioButton();
            this.lvAvailable = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lvSelected = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFormContainer.SuspendLayout();
            this.pnlFindLearner.SuspendLayout();
            this.pnlMultiRecipientContainer.SuspendLayout();
            this.pnlStaffFilter.SuspendLayout();
            this.pnlStaffFilterOptions.SuspendLayout();
            this.pnlMainFilters.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHostel.SuspendLayout();
            this.pnlHouseFilter.SuspendLayout();
            this.pnlMultipleRecipients.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormContainer.Controls.Add(this.chkFindFuture);
            this.pnlFormContainer.Controls.Add(this.chkFindArchived);
            this.pnlFormContainer.Controls.Add(this.textBox2);
            this.pnlFormContainer.Controls.Add(this.label1);
            this.pnlFormContainer.Controls.Add(this.textBox1);
            this.pnlFormContainer.Controls.Add(this.lblNickName);
            this.pnlFormContainer.Controls.Add(this.txtLearnerSurname);
            this.pnlFormContainer.Controls.Add(this.lblLearnerSurname);
            this.pnlFormContainer.Controls.Add(this.pnlFindLearner);
            this.pnlFormContainer.Controls.Add(this.pnlMultiRecipientContainer);
            this.pnlFormContainer.Controls.Add(this.pnlMultipleRecipients);
            this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormContainer.Location = new System.Drawing.Point(4, 4);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Padding = new System.Windows.Forms.Padding(4);
            this.pnlFormContainer.Size = new System.Drawing.Size(625, 401);
            this.pnlFormContainer.TabIndex = 17;
            // 
            // chkFindFuture
            // 
            this.chkFindFuture.AutoSize = true;
            this.chkFindFuture.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFindFuture.Location = new System.Drawing.Point(563, 350);
            this.chkFindFuture.Name = "chkFindFuture";
            this.chkFindFuture.Size = new System.Drawing.Size(56, 17);
            this.chkFindFuture.TabIndex = 30;
            this.chkFindFuture.Text = "Future";
            this.chkFindFuture.UseVisualStyleBackColor = true;
            // 
            // chkFindArchived
            // 
            this.chkFindArchived.AutoSize = true;
            this.chkFindArchived.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFindArchived.Location = new System.Drawing.Point(551, 333);
            this.chkFindArchived.Name = "chkFindArchived";
            this.chkFindArchived.Size = new System.Drawing.Size(68, 17);
            this.chkFindArchived.TabIndex = 29;
            this.chkFindArchived.Text = "Archived";
            this.chkFindArchived.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "or Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 26;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(49, 376);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(60, 13);
            this.lblNickName.TabIndex = 25;
            this.lblNickName.Text = "Nick Name";
            // 
            // txtLearnerSurname
            // 
            this.txtLearnerSurname.Location = new System.Drawing.Point(117, 348);
            this.txtLearnerSurname.Name = "txtLearnerSurname";
            this.txtLearnerSurname.Size = new System.Drawing.Size(217, 20);
            this.txtLearnerSurname.TabIndex = 22;
            // 
            // lblLearnerSurname
            // 
            this.lblLearnerSurname.AutoSize = true;
            this.lblLearnerSurname.Location = new System.Drawing.Point(16, 351);
            this.lblLearnerSurname.Name = "lblLearnerSurname";
            this.lblLearnerSurname.Size = new System.Drawing.Size(95, 13);
            this.lblLearnerSurname.TabIndex = 21;
            this.lblLearnerSurname.Text = "Learner\'s Surname";
            // 
            // pnlFindLearner
            // 
            this.pnlFindLearner.BackColor = System.Drawing.SystemColors.Info;
            this.pnlFindLearner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFindLearner.Controls.Add(this.optFindLearnerParent);
            this.pnlFindLearner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFindLearner.Location = new System.Drawing.Point(4, 287);
            this.pnlFindLearner.Name = "pnlFindLearner";
            this.pnlFindLearner.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFindLearner.Size = new System.Drawing.Size(615, 40);
            this.pnlFindLearner.TabIndex = 20;
            // 
            // pnlMultiRecipientContainer
            // 
            this.pnlMultiRecipientContainer.Controls.Add(this.pnlStaffFilter);
            this.pnlMultiRecipientContainer.Controls.Add(this.pnlMainFilters);
            this.pnlMultiRecipientContainer.Controls.Add(this.panel1);
            this.pnlMultiRecipientContainer.Controls.Add(this.pnlHostel);
            this.pnlMultiRecipientContainer.Controls.Add(this.pnlHouseFilter);
            this.pnlMultiRecipientContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMultiRecipientContainer.Location = new System.Drawing.Point(4, 44);
            this.pnlMultiRecipientContainer.Name = "pnlMultiRecipientContainer";
            this.pnlMultiRecipientContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlMultiRecipientContainer.Size = new System.Drawing.Size(615, 243);
            this.pnlMultiRecipientContainer.TabIndex = 18;
            // 
            // pnlStaffFilter
            // 
            this.pnlStaffFilter.Controls.Add(this.clbOtherStaff);
            this.pnlStaffFilter.Controls.Add(this.pnlStaffFilterOptions);
            this.pnlStaffFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaffFilter.Location = new System.Drawing.Point(0, 67);
            this.pnlStaffFilter.Name = "pnlStaffFilter";
            this.pnlStaffFilter.Padding = new System.Windows.Forms.Padding(10, 4, 10, 0);
            this.pnlStaffFilter.Size = new System.Drawing.Size(415, 166);
            this.pnlStaffFilter.TabIndex = 33;
            this.pnlStaffFilter.Visible = false;
            // 
            // clbOtherStaff
            // 
            this.clbOtherStaff.CheckOnClick = true;
            this.clbOtherStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbOtherStaff.FormattingEnabled = true;
            this.clbOtherStaff.Location = new System.Drawing.Point(161, 4);
            this.clbOtherStaff.Name = "clbOtherStaff";
            this.clbOtherStaff.Size = new System.Drawing.Size(244, 162);
            this.clbOtherStaff.TabIndex = 5;
            // 
            // pnlStaffFilterOptions
            // 
            this.pnlStaffFilterOptions.Controls.Add(this.optStaffGoverningBody);
            this.pnlStaffFilterOptions.Controls.Add(this.optStaffOther);
            this.pnlStaffFilterOptions.Controls.Add(this.optStaffEducators);
            this.pnlStaffFilterOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStaffFilterOptions.Location = new System.Drawing.Point(10, 4);
            this.pnlStaffFilterOptions.Name = "pnlStaffFilterOptions";
            this.pnlStaffFilterOptions.Size = new System.Drawing.Size(151, 162);
            this.pnlStaffFilterOptions.TabIndex = 4;
            // 
            // pnlMainFilters
            // 
            this.pnlMainFilters.Controls.Add(this.chkAllGrades);
            this.pnlMainFilters.Controls.Add(this.chkStatusFuture);
            this.pnlMainFilters.Controls.Add(this.chkStatusArchived);
            this.pnlMainFilters.Controls.Add(this.chkStatusCurrent);
            this.pnlMainFilters.Controls.Add(this.chkGenderUnassigned);
            this.pnlMainFilters.Controls.Add(this.chkGenderFemale);
            this.pnlMainFilters.Controls.Add(this.chkGenderMale);
            this.pnlMainFilters.Controls.Add(this.optLearners);
            this.pnlMainFilters.Controls.Add(this.optStaff);
            this.pnlMainFilters.Controls.Add(this.optParents);
            this.pnlMainFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainFilters.Location = new System.Drawing.Point(0, 10);
            this.pnlMainFilters.Name = "pnlMainFilters";
            this.pnlMainFilters.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlMainFilters.Size = new System.Drawing.Size(415, 57);
            this.pnlMainFilters.TabIndex = 31;
            // 
            // chkAllGrades
            // 
            this.chkAllGrades.AutoSize = true;
            this.chkAllGrades.Checked = true;
            this.chkAllGrades.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllGrades.Location = new System.Drawing.Point(267, 3);
            this.chkAllGrades.Name = "chkAllGrades";
            this.chkAllGrades.Size = new System.Drawing.Size(121, 17);
            this.chkAllGrades.TabIndex = 34;
            this.chkAllGrades.Text = "All Grades / Classes";
            this.chkAllGrades.UseVisualStyleBackColor = true;
            // 
            // chkStatusFuture
            // 
            this.chkStatusFuture.AutoSize = true;
            this.chkStatusFuture.Location = new System.Drawing.Point(189, 37);
            this.chkStatusFuture.Name = "chkStatusFuture";
            this.chkStatusFuture.Size = new System.Drawing.Size(56, 17);
            this.chkStatusFuture.TabIndex = 33;
            this.chkStatusFuture.Text = "Future";
            this.chkStatusFuture.UseVisualStyleBackColor = true;
            // 
            // chkStatusArchived
            // 
            this.chkStatusArchived.AutoSize = true;
            this.chkStatusArchived.Location = new System.Drawing.Point(189, 20);
            this.chkStatusArchived.Name = "chkStatusArchived";
            this.chkStatusArchived.Size = new System.Drawing.Size(68, 17);
            this.chkStatusArchived.TabIndex = 32;
            this.chkStatusArchived.Text = "Archived";
            this.chkStatusArchived.UseVisualStyleBackColor = true;
            // 
            // chkStatusCurrent
            // 
            this.chkStatusCurrent.AutoSize = true;
            this.chkStatusCurrent.Checked = true;
            this.chkStatusCurrent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatusCurrent.Location = new System.Drawing.Point(189, 3);
            this.chkStatusCurrent.Name = "chkStatusCurrent";
            this.chkStatusCurrent.Size = new System.Drawing.Size(60, 17);
            this.chkStatusCurrent.TabIndex = 31;
            this.chkStatusCurrent.Text = "Current";
            this.chkStatusCurrent.UseVisualStyleBackColor = true;
            this.chkStatusCurrent.CheckedChanged += new System.EventHandler(this.optStaff_CheckedChanged);
            // 
            // chkGenderUnassigned
            // 
            this.chkGenderUnassigned.AutoSize = true;
            this.chkGenderUnassigned.Checked = true;
            this.chkGenderUnassigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenderUnassigned.Location = new System.Drawing.Point(100, 37);
            this.chkGenderUnassigned.Name = "chkGenderUnassigned";
            this.chkGenderUnassigned.Size = new System.Drawing.Size(82, 17);
            this.chkGenderUnassigned.TabIndex = 30;
            this.chkGenderUnassigned.Text = "Unassigned";
            this.chkGenderUnassigned.UseVisualStyleBackColor = true;
            // 
            // chkGenderFemale
            // 
            this.chkGenderFemale.AutoSize = true;
            this.chkGenderFemale.Checked = true;
            this.chkGenderFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenderFemale.Location = new System.Drawing.Point(100, 20);
            this.chkGenderFemale.Name = "chkGenderFemale";
            this.chkGenderFemale.Size = new System.Drawing.Size(60, 17);
            this.chkGenderFemale.TabIndex = 29;
            this.chkGenderFemale.Text = "Female";
            this.chkGenderFemale.UseVisualStyleBackColor = true;
            // 
            // chkGenderMale
            // 
            this.chkGenderMale.AutoSize = true;
            this.chkGenderMale.Checked = true;
            this.chkGenderMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenderMale.Location = new System.Drawing.Point(100, 3);
            this.chkGenderMale.Name = "chkGenderMale";
            this.chkGenderMale.Size = new System.Drawing.Size(49, 17);
            this.chkGenderMale.TabIndex = 28;
            this.chkGenderMale.Text = "Male";
            this.chkGenderMale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clbGrades);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(415, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 223);
            this.panel1.TabIndex = 29;
            // 
            // clbGrades
            // 
            this.clbGrades.CheckOnClick = true;
            this.clbGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbGrades.FormattingEnabled = true;
            this.clbGrades.Location = new System.Drawing.Point(0, 0);
            this.clbGrades.Name = "clbGrades";
            this.clbGrades.Size = new System.Drawing.Size(200, 223);
            this.clbGrades.TabIndex = 26;
            // 
            // pnlHostel
            // 
            this.pnlHostel.Controls.Add(this.clbHostel);
            this.pnlHostel.Controls.Add(this.optHostelSelection);
            this.pnlHostel.Controls.Add(this.optHostelNone);
            this.pnlHostel.Controls.Add(this.optHostelAny);
            this.pnlHostel.Location = new System.Drawing.Point(11, 158);
            this.pnlHostel.Name = "pnlHostel";
            this.pnlHostel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlHostel.Size = new System.Drawing.Size(404, 75);
            this.pnlHostel.TabIndex = 27;
            // 
            // clbHostel
            // 
            this.clbHostel.CheckOnClick = true;
            this.clbHostel.Dock = System.Windows.Forms.DockStyle.Right;
            this.clbHostel.FormattingEnabled = true;
            this.clbHostel.Location = new System.Drawing.Point(146, 0);
            this.clbHostel.Name = "clbHostel";
            this.clbHostel.Size = new System.Drawing.Size(248, 75);
            this.clbHostel.TabIndex = 3;
            // 
            // pnlHouseFilter
            // 
            this.pnlHouseFilter.Controls.Add(this.clbHouse);
            this.pnlHouseFilter.Controls.Add(this.optHouseSelection);
            this.pnlHouseFilter.Controls.Add(this.optHouseNone);
            this.pnlHouseFilter.Controls.Add(this.optHouseAny);
            this.pnlHouseFilter.Location = new System.Drawing.Point(11, 77);
            this.pnlHouseFilter.Name = "pnlHouseFilter";
            this.pnlHouseFilter.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlHouseFilter.Size = new System.Drawing.Size(404, 75);
            this.pnlHouseFilter.TabIndex = 26;
            // 
            // clbHouse
            // 
            this.clbHouse.CheckOnClick = true;
            this.clbHouse.Dock = System.Windows.Forms.DockStyle.Right;
            this.clbHouse.FormattingEnabled = true;
            this.clbHouse.Location = new System.Drawing.Point(146, 0);
            this.clbHouse.Name = "clbHouse";
            this.clbHouse.Size = new System.Drawing.Size(248, 75);
            this.clbHouse.TabIndex = 3;
            // 
            // pnlMultipleRecipients
            // 
            this.pnlMultipleRecipients.BackColor = System.Drawing.SystemColors.Info;
            this.pnlMultipleRecipients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMultipleRecipients.Controls.Add(this.optMultipleRecipients);
            this.pnlMultipleRecipients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMultipleRecipients.Location = new System.Drawing.Point(4, 4);
            this.pnlMultipleRecipients.Name = "pnlMultipleRecipients";
            this.pnlMultipleRecipients.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMultipleRecipients.Size = new System.Drawing.Size(615, 40);
            this.pnlMultipleRecipients.TabIndex = 17;
            // 
            // optFindLearnerParent
            // 
            this.optFindLearnerParent.AutoSize = true;
            this.optFindLearnerParent.Dock = System.Windows.Forms.DockStyle.Left;
            this.optFindLearnerParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFindLearnerParent.GroupName = "MainSelection";
            this.optFindLearnerParent.GroupNameLevel = SchoolDataImporter.Controls.GroupedRadioButton.Level.Form;
            this.optFindLearnerParent.Location = new System.Drawing.Point(10, 10);
            this.optFindLearnerParent.Name = "optFindLearnerParent";
            this.optFindLearnerParent.Size = new System.Drawing.Size(175, 18);
            this.optFindLearnerParent.TabIndex = 1;
            this.optFindLearnerParent.Text = "B. Find a Learner / Parent";
            this.optFindLearnerParent.UseVisualStyleBackColor = true;
            // 
            // optStaffGoverningBody
            // 
            this.optStaffGoverningBody.AutoSize = true;
            this.optStaffGoverningBody.GroupName = "StaffFilter";
            this.optStaffGoverningBody.Location = new System.Drawing.Point(0, 34);
            this.optStaffGoverningBody.Name = "optStaffGoverningBody";
            this.optStaffGoverningBody.Size = new System.Drawing.Size(102, 17);
            this.optStaffGoverningBody.TabIndex = 5;
            this.optStaffGoverningBody.Text = "Governing Body";
            this.optStaffGoverningBody.UseVisualStyleBackColor = true;
            this.optStaffGoverningBody.CheckedChanged += new System.EventHandler(this.optStaffEducators_CheckedChanged);
            // 
            // optStaffOther
            // 
            this.optStaffOther.AutoSize = true;
            this.optStaffOther.Checked = true;
            this.optStaffOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optStaffOther.GroupName = "StaffFilter";
            this.optStaffOther.Location = new System.Drawing.Point(0, 17);
            this.optStaffOther.Name = "optStaffOther";
            this.optStaffOther.Size = new System.Drawing.Size(77, 17);
            this.optStaffOther.TabIndex = 4;
            this.optStaffOther.Text = "Other Staff";
            this.optStaffOther.UseVisualStyleBackColor = true;
            this.optStaffOther.CheckedChanged += new System.EventHandler(this.optStaffEducators_CheckedChanged);
            // 
            // optStaffEducators
            // 
            this.optStaffEducators.AutoSize = true;
            this.optStaffEducators.GroupName = "StaffFilter";
            this.optStaffEducators.Location = new System.Drawing.Point(0, 0);
            this.optStaffEducators.Name = "optStaffEducators";
            this.optStaffEducators.Size = new System.Drawing.Size(74, 17);
            this.optStaffEducators.TabIndex = 3;
            this.optStaffEducators.Text = "Educators";
            this.optStaffEducators.UseVisualStyleBackColor = true;
            this.optStaffEducators.CheckedChanged += new System.EventHandler(this.optStaffEducators_CheckedChanged);
            // 
            // optLearners
            // 
            this.optLearners.AutoSize = true;
            this.optLearners.GroupName = "MultipleFilter";
            this.optLearners.Location = new System.Drawing.Point(10, 37);
            this.optLearners.Name = "optLearners";
            this.optLearners.Size = new System.Drawing.Size(67, 17);
            this.optLearners.TabIndex = 27;
            this.optLearners.Text = "Learners";
            this.optLearners.UseVisualStyleBackColor = true;
            this.optLearners.CheckedChanged += new System.EventHandler(this.optStaff_CheckedChanged);
            // 
            // optStaff
            // 
            this.optStaff.AutoSize = true;
            this.optStaff.GroupName = "MultipleFilter";
            this.optStaff.Location = new System.Drawing.Point(10, 20);
            this.optStaff.Name = "optStaff";
            this.optStaff.Size = new System.Drawing.Size(48, 17);
            this.optStaff.TabIndex = 26;
            this.optStaff.Text = "Staff";
            this.optStaff.UseVisualStyleBackColor = true;
            this.optStaff.CheckedChanged += new System.EventHandler(this.optStaff_CheckedChanged);
            // 
            // optParents
            // 
            this.optParents.AutoSize = true;
            this.optParents.Checked = true;
            this.optParents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optParents.GroupName = "MultipleFilter";
            this.optParents.Location = new System.Drawing.Point(10, 3);
            this.optParents.Name = "optParents";
            this.optParents.Size = new System.Drawing.Size(62, 17);
            this.optParents.TabIndex = 25;
            this.optParents.Text = "Parents";
            this.optParents.UseVisualStyleBackColor = true;
            this.optParents.CheckedChanged += new System.EventHandler(this.optStaff_CheckedChanged);
            // 
            // optHostelSelection
            // 
            this.optHostelSelection.AutoSize = true;
            this.optHostelSelection.GroupName = "HostelFilter";
            this.optHostelSelection.Location = new System.Drawing.Point(0, 34);
            this.optHostelSelection.Name = "optHostelSelection";
            this.optHostelSelection.Size = new System.Drawing.Size(140, 17);
            this.optHostelSelection.TabIndex = 2;
            this.optHostelSelection.Text = "In selection . . . . . . . . ->";
            this.optHostelSelection.UseVisualStyleBackColor = true;
            // 
            // optHostelNone
            // 
            this.optHostelNone.AutoSize = true;
            this.optHostelNone.GroupName = "HostelFilter";
            this.optHostelNone.Location = new System.Drawing.Point(0, 17);
            this.optHostelNone.Name = "optHostelNone";
            this.optHostelNone.Size = new System.Drawing.Size(94, 17);
            this.optHostelNone.TabIndex = 1;
            this.optHostelNone.Text = "Not in a hostel";
            this.optHostelNone.UseVisualStyleBackColor = true;
            // 
            // optHostelAny
            // 
            this.optHostelAny.AutoSize = true;
            this.optHostelAny.Checked = true;
            this.optHostelAny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optHostelAny.GroupName = "HostelFilter";
            this.optHostelAny.Location = new System.Drawing.Point(0, 0);
            this.optHostelAny.Name = "optHostelAny";
            this.optHostelAny.Size = new System.Drawing.Size(129, 17);
            this.optHostelAny.TabIndex = 0;
            this.optHostelAny.Text = "Any Hostel, incl. none";
            this.optHostelAny.UseVisualStyleBackColor = true;
            // 
            // optHouseSelection
            // 
            this.optHouseSelection.AutoSize = true;
            this.optHouseSelection.GroupName = "HouseFilter";
            this.optHouseSelection.Location = new System.Drawing.Point(0, 34);
            this.optHouseSelection.Name = "optHouseSelection";
            this.optHouseSelection.Size = new System.Drawing.Size(140, 17);
            this.optHouseSelection.TabIndex = 2;
            this.optHouseSelection.Text = "In selection . . . . . . . . ->";
            this.optHouseSelection.UseVisualStyleBackColor = true;
            // 
            // optHouseNone
            // 
            this.optHouseNone.AutoSize = true;
            this.optHouseNone.GroupName = "HouseFilter";
            this.optHouseNone.Location = new System.Drawing.Point(0, 17);
            this.optHouseNone.Name = "optHouseNone";
            this.optHouseNone.Size = new System.Drawing.Size(95, 17);
            this.optHouseNone.TabIndex = 1;
            this.optHouseNone.Text = "Not in a house";
            this.optHouseNone.UseVisualStyleBackColor = true;
            // 
            // optHouseAny
            // 
            this.optHouseAny.AutoSize = true;
            this.optHouseAny.Checked = true;
            this.optHouseAny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optHouseAny.GroupName = "HouseFilter";
            this.optHouseAny.Location = new System.Drawing.Point(0, 0);
            this.optHouseAny.Name = "optHouseAny";
            this.optHouseAny.Size = new System.Drawing.Size(130, 17);
            this.optHouseAny.TabIndex = 0;
            this.optHouseAny.Text = "Any House, incl. none";
            this.optHouseAny.UseVisualStyleBackColor = true;
            // 
            // optMultipleRecipients
            // 
            this.optMultipleRecipients.AutoSize = true;
            this.optMultipleRecipients.Checked = true;
            this.optMultipleRecipients.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optMultipleRecipients.Dock = System.Windows.Forms.DockStyle.Left;
            this.optMultipleRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMultipleRecipients.GroupName = "MainSelection";
            this.optMultipleRecipients.GroupNameLevel = SchoolDataImporter.Controls.GroupedRadioButton.Level.Form;
            this.optMultipleRecipients.Location = new System.Drawing.Point(10, 10);
            this.optMultipleRecipients.Name = "optMultipleRecipients";
            this.optMultipleRecipients.Size = new System.Drawing.Size(150, 18);
            this.optMultipleRecipients.TabIndex = 1;
            this.optMultipleRecipients.Text = "A. Multiple Recipients";
            this.optMultipleRecipients.UseVisualStyleBackColor = true;
            // 
            // lvAvailable
            // 
            this.lvAvailable.HideSelection = false;
            this.lvAvailable.Location = new System.Drawing.Point(4, 434);
            this.lvAvailable.Name = "lvAvailable";
            this.lvAvailable.Size = new System.Drawing.Size(291, 322);
            this.lvAvailable.TabIndex = 18;
            this.lvAvailable.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 53);
            this.button1.TabIndex = 19;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvSelected
            // 
            this.lvSelected.HideSelection = false;
            this.lvSelected.Location = new System.Drawing.Point(338, 434);
            this.lvSelected.Name = "lvSelected";
            this.lvSelected.Size = new System.Drawing.Size(291, 322);
            this.lvSelected.TabIndex = 20;
            this.lvSelected.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "(SOURCE) Select from this list...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "... To this list (Recipients to Copy)";
            // 
            // fExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvAvailable);
            this.Controls.Add(this.pnlFormContainer);
            this.Name = "fExportData";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.fExportData_Load);
            this.pnlFormContainer.ResumeLayout(false);
            this.pnlFormContainer.PerformLayout();
            this.pnlFindLearner.ResumeLayout(false);
            this.pnlFindLearner.PerformLayout();
            this.pnlMultiRecipientContainer.ResumeLayout(false);
            this.pnlStaffFilter.ResumeLayout(false);
            this.pnlStaffFilterOptions.ResumeLayout(false);
            this.pnlStaffFilterOptions.PerformLayout();
            this.pnlMainFilters.ResumeLayout(false);
            this.pnlMainFilters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlHostel.ResumeLayout(false);
            this.pnlHostel.PerformLayout();
            this.pnlHouseFilter.ResumeLayout(false);
            this.pnlHouseFilter.PerformLayout();
            this.pnlMultipleRecipients.ResumeLayout(false);
            this.pnlMultipleRecipients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormContainer;
        private System.Windows.Forms.Panel pnlMultipleRecipients;
        private Controls.GroupedRadioButton optMultipleRecipients;
        private System.Windows.Forms.Panel pnlMultiRecipientContainer;
        private System.Windows.Forms.Panel pnlHostel;
        private System.Windows.Forms.CheckedListBox clbHostel;
        private Controls.GroupedRadioButton optHostelSelection;
        private Controls.GroupedRadioButton optHostelNone;
        private Controls.GroupedRadioButton optHostelAny;
        private System.Windows.Forms.Panel pnlHouseFilter;
        private System.Windows.Forms.CheckedListBox clbHouse;
        private Controls.GroupedRadioButton optHouseSelection;
        private Controls.GroupedRadioButton optHouseNone;
        private Controls.GroupedRadioButton optHouseAny;
        private System.Windows.Forms.Panel pnlFindLearner;
        private Controls.GroupedRadioButton optFindLearnerParent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbGrades;
        private System.Windows.Forms.Panel pnlMainFilters;
        private System.Windows.Forms.CheckBox chkAllGrades;
        private System.Windows.Forms.CheckBox chkStatusFuture;
        private System.Windows.Forms.CheckBox chkStatusArchived;
        private System.Windows.Forms.CheckBox chkStatusCurrent;
        private System.Windows.Forms.CheckBox chkGenderUnassigned;
        private System.Windows.Forms.CheckBox chkGenderFemale;
        private System.Windows.Forms.CheckBox chkGenderMale;
        private Controls.GroupedRadioButton optLearners;
        private Controls.GroupedRadioButton optStaff;
        private Controls.GroupedRadioButton optParents;
        private System.Windows.Forms.Panel pnlStaffFilter;
        private System.Windows.Forms.CheckedListBox clbOtherStaff;
        private System.Windows.Forms.Panel pnlStaffFilterOptions;
        private Controls.GroupedRadioButton optStaffGoverningBody;
        private Controls.GroupedRadioButton optStaffOther;
        private Controls.GroupedRadioButton optStaffEducators;
        private System.Windows.Forms.CheckBox chkFindFuture;
        private System.Windows.Forms.CheckBox chkFindArchived;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TextBox txtLearnerSurname;
        private System.Windows.Forms.Label lblLearnerSurname;
        private System.Windows.Forms.ListView lvAvailable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}