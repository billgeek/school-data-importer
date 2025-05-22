using SchoolDataImporter.Controls;

namespace SchoolDataImporter.Forms
{
    partial class fRenderData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRenderData));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlFilterContent = new System.Windows.Forms.Panel();
            this.txtTotalFilter = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdClearFilters = new System.Windows.Forms.Button();
            this.cmdApplyFilters = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.chkOnlyNonBlank = new System.Windows.Forms.CheckBox();
            this.expTextSearch = new SchoolDataImporter.Controls.ExpandingPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbLastNameOperator = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbFirstNameOperator = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.expGoverningBody = new SchoolDataImporter.Controls.ExpandingPanel();
            this.clbGoverningBody = new System.Windows.Forms.CheckedListBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cmdGovBodySelNone = new System.Windows.Forms.Button();
            this.cmdGovBodySelAll = new System.Windows.Forms.Button();
            this.expPersonnelCategory = new SchoolDataImporter.Controls.ExpandingPanel();
            this.clbPersonnelCategory = new System.Windows.Forms.CheckedListBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmdStaffSelAll = new System.Windows.Forms.Button();
            this.cmdStaffSelNone = new System.Windows.Forms.Button();
            this.expHostels = new SchoolDataImporter.Controls.ExpandingPanel();
            this.clbHostels = new System.Windows.Forms.CheckedListBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cmdHostelsSelNone = new System.Windows.Forms.Button();
            this.cmdHostelsSelAll = new System.Windows.Forms.Button();
            this.expHouses = new SchoolDataImporter.Controls.ExpandingPanel();
            this.clbHouses = new System.Windows.Forms.CheckedListBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cmdHousesSelNone = new System.Windows.Forms.Button();
            this.cmdHousesSelAll = new System.Windows.Forms.Button();
            this.expBusRoutes = new SchoolDataImporter.Controls.ExpandingPanel();
            this.clbBusRoutes = new System.Windows.Forms.CheckedListBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cmdRoutesSelNone = new System.Windows.Forms.Button();
            this.cmdRoutesSelAll = new System.Windows.Forms.Button();
            this.expGradesClasses = new SchoolDataImporter.Controls.ExpandingPanel();
            this.clbGradesClasses = new System.Windows.Forms.CheckedListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmdGradesSelectNone = new System.Windows.Forms.Button();
            this.cmdGradesSelectAll = new System.Windows.Forms.Button();
            this.expStatus = new SchoolDataImporter.Controls.ExpandingPanel();
            this.chkStatusFuture = new System.Windows.Forms.CheckBox();
            this.chkStatusArchived = new System.Windows.Forms.CheckBox();
            this.chkStatusCurrent = new System.Windows.Forms.CheckBox();
            this.chkStatusUnassigned = new System.Windows.Forms.CheckBox();
            this.expGender = new SchoolDataImporter.Controls.ExpandingPanel();
            this.chkGenderUnassigned = new System.Windows.Forms.CheckBox();
            this.chkGenderFemale = new System.Windows.Forms.CheckBox();
            this.chkGenderMale = new System.Windows.Forms.CheckBox();
            this.expType = new SchoolDataImporter.Controls.ExpandingPanel();
            this.chkTypeGoverningBody = new System.Windows.Forms.RadioButton();
            this.chkTypeLearner = new System.Windows.Forms.RadioButton();
            this.chkTypeStaff = new System.Windows.Forms.RadioButton();
            this.chkTypeParent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSelected = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmdRemoveAll = new System.Windows.Forms.Button();
            this.cmdRemoveSelected = new System.Windows.Forms.Button();
            this.cmdAddAll = new System.Windows.Forms.Button();
            this.cmdAddSelected = new System.Windows.Forms.Button();
            this.pnlOnlyValid = new System.Windows.Forms.Panel();
            this.chkOnlyValidNumbers = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chkOnlySelected = new System.Windows.Forms.CheckBox();
            this.cmdCopyToClipboard = new System.Windows.Forms.Button();
            this.lblExportCount = new System.Windows.Forms.Label();
            this.cmdExportData = new System.Windows.Forms.Button();
            this.pnlAvailable = new System.Windows.Forms.Panel();
            this.dgAvailableData = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.ttCopyData = new System.Windows.Forms.ToolTip(this.components);
            this.ttExportData = new System.Windows.Forms.ToolTip(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.chkVcard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlFilterContent.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.expTextSearch.ContentPanel.SuspendLayout();
            this.expTextSearch.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.expGoverningBody.ContentPanel.SuspendLayout();
            this.expGoverningBody.SuspendLayout();
            this.panel14.SuspendLayout();
            this.expPersonnelCategory.ContentPanel.SuspendLayout();
            this.expPersonnelCategory.SuspendLayout();
            this.panel15.SuspendLayout();
            this.expHostels.ContentPanel.SuspendLayout();
            this.expHostels.SuspendLayout();
            this.panel16.SuspendLayout();
            this.expHouses.ContentPanel.SuspendLayout();
            this.expHouses.SuspendLayout();
            this.panel13.SuspendLayout();
            this.expBusRoutes.ContentPanel.SuspendLayout();
            this.expBusRoutes.SuspendLayout();
            this.panel12.SuspendLayout();
            this.expGradesClasses.ContentPanel.SuspendLayout();
            this.expGradesClasses.SuspendLayout();
            this.panel8.SuspendLayout();
            this.expStatus.ContentPanel.SuspendLayout();
            this.expStatus.SuspendLayout();
            this.expGender.ContentPanel.SuspendLayout();
            this.expGender.SuspendLayout();
            this.expType.ContentPanel.SuspendLayout();
            this.expType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlOnlyValid.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailableData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.pnlFilters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.dgSelected);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Panel2.Controls.Add(this.pnlAvailable);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 573);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 13;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.pnlFilterContent);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(4);
            this.pnlFilters.Size = new System.Drawing.Size(252, 571);
            this.pnlFilters.TabIndex = 1;
            // 
            // pnlFilterContent
            // 
            this.pnlFilterContent.Controls.Add(this.txtTotalFilter);
            this.pnlFilterContent.Controls.Add(this.panel10);
            this.pnlFilterContent.Controls.Add(this.panel3);
            this.pnlFilterContent.Controls.Add(this.expTextSearch);
            this.pnlFilterContent.Controls.Add(this.expGoverningBody);
            this.pnlFilterContent.Controls.Add(this.expPersonnelCategory);
            this.pnlFilterContent.Controls.Add(this.expHostels);
            this.pnlFilterContent.Controls.Add(this.expHouses);
            this.pnlFilterContent.Controls.Add(this.expBusRoutes);
            this.pnlFilterContent.Controls.Add(this.expGradesClasses);
            this.pnlFilterContent.Controls.Add(this.expStatus);
            this.pnlFilterContent.Controls.Add(this.expGender);
            this.pnlFilterContent.Controls.Add(this.expType);
            this.pnlFilterContent.Controls.Add(this.label1);
            this.pnlFilterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterContent.Location = new System.Drawing.Point(4, 4);
            this.pnlFilterContent.Name = "pnlFilterContent";
            this.pnlFilterContent.Size = new System.Drawing.Size(244, 563);
            this.pnlFilterContent.TabIndex = 119;
            // 
            // txtTotalFilter
            // 
            this.txtTotalFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalFilter.Location = new System.Drawing.Point(0, 497);
            this.txtTotalFilter.Multiline = true;
            this.txtTotalFilter.Name = "txtTotalFilter";
            this.txtTotalFilter.ReadOnly = true;
            this.txtTotalFilter.Size = new System.Drawing.Size(244, 194);
            this.txtTotalFilter.TabIndex = 133;
            this.txtTotalFilter.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 466);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(244, 31);
            this.panel10.TabIndex = 132;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SchoolDataImporter.Properties.Resources.Filter_12x_16x;
            this.pictureBox1.Location = new System.Drawing.Point(214, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Show or hide the query applied to the list.");
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdClearFilters);
            this.panel3.Controls.Add(this.cmdApplyFilters);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel3.Size = new System.Drawing.Size(244, 66);
            this.panel3.TabIndex = 131;
            // 
            // cmdClearFilters
            // 
            this.cmdClearFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdClearFilters.Location = new System.Drawing.Point(53, 26);
            this.cmdClearFilters.Name = "cmdClearFilters";
            this.cmdClearFilters.Size = new System.Drawing.Size(94, 40);
            this.cmdClearFilters.TabIndex = 4;
            this.cmdClearFilters.Text = "Reset Filters";
            this.cmdClearFilters.UseVisualStyleBackColor = true;
            this.cmdClearFilters.Click += new System.EventHandler(this.cmdClearFilters_Click);
            // 
            // cmdApplyFilters
            // 
            this.cmdApplyFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdApplyFilters.Location = new System.Drawing.Point(147, 26);
            this.cmdApplyFilters.Name = "cmdApplyFilters";
            this.cmdApplyFilters.Size = new System.Drawing.Size(94, 40);
            this.cmdApplyFilters.TabIndex = 3;
            this.cmdApplyFilters.Text = "Apply Filters";
            this.cmdApplyFilters.UseVisualStyleBackColor = true;
            this.cmdApplyFilters.Click += new System.EventHandler(this.cmdApplyFilters_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.chkOnlyNonBlank);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(241, 26);
            this.panel11.TabIndex = 2;
            // 
            // chkOnlyNonBlank
            // 
            this.chkOnlyNonBlank.AutoSize = true;
            this.chkOnlyNonBlank.Checked = true;
            this.chkOnlyNonBlank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyNonBlank.Location = new System.Drawing.Point(4, 4);
            this.chkOnlyNonBlank.Name = "chkOnlyNonBlank";
            this.chkOnlyNonBlank.Size = new System.Drawing.Size(187, 17);
            this.chkOnlyNonBlank.TabIndex = 0;
            this.chkOnlyNonBlank.Text = "Show only non-blank cell numbers";
            this.chkOnlyNonBlank.UseVisualStyleBackColor = true;
            // 
            // expTextSearch
            // 
            // 
            // expTextSearch.ContentPanel
            // 
            this.expTextSearch.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expTextSearch.ContentPanel.Controls.Add(this.panel5);
            this.expTextSearch.ContentPanel.Controls.Add(this.label11);
            this.expTextSearch.ContentPanel.Controls.Add(this.panel2);
            this.expTextSearch.ContentPanel.Controls.Add(this.label10);
            this.expTextSearch.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expTextSearch.ContentPanel.Enabled = true;
            this.expTextSearch.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expTextSearch.ContentPanel.Name = "ContentPanel";
            this.expTextSearch.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expTextSearch.ContentPanel.Size = new System.Drawing.Size(350, 101);
            this.expTextSearch.ContentPanel.TabIndex = 1;
            this.expTextSearch.ContentPanel.Visible = false;
            this.expTextSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.expTextSearch.ExpandedHeight = 140;
            this.expTextSearch.Heading = "Search";
            this.expTextSearch.IsExpanded = false;
            this.expTextSearch.Location = new System.Drawing.Point(0, 363);
            this.expTextSearch.Name = "expTextSearch";
            this.expTextSearch.Padding = new System.Windows.Forms.Padding(4);
            this.expTextSearch.Size = new System.Drawing.Size(244, 37);
            this.expTextSearch.TabIndex = 128;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.cmbLastNameOperator);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 21);
            this.panel5.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtLastName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(113, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(227, 21);
            this.panel6.TabIndex = 40;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLastName.Location = new System.Drawing.Point(4, 0);
            this.txtLastName.MinimumSize = new System.Drawing.Size(4, 21);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(223, 20);
            this.txtLastName.TabIndex = 44;
            // 
            // cmbLastNameOperator
            // 
            this.cmbLastNameOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbLastNameOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLastNameOperator.FormattingEnabled = true;
            this.cmbLastNameOperator.Items.AddRange(new object[] {
            "Contains",
            "Starts with",
            "Ends with",
            "Equal to",
            "Not Equal to"});
            this.cmbLastNameOperator.Location = new System.Drawing.Point(0, 0);
            this.cmbLastNameOperator.Name = "cmbLastNameOperator";
            this.cmbLastNameOperator.Size = new System.Drawing.Size(113, 21);
            this.cmbLastNameOperator.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(4, 49);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label11.Size = new System.Drawing.Size(340, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Last Name:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cmbFirstNameOperator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 21);
            this.panel2.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtFirstName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(113, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(227, 21);
            this.panel4.TabIndex = 39;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFirstName.Location = new System.Drawing.Point(4, 0);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.txtFirstName.MinimumSize = new System.Drawing.Size(4, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(223, 20);
            this.txtFirstName.TabIndex = 40;
            // 
            // cmbFirstNameOperator
            // 
            this.cmbFirstNameOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbFirstNameOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirstNameOperator.FormattingEnabled = true;
            this.cmbFirstNameOperator.Items.AddRange(new object[] {
            "Contains",
            "Starts with",
            "Ends with",
            "Equal to",
            "Not Equal to"});
            this.cmbFirstNameOperator.Location = new System.Drawing.Point(0, 0);
            this.cmbFirstNameOperator.Name = "cmbFirstNameOperator";
            this.cmbFirstNameOperator.Size = new System.Drawing.Size(113, 21);
            this.cmbFirstNameOperator.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label10.Size = new System.Drawing.Size(340, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "First Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // expGoverningBody
            // 
            // 
            // expGoverningBody.ContentPanel
            // 
            this.expGoverningBody.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expGoverningBody.ContentPanel.Controls.Add(this.clbGoverningBody);
            this.expGoverningBody.ContentPanel.Controls.Add(this.panel14);
            this.expGoverningBody.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expGoverningBody.ContentPanel.Enabled = true;
            this.expGoverningBody.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expGoverningBody.ContentPanel.Name = "ContentPanel";
            this.expGoverningBody.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expGoverningBody.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.expGoverningBody.ContentPanel.TabIndex = 1;
            this.expGoverningBody.ContentPanel.Visible = false;
            this.expGoverningBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.expGoverningBody.ExpandedHeight = 204;
            this.expGoverningBody.Heading = "Governing Body";
            this.expGoverningBody.IsExpanded = false;
            this.expGoverningBody.Location = new System.Drawing.Point(0, 326);
            this.expGoverningBody.Name = "expGoverningBody";
            this.expGoverningBody.Padding = new System.Windows.Forms.Padding(4);
            this.expGoverningBody.Size = new System.Drawing.Size(244, 37);
            this.expGoverningBody.TabIndex = 127;
            // 
            // clbGoverningBody
            // 
            this.clbGoverningBody.CheckOnClick = true;
            this.clbGoverningBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbGoverningBody.FormattingEnabled = true;
            this.clbGoverningBody.Location = new System.Drawing.Point(4, 4);
            this.clbGoverningBody.Name = "clbGoverningBody";
            this.clbGoverningBody.Size = new System.Drawing.Size(223, 125);
            this.clbGoverningBody.TabIndex = 155;
            this.clbGoverningBody.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGradesClasses_ItemCheck);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.cmdGovBodySelNone);
            this.panel14.Controls.Add(this.cmdGovBodySelAll);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(4, 129);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel14.Size = new System.Drawing.Size(223, 30);
            this.panel14.TabIndex = 154;
            // 
            // cmdGovBodySelNone
            // 
            this.cmdGovBodySelNone.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdGovBodySelNone.Location = new System.Drawing.Point(73, 4);
            this.cmdGovBodySelNone.Name = "cmdGovBodySelNone";
            this.cmdGovBodySelNone.Size = new System.Drawing.Size(75, 26);
            this.cmdGovBodySelNone.TabIndex = 1;
            this.cmdGovBodySelNone.Text = "None";
            this.cmdGovBodySelNone.UseVisualStyleBackColor = true;
            this.cmdGovBodySelNone.Click += new System.EventHandler(this.cmdGovBodySelNone_Click);
            // 
            // cmdGovBodySelAll
            // 
            this.cmdGovBodySelAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdGovBodySelAll.Location = new System.Drawing.Point(148, 4);
            this.cmdGovBodySelAll.Name = "cmdGovBodySelAll";
            this.cmdGovBodySelAll.Size = new System.Drawing.Size(75, 26);
            this.cmdGovBodySelAll.TabIndex = 0;
            this.cmdGovBodySelAll.Text = "All";
            this.cmdGovBodySelAll.UseVisualStyleBackColor = true;
            this.cmdGovBodySelAll.Click += new System.EventHandler(this.cmdGovBodySelAll_Click);
            // 
            // expPersonnelCategory
            // 
            // 
            // expPersonnelCategory.ContentPanel
            // 
            this.expPersonnelCategory.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expPersonnelCategory.ContentPanel.Controls.Add(this.clbPersonnelCategory);
            this.expPersonnelCategory.ContentPanel.Controls.Add(this.panel15);
            this.expPersonnelCategory.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expPersonnelCategory.ContentPanel.Enabled = true;
            this.expPersonnelCategory.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expPersonnelCategory.ContentPanel.Name = "ContentPanel";
            this.expPersonnelCategory.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expPersonnelCategory.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.expPersonnelCategory.ContentPanel.TabIndex = 1;
            this.expPersonnelCategory.ContentPanel.Visible = false;
            this.expPersonnelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.expPersonnelCategory.ExpandedHeight = 204;
            this.expPersonnelCategory.Heading = "Staff Type";
            this.expPersonnelCategory.IsExpanded = false;
            this.expPersonnelCategory.Location = new System.Drawing.Point(0, 289);
            this.expPersonnelCategory.Name = "expPersonnelCategory";
            this.expPersonnelCategory.Padding = new System.Windows.Forms.Padding(4);
            this.expPersonnelCategory.Size = new System.Drawing.Size(244, 37);
            this.expPersonnelCategory.TabIndex = 126;
            // 
            // clbPersonnelCategory
            // 
            this.clbPersonnelCategory.CheckOnClick = true;
            this.clbPersonnelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbPersonnelCategory.FormattingEnabled = true;
            this.clbPersonnelCategory.Location = new System.Drawing.Point(4, 4);
            this.clbPersonnelCategory.Name = "clbPersonnelCategory";
            this.clbPersonnelCategory.Size = new System.Drawing.Size(223, 125);
            this.clbPersonnelCategory.TabIndex = 156;
            this.clbPersonnelCategory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGradesClasses_ItemCheck);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.cmdStaffSelAll);
            this.panel15.Controls.Add(this.cmdStaffSelNone);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(4, 129);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel15.Size = new System.Drawing.Size(223, 30);
            this.panel15.TabIndex = 155;
            // 
            // cmdStaffSelAll
            // 
            this.cmdStaffSelAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdStaffSelAll.Location = new System.Drawing.Point(73, 4);
            this.cmdStaffSelAll.Name = "cmdStaffSelAll";
            this.cmdStaffSelAll.Size = new System.Drawing.Size(75, 26);
            this.cmdStaffSelAll.TabIndex = 1;
            this.cmdStaffSelAll.Text = "None";
            this.cmdStaffSelAll.UseVisualStyleBackColor = true;
            this.cmdStaffSelAll.Click += new System.EventHandler(this.cmdStaffSelAll_Click);
            // 
            // cmdStaffSelNone
            // 
            this.cmdStaffSelNone.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdStaffSelNone.Location = new System.Drawing.Point(148, 4);
            this.cmdStaffSelNone.Name = "cmdStaffSelNone";
            this.cmdStaffSelNone.Size = new System.Drawing.Size(75, 26);
            this.cmdStaffSelNone.TabIndex = 0;
            this.cmdStaffSelNone.Text = "All";
            this.cmdStaffSelNone.UseVisualStyleBackColor = true;
            this.cmdStaffSelNone.Click += new System.EventHandler(this.cmdStaffSelNone_Click);
            // 
            // expHostels
            // 
            // 
            // expHostels.ContentPanel
            // 
            this.expHostels.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expHostels.ContentPanel.Controls.Add(this.clbHostels);
            this.expHostels.ContentPanel.Controls.Add(this.panel16);
            this.expHostels.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expHostels.ContentPanel.Enabled = true;
            this.expHostels.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expHostels.ContentPanel.Name = "ContentPanel";
            this.expHostels.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expHostels.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.expHostels.ContentPanel.TabIndex = 1;
            this.expHostels.ContentPanel.Visible = false;
            this.expHostels.Dock = System.Windows.Forms.DockStyle.Top;
            this.expHostels.ExpandedHeight = 204;
            this.expHostels.Heading = "Hostels";
            this.expHostels.IsExpanded = false;
            this.expHostels.Location = new System.Drawing.Point(0, 252);
            this.expHostels.Name = "expHostels";
            this.expHostels.Padding = new System.Windows.Forms.Padding(4);
            this.expHostels.Size = new System.Drawing.Size(244, 37);
            this.expHostels.TabIndex = 125;
            // 
            // clbHostels
            // 
            this.clbHostels.CheckOnClick = true;
            this.clbHostels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbHostels.FormattingEnabled = true;
            this.clbHostels.Location = new System.Drawing.Point(4, 4);
            this.clbHostels.Name = "clbHostels";
            this.clbHostels.Size = new System.Drawing.Size(223, 125);
            this.clbHostels.TabIndex = 151;
            this.clbHostels.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGradesClasses_ItemCheck);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.cmdHostelsSelNone);
            this.panel16.Controls.Add(this.cmdHostelsSelAll);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(4, 129);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel16.Size = new System.Drawing.Size(223, 30);
            this.panel16.TabIndex = 150;
            // 
            // cmdHostelsSelNone
            // 
            this.cmdHostelsSelNone.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdHostelsSelNone.Location = new System.Drawing.Point(73, 4);
            this.cmdHostelsSelNone.Name = "cmdHostelsSelNone";
            this.cmdHostelsSelNone.Size = new System.Drawing.Size(75, 26);
            this.cmdHostelsSelNone.TabIndex = 1;
            this.cmdHostelsSelNone.Text = "None";
            this.cmdHostelsSelNone.UseVisualStyleBackColor = true;
            this.cmdHostelsSelNone.Click += new System.EventHandler(this.cmdHostelsSelNone_Click);
            // 
            // cmdHostelsSelAll
            // 
            this.cmdHostelsSelAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdHostelsSelAll.Location = new System.Drawing.Point(148, 4);
            this.cmdHostelsSelAll.Name = "cmdHostelsSelAll";
            this.cmdHostelsSelAll.Size = new System.Drawing.Size(75, 26);
            this.cmdHostelsSelAll.TabIndex = 0;
            this.cmdHostelsSelAll.Text = "All";
            this.cmdHostelsSelAll.UseVisualStyleBackColor = true;
            this.cmdHostelsSelAll.Click += new System.EventHandler(this.cmdHostelsSelAll_Click);
            // 
            // expHouses
            // 
            // 
            // expHouses.ContentPanel
            // 
            this.expHouses.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expHouses.ContentPanel.Controls.Add(this.clbHouses);
            this.expHouses.ContentPanel.Controls.Add(this.panel13);
            this.expHouses.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expHouses.ContentPanel.Enabled = true;
            this.expHouses.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expHouses.ContentPanel.Name = "ContentPanel";
            this.expHouses.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expHouses.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.expHouses.ContentPanel.TabIndex = 1;
            this.expHouses.ContentPanel.Visible = false;
            this.expHouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.expHouses.ExpandedHeight = 204;
            this.expHouses.Heading = "Houses";
            this.expHouses.IsExpanded = false;
            this.expHouses.Location = new System.Drawing.Point(0, 215);
            this.expHouses.Name = "expHouses";
            this.expHouses.Padding = new System.Windows.Forms.Padding(4);
            this.expHouses.Size = new System.Drawing.Size(244, 37);
            this.expHouses.TabIndex = 124;
            // 
            // clbHouses
            // 
            this.clbHouses.CheckOnClick = true;
            this.clbHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbHouses.FormattingEnabled = true;
            this.clbHouses.Location = new System.Drawing.Point(4, 4);
            this.clbHouses.Name = "clbHouses";
            this.clbHouses.Size = new System.Drawing.Size(223, 125);
            this.clbHouses.TabIndex = 150;
            this.clbHouses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGradesClasses_ItemCheck);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cmdHousesSelNone);
            this.panel13.Controls.Add(this.cmdHousesSelAll);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(4, 129);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel13.Size = new System.Drawing.Size(223, 30);
            this.panel13.TabIndex = 149;
            // 
            // cmdHousesSelNone
            // 
            this.cmdHousesSelNone.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdHousesSelNone.Location = new System.Drawing.Point(73, 4);
            this.cmdHousesSelNone.Name = "cmdHousesSelNone";
            this.cmdHousesSelNone.Size = new System.Drawing.Size(75, 26);
            this.cmdHousesSelNone.TabIndex = 1;
            this.cmdHousesSelNone.Text = "None";
            this.cmdHousesSelNone.UseVisualStyleBackColor = true;
            this.cmdHousesSelNone.Click += new System.EventHandler(this.cmdHousesSelNone_Click);
            // 
            // cmdHousesSelAll
            // 
            this.cmdHousesSelAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdHousesSelAll.Location = new System.Drawing.Point(148, 4);
            this.cmdHousesSelAll.Name = "cmdHousesSelAll";
            this.cmdHousesSelAll.Size = new System.Drawing.Size(75, 26);
            this.cmdHousesSelAll.TabIndex = 0;
            this.cmdHousesSelAll.Text = "All";
            this.cmdHousesSelAll.UseVisualStyleBackColor = true;
            this.cmdHousesSelAll.Click += new System.EventHandler(this.cmdHousesSelAll_Click);
            // 
            // expBusRoutes
            // 
            // 
            // expBusRoutes.ContentPanel
            // 
            this.expBusRoutes.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expBusRoutes.ContentPanel.Controls.Add(this.clbBusRoutes);
            this.expBusRoutes.ContentPanel.Controls.Add(this.panel12);
            this.expBusRoutes.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expBusRoutes.ContentPanel.Enabled = true;
            this.expBusRoutes.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expBusRoutes.ContentPanel.Name = "ContentPanel";
            this.expBusRoutes.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expBusRoutes.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.expBusRoutes.ContentPanel.TabIndex = 1;
            this.expBusRoutes.ContentPanel.Visible = false;
            this.expBusRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.expBusRoutes.ExpandedHeight = 204;
            this.expBusRoutes.Heading = "Bus Routes";
            this.expBusRoutes.IsExpanded = false;
            this.expBusRoutes.Location = new System.Drawing.Point(0, 178);
            this.expBusRoutes.Name = "expBusRoutes";
            this.expBusRoutes.Padding = new System.Windows.Forms.Padding(4);
            this.expBusRoutes.Size = new System.Drawing.Size(244, 37);
            this.expBusRoutes.TabIndex = 125;
            // 
            // clbBusRoutes
            // 
            this.clbBusRoutes.CheckOnClick = true;
            this.clbBusRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbBusRoutes.FormattingEnabled = true;
            this.clbBusRoutes.Location = new System.Drawing.Point(4, 4);
            this.clbBusRoutes.Name = "clbBusRoutes";
            this.clbBusRoutes.Size = new System.Drawing.Size(223, 125);
            this.clbBusRoutes.TabIndex = 149;
            this.clbBusRoutes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGradesClasses_ItemCheck);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cmdRoutesSelNone);
            this.panel12.Controls.Add(this.cmdRoutesSelAll);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(4, 129);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel12.Size = new System.Drawing.Size(223, 30);
            this.panel12.TabIndex = 148;
            // 
            // cmdRoutesSelNone
            // 
            this.cmdRoutesSelNone.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdRoutesSelNone.Location = new System.Drawing.Point(73, 4);
            this.cmdRoutesSelNone.Name = "cmdRoutesSelNone";
            this.cmdRoutesSelNone.Size = new System.Drawing.Size(75, 26);
            this.cmdRoutesSelNone.TabIndex = 1;
            this.cmdRoutesSelNone.Text = "None";
            this.cmdRoutesSelNone.UseVisualStyleBackColor = true;
            this.cmdRoutesSelNone.Click += new System.EventHandler(this.cmdRoutesSelNone_Click);
            // 
            // cmdRoutesSelAll
            // 
            this.cmdRoutesSelAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdRoutesSelAll.Location = new System.Drawing.Point(148, 4);
            this.cmdRoutesSelAll.Name = "cmdRoutesSelAll";
            this.cmdRoutesSelAll.Size = new System.Drawing.Size(75, 26);
            this.cmdRoutesSelAll.TabIndex = 0;
            this.cmdRoutesSelAll.Text = "All";
            this.cmdRoutesSelAll.UseVisualStyleBackColor = true;
            this.cmdRoutesSelAll.Click += new System.EventHandler(this.cmdRoutesSelAll_Click);
            // 
            // expGradesClasses
            // 
            // 
            // expGradesClasses.ContentPanel
            // 
            this.expGradesClasses.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expGradesClasses.ContentPanel.Controls.Add(this.clbGradesClasses);
            this.expGradesClasses.ContentPanel.Controls.Add(this.panel8);
            this.expGradesClasses.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expGradesClasses.ContentPanel.Enabled = true;
            this.expGradesClasses.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expGradesClasses.ContentPanel.Name = "ContentPanel";
            this.expGradesClasses.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expGradesClasses.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.expGradesClasses.ContentPanel.TabIndex = 1;
            this.expGradesClasses.ContentPanel.Visible = false;
            this.expGradesClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.expGradesClasses.ExpandedHeight = 204;
            this.expGradesClasses.Heading = "Grades / Classes";
            this.expGradesClasses.IsExpanded = false;
            this.expGradesClasses.Location = new System.Drawing.Point(0, 141);
            this.expGradesClasses.Name = "expGradesClasses";
            this.expGradesClasses.Padding = new System.Windows.Forms.Padding(4);
            this.expGradesClasses.Size = new System.Drawing.Size(244, 37);
            this.expGradesClasses.TabIndex = 123;
            // 
            // clbGradesClasses
            // 
            this.clbGradesClasses.CheckOnClick = true;
            this.clbGradesClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbGradesClasses.FormattingEnabled = true;
            this.clbGradesClasses.Location = new System.Drawing.Point(4, 4);
            this.clbGradesClasses.Name = "clbGradesClasses";
            this.clbGradesClasses.Size = new System.Drawing.Size(223, 125);
            this.clbGradesClasses.TabIndex = 146;
            this.clbGradesClasses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGradesClasses_ItemCheck);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cmdGradesSelectNone);
            this.panel8.Controls.Add(this.cmdGradesSelectAll);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(4, 129);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel8.Size = new System.Drawing.Size(223, 30);
            this.panel8.TabIndex = 0;
            // 
            // cmdGradesSelectNone
            // 
            this.cmdGradesSelectNone.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdGradesSelectNone.Location = new System.Drawing.Point(73, 4);
            this.cmdGradesSelectNone.Name = "cmdGradesSelectNone";
            this.cmdGradesSelectNone.Size = new System.Drawing.Size(75, 26);
            this.cmdGradesSelectNone.TabIndex = 1;
            this.cmdGradesSelectNone.Text = "None";
            this.cmdGradesSelectNone.UseVisualStyleBackColor = true;
            this.cmdGradesSelectNone.Click += new System.EventHandler(this.cmdGradesSelectNone_Click);
            // 
            // cmdGradesSelectAll
            // 
            this.cmdGradesSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdGradesSelectAll.Location = new System.Drawing.Point(148, 4);
            this.cmdGradesSelectAll.Name = "cmdGradesSelectAll";
            this.cmdGradesSelectAll.Size = new System.Drawing.Size(75, 26);
            this.cmdGradesSelectAll.TabIndex = 0;
            this.cmdGradesSelectAll.Text = "All";
            this.cmdGradesSelectAll.UseVisualStyleBackColor = true;
            this.cmdGradesSelectAll.Click += new System.EventHandler(this.cmdGradesSelectAll_Click);
            // 
            // expStatus
            // 
            // 
            // expStatus.ContentPanel
            // 
            this.expStatus.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expStatus.ContentPanel.Controls.Add(this.chkStatusFuture);
            this.expStatus.ContentPanel.Controls.Add(this.chkStatusArchived);
            this.expStatus.ContentPanel.Controls.Add(this.chkStatusCurrent);
            this.expStatus.ContentPanel.Controls.Add(this.chkStatusUnassigned);
            this.expStatus.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expStatus.ContentPanel.Enabled = true;
            this.expStatus.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expStatus.ContentPanel.Name = "ContentPanel";
            this.expStatus.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expStatus.ContentPanel.Size = new System.Drawing.Size(233, 75);
            this.expStatus.ContentPanel.TabIndex = 1;
            this.expStatus.ContentPanel.Visible = false;
            this.expStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.expStatus.ExpandedHeight = 114;
            this.expStatus.Heading = "Status";
            this.expStatus.IsExpanded = false;
            this.expStatus.Location = new System.Drawing.Point(0, 104);
            this.expStatus.Name = "expStatus";
            this.expStatus.Padding = new System.Windows.Forms.Padding(4);
            this.expStatus.Size = new System.Drawing.Size(244, 37);
            this.expStatus.TabIndex = 122;
            // 
            // chkStatusFuture
            // 
            this.chkStatusFuture.AutoSize = true;
            this.chkStatusFuture.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkStatusFuture.Location = new System.Drawing.Point(4, 55);
            this.chkStatusFuture.Name = "chkStatusFuture";
            this.chkStatusFuture.Size = new System.Drawing.Size(223, 17);
            this.chkStatusFuture.TabIndex = 7;
            this.chkStatusFuture.Text = "Future";
            this.chkStatusFuture.UseVisualStyleBackColor = true;
            this.chkStatusFuture.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // chkStatusArchived
            // 
            this.chkStatusArchived.AutoSize = true;
            this.chkStatusArchived.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkStatusArchived.Location = new System.Drawing.Point(4, 38);
            this.chkStatusArchived.Name = "chkStatusArchived";
            this.chkStatusArchived.Size = new System.Drawing.Size(223, 17);
            this.chkStatusArchived.TabIndex = 6;
            this.chkStatusArchived.Text = "Archived";
            this.chkStatusArchived.UseVisualStyleBackColor = true;
            this.chkStatusArchived.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // chkStatusCurrent
            // 
            this.chkStatusCurrent.AutoSize = true;
            this.chkStatusCurrent.Checked = true;
            this.chkStatusCurrent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatusCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkStatusCurrent.Location = new System.Drawing.Point(4, 21);
            this.chkStatusCurrent.Name = "chkStatusCurrent";
            this.chkStatusCurrent.Size = new System.Drawing.Size(223, 17);
            this.chkStatusCurrent.TabIndex = 5;
            this.chkStatusCurrent.Text = "Current";
            this.chkStatusCurrent.UseVisualStyleBackColor = true;
            this.chkStatusCurrent.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // chkStatusUnassigned
            // 
            this.chkStatusUnassigned.AutoSize = true;
            this.chkStatusUnassigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkStatusUnassigned.Location = new System.Drawing.Point(4, 4);
            this.chkStatusUnassigned.Name = "chkStatusUnassigned";
            this.chkStatusUnassigned.Size = new System.Drawing.Size(223, 17);
            this.chkStatusUnassigned.TabIndex = 4;
            this.chkStatusUnassigned.Text = "Unassigned";
            this.chkStatusUnassigned.UseVisualStyleBackColor = true;
            this.chkStatusUnassigned.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // expGender
            // 
            // 
            // expGender.ContentPanel
            // 
            this.expGender.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expGender.ContentPanel.Controls.Add(this.chkGenderUnassigned);
            this.expGender.ContentPanel.Controls.Add(this.chkGenderFemale);
            this.expGender.ContentPanel.Controls.Add(this.chkGenderMale);
            this.expGender.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expGender.ContentPanel.Enabled = true;
            this.expGender.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expGender.ContentPanel.Name = "ContentPanel";
            this.expGender.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expGender.ContentPanel.Size = new System.Drawing.Size(233, 57);
            this.expGender.ContentPanel.TabIndex = 1;
            this.expGender.ContentPanel.Visible = false;
            this.expGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.expGender.ExpandedHeight = 96;
            this.expGender.Heading = "Gender";
            this.expGender.IsExpanded = false;
            this.expGender.Location = new System.Drawing.Point(0, 67);
            this.expGender.Name = "expGender";
            this.expGender.Padding = new System.Windows.Forms.Padding(4);
            this.expGender.Size = new System.Drawing.Size(244, 37);
            this.expGender.TabIndex = 121;
            // 
            // chkGenderUnassigned
            // 
            this.chkGenderUnassigned.AutoSize = true;
            this.chkGenderUnassigned.Checked = true;
            this.chkGenderUnassigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenderUnassigned.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkGenderUnassigned.Location = new System.Drawing.Point(4, 38);
            this.chkGenderUnassigned.Name = "chkGenderUnassigned";
            this.chkGenderUnassigned.Size = new System.Drawing.Size(223, 17);
            this.chkGenderUnassigned.TabIndex = 3;
            this.chkGenderUnassigned.Text = "Unassigned";
            this.chkGenderUnassigned.UseVisualStyleBackColor = true;
            this.chkGenderUnassigned.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // chkGenderFemale
            // 
            this.chkGenderFemale.AutoSize = true;
            this.chkGenderFemale.Checked = true;
            this.chkGenderFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenderFemale.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkGenderFemale.Location = new System.Drawing.Point(4, 21);
            this.chkGenderFemale.Name = "chkGenderFemale";
            this.chkGenderFemale.Size = new System.Drawing.Size(223, 17);
            this.chkGenderFemale.TabIndex = 2;
            this.chkGenderFemale.Text = "Female";
            this.chkGenderFemale.UseVisualStyleBackColor = true;
            this.chkGenderFemale.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // chkGenderMale
            // 
            this.chkGenderMale.AutoSize = true;
            this.chkGenderMale.Checked = true;
            this.chkGenderMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenderMale.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkGenderMale.Location = new System.Drawing.Point(4, 4);
            this.chkGenderMale.Name = "chkGenderMale";
            this.chkGenderMale.Size = new System.Drawing.Size(223, 17);
            this.chkGenderMale.TabIndex = 1;
            this.chkGenderMale.Text = "Male";
            this.chkGenderMale.UseVisualStyleBackColor = true;
            this.chkGenderMale.CheckedChanged += new System.EventHandler(this.chkGenderMale_CheckedChanged);
            // 
            // expType
            // 
            // 
            // expType.ContentPanel
            // 
            this.expType.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expType.ContentPanel.Controls.Add(this.chkTypeGoverningBody);
            this.expType.ContentPanel.Controls.Add(this.chkTypeLearner);
            this.expType.ContentPanel.Controls.Add(this.chkTypeStaff);
            this.expType.ContentPanel.Controls.Add(this.chkTypeParent);
            this.expType.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expType.ContentPanel.Enabled = true;
            this.expType.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.expType.ContentPanel.Name = "ContentPanel";
            this.expType.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.expType.ContentPanel.Size = new System.Drawing.Size(233, 79);
            this.expType.ContentPanel.TabIndex = 1;
            this.expType.ContentPanel.Visible = false;
            this.expType.Dock = System.Windows.Forms.DockStyle.Top;
            this.expType.ExpandedHeight = 118;
            this.expType.Heading = "Category";
            this.expType.IsExpanded = false;
            this.expType.Location = new System.Drawing.Point(0, 30);
            this.expType.Name = "expType";
            this.expType.Padding = new System.Windows.Forms.Padding(4);
            this.expType.Size = new System.Drawing.Size(244, 37);
            this.expType.TabIndex = 120;
            // 
            // chkTypeGoverningBody
            // 
            this.chkTypeGoverningBody.AutoSize = true;
            this.chkTypeGoverningBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTypeGoverningBody.Location = new System.Drawing.Point(4, 55);
            this.chkTypeGoverningBody.Name = "chkTypeGoverningBody";
            this.chkTypeGoverningBody.Size = new System.Drawing.Size(223, 17);
            this.chkTypeGoverningBody.TabIndex = 6;
            this.chkTypeGoverningBody.Text = "Governing Body";
            this.chkTypeGoverningBody.UseVisualStyleBackColor = true;
            this.chkTypeGoverningBody.CheckedChanged += new System.EventHandler(this.chkTypeGoverningBody_CheckedChanged);
            // 
            // chkTypeLearner
            // 
            this.chkTypeLearner.AutoSize = true;
            this.chkTypeLearner.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTypeLearner.Location = new System.Drawing.Point(4, 38);
            this.chkTypeLearner.Name = "chkTypeLearner";
            this.chkTypeLearner.Size = new System.Drawing.Size(223, 17);
            this.chkTypeLearner.TabIndex = 5;
            this.chkTypeLearner.Text = "Learner";
            this.chkTypeLearner.UseVisualStyleBackColor = true;
            this.chkTypeLearner.CheckedChanged += new System.EventHandler(this.chkTypeLearner_CheckedChanged);
            // 
            // chkTypeStaff
            // 
            this.chkTypeStaff.AutoSize = true;
            this.chkTypeStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTypeStaff.Location = new System.Drawing.Point(4, 21);
            this.chkTypeStaff.Name = "chkTypeStaff";
            this.chkTypeStaff.Size = new System.Drawing.Size(223, 17);
            this.chkTypeStaff.TabIndex = 4;
            this.chkTypeStaff.Text = "Staff";
            this.chkTypeStaff.UseVisualStyleBackColor = true;
            this.chkTypeStaff.CheckedChanged += new System.EventHandler(this.chkTypeStaff_CheckedChanged);
            // 
            // chkTypeParent
            // 
            this.chkTypeParent.AutoSize = true;
            this.chkTypeParent.Checked = true;
            this.chkTypeParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTypeParent.Location = new System.Drawing.Point(4, 4);
            this.chkTypeParent.Name = "chkTypeParent";
            this.chkTypeParent.Size = new System.Drawing.Size(223, 17);
            this.chkTypeParent.TabIndex = 3;
            this.chkTypeParent.TabStop = true;
            this.chkTypeParent.Text = "Parent";
            this.chkTypeParent.UseVisualStyleBackColor = true;
            this.chkTypeParent.CheckedChanged += new System.EventHandler(this.chkTypeParent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 30);
            this.label1.TabIndex = 119;
            this.label1.Text = "Filters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgSelected
            // 
            this.dgSelected.AllowUserToAddRows = false;
            this.dgSelected.AllowUserToDeleteRows = false;
            this.dgSelected.AllowUserToOrderColumns = true;
            this.dgSelected.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSelected.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSelected.Location = new System.Drawing.Point(4, 373);
            this.dgSelected.Name = "dgSelected";
            this.dgSelected.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSelected.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSelected.Size = new System.Drawing.Size(848, 150);
            this.dgSelected.TabIndex = 25;
            this.dgSelected.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgSelected_RowsAdded);
            this.dgSelected.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgSelected_RowsRemoved);
            this.dgSelected.SelectionChanged += new System.EventHandler(this.dgSelected_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRowCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 254);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(848, 119);
            this.panel1.TabIndex = 24;
            // 
            // lblRowCount
            // 
            this.lblRowCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRowCount.Location = new System.Drawing.Point(329, 10);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(519, 27);
            this.lblRowCount.TabIndex = 2;
            this.lblRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rows highlighted above are included in the list below";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cmdRemoveAll);
            this.panel9.Controls.Add(this.cmdRemoveSelected);
            this.panel9.Controls.Add(this.cmdAddAll);
            this.panel9.Controls.Add(this.cmdAddSelected);
            this.panel9.Controls.Add(this.pnlOnlyValid);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 37);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel9.Size = new System.Drawing.Size(848, 72);
            this.panel9.TabIndex = 0;
            // 
            // cmdRemoveAll
            // 
            this.cmdRemoveAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdRemoveAll.Location = new System.Drawing.Point(594, 37);
            this.cmdRemoveAll.Name = "cmdRemoveAll";
            this.cmdRemoveAll.Size = new System.Drawing.Size(127, 35);
            this.cmdRemoveAll.TabIndex = 14;
            this.cmdRemoveAll.Text = "Remove All";
            this.cmdRemoveAll.UseVisualStyleBackColor = true;
            this.cmdRemoveAll.Click += new System.EventHandler(this.cmdRemoveAll_Click);
            // 
            // cmdRemoveSelected
            // 
            this.cmdRemoveSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdRemoveSelected.Enabled = false;
            this.cmdRemoveSelected.Location = new System.Drawing.Point(721, 37);
            this.cmdRemoveSelected.Name = "cmdRemoveSelected";
            this.cmdRemoveSelected.Size = new System.Drawing.Size(127, 35);
            this.cmdRemoveSelected.TabIndex = 13;
            this.cmdRemoveSelected.Text = "Remove Selected";
            this.cmdRemoveSelected.UseVisualStyleBackColor = true;
            this.cmdRemoveSelected.Click += new System.EventHandler(this.cmdRemoveSelected_Click);
            // 
            // cmdAddAll
            // 
            this.cmdAddAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAddAll.Location = new System.Drawing.Point(127, 37);
            this.cmdAddAll.Name = "cmdAddAll";
            this.cmdAddAll.Size = new System.Drawing.Size(127, 35);
            this.cmdAddAll.TabIndex = 12;
            this.cmdAddAll.Text = "Add All";
            this.cmdAddAll.UseVisualStyleBackColor = true;
            this.cmdAddAll.Click += new System.EventHandler(this.cmdAddAll_Click);
            // 
            // cmdAddSelected
            // 
            this.cmdAddSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAddSelected.Enabled = false;
            this.cmdAddSelected.Location = new System.Drawing.Point(0, 37);
            this.cmdAddSelected.Name = "cmdAddSelected";
            this.cmdAddSelected.Size = new System.Drawing.Size(127, 35);
            this.cmdAddSelected.TabIndex = 11;
            this.cmdAddSelected.Text = "Add Selected";
            this.cmdAddSelected.UseVisualStyleBackColor = true;
            this.cmdAddSelected.Click += new System.EventHandler(this.cmdAddSelected_Click);
            // 
            // pnlOnlyValid
            // 
            this.pnlOnlyValid.Controls.Add(this.chkOnlyValidNumbers);
            this.pnlOnlyValid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOnlyValid.Location = new System.Drawing.Point(0, 4);
            this.pnlOnlyValid.Name = "pnlOnlyValid";
            this.pnlOnlyValid.Size = new System.Drawing.Size(848, 33);
            this.pnlOnlyValid.TabIndex = 0;
            // 
            // chkOnlyValidNumbers
            // 
            this.chkOnlyValidNumbers.AutoSize = true;
            this.chkOnlyValidNumbers.Checked = true;
            this.chkOnlyValidNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyValidNumbers.Location = new System.Drawing.Point(3, 3);
            this.chkOnlyValidNumbers.Name = "chkOnlyValidNumbers";
            this.chkOnlyValidNumbers.Size = new System.Drawing.Size(135, 17);
            this.chkOnlyValidNumbers.TabIndex = 0;
            this.chkOnlyValidNumbers.Text = "Add only valid numbers";
            this.chkOnlyValidNumbers.UseVisualStyleBackColor = true;
            this.chkOnlyValidNumbers.Visible = false;
            this.chkOnlyValidNumbers.CheckedChanged += new System.EventHandler(this.chkOnlySelected_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(4, 251);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(848, 3);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chkVcard);
            this.panel7.Controls.Add(this.chkOnlySelected);
            this.panel7.Controls.Add(this.cmdCopyToClipboard);
            this.panel7.Controls.Add(this.lblExportCount);
            this.panel7.Controls.Add(this.cmdExportData);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(4, 523);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.panel7.Size = new System.Drawing.Size(848, 48);
            this.panel7.TabIndex = 20;
            // 
            // chkOnlySelected
            // 
            this.chkOnlySelected.AutoSize = true;
            this.chkOnlySelected.Location = new System.Drawing.Point(332, 4);
            this.chkOnlySelected.Name = "chkOnlySelected";
            this.chkOnlySelected.Size = new System.Drawing.Size(192, 17);
            this.chkOnlySelected.TabIndex = 4;
            this.chkOnlySelected.Text = "Only copy / export highlighted rows";
            this.chkOnlySelected.UseVisualStyleBackColor = true;
            this.chkOnlySelected.CheckedChanged += new System.EventHandler(this.chkOnlySelected_CheckedChanged);
            // 
            // cmdCopyToClipboard
            // 
            this.cmdCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdCopyToClipboard.Enabled = false;
            this.cmdCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCopyToClipboard.Location = new System.Drawing.Point(660, 4);
            this.cmdCopyToClipboard.Name = "cmdCopyToClipboard";
            this.cmdCopyToClipboard.Size = new System.Drawing.Size(94, 40);
            this.cmdCopyToClipboard.TabIndex = 3;
            this.cmdCopyToClipboard.Text = "Copy";
            this.ttCopyData.SetToolTip(this.cmdCopyToClipboard, "Copies the rows in the list above to the Clipboard");
            this.cmdCopyToClipboard.UseVisualStyleBackColor = false;
            this.cmdCopyToClipboard.Click += new System.EventHandler(this.cmdCopyToClipboard_Click);
            // 
            // lblExportCount
            // 
            this.lblExportCount.BackColor = System.Drawing.SystemColors.Info;
            this.lblExportCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExportCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblExportCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportCount.Location = new System.Drawing.Point(0, 4);
            this.lblExportCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblExportCount.Name = "lblExportCount";
            this.lblExportCount.Size = new System.Drawing.Size(329, 40);
            this.lblExportCount.TabIndex = 2;
            this.lblExportCount.Text = "0 rows for export";
            this.lblExportCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdExportData
            // 
            this.cmdExportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdExportData.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdExportData.Enabled = false;
            this.cmdExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportData.Location = new System.Drawing.Point(754, 4);
            this.cmdExportData.Name = "cmdExportData";
            this.cmdExportData.Size = new System.Drawing.Size(94, 40);
            this.cmdExportData.TabIndex = 1;
            this.cmdExportData.Text = "Export";
            this.ttExportData.SetToolTip(this.cmdExportData, "Exports the rows in the list above to a new Excel file");
            this.cmdExportData.UseVisualStyleBackColor = false;
            this.cmdExportData.Click += new System.EventHandler(this.cmdExportData_Click);
            // 
            // pnlAvailable
            // 
            this.pnlAvailable.Controls.Add(this.dgAvailableData);
            this.pnlAvailable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvailable.Location = new System.Drawing.Point(4, 0);
            this.pnlAvailable.Name = "pnlAvailable";
            this.pnlAvailable.Size = new System.Drawing.Size(848, 251);
            this.pnlAvailable.TabIndex = 14;
            // 
            // dgAvailableData
            // 
            this.dgAvailableData.AllowUserToAddRows = false;
            this.dgAvailableData.AllowUserToDeleteRows = false;
            this.dgAvailableData.AllowUserToOrderColumns = true;
            this.dgAvailableData.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAvailableData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAvailableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAvailableData.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgAvailableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAvailableData.Location = new System.Drawing.Point(0, 0);
            this.dgAvailableData.Name = "dgAvailableData";
            this.dgAvailableData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAvailableData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgAvailableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAvailableData.Size = new System.Drawing.Size(848, 251);
            this.dgAvailableData.TabIndex = 13;
            this.dgAvailableData.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgAvailableData_ColumnDisplayIndexChanged);
            this.dgAvailableData.SelectionChanged += new System.EventHandler(this.dgAvailableData_SelectionChanged);
            this.dgAvailableData.Sorted += new System.EventHandler(this.dgAvailableData_Sorted);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "View Filter";
            // 
            // ttCopyData
            // 
            this.ttCopyData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttCopyData.ToolTipTitle = "Copy Data";
            // 
            // ttExportData
            // 
            this.ttExportData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttExportData.ToolTipTitle = "Export Data";
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(4, 35);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.ContentPanel.Size = new System.Drawing.Size(233, 165);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.Visible = false;
            // 
            // chkVcard
            // 
            this.chkVcard.AutoSize = true;
            this.chkVcard.Location = new System.Drawing.Point(332, 27);
            this.chkVcard.Name = "chkVcard";
            this.chkVcard.Size = new System.Drawing.Size(96, 17);
            this.chkVcard.TabIndex = 5;
            this.chkVcard.Text = "vCard columns";
            this.chkVcard.UseVisualStyleBackColor = true;
            // 
            // fRenderData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 593);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRenderData";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter and Export Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.fRenderData_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRenderData_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilterContent.ResumeLayout(false);
            this.pnlFilterContent.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.expTextSearch.ContentPanel.ResumeLayout(false);
            this.expTextSearch.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.expGoverningBody.ContentPanel.ResumeLayout(false);
            this.expGoverningBody.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.expPersonnelCategory.ContentPanel.ResumeLayout(false);
            this.expPersonnelCategory.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.expHostels.ContentPanel.ResumeLayout(false);
            this.expHostels.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.expHouses.ContentPanel.ResumeLayout(false);
            this.expHouses.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.expBusRoutes.ContentPanel.ResumeLayout(false);
            this.expBusRoutes.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.expGradesClasses.ContentPanel.ResumeLayout(false);
            this.expGradesClasses.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.expStatus.ContentPanel.ResumeLayout(false);
            this.expStatus.ContentPanel.PerformLayout();
            this.expStatus.ResumeLayout(false);
            this.expGender.ContentPanel.ResumeLayout(false);
            this.expGender.ContentPanel.PerformLayout();
            this.expGender.ResumeLayout(false);
            this.expType.ContentPanel.ResumeLayout(false);
            this.expType.ContentPanel.PerformLayout();
            this.expType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnlOnlyValid.ResumeLayout(false);
            this.pnlOnlyValid.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailableData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlFilterContent;
        private ExpandingPanel expTextSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbLastNameOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private ExpandingPanel expGoverningBody;
        private ExpandingPanel expPersonnelCategory;
        private ExpandingPanel expHostels;
        private ExpandingPanel expHouses;
        private ExpandingPanel expGradesClasses;
        private System.Windows.Forms.CheckedListBox clbGradesClasses;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button cmdGradesSelectNone;
        private System.Windows.Forms.Button cmdGradesSelectAll;
        private ExpandingPanel expStatus;
        private ExpandingPanel expGender;
        private System.Windows.Forms.CheckBox chkGenderUnassigned;
        private System.Windows.Forms.CheckBox chkGenderFemale;
        private System.Windows.Forms.CheckBox chkGenderMale;
        private ExpandingPanel expType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkStatusFuture;
        private System.Windows.Forms.CheckBox chkStatusArchived;
        private System.Windows.Forms.CheckBox chkStatusCurrent;
        private System.Windows.Forms.CheckBox chkStatusUnassigned;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalFilter;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolTip ttCopyData;
        private System.Windows.Forms.ToolTip ttExportData;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.CheckBox chkOnlyNonBlank;
        private System.Windows.Forms.Button cmdClearFilters;
        private System.Windows.Forms.Button cmdApplyFilters;
        private System.Windows.Forms.Panel ContentPanel;
        private ExpandingPanel expBusRoutes;
        private System.Windows.Forms.CheckedListBox clbBusRoutes;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button cmdRoutesSelNone;
        private System.Windows.Forms.Button cmdRoutesSelAll;
        private System.Windows.Forms.RadioButton chkTypeParent;
        private System.Windows.Forms.RadioButton chkTypeLearner;
        private System.Windows.Forms.RadioButton chkTypeStaff;
        private System.Windows.Forms.RadioButton chkTypeGoverningBody;
        private System.Windows.Forms.CheckedListBox clbHouses;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button cmdHousesSelNone;
        private System.Windows.Forms.Button cmdHousesSelAll;
        private System.Windows.Forms.CheckedListBox clbGoverningBody;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button cmdGovBodySelNone;
        private System.Windows.Forms.Button cmdGovBodySelAll;
        private System.Windows.Forms.CheckedListBox clbPersonnelCategory;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button cmdStaffSelAll;
        private System.Windows.Forms.Button cmdStaffSelNone;
        private System.Windows.Forms.CheckedListBox clbHostels;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button cmdHostelsSelNone;
        private System.Windows.Forms.Button cmdHostelsSelAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbFirstNameOperator;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox chkOnlySelected;
        private System.Windows.Forms.Button cmdCopyToClipboard;
        private System.Windows.Forms.Label lblExportCount;
        private System.Windows.Forms.Button cmdExportData;
        private System.Windows.Forms.Panel pnlAvailable;
        private System.Windows.Forms.DataGridView dgAvailableData;
        private System.Windows.Forms.DataGridView dgSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button cmdRemoveAll;
        private System.Windows.Forms.Button cmdRemoveSelected;
        private System.Windows.Forms.Button cmdAddAll;
        private System.Windows.Forms.Button cmdAddSelected;
        private System.Windows.Forms.Panel pnlOnlyValid;
        private System.Windows.Forms.CheckBox chkOnlyValidNumbers;
        private System.Windows.Forms.CheckBox chkVcard;
    }
}