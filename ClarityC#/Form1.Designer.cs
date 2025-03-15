namespace ClarityC_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ReceiptButn = new Button();
            SettingButn = new Button();
            MusikButn = new Button();
            ClockButn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ReceiptButn
            // 
            ReceiptButn.BackColor = Color.CornflowerBlue;
            ReceiptButn.Font = new Font("Segoe UI", 13F);
            ReceiptButn.Location = new Point(6, 199);
            ReceiptButn.Name = "ReceiptButn";
            ReceiptButn.Size = new Size(148, 86);
            ReceiptButn.TabIndex = 0;
            ReceiptButn.TabStop = false;
            ReceiptButn.Text = "Расписание";
            ReceiptButn.UseVisualStyleBackColor = false;
            ReceiptButn.Click += button1_Click;
            // 
            // SettingButn
            // 
            SettingButn.BackColor = Color.CornflowerBlue;
            SettingButn.Font = new Font("Segoe UI", 13F);
            SettingButn.Location = new Point(5, 380);
            SettingButn.Name = "SettingButn";
            SettingButn.Size = new Size(148, 86);
            SettingButn.TabIndex = 0;
            SettingButn.TabStop = false;
            SettingButn.Text = "Настройки";
            SettingButn.UseVisualStyleBackColor = false;
            // 
            // MusikButn
            // 
            MusikButn.BackColor = Color.CornflowerBlue;
            MusikButn.Font = new Font("Segoe UI", 13F);
            MusikButn.Location = new Point(6, 288);
            MusikButn.Name = "MusikButn";
            MusikButn.Size = new Size(148, 86);
            MusikButn.TabIndex = 0;
            MusikButn.TabStop = false;
            MusikButn.Text = "Музыка";
            MusikButn.UseVisualStyleBackColor = false;
            // 
            // ClockButn
            // 
            ClockButn.BackColor = Color.CornflowerBlue;
            ClockButn.Font = new Font("Segoe UI", 13F);
            ClockButn.Location = new Point(6, 107);
            ClockButn.Name = "ClockButn";
            ClockButn.Size = new Size(148, 86);
            ClockButn.TabIndex = 1;
            ClockButn.TabStop = false;
            ClockButn.Text = "Будильник";
            ClockButn.TextImageRelation = TextImageRelation.TextAboveImage;
            ClockButn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(ClockButn);
            groupBox1.Controls.Add(ReceiptButn);
            groupBox1.Controls.Add(SettingButn);
            groupBox1.Controls.Add(MusikButn);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(-1, -46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 637);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 553);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.GradientInactiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "Form1";
            Text = "Clarity";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ReceiptButn;
        private Button SettingButn;
        private Button MusikButn;
        private Button ClockButn;
        private GroupBox groupBox1;
    }
}
