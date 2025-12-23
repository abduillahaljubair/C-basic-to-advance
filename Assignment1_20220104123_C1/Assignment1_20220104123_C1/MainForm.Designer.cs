namespace Assignment1_20220104123_C1
{
    partial class MainForm
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
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.RollNo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Online_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assignment_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSearchRoll = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RollNo_col,
            this.Name_col,
            this.Attendance_col,
            this.Online_col,
            this.Assignment_col,
            this.Project_col,
            this.Total_col,
            this.Grade_col});
            this.grdStudents.Location = new System.Drawing.Point(91, 100);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.RowHeadersWidth = 51;
            this.grdStudents.RowTemplate.Height = 24;
            this.grdStudents.Size = new System.Drawing.Size(1006, 245);
            this.grdStudents.TabIndex = 1;
            this.grdStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudents_CellContentClick);
            // 
            // RollNo_col
            // 
            this.RollNo_col.HeaderText = "RollNo";
            this.RollNo_col.MinimumWidth = 6;
            this.RollNo_col.Name = "RollNo_col";
            this.RollNo_col.Width = 125;
            // 
            // Name_col
            // 
            this.Name_col.HeaderText = "Name";
            this.Name_col.MinimumWidth = 6;
            this.Name_col.Name = "Name_col";
            this.Name_col.Width = 125;
            // 
            // Attendance_col
            // 
            this.Attendance_col.HeaderText = "Attendance";
            this.Attendance_col.MinimumWidth = 6;
            this.Attendance_col.Name = "Attendance_col";
            this.Attendance_col.Width = 125;
            // 
            // Online_col
            // 
            this.Online_col.HeaderText = "Online";
            this.Online_col.MinimumWidth = 6;
            this.Online_col.Name = "Online_col";
            this.Online_col.Width = 125;
            // 
            // Assignment_col
            // 
            this.Assignment_col.HeaderText = "Assignment";
            this.Assignment_col.MinimumWidth = 6;
            this.Assignment_col.Name = "Assignment_col";
            this.Assignment_col.Width = 125;
            // 
            // Project_col
            // 
            this.Project_col.HeaderText = "Project";
            this.Project_col.MinimumWidth = 6;
            this.Project_col.Name = "Project_col";
            this.Project_col.Width = 125;
            // 
            // Total_col
            // 
            this.Total_col.HeaderText = "Total";
            this.Total_col.MinimumWidth = 6;
            this.Total_col.Name = "Total_col";
            this.Total_col.Width = 125;
            // 
            // Grade_col
            // 
            this.Grade_col.HeaderText = "Grade";
            this.Grade_col.MinimumWidth = 6;
            this.Grade_col.Name = "Grade_col";
            this.Grade_col.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 57);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(335, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 57);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(550, 351);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(132, 57);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(748, 351);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 57);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Grades";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(933, 351);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(141, 57);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(506, 43);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 16);
            this.Search.TabIndex = 7;
            this.Search.Text = "SearchById:";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnsearch
            // 
            // btnsearch
            this.btnsearch.Location = new System.Drawing.Point(729, 36);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 30);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // এখানে ঠিক করো:
            this.btnsearch.Click += new System.EventHandler(this.Search_Click);

            // 
            // txtSearchRoll
            // 
            this.txtSearchRoll.Location = new System.Drawing.Point(592, 40);
            this.txtSearchRoll.Name = "txtSearchRoll";
            this.txtSearchRoll.Size = new System.Drawing.Size(131, 22);
            this.txtSearchRoll.TabIndex = 9;
            this.txtSearchRoll.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 498);
            this.Controls.Add(this.txtSearchRoll);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdStudents);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Online_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade_col;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearchRoll;
    }
}