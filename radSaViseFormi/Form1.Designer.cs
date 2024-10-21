namespace radSaViseFormi
{
    partial class studentDisplayScreen
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
            this.addNewStudent = new System.Windows.Forms.Button();
            this.deleteAllStudents = new System.Windows.Forms.Button();
            this.deleteOneStudent = new System.Windows.Forms.Button();
            this.studentDisplay = new System.Windows.Forms.ListBox();
            this.saveToTxt = new System.Windows.Forms.Button();
            this.loadFromTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewStudent
            // 
            this.addNewStudent.Location = new System.Drawing.Point(71, 70);
            this.addNewStudent.Name = "addNewStudent";
            this.addNewStudent.Size = new System.Drawing.Size(166, 23);
            this.addNewStudent.TabIndex = 1;
            this.addNewStudent.Text = "Dodaj novog studenta";
            this.addNewStudent.UseVisualStyleBackColor = true;
            this.addNewStudent.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // deleteAllStudents
            // 
            this.deleteAllStudents.Location = new System.Drawing.Point(71, 302);
            this.deleteAllStudents.Name = "deleteAllStudents";
            this.deleteAllStudents.Size = new System.Drawing.Size(166, 23);
            this.deleteAllStudents.TabIndex = 2;
            this.deleteAllStudents.Text = "Obriši sve studente";
            this.deleteAllStudents.UseVisualStyleBackColor = true;
            this.deleteAllStudents.Click += new System.EventHandler(this.deleteAllStudents_Click);
            // 
            // deleteOneStudent
            // 
            this.deleteOneStudent.Location = new System.Drawing.Point(388, 185);
            this.deleteOneStudent.Name = "deleteOneStudent";
            this.deleteOneStudent.Size = new System.Drawing.Size(166, 23);
            this.deleteOneStudent.TabIndex = 3;
            this.deleteOneStudent.Text = "Obriši studenta";
            this.deleteOneStudent.UseVisualStyleBackColor = true;
            this.deleteOneStudent.Click += new System.EventHandler(this.deleteOneStudent_Click);
            // 
            // studentDisplay
            // 
            this.studentDisplay.FormattingEnabled = true;
            this.studentDisplay.Location = new System.Drawing.Point(71, 99);
            this.studentDisplay.Name = "studentDisplay";
            this.studentDisplay.Size = new System.Drawing.Size(311, 199);
            this.studentDisplay.TabIndex = 4;
            // 
            // saveToTxt
            // 
            this.saveToTxt.Location = new System.Drawing.Point(388, 156);
            this.saveToTxt.Name = "saveToTxt";
            this.saveToTxt.Size = new System.Drawing.Size(166, 23);
            this.saveToTxt.TabIndex = 5;
            this.saveToTxt.Text = "Spremi";
            this.saveToTxt.UseVisualStyleBackColor = true;
            this.saveToTxt.Click += new System.EventHandler(this.saveToTxt_Click);
            // 
            // loadFromTxt
            // 
            this.loadFromTxt.Location = new System.Drawing.Point(388, 214);
            this.loadFromTxt.Name = "loadFromTxt";
            this.loadFromTxt.Size = new System.Drawing.Size(166, 23);
            this.loadFromTxt.TabIndex = 6;
            this.loadFromTxt.Text = "Učitaj";
            this.loadFromTxt.UseVisualStyleBackColor = true;
            this.loadFromTxt.Click += new System.EventHandler(this.loadFromTxt_Click);
            // 
            // studentDisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadFromTxt);
            this.Controls.Add(this.saveToTxt);
            this.Controls.Add(this.studentDisplay);
            this.Controls.Add(this.deleteOneStudent);
            this.Controls.Add(this.deleteAllStudents);
            this.Controls.Add(this.addNewStudent);
            this.Name = "studentDisplayScreen";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewStudent;
        private System.Windows.Forms.Button deleteAllStudents;
        private System.Windows.Forms.Button deleteOneStudent;
        private System.Windows.Forms.ListBox studentDisplay;
        private System.Windows.Forms.Button saveToTxt;
        private System.Windows.Forms.Button loadFromTxt;
    }
}

