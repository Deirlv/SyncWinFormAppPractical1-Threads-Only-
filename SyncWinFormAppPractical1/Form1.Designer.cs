namespace SyncWinFormAppPractical1
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
            tabControlTask = new TabControl();
            tabPageTask1 = new TabPage();
            dataGridView1 = new DataGridView();
            columnValue = new DataGridViewTextBoxColumn();
            columnThread = new DataGridViewTextBoxColumn();
            buttonStart = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownThreads = new NumericUpDown();
            numericUpDownEnd = new NumericUpDown();
            numericUpDownStart = new NumericUpDown();
            tabPageTask2 = new TabPage();
            buttonFileStart = new Button();
            tabControlTask.SuspendLayout();
            tabPageTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).BeginInit();
            tabPageTask2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlTask
            // 
            tabControlTask.Controls.Add(tabPageTask1);
            tabControlTask.Controls.Add(tabPageTask2);
            tabControlTask.Location = new Point(12, 12);
            tabControlTask.Name = "tabControlTask";
            tabControlTask.SelectedIndex = 0;
            tabControlTask.Size = new Size(767, 426);
            tabControlTask.TabIndex = 0;
            // 
            // tabPageTask1
            // 
            tabPageTask1.Controls.Add(dataGridView1);
            tabPageTask1.Controls.Add(buttonStart);
            tabPageTask1.Controls.Add(label3);
            tabPageTask1.Controls.Add(label2);
            tabPageTask1.Controls.Add(label1);
            tabPageTask1.Controls.Add(numericUpDownThreads);
            tabPageTask1.Controls.Add(numericUpDownEnd);
            tabPageTask1.Controls.Add(numericUpDownStart);
            tabPageTask1.Location = new Point(4, 24);
            tabPageTask1.Name = "tabPageTask1";
            tabPageTask1.Padding = new Padding(3);
            tabPageTask1.Size = new Size(759, 398);
            tabPageTask1.TabIndex = 0;
            tabPageTask1.Text = "Task 1";
            tabPageTask1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnValue, columnThread });
            dataGridView1.Location = new Point(23, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(401, 350);
            dataGridView1.TabIndex = 6;
            // 
            // columnValue
            // 
            columnValue.HeaderText = "Value";
            columnValue.Name = "columnValue";
            columnValue.ReadOnly = true;
            columnValue.Width = 150;
            // 
            // columnThread
            // 
            columnThread.HeaderText = "Thread";
            columnThread.Name = "columnThread";
            columnThread.ReadOnly = true;
            columnThread.Width = 200;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(559, 287);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 190);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "Number of threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 140);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 4;
            label2.Text = "End of the range";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 92);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Start of the range";
            // 
            // numericUpDownThreads
            // 
            numericUpDownThreads.Location = new Point(492, 208);
            numericUpDownThreads.Name = "numericUpDownThreads";
            numericUpDownThreads.Size = new Size(205, 23);
            numericUpDownThreads.TabIndex = 2;
            // 
            // numericUpDownEnd
            // 
            numericUpDownEnd.Location = new Point(492, 158);
            numericUpDownEnd.Name = "numericUpDownEnd";
            numericUpDownEnd.Size = new Size(205, 23);
            numericUpDownEnd.TabIndex = 1;
            // 
            // numericUpDownStart
            // 
            numericUpDownStart.Location = new Point(492, 110);
            numericUpDownStart.Name = "numericUpDownStart";
            numericUpDownStart.Size = new Size(205, 23);
            numericUpDownStart.TabIndex = 0;
            // 
            // tabPageTask2
            // 
            tabPageTask2.Controls.Add(buttonFileStart);
            tabPageTask2.Location = new Point(4, 24);
            tabPageTask2.Name = "tabPageTask2";
            tabPageTask2.Padding = new Padding(3);
            tabPageTask2.Size = new Size(759, 398);
            tabPageTask2.TabIndex = 1;
            tabPageTask2.Text = "Task 2";
            tabPageTask2.UseVisualStyleBackColor = true;
            // 
            // buttonFileStart
            // 
            buttonFileStart.Location = new Point(310, 180);
            buttonFileStart.Name = "buttonFileStart";
            buttonFileStart.Size = new Size(127, 29);
            buttonFileStart.TabIndex = 0;
            buttonFileStart.Text = "Start File";
            buttonFileStart.UseVisualStyleBackColor = true;
            buttonFileStart.Click += buttonFileStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlTask);
            Name = "Form1";
            Text = "Form1";
            tabControlTask.ResumeLayout(false);
            tabPageTask1.ResumeLayout(false);
            tabPageTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThreads).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).EndInit();
            tabPageTask2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTask;
        private TabPage tabPageTask1;
        private TabPage tabPageTask2;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownThreads;
        private NumericUpDown numericUpDownEnd;
        private NumericUpDown numericUpDownStart;
        private Button buttonStart;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columnValue;
        private DataGridViewTextBoxColumn columnThread;
        private Button buttonFileStart;
    }
}
