
namespace VehicleLicenseTax
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
            this.cbxSelect_Usage = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labelUsage = new System.Windows.Forms.Label();
            this.labelMotor = new System.Windows.Forms.Label();
            this.buttonComfirm = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.cbxSelect_Motor = new System.Windows.Forms.ComboBox();
            this.radio_Allyear = new System.Windows.Forms.RadioButton();
            this.radioPeriod = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.gbDuration = new System.Windows.Forms.GroupBox();
            this.gbUsageCC = new System.Windows.Forms.GroupBox();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.gbDuration.SuspendLayout();
            this.gbUsageCC.SuspendLayout();
            this.gpbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelect_Usage
            // 
            this.cbxSelect_Usage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelect_Usage.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxSelect_Usage.FormattingEnabled = true;
            this.cbxSelect_Usage.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxSelect_Usage.Location = new System.Drawing.Point(348, 35);
            this.cbxSelect_Usage.Name = "cbxSelect_Usage";
            this.cbxSelect_Usage.Size = new System.Drawing.Size(598, 41);
            this.cbxSelect_Usage.TabIndex = 0;
            this.cbxSelect_Usage.SelectedIndexChanged += new System.EventHandler(this.cbxSelect_Usage_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(19, 43);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAmount.Size = new System.Drawing.Size(936, 244);
            this.txtAmount.TabIndex = 2;
            // 
            // labelUsage
            // 
            this.labelUsage.AutoSize = true;
            this.labelUsage.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelUsage.Location = new System.Drawing.Point(239, 38);
            this.labelUsage.Name = "labelUsage";
            this.labelUsage.Size = new System.Drawing.Size(81, 33);
            this.labelUsage.TabIndex = 4;
            this.labelUsage.Text = "用途";
            this.labelUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMotor
            // 
            this.labelMotor.AutoSize = true;
            this.labelMotor.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMotor.Location = new System.Drawing.Point(23, 121);
            this.labelMotor.Name = "labelMotor";
            this.labelMotor.Size = new System.Drawing.Size(297, 33);
            this.labelMotor.TabIndex = 5;
            this.labelMotor.Text = "汽缸CC數/馬達馬力";
            this.labelMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonComfirm
            // 
            this.buttonComfirm.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonComfirm.Location = new System.Drawing.Point(974, 88);
            this.buttonComfirm.Name = "buttonComfirm";
            this.buttonComfirm.Size = new System.Drawing.Size(140, 49);
            this.buttonComfirm.TabIndex = 6;
            this.buttonComfirm.Text = "確認";
            this.buttonComfirm.UseVisualStyleBackColor = true;
            this.buttonComfirm.Click += new System.EventHandler(this.buttonComfirm_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.Location = new System.Drawing.Point(974, 184);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(140, 49);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // cbxSelect_Motor
            // 
            this.cbxSelect_Motor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelect_Motor.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxSelect_Motor.FormattingEnabled = true;
            this.cbxSelect_Motor.Items.AddRange(new object[] {
            ""});
            this.cbxSelect_Motor.Location = new System.Drawing.Point(348, 121);
            this.cbxSelect_Motor.Name = "cbxSelect_Motor";
            this.cbxSelect_Motor.Size = new System.Drawing.Size(598, 41);
            this.cbxSelect_Motor.TabIndex = 9;
            // 
            // radio_Allyear
            // 
            this.radio_Allyear.AutoSize = true;
            this.radio_Allyear.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio_Allyear.Location = new System.Drawing.Point(3, 29);
            this.radio_Allyear.Name = "radio_Allyear";
            this.radio_Allyear.Size = new System.Drawing.Size(135, 37);
            this.radio_Allyear.TabIndex = 11;
            this.radio_Allyear.TabStop = true;
            this.radio_Allyear.Text = "全年度";
            this.radio_Allyear.UseVisualStyleBackColor = true;
            // 
            // radioPeriod
            // 
            this.radioPeriod.AutoSize = true;
            this.radioPeriod.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioPeriod.Location = new System.Drawing.Point(3, 99);
            this.radioPeriod.Name = "radioPeriod";
            this.radioPeriod.Size = new System.Drawing.Size(135, 37);
            this.radioPeriod.TabIndex = 12;
            this.radioPeriod.TabStop = true;
            this.radioPeriod.Text = "依期間";
            this.radioPeriod.UseVisualStyleBackColor = true;
            this.radioPeriod.CheckedChanged += new System.EventHandler(this.radioPeriod_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEnd);
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.radioPeriod);
            this.panel1.Controls.Add(this.radio_Allyear);
            this.panel1.Location = new System.Drawing.Point(182, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 177);
            this.panel1.TabIndex = 13;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEnd.Location = new System.Drawing.Point(286, 125);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(48, 33);
            this.labelEnd.TabIndex = 18;
            this.labelEnd.Text = "訖";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStart.Location = new System.Drawing.Point(286, 72);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(48, 33);
            this.labelStart.TabIndex = 17;
            this.labelStart.Text = "起";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Location = new System.Drawing.Point(366, 116);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(278, 47);
            this.dtpEnd.TabIndex = 16;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("PMingLiU", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Location = new System.Drawing.Point(366, 63);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(278, 47);
            this.dtpStart.TabIndex = 15;
            // 
            // gbDuration
            // 
            this.gbDuration.Controls.Add(this.panel1);
            this.gbDuration.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbDuration.Location = new System.Drawing.Point(98, 29);
            this.gbDuration.Name = "gbDuration";
            this.gbDuration.Size = new System.Drawing.Size(1009, 212);
            this.gbDuration.TabIndex = 14;
            this.gbDuration.TabStop = false;
            this.gbDuration.Text = "使用期限";
            // 
            // gbUsageCC
            // 
            this.gbUsageCC.Controls.Add(this.cbxSelect_Motor);
            this.gbUsageCC.Controls.Add(this.labelMotor);
            this.gbUsageCC.Controls.Add(this.labelUsage);
            this.gbUsageCC.Controls.Add(this.cbxSelect_Usage);
            this.gbUsageCC.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbUsageCC.Location = new System.Drawing.Point(98, 259);
            this.gbUsageCC.Name = "gbUsageCC";
            this.gbUsageCC.Size = new System.Drawing.Size(1009, 174);
            this.gbUsageCC.TabIndex = 15;
            this.gbUsageCC.TabStop = false;
            this.gbUsageCC.Text = "用途及排氣量";
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.txtAmount);
            this.gpbResult.Controls.Add(this.buttonClear);
            this.gpbResult.Controls.Add(this.buttonComfirm);
            this.gpbResult.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbResult.Location = new System.Drawing.Point(98, 456);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Size = new System.Drawing.Size(1142, 293);
            this.gpbResult.TabIndex = 16;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "試算結果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 761);
            this.Controls.Add(this.gpbResult);
            this.Controls.Add(this.gbUsageCC);
            this.Controls.Add(this.gbDuration);
            this.Name = "Form1";
            this.Text = "VehicleLicenseTax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDuration.ResumeLayout(false);
            this.gbUsageCC.ResumeLayout(false);
            this.gbUsageCC.PerformLayout();
            this.gpbResult.ResumeLayout(false);
            this.gpbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelect_Usage;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labelUsage;
        private System.Windows.Forms.Label labelMotor;
        private System.Windows.Forms.Button buttonComfirm;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox cbxSelect_Motor;
        private System.Windows.Forms.RadioButton radio_Allyear;
        private System.Windows.Forms.RadioButton radioPeriod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.GroupBox gbDuration;
        private System.Windows.Forms.GroupBox gbUsageCC;
        private System.Windows.Forms.GroupBox gpbResult;
    }
}

