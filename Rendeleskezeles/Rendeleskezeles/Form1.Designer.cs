namespace Rendeleskezeles
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
            components = new System.ComponentModel.Container();
            textBoxNafogasszures = new TextBox();
            listBoxNyaFogas = new ListBox();
            fogasokBindingSource = new BindingSource(components);
            listBoxAnyagfuhasiskoko = new ListBox();
            nyersanyagokBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            receptIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fogasIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiseg4foDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            árDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hozzavaloBindingSource = new BindingSource(components);
            comboBoxCim = new ComboBox();
            textBoxAnyagszuro = new TextBox();
            comboBoxStatus = new ComboBox();
            buttonTetelHozzaadas = new Button();
            buttonTeteltorles = new Button();
            textBoxMennyiseg = new TextBox();
            buttonUjrendeles = new Button();
            buttonMentes = new Button();
            buttonMentesExcel = new Button();
            labelosszertek = new Label();
            labelMennyiseg = new Label();
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hozzavaloBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxNafogasszures
            // 
            textBoxNafogasszures.Location = new Point(12, 12);
            textBoxNafogasszures.Name = "textBoxNafogasszures";
            textBoxNafogasszures.Size = new Size(202, 23);
            textBoxNafogasszures.TabIndex = 0;
            textBoxNafogasszures.TextChanged += textBoxNafogasszures_TextChanged;
            // 
            // listBoxNyaFogas
            // 
            listBoxNyaFogas.DataSource = fogasokBindingSource;
            listBoxNyaFogas.DisplayMember = "FogasNev";
            listBoxNyaFogas.FormattingEnabled = true;
            listBoxNyaFogas.ItemHeight = 15;
            listBoxNyaFogas.Location = new Point(12, 50);
            listBoxNyaFogas.Name = "listBoxNyaFogas";
            listBoxNyaFogas.Size = new Size(202, 409);
            listBoxNyaFogas.TabIndex = 1;
            listBoxNyaFogas.ValueMember = "FogasId";
            listBoxNyaFogas.SelectedIndexChanged += listBoxNyaFogas_SelectedIndexChanged;
            // 
            // fogasokBindingSource
            // 
            fogasokBindingSource.DataSource = typeof(Models.Fogasok);
            // 
            // listBoxAnyagfuhasiskoko
            // 
            listBoxAnyagfuhasiskoko.DataSource = nyersanyagokBindingSource;
            listBoxAnyagfuhasiskoko.DisplayMember = "NyersanyagNev";
            listBoxAnyagfuhasiskoko.FormattingEnabled = true;
            listBoxAnyagfuhasiskoko.ItemHeight = 15;
            listBoxAnyagfuhasiskoko.Location = new Point(1223, 50);
            listBoxAnyagfuhasiskoko.Name = "listBoxAnyagfuhasiskoko";
            listBoxAnyagfuhasiskoko.Size = new Size(240, 409);
            listBoxAnyagfuhasiskoko.TabIndex = 3;
            listBoxAnyagfuhasiskoko.ValueMember = "NyersanyagId";
            listBoxAnyagfuhasiskoko.SelectedIndexChanged += listBoxAnyagfuhasiskoko_SelectedIndexChanged;
            // 
            // nyersanyagokBindingSource
            // 
            nyersanyagokBindingSource.DataSource = typeof(Models.Nyersanyagok);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { receptIDDataGridViewTextBoxColumn, fogasIDDataGridViewTextBoxColumn, nyersanyagNevDataGridViewTextBoxColumn, mennyiseg4foDataGridViewTextBoxColumn, egysegNevDataGridViewTextBoxColumn, árDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hozzavaloBindingSource;
            dataGridView1.Location = new Point(443, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(589, 358);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            árDataGridViewTextBoxColumn.HeaderText = "Ár";
            árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // hozzavaloBindingSource
            // 
            hozzavaloBindingSource.DataSource = typeof(Hozzavalo);
            // 
            // comboBoxCim
            // 
            comboBoxCim.FormattingEnabled = true;
            comboBoxCim.Location = new Point(443, 50);
            comboBoxCim.Name = "comboBoxCim";
            comboBoxCim.Size = new Size(332, 23);
            comboBoxCim.TabIndex = 5;
            // 
            // textBoxAnyagszuro
            // 
            textBoxAnyagszuro.Location = new Point(1223, 21);
            textBoxAnyagszuro.Name = "textBoxAnyagszuro";
            textBoxAnyagszuro.Size = new Size(240, 23);
            textBoxAnyagszuro.TabIndex = 6;
            textBoxAnyagszuro.TextChanged += textBoxAnyagszuro_TextChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DataSource = nyersanyagokBindingSource;
            comboBoxStatus.DisplayMember = "NyersanyagNev";
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(887, 50);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(145, 23);
            comboBoxStatus.TabIndex = 7;
            comboBoxStatus.ValueMember = "NyersanyagId";
            // 
            // buttonTetelHozzaadas
            // 
            buttonTetelHozzaadas.Location = new Point(1071, 258);
            buttonTetelHozzaadas.Name = "buttonTetelHozzaadas";
            buttonTetelHozzaadas.Size = new Size(118, 23);
            buttonTetelHozzaadas.TabIndex = 8;
            buttonTetelHozzaadas.Text = "Tétel hozzáadása";
            buttonTetelHozzaadas.UseVisualStyleBackColor = true;
            buttonTetelHozzaadas.Click += buttonTetelHozzaadas_Click;
            // 
            // buttonTeteltorles
            // 
            buttonTeteltorles.Location = new Point(1071, 323);
            buttonTeteltorles.Name = "buttonTeteltorles";
            buttonTeteltorles.Size = new Size(118, 23);
            buttonTeteltorles.TabIndex = 9;
            buttonTeteltorles.Text = "Tétel Törlés";
            buttonTeteltorles.UseVisualStyleBackColor = true;
            buttonTeteltorles.Click += buttonTeteltorles_Click;
            // 
            // textBoxMennyiseg
            // 
            textBoxMennyiseg.Location = new Point(1220, 465);
            textBoxMennyiseg.Name = "textBoxMennyiseg";
            textBoxMennyiseg.Size = new Size(100, 23);
            textBoxMennyiseg.TabIndex = 10;
            // 
            // buttonUjrendeles
            // 
            buttonUjrendeles.Location = new Point(235, 481);
            buttonUjrendeles.Name = "buttonUjrendeles";
            buttonUjrendeles.Size = new Size(118, 23);
            buttonUjrendeles.TabIndex = 11;
            buttonUjrendeles.Text = "Ujreneles";
            buttonUjrendeles.UseVisualStyleBackColor = true;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(763, 481);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(118, 23);
            buttonMentes.TabIndex = 12;
            buttonMentes.Text = "Mentes";
            buttonMentes.UseVisualStyleBackColor = true;
            // 
            // buttonMentesExcel
            // 
            buttonMentesExcel.Location = new Point(914, 481);
            buttonMentesExcel.Name = "buttonMentesExcel";
            buttonMentesExcel.Size = new Size(118, 24);
            buttonMentesExcel.TabIndex = 13;
            buttonMentesExcel.Text = "MentesExcel";
            buttonMentesExcel.UseVisualStyleBackColor = true;
            buttonMentesExcel.Click += buttonMentesExcel_Click;
            // 
            // labelosszertek
            // 
            labelosszertek.AutoSize = true;
            labelosszertek.Location = new Point(477, 481);
            labelosszertek.Name = "labelosszertek";
            labelosszertek.Size = new Size(38, 15);
            labelosszertek.TabIndex = 14;
            labelosszertek.Text = "label1";
            // 
            // labelMennyiseg
            // 
            labelMennyiseg.AutoSize = true;
            labelMennyiseg.Location = new Point(1326, 471);
            labelMennyiseg.Name = "labelMennyiseg";
            labelMennyiseg.Size = new Size(38, 15);
            labelMennyiseg.TabIndex = 15;
            labelMennyiseg.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 516);
            Controls.Add(labelMennyiseg);
            Controls.Add(labelosszertek);
            Controls.Add(buttonMentesExcel);
            Controls.Add(buttonMentes);
            Controls.Add(buttonUjrendeles);
            Controls.Add(textBoxMennyiseg);
            Controls.Add(buttonTeteltorles);
            Controls.Add(buttonTetelHozzaadas);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxAnyagszuro);
            Controls.Add(comboBoxCim);
            Controls.Add(dataGridView1);
            Controls.Add(listBoxAnyagfuhasiskoko);
            Controls.Add(listBoxNyaFogas);
            Controls.Add(textBoxNafogasszures);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hozzavaloBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNafogasszures;
        private ListBox listBoxNyaFogas;
        private ListBox listBoxAnyagfuhasiskoko;
        private DataGridView dataGridView1;
        private ComboBox comboBoxCim;
        private TextBox textBoxAnyagszuro;
        private ComboBox comboBoxStatus;
        private Button buttonTetelHozzaadas;
        private Button buttonTeteltorles;
        private TextBox textBoxMennyiseg;
        private Button buttonUjrendeles;
        private Button buttonMentes;
        private Button buttonMentesExcel;
        private Label labelosszertek;
        private Label labelMennyiseg;
        private BindingSource nyersanyagokBindingSource;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private BindingSource fogasokBindingSource;
        private BindingSource hozzavaloBindingSource;
        private DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
    }
}