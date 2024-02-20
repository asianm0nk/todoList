namespace ToDo_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createBTN = new Button();
            TextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // createBTN
            // 
            createBTN.Location = new Point(683, 42);
            createBTN.Name = "createBTN";
            createBTN.Size = new Size(94, 29);
            createBTN.TabIndex = 0;
            createBTN.Text = "Create";
            createBTN.UseVisualStyleBackColor = true;
            createBTN.Click += createBTN_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(461, 44);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(216, 27);
            TextBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Location = new Point(12, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(408, 349);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TextBox);
            Controls.Add(createBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBTN;
        private TextBox TextBox;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
