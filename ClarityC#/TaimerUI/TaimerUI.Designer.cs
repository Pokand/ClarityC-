namespace ClarityC_.TaimerUI
{
    partial class TaimerUI
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            textTaimer1 = new TextTaimer();
            taimerStartBtn1 = new TaimerStartBtn();
            SuspendLayout();
            // 
            // textTaimer1
            // 
            textTaimer1.BackColor = SystemColors.ActiveCaption;
            textTaimer1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTaimer1.Location = new Point(12, 19);
            textTaimer1.Name = "textTaimer1";
            textTaimer1.Size = new Size(141, 46);
            textTaimer1.TabIndex = 0;
            textTaimer1.TabStop = false;
            textTaimer1.Text = "00:01:00";
            // 
            // taimerStartBtn1
            // 
            taimerStartBtn1.BackColor = SystemColors.ActiveCaption;
            taimerStartBtn1.ForeColor = SystemColors.Control;
            taimerStartBtn1.Location = new Point(49, 95);
            taimerStartBtn1.Name = "taimerStartBtn1";
            taimerStartBtn1.Size = new Size(48, 48);
            taimerStartBtn1.TabIndex = 1;
            taimerStartBtn1.TabStop = false;
            taimerStartBtn1.Text = "taimerStartBtn1";
            taimerStartBtn1.Click += taimerStartBtn1_Click;
            // 
            // TaimerUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taimerStartBtn1);
            Controls.Add(textTaimer1);
            Name = "TaimerUI";
            Size = new Size(180, 177);
            Load += TaimerUI_Load;
            ResumeLayout(false);
        }

        #endregion
        private TaimerStartBtn taimerStartBtn1;
        public TextTaimer textTaimer1;
    }
}
