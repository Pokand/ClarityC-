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
            retText5 = new TaimerUI.RetText();
            retText4 = new TaimerUI.RetText();
            retText3 = new TaimerUI.RetText();
            retText2 = new TaimerUI.RetText();
            retText1 = new TaimerUI.RetText();
            buttonRet1 = new TaimerUI.ButtonRet();
            buttonRet2 = new TaimerUI.ButtonRet();
            buttonRet3 = new TaimerUI.ButtonRet();
            buttonReverse1 = new TaimerUI.ButtonReverse();
            buttonReverse2 = new TaimerUI.ButtonReverse();
            buttonReverse3 = new TaimerUI.ButtonReverse();
            classButton1 = new ClassButton();
            SuspendLayout();
            // 
            // retText5
            // 
            retText5.Font = new Font("Gadugi", 20.25F, FontStyle.Bold);
            retText5.Location = new Point(350, 96);
            retText5.Name = "retText5";
            retText5.Size = new Size(10, 81);
            retText5.TabIndex = 14;
            retText5.Text = ":";
            // 
            // retText4
            // 
            retText4.Font = new Font("Gadugi", 20.25F, FontStyle.Bold);
            retText4.Location = new Point(250, 96);
            retText4.Name = "retText4";
            retText4.Size = new Size(10, 81);
            retText4.TabIndex = 13;
            retText4.Text = ":";
            // 
            // retText3
            // 
            retText3.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retText3.Location = new Point(331, 96);
            retText3.Name = "retText3";
            retText3.Size = new Size(144, 81);
            retText3.TabIndex = 12;
            retText3.Text = "00";
            // 
            // retText2
            // 
            retText2.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retText2.Location = new Point(234, 96);
            retText2.Name = "retText2";
            retText2.Size = new Size(158, 81);
            retText2.TabIndex = 11;
            retText2.Text = "00";
            // 
            // retText1
            // 
            retText1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retText1.Location = new Point(144, 96);
            retText1.Name = "retText1";
            retText1.Size = new Size(150, 81);
            retText1.TabIndex = 10;
            retText1.Text = "00";
            // 
            // buttonRet1
            // 
            buttonRet1.Location = new Point(193, 64);
            buttonRet1.Name = "buttonRet1";
            buttonRet1.Size = new Size(51, 26);
            buttonRet1.TabIndex = 15;
            buttonRet1.Text = "buttonRet1";
            buttonRet1.MouseDown += buttonRet1_MouseDown;
            // 
            // buttonRet2
            // 
            buttonRet2.Location = new Point(287, 64);
            buttonRet2.Name = "buttonRet2";
            buttonRet2.Size = new Size(51, 26);
            buttonRet2.TabIndex = 16;
            buttonRet2.Text = "buttonRet2";
            buttonRet2.MouseDown += buttonRet2_MouseDown;
            // 
            // buttonRet3
            // 
            buttonRet3.BackColor = SystemColors.ActiveCaption;
            buttonRet3.Location = new Point(375, 64);
            buttonRet3.Name = "buttonRet3";
            buttonRet3.Size = new Size(51, 26);
            buttonRet3.TabIndex = 17;
            buttonRet3.Text = "buttonRet3";
            buttonRet3.MouseDown += buttonRet3_MouseDown;
            // 
            // buttonReverse1
            // 
            buttonReverse1.Location = new Point(193, 183);
            buttonReverse1.Name = "buttonReverse1";
            buttonReverse1.Size = new Size(51, 26);
            buttonReverse1.TabIndex = 18;
            buttonReverse1.Text = "buttonReverse1";
            buttonReverse1.MouseDown += buttonReverse1_MouseDown;
            // 
            // buttonReverse2
            // 
            buttonReverse2.Location = new Point(287, 183);
            buttonReverse2.Name = "buttonReverse2";
            buttonReverse2.Size = new Size(51, 26);
            buttonReverse2.TabIndex = 19;
            buttonReverse2.Text = "buttonReverse2";
            buttonReverse2.MouseDown += buttonReverse2_MouseDown;
            // 
            // buttonReverse3
            // 
            buttonReverse3.ForeColor = SystemColors.ControlText;
            buttonReverse3.Location = new Point(375, 183);
            buttonReverse3.Name = "buttonReverse3";
            buttonReverse3.Size = new Size(51, 26);
            buttonReverse3.TabIndex = 20;
            buttonReverse3.Text = "buttonReverse3";
            buttonReverse3.MouseDown += buttonReverse3_MouseDown;
            // 
            // classButton1
            // 
            classButton1.BackColor = Color.IndianRed;
            classButton1.Location = new Point(234, 253);
            classButton1.Name = "classButton1";
            classButton1.Size = new Size(160, 75);
            classButton1.TabIndex = 21;
            classButton1.Text = "Сохранить";
            classButton1.MouseDown += classButton1_MouseDown;
            // 
            // ClockBClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(classButton1);
            Controls.Add(buttonReverse3);
            Controls.Add(buttonReverse2);
            Controls.Add(buttonReverse1);
            Controls.Add(buttonRet3);
            Controls.Add(buttonRet2);
            Controls.Add(buttonRet1);
            Controls.Add(retText5);
            Controls.Add(retText4);
            Controls.Add(retText3);
            Controls.Add(retText2);
            Controls.Add(retText1);
            Name = "ClockBClass";
            Size = new Size(625, 563);
            ResumeLayout(false);
        }

        #endregion

        private TaimerUI.RetText retText5;
        private TaimerUI.RetText retText4;
        private TaimerUI.RetText retText3;
        private TaimerUI.RetText retText2;
        private TaimerUI.RetText retText1;
        private TaimerUI.ButtonRet buttonRet1;
        private TaimerUI.ButtonRet buttonRet2;
        private TaimerUI.ButtonRet buttonRet3;
        private TaimerUI.ButtonReverse buttonReverse1;
        private TaimerUI.ButtonReverse buttonReverse2;
        private TaimerUI.ButtonReverse buttonReverse3;
        private ClassButton classButton1;
    }
}
