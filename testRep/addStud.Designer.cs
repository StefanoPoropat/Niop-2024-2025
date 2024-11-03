namespace testRep
{
    partial class addStud
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNoIndex = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbIndex = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnCloseWithOutSaving = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudyType = new System.Windows.Forms.Label();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbIregular = new System.Windows.Forms.RadioButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(36, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // lblNoIndex
            // 
            this.lblNoIndex.Location = new System.Drawing.Point(352, 55);
            this.lblNoIndex.Name = "lblNoIndex";
            this.lblNoIndex.Size = new System.Drawing.Size(108, 28);
            this.lblNoIndex.TabIndex = 1;
            this.lblNoIndex.Text = "Broj indexa:";
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(36, 155);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(108, 28);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Prezime:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(352, 155);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(108, 28);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Datum rođenja:";
            // 
            // lblDirection
            // 
            this.lblDirection.Location = new System.Drawing.Point(36, 246);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(108, 28);
            this.lblDirection.TabIndex = 4;
            this.lblDirection.Text = "Smjer:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(39, 86);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(157, 22);
            this.txbName.TabIndex = 5;
            // 
            // txbIndex
            // 
            this.txbIndex.Location = new System.Drawing.Point(355, 86);
            this.txbIndex.Name = "txbIndex";
            this.txbIndex.Size = new System.Drawing.Size(157, 22);
            this.txbIndex.TabIndex = 6;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(39, 186);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(157, 22);
            this.txbSurname.TabIndex = 7;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(355, 184);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.cbDirection.Location = new System.Drawing.Point(39, 277);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(159, 24);
            this.cbDirection.TabIndex = 9;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(48, 382);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(148, 44);
            this.btnSaveData.TabIndex = 10;
            this.btnSaveData.Text = "Snimi";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnCloseWithOutSaving
            // 
            this.btnCloseWithOutSaving.Location = new System.Drawing.Point(364, 382);
            this.btnCloseWithOutSaving.Name = "btnCloseWithOutSaving";
            this.btnCloseWithOutSaving.Size = new System.Drawing.Size(148, 44);
            this.btnCloseWithOutSaving.TabIndex = 11;
            this.btnCloseWithOutSaving.Text = "Otkaži";
            this.btnCloseWithOutSaving.UseVisualStyleBackColor = true;
            this.btnCloseWithOutSaving.Click += new System.EventHandler(this.btnCloseWithOutSaving_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIregular);
            this.groupBox1.Controls.Add(this.rbRegular);
            this.groupBox1.Location = new System.Drawing.Point(355, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblStudyType
            // 
            this.lblStudyType.Location = new System.Drawing.Point(352, 246);
            this.lblStudyType.Name = "lblStudyType";
            this.lblStudyType.Size = new System.Drawing.Size(108, 28);
            this.lblStudyType.TabIndex = 13;
            this.lblStudyType.Text = "Vrsta studija:";
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Checked = true;
            this.rbRegular.Location = new System.Drawing.Point(9, 22);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(79, 20);
            this.rbRegular.TabIndex = 0;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Redovni";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // rbIregular
            // 
            this.rbIregular.AutoSize = true;
            this.rbIregular.Location = new System.Drawing.Point(9, 48);
            this.rbIregular.Name = "rbIregular";
            this.rbIregular.Size = new System.Drawing.Size(89, 20);
            this.rbIregular.TabIndex = 1;
            this.rbIregular.Text = "Izvanredni";
            this.rbIregular.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 24);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 24);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 30);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblStudyType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseWithOutSaving);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.cbDirection);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbIndex);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblNoIndex);
            this.Controls.Add(this.lblName);
            this.Name = "addStud";
            this.Text = "addStud";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNoIndex;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbIndex;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnCloseWithOutSaving;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIregular;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.Label lblStudyType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
    }
}