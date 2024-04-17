namespace FutoVersenyzok
{
    partial class FormAddNew
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            versenyzőBindingSource = new BindingSource(components);
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)versenyzőBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(323, 526);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(231, 526);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 1;
            button2.Text = "&Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", versenyzőBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(34, 59);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 2;
            // 
            // versenyzőBindingSource
            // 
            versenyzőBindingSource.DataSource = typeof(Versenyző);
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", versenyzőBindingSource, "Nev", true));
            textBox6.Location = new Point(34, 159);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 27);
            textBox6.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", versenyzőBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(34, 266);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", versenyzőBindingSource, "EredmenyPerc", true));
            textBox8.Location = new Point(34, 366);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(274, 27);
            textBox8.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", versenyzőBindingSource, "Kategoria", true));
            textBox10.Location = new Point(34, 470);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(274, 27);
            textBox10.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 14;
            label1.Text = "Versenyző azonosítója";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 123);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 15;
            label2.Text = "Név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 230);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 16;
            label3.Text = "Nemzetiség";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 331);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 17;
            label4.Text = "Eredmény";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 436);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 18;
            label5.Text = "Kategória";
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 564);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox10);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddNew";
            Text = "FormAddNew";
            Load += FormAddNew_Load;
            ((System.ComponentModel.ISupportInitialize)versenyzőBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox textBox10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource versenyzőBindingSource;
    }
}