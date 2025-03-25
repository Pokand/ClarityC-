using ClarityC_.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityC_.TaimerUI
{
    public class TextTaimer : Control
    {
        StringFormat sf = new StringFormat();

        public TextTaimer()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            Size = new Size(100, 50);
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            TabStop = false;
            BackColor = Color.AntiqueWhite;
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);
            Rectangle rec = new Rectangle(0, 0, Width - 1, Height - 1);
            g.DrawRectangle(new Pen(BackColor), rec);
            g.FillRectangle(new SolidBrush(BackColor), rec);
            g.DrawString(Text, Font, new SolidBrush(Color.Black), rec, sf);

        }

    }


    public class TaimerStartBtn : Control
        {
            bool MDown = false;
            public TaimerStartBtn()
            {
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
                DoubleBuffered = true;
                Size = new Size(46, 46);
                TabStop = false;

            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.HighQuality;

                Rectangle rec = new Rectangle(0, 0, Width - 1, Height - 1);
                if (MDown)
                {
                    g.DrawRectangle(new Pen(Color.FromArgb(30, Color.White)), rec);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), rec);

                }
                g.DrawIconUnstretched(Resources.playBtn, rec);
            }
            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                MDown = true;
                Invalidate();
            }
            protected override void OnMouseUp(MouseEventArgs e)
            {
                base.OnMouseUp(e);
                MDown = false;
                Invalidate();
        }

    }

    public class NewTaimer : Control {
        bool mDown = false;
        public NewTaimer()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            Size = new Size(24, 24);
            TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(SystemColors.ActiveCaption);
            Rectangle rec = new Rectangle(0, 0, Width - 1, Height - 1);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            if (mDown)
            {
                g.DrawRectangle(new Pen(Color.FromArgb(20, Color.White)), rec);
                g.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), rec);
                
            }
            g.DrawLine(new Pen(Color.Black, 3), new Point(Width / 2, 0), new Point(Width / 2, Height));
            g.DrawLine(new Pen(Color.Black, 3), new Point(0, Height/ 2), new Point(Width, Height/ 2));
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mDown = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mDown = false; 
            Invalidate();
        }
    }


    public class ButtonRet : Control {
        bool mDowsn = false;
        public ButtonRet()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            new Size(100, 100);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.Clear(Parent.BackColor);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            
            Point point = new Point(0, Height -1);
            Point point1 = new Point(Width / 2, 0);
            Point point2 = new Point(Width, Height - 1);
            graphics.DrawPolygon(new Pen(Color.Black, 3), new Point[] {point,point1,point2 });
            graphics.FillPolygon(new SolidBrush(Color.Black), new PointF[] {point,point1,point2});
            if (mDowsn)
            {
                graphics.DrawPolygon(new Pen(Color.FromArgb(50, Color.White)), new Point[] { point, point1, point2 });
                graphics.FillPolygon(new SolidBrush(Color.FromArgb(50, Color.White)), new PointF[] { point, point1, point2 });
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mDowsn = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mDowsn = false;
            Invalidate();
        }
    }
    public class ButtonReverse : Control
    {
        bool mDowsn = false;
        public ButtonReverse()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            new Size(100, 100);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.Clear(Parent.BackColor);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            Point point = new Point(0, 0);
            Point point1 = new Point(Width / 2, Height - 1);
            Point point2 = new Point(Width, 0);
            graphics.DrawPolygon(new Pen(Color.Black, 1), new Point[] { point, point1, point2 });
            graphics.FillPolygon(new SolidBrush(Color.Black), new PointF[] { point, point1, point2 });
            if (mDowsn)
            {
                graphics.DrawPolygon(new Pen(Color.FromArgb(50,Color.White)), new Point[] { point, point1, point2 });
                graphics.FillPolygon(new SolidBrush(Color.FromArgb(50, Color.White)), new PointF[] { point, point1, point2 });
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mDowsn = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mDowsn = false;
            Invalidate();
        }
    }
    public class RetText : Control
    {
        StringFormat sf = new StringFormat();
        public RetText()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
            new Size(100, 100);
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.Clear(Parent.BackColor);
            Rectangle rec = new Rectangle(0, 0, Width - 1, Height - 1);
            graphics.DrawString(Text, Font, new SolidBrush(Color.Black), rec,sf);
        }
    }
    
}
