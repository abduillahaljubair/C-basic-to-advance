using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1_20220104123_C1
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(DataGridView grid)
        {
            InitializeComponent();

            List<int> totalMarks = new List<int>();
            Dictionary<string, int> gradeCount = new Dictionary<string, int>();

            // Collect total marks and grades from DataGridView
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                int total = 0;
                if (int.TryParse(row.Cells["Total_col"].Value?.ToString(), out total))
                {
                    totalMarks.Add(total);
                }

                string grade = row.Cells["Grade_col"].Value?.ToString();
                if (!string.IsNullOrEmpty(grade))
                {
                    if (!gradeCount.ContainsKey(grade))
                        gradeCount[grade] = 0;

                    gradeCount[grade]++;
                }
            }

            // Show average, high, low
            if (totalMarks.Count > 0)
            {
                double avg = totalMarks.Count > 0 ? totalMarks.Average() : 0;
                int high = totalMarks.Count > 0 ? totalMarks.Max() : 0;
                int low = totalMarks.Count > 0 ? totalMarks.Min() : 0;

                lblAverage.Text = $"Average: {avg:F2}";
                lblHigh.Text = $"Highest: {high}";
                lblLow.Text = $"Lowest: {low}";
            }

            // Show grade distribution
            lstGrades.Items.Clear();
            foreach (var pair in gradeCount)
            {
                lstGrades.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Just close summary form, back to main
        }
    }
}
