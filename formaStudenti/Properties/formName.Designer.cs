namespace formaStudenti.Properties
{
    partial class formName
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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.nuIndex = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.Label();
            this.classes = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNuId = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(30, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(24, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Ime";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(305, 29);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(44, 13);
            this.surname.TabIndex = 1;
            this.surname.Text = "Prezime";
            // 
            // nuIndex
            // 
            this.nuIndex.AutoSize = true;
            this.nuIndex.Location = new System.Drawing.Point(30, 158);
            this.nuIndex.Name = "nuIndex";
            this.nuIndex.Size = new System.Drawing.Size(65, 13);
            this.nuIndex.TabIndex = 2;
            this.nuIndex.Text = "Broj indeksa";
            // 
            // bday
            // 
            this.bday.AutoSize = true;
            this.bday.Location = new System.Drawing.Point(305, 158);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(77, 13);
            this.bday.TabIndex = 3;
            this.bday.Text = "Datum rođenja";
            // 
            // classes
            // 
            this.classes.AutoSize = true;
            this.classes.Location = new System.Drawing.Point(30, 271);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(33, 13);
            this.classes.TabIndex = 4;
            this.classes.Text = "Smjer";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtNuId
            // 
            this.txtNuId.Location = new System.Drawing.Point(33, 174);
            this.txtNuId.Name = "txtNuId";
            this.txtNuId.Size = new System.Drawing.Size(100, 20);
            this.txtNuId.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(308, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "programer",
            "mrežni admin",
            "system admin"});
            this.comboBox1.Location = new System.Drawing.Point(33, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(60, 363);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Spremi";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(433, 363);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Otkaži";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // formName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtNuId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.nuIndex);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "formName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label nuIndex;
        private System.Windows.Forms.Label bday;
        private System.Windows.Forms.Label classes;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNuId;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}