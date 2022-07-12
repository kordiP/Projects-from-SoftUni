namespace RadioButtonCalc
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
            this.plus = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.umnojenie = new System.Windows.Forms.RadioButton();
            this.delenie = new System.Windows.Forms.RadioButton();
            this.ostatuk = new System.Windows.Forms.RadioButton();
            this.presmetni = new System.Windows.Forms.Button();
            this.Izchisti = new System.Windows.Forms.Button();
            this.Izhod = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subirane = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(67, 81);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(14, 13);
            this.plus.TabIndex = 0;
            this.plus.TabStop = true;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.CheckedChanged += new System.EventHandler(this.plus_CheckedChanged);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(81, 133);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(109, 27);
            this.minus.TabIndex = 1;
            this.minus.TabStop = true;
            this.minus.Text = "Изваждане";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.CheckedChanged += new System.EventHandler(this.minus_CheckedChanged);
            // 
            // umnojenie
            // 
            this.umnojenie.AutoSize = true;
            this.umnojenie.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.umnojenie.Location = new System.Drawing.Point(80, 160);
            this.umnojenie.Name = "umnojenie";
            this.umnojenie.Size = new System.Drawing.Size(113, 27);
            this.umnojenie.TabIndex = 2;
            this.umnojenie.TabStop = true;
            this.umnojenie.Text = "Умножение";
            this.umnojenie.UseVisualStyleBackColor = true;
            this.umnojenie.CheckedChanged += new System.EventHandler(this.umnojenie_CheckedChanged);
            // 
            // delenie
            // 
            this.delenie.AutoSize = true;
            this.delenie.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delenie.Location = new System.Drawing.Point(80, 186);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(93, 27);
            this.delenie.TabIndex = 3;
            this.delenie.TabStop = true;
            this.delenie.Text = "Деление";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.CheckedChanged += new System.EventHandler(this.delenie_CheckedChanged);
            // 
            // ostatuk
            // 
            this.ostatuk.AutoSize = true;
            this.ostatuk.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ostatuk.Location = new System.Drawing.Point(80, 216);
            this.ostatuk.Name = "ostatuk";
            this.ostatuk.Size = new System.Drawing.Size(175, 27);
            this.ostatuk.TabIndex = 4;
            this.ostatuk.TabStop = true;
            this.ostatuk.Text = "Остатък от деление";
            this.ostatuk.UseVisualStyleBackColor = true;
            this.ostatuk.CheckedChanged += new System.EventHandler(this.ostatuk_CheckedChanged);
            // 
            // presmetni
            // 
            this.presmetni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.presmetni.Location = new System.Drawing.Point(414, 94);
            this.presmetni.Name = "presmetni";
            this.presmetni.Size = new System.Drawing.Size(168, 49);
            this.presmetni.TabIndex = 5;
            this.presmetni.Text = "Пресметни";
            this.presmetni.UseVisualStyleBackColor = true;
            this.presmetni.Click += new System.EventHandler(this.presmetni_Click);
            // 
            // Izchisti
            // 
            this.Izchisti.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Izchisti.Location = new System.Drawing.Point(414, 149);
            this.Izchisti.Name = "Izchisti";
            this.Izchisti.Size = new System.Drawing.Size(168, 46);
            this.Izchisti.TabIndex = 6;
            this.Izchisti.Text = "Изчисти";
            this.Izchisti.UseVisualStyleBackColor = true;
            this.Izchisti.Click += new System.EventHandler(this.Izchisti_Click);
            // 
            // Izhod
            // 
            this.Izhod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Izhod.Location = new System.Drawing.Point(414, 202);
            this.Izhod.Name = "Izhod";
            this.Izhod.Size = new System.Drawing.Size(168, 50);
            this.Izhod.TabIndex = 7;
            this.Izhod.Text = "Изход";
            this.Izhod.UseVisualStyleBackColor = true;
            this.Izhod.Click += new System.EventHandler(this.Izhod_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(226, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 27);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(120, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(226, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Избери операция:";
            // 
            // subirane
            // 
            this.subirane.AutoSize = true;
            this.subirane.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subirane.Location = new System.Drawing.Point(81, 106);
            this.subirane.Name = "subirane";
            this.subirane.Size = new System.Drawing.Size(103, 27);
            this.subirane.TabIndex = 12;
            this.subirane.TabStop = true;
            this.subirane.Text = "Събиране";
            this.subirane.UseVisualStyleBackColor = true;
            this.subirane.CheckedChanged += new System.EventHandler(this.subirane_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 305);
            this.Controls.Add(this.subirane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Izhod);
            this.Controls.Add(this.Izchisti);
            this.Controls.Add(this.presmetni);
            this.Controls.Add(this.ostatuk);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.umnojenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton umnojenie;
        private System.Windows.Forms.RadioButton delenie;
        private System.Windows.Forms.RadioButton ostatuk;
        private System.Windows.Forms.Button presmetni;
        private System.Windows.Forms.Button Izchisti;
        private System.Windows.Forms.Button Izhod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton subirane;
    }
}

