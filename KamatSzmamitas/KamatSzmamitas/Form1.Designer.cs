namespace KamatSzmamitas
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
            label1 = new Label();
            TextboxHitelösszeg = new TextBox();
            label2 = new Label();
            comboBoxHavitörlesztő = new ComboBox();
            textBoxHavikamat = new TextBox();
            label3 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Hitel összege";
            // 
            // TextboxHitelösszeg
            // 
            TextboxHitelösszeg.Location = new Point(48, 59);
            TextboxHitelösszeg.Name = "TextboxHitelösszeg";
            TextboxHitelösszeg.Size = new Size(100, 23);
            TextboxHitelösszeg.TabIndex = 1;
            TextboxHitelösszeg.Text = "1000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 41);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Havi törlesztő";
            // 
            // comboBoxHavitörlesztő
            // 
            comboBoxHavitörlesztő.FormattingEnabled = true;
            comboBoxHavitörlesztő.Items.AddRange(new object[] { "10", "100", "1000" });
            comboBoxHavitörlesztő.Location = new Point(176, 59);
            comboBoxHavitörlesztő.Name = "comboBoxHavitörlesztő";
            comboBoxHavitörlesztő.Size = new Size(121, 23);
            comboBoxHavitörlesztő.TabIndex = 4;
            comboBoxHavitörlesztő.Text = "  20000";
            // 
            // textBoxHavikamat
            // 
            textBoxHavikamat.Location = new Point(48, 120);
            textBoxHavikamat.Name = "textBoxHavikamat";
            textBoxHavikamat.Size = new Size(100, 23);
            textBoxHavikamat.TabIndex = 6;
            textBoxHavikamat.Text = "1000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 102);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Havi kamat";
            // 
            // button1
            // 
            button1.Location = new Point(222, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(615, 150);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBoxHavikamat);
            Controls.Add(label3);
            Controls.Add(comboBoxHavitörlesztő);
            Controls.Add(label2);
            Controls.Add(TextboxHitelösszeg);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextboxHitelösszeg;
        private Label label2;
        private ComboBox comboBoxHavitörlesztő;
        private TextBox textBoxHavikamat;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
    }
}