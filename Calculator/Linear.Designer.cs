namespace Calculator
{
    partial class Linear
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(20, 30);
            label1.TabIndex = 0;
            label1.Text = "(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 30);
            label2.Name = "label2";
            label2.Size = new Size(18, 30);
            label2.TabIndex = 1;
            label2.Text = ",";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(140, 23);
            label3.Name = "label3";
            label3.Size = new Size(20, 30);
            label3.TabIndex = 2;
            label3.Text = ")";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(20, 30);
            label4.TabIndex = 5;
            label4.Text = "(";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(37, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 92);
            label5.Name = "label5";
            label5.Size = new Size(18, 30);
            label5.TabIndex = 7;
            label5.Text = ",";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(37, 23);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(140, 85);
            label6.Name = "label6";
            label6.Size = new Size(20, 30);
            label6.TabIndex = 9;
            label6.Text = ")";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 8);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 10;
            label7.Text = "Point 1:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 74);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 11;
            label8.Text = "Point 2:";
            // 
            // button1
            // 
            button1.Location = new Point(18, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 5);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 13;
            label9.Text = "Result:";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(8, 60);
            label10.MinimumSize = new Size(175, 36);
            label10.Name = "label10";
            label10.Size = new Size(175, 36);
            label10.TabIndex = 14;
            label10.Text = "label10";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(103, 137);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Linear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 166);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Linear";
            Text = "Linear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private Label label10;
        private Button button2;
    }
}