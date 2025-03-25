using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityC_
{
    public class ClassButton : Control
    {   
        StringFormat sf = new StringFormat();
        bool EnterMouse = false;
        bool MouseDouwn = false;
        public ClassButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            Visible = true;
            Size = new Size(130, 39);
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            BackColor = Color.IndianRed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Parent.BackColor);
            Rectangle rec = new Rectangle(0, 0, Width -1 , Height - 1);
            graphics.DrawRectangle(new Pen(BackColor), rec);
            graphics.FillRectangle(new SolidBrush(BackColor), rec);

            if (EnterMouse)
            {
                
                graphics.DrawRectangle(new Pen(Color.FromArgb(25, Color.White)), rec);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(25,Color.White)), rec);
            }
            if (MouseDouwn)
            {
                graphics.DrawRectangle(new Pen(Color.FromArgb(10, Color.Black)), rec);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(10, Color.Black)), rec);  
            }
            graphics.DrawString(Text, Font ,new SolidBrush(ForeColor), rec, sf);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            EnterMouse = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            EnterMouse = false;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MouseDouwn = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MouseDouwn = false;
            Invalidate();
        }


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }

    public class ButtonTaimerArrows : Control
    {
        public ButtonTaimerArrows()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            Size = new Size(30, 30);
            BackColor = Color.Black;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);
            Rectangle rec = new Rectangle(0, 0, Width - 1,  Height - 1);
            g.DrawRectangle(new Pen(BackColor), rec );
        }


    }
}
