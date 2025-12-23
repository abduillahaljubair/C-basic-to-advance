using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1_20220104123_C1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // 🔹 Add Student Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var (roll, name, att, online, assign, proj) = Prompt.ShowStudentDialog();

            if (string.IsNullOrWhiteSpace(roll) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Roll No and Name cannot be empty!");
                return;
            }

            if (IsDuplicateRoll(roll))
            {
                MessageBox.Show("Duplicate Roll Number! Please enter a unique Roll No.");
                return;
            }

            if (att < 0 || att > 20 || online < 0 || online > 10 ||
                assign < 0 || assign > 20 || proj < 0 || proj > 50)
            {
                MessageBox.Show("Marks must be within valid range:\nAttendance (0-20), Online (0-10), Assignment (0-20), Project (0-50)");
                return;
            }

            int total = att + online + assign + proj;
            string grade = GetGrade(total);

            grdStudents.Rows.Add(roll, name, att, online, assign, proj, total, grade);
        }

        // 🔹 Remove Selected Student
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdStudents.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    grdStudents.Rows.Remove(row);
                }
            }
        }

        // 🔹 Import CSV
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] data = line.Split(',');

                        if (data.Length >= 2)
                        {
                            string roll = data[0].Trim();
                            string name = data[1].Trim();

                            if (!IsDuplicateRoll(roll))
                            {
                                int att = data.Length > 2 ? ToInt(data[2]) : 0;
                                int online = data.Length > 3 ? ToInt(data[3]) : 0;
                                int assign = data.Length > 4 ? ToInt(data[4]) : 0;
                                int proj = data.Length > 5 ? ToInt(data[5]) : 0;

                                int total = att + online + assign + proj;
                                string grade = GetGrade(total);

                                grdStudents.Rows.Add(roll, name, att, online, assign, proj, total, grade);
                            }
                        }
                    }
                    MessageBox.Show("Import completed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error importing file: " + ex.Message);
                }
            }
        }

        // 🔹 Export CSV
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();

                foreach (DataGridViewRow row in grdStudents.Rows)
                {
                    if (row.IsNewRow) continue;

                    List<string> rowData = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowData.Add(cell.Value?.ToString() ?? "");
                    }
                    lines.Add(string.Join(",", rowData));
                }

                File.WriteAllLines(sfd.FileName, lines);
                MessageBox.Show("Exported successfully!");
            }
        }

        // 🔹 Generate Report / Summary
        private void btnReport_Click(object sender, EventArgs e)
        {
            CalculateGrades();
            MessageBox.Show("Grades calculated & updated!");

            SummaryForm summary = new SummaryForm(grdStudents);
            summary.Show();
        }

        // 🔹 Summary button
        private void btnSummary_Click(object sender, EventArgs e)
        {
            SummaryForm summary = new SummaryForm(grdStudents);
            summary.Show();
        }

        // 🔹 Search button → shows MessageBox
        private void Search_Click(object sender, EventArgs e)
        {
            string searchRoll = txtSearchRoll.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchRoll))
            {
                MessageBox.Show("Please enter a Roll No to search.");
                return;
            }
            SearchStudentByRoll_ShowMessage(searchRoll);
        }

        // 🔹 TextBox text changed → only highlight
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string roll = txtSearchRoll.Text.Trim();
            if (!string.IsNullOrWhiteSpace(roll))
            {
                SearchStudentByRoll_HighlightOnly(roll);
            }
        }

        // 🔹 Helper: show MessageBox when search button clicked
        private void SearchStudentByRoll_ShowMessage(string roll)
        {
            foreach (DataGridViewRow row in grdStudents.Rows)
            {
                if (!row.IsNewRow && row.Cells["RollNo_col"].Value?.ToString() == roll)
                {
                    string name = row.Cells["Name_col"].Value?.ToString();
                    string total = row.Cells["Total_col"].Value?.ToString();

                    MessageBox.Show($"Found!\nRoll No: {roll}\nName: {name}\nTotal Marks: {total}");
                    row.Selected = true;
                    grdStudents.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
            MessageBox.Show("Student not found!");
        }

        // 🔹 Helper: only highlight when typing
        private void SearchStudentByRoll_HighlightOnly(string roll)
        {
            foreach (DataGridViewRow row in grdStudents.Rows)
            {
                if (!row.IsNewRow && row.Cells["RollNo_col"].Value?.ToString() == roll)
                {
                    row.Selected = true;
                    grdStudents.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }

        // 🔹 Calculate grades
        private void CalculateGrades()
        {
            foreach (DataGridViewRow row in grdStudents.Rows)
            {
                if (row.IsNewRow) continue;

                int att = ToInt(row.Cells["Attendance_col"].Value);
                int online = ToInt(row.Cells["Online_col"].Value);
                int assign = ToInt(row.Cells["Assignment_col"].Value);
                int proj = ToInt(row.Cells["Project_col"].Value);

                int total = att + online + assign + proj;
                string grade = GetGrade(total);

                row.Cells["Total_col"].Value = total;
                row.Cells["Grade_col"].Value = grade;
            }
        }

        // 🔹 Get grade
        private string GetGrade(int total)
        {
            if (total >= 90) return "A+";
            else if (total >= 80) return "A";
            else if (total >= 75) return "A-";
            else if (total >= 70) return "B+";
            else if (total >= 65) return "B";
            else if (total >= 60) return "B-";
            else if (total >= 55) return "C+";
            else if (total >= 50) return "C";
            else if (total >= 40) return "D";
            else return "F";
        }

        // 🔹 Check duplicate roll
        private bool IsDuplicateRoll(string roll)
        {
            foreach (DataGridViewRow row in grdStudents.Rows)
            {
                if (!row.IsNewRow && row.Cells["RollNo_col"].Value?.ToString() == roll)
                    return true;
            }
            return false;
        }

        // 🔹 Convert to int
        private int ToInt(object value)
        {
            return int.TryParse(value?.ToString(), out int result) ? result : 0;
        }

        // auto-generated event (optional)
        private void grdStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
