namespace FutoVersenyzok
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
            dataGridView1 = new DataGridView();
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versenyzőBindingSource = new BindingSource(components);
            ButtonOpen = new Button();
            ButtonSave = new Button();
            ButtonDelete = new Button();
            ButtonAddNew = new Button();
            ButtonCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)versenyzőBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = versenyzőBindingSource;
            dataGridView1.Location = new Point(14, 248);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(875, 336);
            dataGridView1.TabIndex = 0;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            versenyzoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 6;
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            nemzetisegDataGridViewTextBoxColumn.Width = 125;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 6;
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            eredmenyPercDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // versenyzőBindingSource
            // 
            versenyzőBindingSource.DataSource = typeof(Versenyző);
            // 
            // ButtonOpen
            // 
            ButtonOpen.Location = new Point(763, 36);
            ButtonOpen.Margin = new Padding(3, 4, 3, 4);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(126, 51);
            ButtonOpen.TabIndex = 1;
            ButtonOpen.Text = "Megnyitás";
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(763, 113);
            ButtonSave.Margin = new Padding(3, 4, 3, 4);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(126, 55);
            ButtonSave.TabIndex = 2;
            ButtonSave.Text = "Mentés";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(14, 36);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(133, 60);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Törlés";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonAddNew
            // 
            ButtonAddNew.Location = new Point(14, 113);
            ButtonAddNew.Margin = new Padding(3, 4, 3, 4);
            ButtonAddNew.Name = "ButtonAddNew";
            ButtonAddNew.Size = new Size(133, 60);
            ButtonAddNew.TabIndex = 4;
            ButtonAddNew.Text = "Új";
            ButtonAddNew.UseVisualStyleBackColor = true;
            ButtonAddNew.Click += ButtonAddNew_Click;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(400, 183);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(94, 29);
            ButtonCalculate.TabIndex = 5;
            ButtonCalculate.Text = "Számítások";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ButtonCalculate);
            Controls.Add(ButtonAddNew);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonOpen);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)versenyzőBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ButtonOpen;
        private Button ButtonSave;
        private Button ButtonDelete;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource versenyzőBindingSource;
        private Button ButtonAddNew;
        private Button ButtonCalculate;
    }
}