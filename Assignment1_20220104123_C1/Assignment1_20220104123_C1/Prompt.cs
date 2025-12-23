using System;
using System.Windows.Forms;

public static class Prompt
{
    // যেহেতু আমরা একসাথে RollNo, Name, Attendance, Online, Assignment, Project নিচ্ছি,
    // তাই ShowStudentDialog() নামে একটি মেথড ব্যবহার করব:
    public static (string roll, string name, int attendance, int online, int assignment, int project) ShowStudentDialog()
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 400,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = "Add Student",
            StartPosition = FormStartPosition.CenterScreen
        };

        Label[] labels = new Label[]
        {
            new Label() { Left = 20, Top = 20, Text = "Roll No:", AutoSize = true },
            new Label() { Left = 20, Top = 60, Text = "Name:", AutoSize = true },
            new Label() { Left = 20, Top = 100, Text = "Attendance (0-20):", AutoSize = true },
            new Label() { Left = 20, Top = 140, Text = "Online (0-10):", AutoSize = true },
            new Label() { Left = 20, Top = 180, Text = "Assignment (0-20):", AutoSize = true },
            new Label() { Left = 20, Top = 220, Text = "Project (0-50):", AutoSize = true },
        };

        TextBox[] textBoxes = new TextBox[6];
        for (int i = 0; i < 6; i++)
        {
            textBoxes[i] = new TextBox() { Left = 180, Top = 20 + i * 40, Width = 180 };
            prompt.Controls.Add(labels[i]);
            prompt.Controls.Add(textBoxes[i]);
        }

        Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 280, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(confirmation);
        prompt.AcceptButton = confirmation;

        if (prompt.ShowDialog() == DialogResult.OK)
        {
            try
            {
                string roll = textBoxes[0].Text.Trim();
                string name = textBoxes[1].Text.Trim();
                int attendance = int.Parse(textBoxes[2].Text.Trim());
                int online = int.Parse(textBoxes[3].Text.Trim());
                int assignment = int.Parse(textBoxes[4].Text.Trim());
                int project = int.Parse(textBoxes[5].Text.Trim());

                return (roll, name, attendance, online, assignment, project);
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter correct data.");
            }
        }

        return ("", "", 0, 0, 0, 0);
    }

    // যদি শুধু RollNo দিয়ে search করো, তাহলে ShowDialog(string, string) মেথড আলাদা রাখতে পারো:
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
        TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
        Button confirmation = new Button() { Text = "Ok", Left = 270, Width = 90, Top = 80, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };

        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }
}
