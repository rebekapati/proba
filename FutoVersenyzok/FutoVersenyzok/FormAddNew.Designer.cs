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
            bindingSource1 = new BindingSource(components);
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(305, 605);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(213, 605);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 1;
            button2.Text = "&Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBox1.Location = new Point(41, 112);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 2;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Versenyző);
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox6.Location = new Point(41, 212);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 27);
            textBox6.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBox3.Location = new Point(41, 319);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBox8.Location = new Point(41, 419);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(274, 27);
            textBox8.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBox10.Location = new Point(41, 523);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(274, 27);
            textBox10.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 75);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 14;
            label1.Text = "Versenyző azonosítója";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 176);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 15;
            label2.Text = "Név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 283);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 16;
            label3.Text = "Nemzetiség";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 384);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 17;
            label4.Text = "Eredmény";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 489);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 18;
            label5.Text = "Kategória";
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 652);
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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
        private BindingSource bindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}