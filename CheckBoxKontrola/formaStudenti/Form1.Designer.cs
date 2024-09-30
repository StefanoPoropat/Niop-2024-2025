namespace formaStudenti
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
            this.studentDisplay = new System.Windows.Forms.ListBox();
            this.newStudent = new System.Windows.Forms.Button();
            this.deleteOneStudnet = new System.Windows.Forms.Button();
            this.deleteAllStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentDisplay
            // 
            this.studentDisplay.FormattingEnabled = true;
            this.studentDisplay.Location = new System.Drawing.Point(92, 99);
            this.studentDisplay.Name = "studentDisplay";
            this.studentDisplay.Size = new System.Drawing.Size(260, 186);
            this.studentDisplay.TabIndex = 0;
            this.studentDisplay.SelectedIndexChanged += new System.EventHandler(this.studentDispaly_SelectedIndexChanged);
            // 
            // newStudent
            // 
            this.newStudent.Location = new System.Drawing.Point(92, 70);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(157, 23);
            this.newStudent.TabIndex = 1;
            this.newStudent.Text = "Dodaj novog studenta";
            this.newStudent.UseVisualStyleBackColor = true;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // deleteOneStudnet
            // 
            this.deleteOneStudnet.Location = new System.Drawing.Point(358, 188);
            this.deleteOneStudnet.Name = "deleteOneStudnet";
            this.deleteOneStudnet.Size = new System.Drawing.Size(96, 23);
            this.deleteOneStudnet.TabIndex = 2;
            this.deleteOneStudnet.Text = "Obriši studneta";
            this.deleteOneStudnet.UseVisualStyleBackColor = true;
            this.deleteOneStudnet.Click += new System.EventHandler(this.deleteOneStudnet_Click);
            // 
            // deleteAllStudents
            // 
            this.deleteAllStudents.Location = new System.Drawing.Point(92, 291);
            this.deleteAllStudents.Name = "deleteAllStudents";
            this.deleteAllStudents.Size = new System.Drawing.Size(157, 23);
            this.deleteAllStudents.TabIndex = 3;
            this.deleteAllStudents.Text = "Obriši sve studente";
            this.deleteAllStudents.UseVisualStyleBackColor = true;
            this.deleteAllStudents.Click += new System.EventHandler(this.deleteAllStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteAllStudents);
            this.Controls.Add(this.deleteOneStudnet);
            this.Controls.Add(this.newStudent);
            this.Controls.Add(this.studentDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentDisplay;
        private System.Windows.Forms.Button newStudent;
        private System.Windows.Forms.Button deleteOneStudnet;
        private System.Windows.Forms.Button deleteAllStudents;
    }
}

