namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbMonthly = new System.Windows.Forms.Label();
            this.lbBonus = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.gbLang = new System.Windows.Forms.GroupBox();
            this.radioFrench = new System.Windows.Forms.RadioButton();
            this.radioEnglish = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbLang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(12, 111);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 2;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            this.txtHours.Leave += new System.EventHandler(this.txtHours_Leave);
            // 
            // txtMonthly
            // 
            this.txtMonthly.Location = new System.Drawing.Point(12, 154);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.Size = new System.Drawing.Size(100, 20);
            this.txtMonthly.TabIndex = 3;
            this.txtMonthly.Enter += new System.EventHandler(this.txtMonthly_Enter);
            this.txtMonthly.Leave += new System.EventHandler(this.txtMonthly_Leave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Employee Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 52);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(67, 13);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "Employee ID";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(12, 95);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(103, 13);
            this.lbHours.TabIndex = 6;
            this.lbHours.Text = "Total Hours Worked";
            // 
            // lbMonthly
            // 
            this.lbMonthly.AutoSize = true;
            this.lbMonthly.Location = new System.Drawing.Point(12, 138);
            this.lbMonthly.Name = "lbMonthly";
            this.lbMonthly.Size = new System.Drawing.Size(100, 13);
            this.lbMonthly.TabIndex = 7;
            this.lbMonthly.Text = "Total Monthly Sales";
            // 
            // lbBonus
            // 
            this.lbBonus.AutoSize = true;
            this.lbBonus.Location = new System.Drawing.Point(164, 9);
            this.lbBonus.Name = "lbBonus";
            this.lbBonus.Size = new System.Drawing.Size(66, 13);
            this.lbBonus.TabIndex = 8;
            this.lbBonus.Text = "Sales Bonus";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(167, 25);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.ReadOnly = true;
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 9;
            this.txtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbLang
            // 
            this.gbLang.Controls.Add(this.radioFrench);
            this.gbLang.Controls.Add(this.radioEnglish);
            this.gbLang.Location = new System.Drawing.Point(12, 187);
            this.gbLang.Name = "gbLang";
            this.gbLang.Size = new System.Drawing.Size(99, 63);
            this.gbLang.TabIndex = 10;
            this.gbLang.TabStop = false;
            this.gbLang.Text = "Language";
            // 
            // radioFrench
            // 
            this.radioFrench.AutoSize = true;
            this.radioFrench.Location = new System.Drawing.Point(8, 40);
            this.radioFrench.Name = "radioFrench";
            this.radioFrench.Size = new System.Drawing.Size(65, 17);
            this.radioFrench.TabIndex = 1;
            this.radioFrench.TabStop = true;
            this.radioFrench.Text = "Français";
            this.radioFrench.UseVisualStyleBackColor = true;
            // 
            // radioEnglish
            // 
            this.radioEnglish.AutoSize = true;
            this.radioEnglish.Location = new System.Drawing.Point(8, 19);
            this.radioEnglish.Name = "radioEnglish";
            this.radioEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioEnglish.TabIndex = 0;
            this.radioEnglish.TabStop = true;
            this.radioEnglish.Text = "English";
            this.radioEnglish.UseVisualStyleBackColor = true;
            this.radioEnglish.CheckedChanged += new System.EventHandler(this.radioEnglish_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(191, 52);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(190, 82);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.Confound;
            this.pictureBox1.Location = new System.Drawing.Point(136, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gbLang);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.lbBonus);
            this.Controls.Add(this.lbMonthly);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtMonthly);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLang.ResumeLayout(false);
            this.gbLang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbMonthly;
        private System.Windows.Forms.Label lbBonus;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.GroupBox gbLang;
        private System.Windows.Forms.RadioButton radioFrench;
        private System.Windows.Forms.RadioButton radioEnglish;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

