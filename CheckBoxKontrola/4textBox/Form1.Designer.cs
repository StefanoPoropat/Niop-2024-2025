namespace _4textBox
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
            this.dorucak = new System.Windows.Forms.CheckBox();
            this.rucak = new System.Windows.Forms.CheckBox();
            this.vecera = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 153);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Odabrali ste:";
            // 
            // dorucak
            // 
            this.dorucak.AutoSize = true;
            this.dorucak.Location = new System.Drawing.Point(64, 100);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(67, 17);
            this.dorucak.TabIndex = 1;
            this.dorucak.Text = "Doručak";
            this.dorucak.UseVisualStyleBackColor = true;
            this.dorucak.CheckedChanged += new System.EventHandler(this.dorucak_CheckedChanged);
            // 
            // rucak
            // 
            this.rucak.AutoSize = true;
            this.rucak.Location = new System.Drawing.Point(64, 134);
            this.rucak.Name = "rucak";
            this.rucak.Size = new System.Drawing.Size(58, 17);
            this.rucak.TabIndex = 2;
            this.rucak.Text = "Ručak";
            this.rucak.UseVisualStyleBackColor = true;
            this.rucak.CheckedChanged += new System.EventHandler(this.rucak_CheckedChanged);
            // 
            // vecera
            // 
            this.vecera.AutoSize = true;
            this.vecera.Location = new System.Drawing.Point(64, 170);
            this.vecera.Name = "vecera";
            this.vecera.Size = new System.Drawing.Size(60, 17);
            this.vecera.TabIndex = 4;
            this.vecera.Text = "Večera";
            this.vecera.UseVisualStyleBackColor = true;
            this.vecera.CheckedChanged += new System.EventHandler(this.vecera_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(451, 323);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(99, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Sakrij narudžba";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pošalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vecera);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.rucak);
            this.Controls.Add(this.dorucak);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox dorucak;
        private System.Windows.Forms.CheckBox rucak;
        private System.Windows.Forms.CheckBox vecera;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
    }
}

