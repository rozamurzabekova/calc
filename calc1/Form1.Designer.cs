namespace calc1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.Rez = new System.Windows.Forms.Label();
            this.cos = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число2";
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(31, 81);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Calculate);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(121, 81);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Calculate);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(31, 111);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 6;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.Calculate);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(121, 110);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 7;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Calculate);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(31, 140);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 9;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneCalculate);
            // 
            // Rez
            // 
            this.Rez.AutoSize = true;
            this.Rez.Location = new System.Drawing.Point(45, 181);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(26, 13);
            this.Rez.TabIndex = 10;
            this.Rez.Text = "Rez";
            this.Rez.Click += new System.EventHandler(this.Rez_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(121, 140);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 11;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneCalculate);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(121, 169);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 12;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.OneCalculate);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(121, 198);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 13;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneCalculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.log);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Label Rez;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button tan;
    }
}

