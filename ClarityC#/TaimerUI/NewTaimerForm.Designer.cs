namespace ClarityC_.TaimerUI
{
    partial class NewTaimerForm
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
            classButton1 = new ClassButton();
            buttonRet1 = new ButtonRet();
            retText1 = new RetText();
            buttonRet2 = new ButtonRet();
            buttonRet3 = new ButtonRet();
            retText2 = new RetText();
            retText3 = new RetText();
            retText4 = new RetText();
            retText5 = new RetText();
            buttonReverse1 = new ButtonReverse();
            buttonReverse2 = new ButtonReverse();
            buttonReverse3 = new ButtonReverse();
            SuspendLayout();
            // 
            // classButton1
            // 
            classButton1.BackColor = Color.IndianRed;
            classButton1.Location = new Point(140, 168);
            classButton1.Name = "classButton1";
            classButton1.Size = new Size(130, 39);
            classButton1.TabIndex = 0;
            classButton1.Text = "Сохранить";
            classButton1.Click += classButton1_Click;
            // 
            // buttonRet1
            // 
            buttonRet1.Location = new Point(110, 30);
            buttonRet1.Name = "buttonRet1";
            buttonRet1.Size = new Size(51, 26);
            buttonRet1.TabIndex = 1;
            buttonRet1.Text = "buttonRet1";
            buttonRet1.Click += buttonRet1_Click;
            // 
            // retText1
            // 
            retText1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retText1.Location = new Point(110, 62);
            retText1.Name = "retText1";
            retText1.Size = new Size(51, 40);
            retText1.TabIndex = 2;
            retText1.Text = "00";
            // 
            // buttonRet2
            // 
            buttonRet2.Location = new Point(182, 30);
            buttonRet2.Name = "buttonRet2";
            buttonRet2.Size = new Size(51, 26);
            buttonRet2.TabIndex = 4;
            buttonRet2.Text = "buttonRet2";
            // 
            // buttonRet3
            // 
            buttonRet3.Location = new Point(254, 30);
            buttonRet3.Name = "buttonRet3";
            buttonRet3.Size = new Size(51, 26);
            buttonRet3.TabIndex = 5;
            buttonRet3.Text = "buttonRet3";
            // 
            // retText2
            // 
            retText2.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retText2.Location = new Point(182, 62);
            retText2.Name = "retText2";
            retText2.Size = new Size(51, 40);
            retText2.TabIndex = 6;
            retText2.Text = "00";
            // 
            // retText3
            // 
            retText3.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retText3.Location = new Point(254, 62);
            retText3.Name = "retText3";
            retText3.Size = new Size(51, 40);
            retText3.TabIndex = 7;
            retText3.Text = "00";
            // 
            // retText4
            // 
            retText4.Font = new Font("Gadugi", 20.25F, FontStyle.Bold);
            retText4.Location = new Point(162, 62);
            retText4.Name = "retText4";
            retText4.Size = new Size(14, 40);
            retText4.TabIndex = 8;
            retText4.Text = ":";
            // 
            // retText5
            // 
            retText5.Font = new Font("Gadugi", 20.25F, FontStyle.Bold);
            retText5.Location = new Point(234, 62);
            retText5.Name = "retText5";
            retText5.Size = new Size(14, 40);
            retText5.TabIndex = 9;
            retText5.Text = ":";
            // 
            // buttonReverse1
            // 
            buttonReverse1.Location = new Point(110, 108);
            buttonReverse1.Name = "buttonReverse1";
            buttonReverse1.Size = new Size(51, 26);
            buttonReverse1.TabIndex = 10;
            buttonReverse1.Text = "buttonReverse1";
            buttonReverse1.Click += buttonReverse1_Click;
            // 
            // buttonReverse2
            // 
            buttonReverse2.Location = new Point(182, 108);
            buttonReverse2.Name = "buttonReverse2";
            buttonReverse2.Size = new Size(51, 26);
            buttonReverse2.TabIndex = 11;
            buttonReverse2.Text = "buttonReverse2";
            // 
            // buttonReverse3
            // 
            buttonReverse3.Location = new Point(254, 108);
            buttonReverse3.Name = "buttonReverse3";
            buttonReverse3.Size = new Size(51, 26);
            buttonReverse3.TabIndex = 12;
            buttonReverse3.Text = "buttonReverse3";
            // 
            // NewTaimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(427, 219);
            Controls.Add(buttonReverse3);
            Controls.Add(buttonReverse2);
            Controls.Add(buttonReverse1);
            Controls.Add(retText5);
            Controls.Add(retText4);
            Controls.Add(retText3);
            Controls.Add(retText2);
            Controls.Add(buttonRet3);
            Controls.Add(buttonRet2);
            Controls.Add(retText1);
            Controls.Add(buttonRet1);
            Controls.Add(classButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewTaimerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewTaimerForm";
            ResumeLayout(false);
        }

        #endregion

        private ClassButton classButton1;
        private ButtonRet buttonRet1;
        private RetText retText1;
        private ButtonRet buttonRet2;
        private ButtonRet buttonRet3;
        private RetText retText2;
        private RetText retText3;
        private RetText retText4;
        private RetText retText5;
        private ButtonReverse buttonReverse1;
        private ButtonReverse buttonReverse2;
        private ButtonReverse buttonReverse3;
    }
}