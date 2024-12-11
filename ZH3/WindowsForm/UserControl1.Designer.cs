namespace WindowsForm
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            riddleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            questionTextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correctAnswerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wrongAnswer1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wrongAnswer2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wrongAnswer3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            riddleBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)riddleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { riddleIdDataGridViewTextBoxColumn, questionTextDataGridViewTextBoxColumn, correctAnswerDataGridViewTextBoxColumn, wrongAnswer1DataGridViewTextBoxColumn, wrongAnswer2DataGridViewTextBoxColumn, wrongAnswer3DataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = riddleBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(859, 227);
            dataGridView1.TabIndex = 0;
            // 
            // riddleIdDataGridViewTextBoxColumn
            // 
            riddleIdDataGridViewTextBoxColumn.DataPropertyName = "RiddleId";
            riddleIdDataGridViewTextBoxColumn.HeaderText = "RiddleId";
            riddleIdDataGridViewTextBoxColumn.Name = "riddleIdDataGridViewTextBoxColumn";
            // 
            // questionTextDataGridViewTextBoxColumn
            // 
            questionTextDataGridViewTextBoxColumn.DataPropertyName = "QuestionText";
            questionTextDataGridViewTextBoxColumn.HeaderText = "QuestionText";
            questionTextDataGridViewTextBoxColumn.Name = "questionTextDataGridViewTextBoxColumn";
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            // 
            // wrongAnswer1DataGridViewTextBoxColumn
            // 
            wrongAnswer1DataGridViewTextBoxColumn.DataPropertyName = "WrongAnswer1";
            wrongAnswer1DataGridViewTextBoxColumn.HeaderText = "WrongAnswer1";
            wrongAnswer1DataGridViewTextBoxColumn.Name = "wrongAnswer1DataGridViewTextBoxColumn";
            // 
            // wrongAnswer2DataGridViewTextBoxColumn
            // 
            wrongAnswer2DataGridViewTextBoxColumn.DataPropertyName = "WrongAnswer2";
            wrongAnswer2DataGridViewTextBoxColumn.HeaderText = "WrongAnswer2";
            wrongAnswer2DataGridViewTextBoxColumn.Name = "wrongAnswer2DataGridViewTextBoxColumn";
            // 
            // wrongAnswer3DataGridViewTextBoxColumn
            // 
            wrongAnswer3DataGridViewTextBoxColumn.DataPropertyName = "WrongAnswer3";
            wrongAnswer3DataGridViewTextBoxColumn.HeaderText = "WrongAnswer3";
            wrongAnswer3DataGridViewTextBoxColumn.Name = "wrongAnswer3DataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // riddleBindingSource
            // 
            riddleBindingSource.DataSource = typeof(Models.Riddle);
            // 
            // button1
            // 
            button1.Location = new Point(30, 264);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 1;
            button1.Text = "Uj hozzaadasa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(181, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Mentes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 264);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "törlés";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(443, 264);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "mentés excelbe";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserControl1";
            Size = new Size(865, 381);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)riddleBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn riddleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn questionTextDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wrongAnswer1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wrongAnswer2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wrongAnswer3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource riddleBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
