using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maikHardt_projektBBP
{
    public class KreisTool : Tool
    {
        public KreisTool(Form1 Auswahl) : base(Auswahl)
        {
            radioButton.BackgroundImage = Properties.Resources.Kreis;
            radioButton.BackgroundImageLayout = ImageLayout.Center;
        }       
        private System.Drawing.Pen pen;
        private bool _isDrawing = false;
        private int downX = 0;
        private int downY = 0;
        private int moveX = 0;
        private int moveY = 0;
        int radius;
        int topLeftX;
        int topLeftY;
        int diameter;

        public override void SetPen(System.Drawing.Color _currentColor, System.Int32 Pensize)
        {
            this.pen = new Pen(_currentColor, Pensize);
        }

        public override void MouseDown(MouseEventArgs e)
        {
            _isDrawing = true;
            downX = e.X;
            downY = e.Y;
        }
        public override void MouseMove(MouseEventArgs e, Graphics g)
        {
            if (_isDrawing)
            {
                radius = (int)Math.Sqrt(Math.Pow((moveX = e.X) - downX, 2) + Math.Pow((moveY = e.Y) - downY, 2));
                topLeftX = downX - radius;
                topLeftY = downY - radius;
                diameter = radius * 2;
            }            
        }
        public override void MouseUp(MouseEventArgs e) 
        {
            if (_isDrawing)
            {
                _isDrawing = false;
                using (Graphics g = Graphics.FromImage(Form1._canvas))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawEllipse(pen, topLeftX, topLeftY, diameter, diameter);
                }
            }
        }
        public override void Paint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Form1._canvas, Point.Empty);

            if (_isDrawing)
            {                
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;                
                e.Graphics.DrawEllipse(pen, topLeftX, topLeftY, diameter, diameter);
            }
        }        
    }    
}
