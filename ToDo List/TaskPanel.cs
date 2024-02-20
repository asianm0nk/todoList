using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    internal class TaskPanel : Panel
    {
        public TaskPanel(Task task) { 
            
            this.task = task;

            Height = 125;
            Width = 373;

            panel = new Panel
            {
                Parent = this,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Size = new Size(373, 125),
                Location = new Point(3, 3)
            };

            isDoneOnPanel = new CheckBox
            {
                Parent = panel,
                Location = new Point(152, 95),
                Checked = task.getIsDone(),
                Size = new Size(18, 17)
            };

            nameOnPanel = new TextBox
            {
                Parent = panel,
                Location = new Point(3, 6),
                Text = task.getName(),
                Size = new Size(373, 50),
                Enabled = false
            };

            Delete = new Button
            {
                Parent = panel,
                Location = new Point(276, 93),
                Text = "Delete",
                Size = new Size(94, 30)
                
            };

            Edit = new Button
            {
                Parent = panel,
                Location = new Point(176, 93),
                Text = "Edit",
                Size = new Size(94, 30)
            };

            Delete.Click += DeleleBTN_click;
            Edit.Click += EditBTN_click;
        }

        private int id;
        private Panel panel;
        private Task task;

        private CheckBox isDoneOnPanel;
        private TextBox nameOnPanel;
        private Button Delete;
        private Button Edit;

        private void DeleleBTN_click(object sender, EventArgs e)
        {
            if (Delete.Text == "Delete")
            {
                Form1.tasksPanel.Remove(this);
                this.Parent?.Controls.Remove(this);
            }
            else
            {
                nameOnPanel.Text = task.getName();
                isDoneOnPanel.Checked = task.getIsDone();
                Edit.Text = "Edit";
                Delete.Text = "Delete";
                nameOnPanel.Enabled = false;
            }
        }

        private void EditBTN_click(object sender, EventArgs e)
        {
            Edit.Text = "Save";
            Delete.Text = "Cancel";
            nameOnPanel.Enabled = true;
            Edit.Click -= EditBTN_click;
            Edit.Click += saveBTN_click;
        }

        private void saveBTN_click(Object sender, EventArgs e)
        {
            nameOnPanel.Enabled = false;
            Edit.Text = "Edit";
            Delete.Text = "Delete";
            Edit.Click -= saveBTN_click;
            Edit.Click += EditBTN_click;
            task.setName(nameOnPanel.Text);
            task.setIsDone(isDoneOnPanel.Checked);
        }
    }
}
