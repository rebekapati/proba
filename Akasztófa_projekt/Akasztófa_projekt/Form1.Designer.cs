namespace Akasztófa_projekt
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
            button1 = new Button();
            label1 = new Label();
            feladvany = new TextBox();
            label2 = new Label();
            hibaszam = new TextBox();
            button_Open = new Button();
            uzenet = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(12, 39);
            button1.Name = "button1";
            button1.Size = new Size(150, 61);
            button1.TabIndex = 0;
            button1.Text = "Új játék";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Feladvány:";
            // 
            // feladvany
            // 
            feladvany.Location = new Point(339, 62);
            feladvany.Name = "feladvany";
            feladvany.Size = new Size(248, 23);
            feladvany.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(684, 65);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Hibák száma:";
            // 
            // hibaszam
            // 
            hibaszam.Location = new Point(767, 62);
            hibaszam.Name = "hibaszam";
            hibaszam.Size = new Size(90, 23);
            hibaszam.TabIndex = 4;
            // 
            // button_Open
            // 
            button_Open.Location = new Point(12, 10);
            button_Open.Name = "button_Open";
            button_Open.Size = new Size(75, 23);
            button_Open.TabIndex = 5;
            button_Open.Text = "Megnyitás";
            button_Open.UseVisualStyleBackColor = true;
            button_Open.Click += button_Open_Click;
            // 
            // uzenet
            // 
            uzenet.AutoSize = true;
            uzenet.Location = new Point(251, 124);
            uzenet.Name = "uzenet";
            uzenet.Size = new Size(0, 15);
            uzenet.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 514);
            Controls.Add(uzenet);
            Controls.Add(button_Open);
            Controls.Add(hibaszam);
            Controls.Add(label2);
            Controls.Add(feladvany);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox feladvany;
        private Label label2;
        private TextBox hibaszam;
        private Button button_Open;
        private Label uzenet;
    }
}