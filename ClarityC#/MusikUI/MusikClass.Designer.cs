namespace ClarityC_.MusikUI
{
    partial class MusikClass
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
            classButton2 = new ClassButton();
            classButton3 = new ClassButton();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            фаилToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // classButton2
            // 
            classButton2.BackColor = Color.IndianRed;
            classButton2.Location = new Point(56, 186);
            classButton2.Name = "classButton2";
            classButton2.Size = new Size(112, 32);
            classButton2.TabIndex = 2;
            classButton2.Text = "Начать";
            classButton2.Click += classButton2_Click;
            // 
            // classButton3
            // 
            classButton3.BackColor = Color.IndianRed;
            classButton3.Location = new Point(240, 186);
            classButton3.Name = "classButton3";
            classButton3.Size = new Size(112, 32);
            classButton3.TabIndex = 3;
            classButton3.Text = "Остановить";
            classButton3.Click += classButton3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(153, 143);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(469, 16);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 143);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Сейчас Играет:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { фаилToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(625, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            фаилToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            фаилToolStripMenuItem.Size = new Size(48, 20);
            фаилToolStripMenuItem.Text = "Фаил";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // MusikClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(classButton3);
            Controls.Add(classButton2);
            Controls.Add(menuStrip1);
            Name = "MusikClass";
            Size = new Size(625, 563);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ClassButton classButton2;
        private ClassButton classButton3;
        private TextBox textBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem фаилToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
    }
}
