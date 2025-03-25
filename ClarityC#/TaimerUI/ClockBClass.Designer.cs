namespace ClarityC_
{
    partial class ClockBClass
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            taimerui1 = new TaimerUI.TaimerUI();
            taimerui2 = new TaimerUI.TaimerUI();
            taimerui3 = new TaimerUI.TaimerUI();
            taimerui4 = new TaimerUI.TaimerUI();
            newTaimer1 = new TaimerUI.NewTaimer();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(taimerui1);
            flowLayoutPanel1.Controls.Add(taimerui2);
            flowLayoutPanel1.Controls.Add(taimerui3);
            flowLayoutPanel1.Controls.Add(taimerui4);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(535, 557);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // taimerui1
            // 
            taimerui1.Location = new Point(3, 3);
            taimerui1.Name = "taimerui1";
            taimerui1.Size = new Size(170, 177);
            taimerui1.TabIndex = 0;
            // 
            // taimerui2
            // 
            taimerui2.Location = new Point(179, 3);
            taimerui2.Name = "taimerui2";
            taimerui2.Size = new Size(170, 177);
            taimerui2.TabIndex = 1;
            taimerui2.Load += taimerui2_Load;
            // 
            // taimerui3
            // 
            taimerui3.Location = new Point(355, 3);
            taimerui3.Name = "taimerui3";
            taimerui3.Size = new Size(170, 177);
            taimerui3.TabIndex = 2;
            // 
            // taimerui4
            // 
            taimerui4.Location = new Point(3, 186);
            taimerui4.Name = "taimerui4";
            taimerui4.Size = new Size(170, 177);
            taimerui4.TabIndex = 3;
            // 
            // newTaimer1
            // 
            newTaimer1.Location = new Point(588, 527);
            newTaimer1.Name = "newTaimer1";
            newTaimer1.Size = new Size(30, 30);
            newTaimer1.TabIndex = 1;
            newTaimer1.TabStop = false;
            newTaimer1.Text = "newTaimer1";
            newTaimer1.Click += newTaimer1_Click;
            // 
            // ClockBClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(newTaimer1);
            Controls.Add(flowLayoutPanel1);
            Name = "ClockBClass";
            Size = new Size(625, 563);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TaimerUI.TaimerUI taimerui1;
        private TaimerUI.TaimerUI taimerui2;
        private TaimerUI.TaimerUI taimerui3;
        private TaimerUI.TaimerUI taimerui4;
        private TaimerUI.NewTaimer newTaimer1;
    }
}
