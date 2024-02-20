namespace ToDo_List
{
    internal partial class Form1 : Form
    {
        public static List<TaskPanel> tasksPanel = new List<TaskPanel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            tasksPanel.Add(new TaskPanel(new Task(TextBox.Text)));
            addToDGV();
            clearBox();
        }

        private void clearBox()
        {
            TextBox.Text = string.Empty;
        }

        private void addToDGV()
        {
            tableLayoutPanel1.Controls.Clear();
            foreach (var task in tasksPanel)
            {
                tableLayoutPanel1.Controls.Add(task);
            }
        }

    }
}
