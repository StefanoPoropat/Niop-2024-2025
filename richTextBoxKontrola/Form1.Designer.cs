namespace richTextBoxKontrola
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
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.read = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(195, 127);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(357, 190);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "";
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(195, 82);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(126, 27);
            this.read.TabIndex = 1;
            this.read.Text = "Čitaj";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(426, 82);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(126, 27);
            this.delete.TabIndex = 2;
            this.delete.Text = "Briši";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(195, 336);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(126, 27);
            this.save.TabIndex = 3;
            this.save.Text = "Snimi";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.read);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
    }
}

