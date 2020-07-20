namespace SchoolDataImporter.Forms
{
    partial class fTest
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
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbPersonType = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgSelected = new System.Windows.Forms.DataGridView();
            this.cmdAddSelected = new System.Windows.Forms.Button();
            this.cmdAddAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.panel2);
            this.pnlFilters.Controls.Add(this.cmbGender);
            this.pnlFilters.Controls.Add(this.label2);
            this.pnlFilters.Controls.Add(this.cmbPersonType);
            this.pnlFilters.Controls.Add(this.lblType);
            this.pnlFilters.Controls.Add(this.label1);
            this.pnlFilters.Controls.Add(this.vScrollBar1);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFilters.Location = new System.Drawing.Point(10, 10);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(419, 694);
            this.pnlFilters.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(402, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 694);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(429, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 694);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Dock = System.Windows.Forms.DockStyle.Top;
            this.dg.Location = new System.Drawing.Point(432, 10);
            this.dg.Name = "dg";
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(690, 251);
            this.dg.TabIndex = 2;
            this.dg.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType.Location = new System.Drawing.Point(0, 30);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblType.Size = new System.Drawing.Size(402, 24);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type of Person:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbPersonType
            // 
            this.cmbPersonType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonType.FormattingEnabled = true;
            this.cmbPersonType.Items.AddRange(new object[] {
            "All",
            "Parents",
            "Staff",
            "Learners"});
            this.cmbPersonType.Location = new System.Drawing.Point(0, 54);
            this.cmbPersonType.Name = "cmbPersonType";
            this.cmbPersonType.Size = new System.Drawing.Size(402, 21);
            this.cmbPersonType.TabIndex = 4;
            this.cmbPersonType.SelectedIndexChanged += new System.EventHandler(this.cmbPersonType_SelectedIndexChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female",
            "Unassigned"});
            this.cmbGender.Location = new System.Drawing.Point(0, 99);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(402, 21);
            this.cmbGender.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 75);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(402, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gender:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(432, 261);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(690, 3);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmdAddAll);
            this.panel1.Controls.Add(this.cmdAddSelected);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(432, 264);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(690, 47);
            this.panel1.TabIndex = 4;
            // 
            // dgSelected
            // 
            this.dgSelected.AllowUserToAddRows = false;
            this.dgSelected.AllowUserToDeleteRows = false;
            this.dgSelected.AllowUserToOrderColumns = true;
            this.dgSelected.AllowUserToResizeRows = false;
            this.dgSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSelected.Location = new System.Drawing.Point(432, 311);
            this.dgSelected.Name = "dgSelected";
            this.dgSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSelected.Size = new System.Drawing.Size(690, 393);
            this.dgSelected.TabIndex = 5;
            // 
            // cmdAddSelected
            // 
            this.cmdAddSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAddSelected.Enabled = false;
            this.cmdAddSelected.Location = new System.Drawing.Point(0, 10);
            this.cmdAddSelected.Name = "cmdAddSelected";
            this.cmdAddSelected.Size = new System.Drawing.Size(127, 27);
            this.cmdAddSelected.TabIndex = 3;
            this.cmdAddSelected.Text = "Add Selected";
            this.cmdAddSelected.UseVisualStyleBackColor = true;
            this.cmdAddSelected.Click += new System.EventHandler(this.cmdAddSelected_Click);
            // 
            // cmdAddAll
            // 
            this.cmdAddAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAddAll.Location = new System.Drawing.Point(127, 10);
            this.cmdAddAll.Name = "cmdAddAll";
            this.cmdAddAll.Size = new System.Drawing.Size(127, 27);
            this.cmdAddAll.TabIndex = 4;
            this.cmdAddAll.Text = "Add All";
            this.cmdAddAll.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(436, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(563, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove Selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(402, 38);
            this.panel2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(294, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "Reset Filters";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 714);
            this.Controls.Add(this.dgSelected);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlFilters);
            this.Name = "fTest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "fTest";
            this.Activated += new System.EventHandler(this.fTest_Activated);
            this.Load += new System.EventHandler(this.fTest_Load);
            this.pnlFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox cmbPersonType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdAddSelected;
        private System.Windows.Forms.DataGridView dgSelected;
        private System.Windows.Forms.Button cmdAddAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}