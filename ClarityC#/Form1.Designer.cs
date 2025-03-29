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
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(218, 143);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 5;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.HotTrack;
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.ForeColor = SystemColors.Menu;
            numericUpDown1.Location = new Point(218, 61);
            numericUpDown1.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Visible = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = SystemColors.HotTrack;
            numericUpDown2.ForeColor = SystemColors.Menu;
            numericUpDown2.Location = new Point(295, 61);
            numericUpDown2.Maximum = new decimal(new int[] { 55, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(53, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 8;
            textBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 561);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.GradientInactiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "Form1";
            Text = "Clarity";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ReceiptButn;
        private Button SettingButn;
        private Button MusikButn;
        private Button ClockButn;
        private GroupBox groupBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
    }
}
