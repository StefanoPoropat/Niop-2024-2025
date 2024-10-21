namespace radSaViseFormi
{
    partial class addNewStudent
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtdateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtDirection = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.studyType = new System.Windows.Forms.GroupBox();
            this.btnIregularStudent = new System.Windows.Forms.RadioButton();
            this.btnRegularStudent = new System.Windows.Forms.RadioButton();
            this.studyType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(46, 66);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(27, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Ime:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(46, 172);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(47, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Prezime:";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(46, 271);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(36, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Smjer:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(447, 66);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(68, 13);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "Broj indeksa:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(447, 172);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(80, 13);
            this.lb5.TabIndex = 4;
            this.lb5.Text = "Datum rođenja:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(49, 188);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(450, 82);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(156, 20);
            this.txtIndex.TabIndex = 7;
            // 
            // txtdateOfBirth
            // 
            this.txtdateOfBirth.Location = new System.Drawing.Point(450, 188);
            this.txtdateOfBirth.Name = "txtdateOfBirth";
            this.txtdateOfBirth.Size = new System.Drawing.Size(141, 20);
            this.txtdateOfBirth.TabIndex = 8;
            // 
            // txtDirection
            // 
            this.txtDirection.FormattingEnabled = true;
            this.txtDirection.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.txtDirection.Location = new System.Drawing.Point(49, 287);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(155, 21);
            this.txtDirection.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Snimi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(436, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // studyType
            // 
            this.studyType.Controls.Add(this.btnIregularStudent);
            this.studyType.Controls.Add(this.btnRegularStudent);
            this.studyType.Location = new System.Drawing.Point(450, 228);
            this.studyType.Name = "studyType";
            this.studyType.Size = new System.Drawing.Size(140, 113);
            this.studyType.TabIndex = 12;
            this.studyType.TabStop = false;
            this.studyType.Text = "Vrsta studija:";
            // 
            // btnIregularStudent
            // 
            this.btnIregularStudent.AutoSize = true;
            this.btnIregularStudent.Location = new System.Drawing.Point(25, 43);
            this.btnIregularStudent.Name = "btnIregularStudent";
            this.btnIregularStudent.Size = new System.Drawing.Size(74, 17);
            this.btnIregularStudent.TabIndex = 1;
            this.btnIregularStudent.TabStop = true;
            this.btnIregularStudent.Text = "Izvanredni";
            this.btnIregularStudent.UseVisualStyleBackColor = true;
            // 
            // btnRegularStudent
            // 
            this.btnRegularStudent.AutoSize = true;
            this.btnRegularStudent.Checked = true;
            this.btnRegularStudent.Location = new System.Drawing.Point(25, 19);
            this.btnRegularStudent.Name = "btnRegularStudent";
            this.btnRegularStudent.Size = new System.Drawing.Size(65, 17);
            this.btnRegularStudent.TabIndex = 0;
            this.btnRegularStudent.TabStop = true;
            this.btnRegularStudent.Text = "Redovni";
            this.btnRegularStudent.UseVisualStyleBackColor = true;
            // 
            // addNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studyType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.txtdateOfBirth);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "addNewStudent";
            this.Text = "Unos novog studenta";
            this.studyType.ResumeLayout(false);
            this.studyType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.DateTimePicker txtdateOfBirth;
        private System.Windows.Forms.ComboBox txtDirection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox studyType;
        private System.Windows.Forms.RadioButton btnIregularStudent;
        private System.Windows.Forms.RadioButton btnRegularStudent;
    }
}