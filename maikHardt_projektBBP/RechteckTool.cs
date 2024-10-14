using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maikHardt_projektBBP
{
    public class RechteckTool : Tool
    {
        public RechteckTool(Form1 Auswahl) : base(Auswahl)
        {
            radioButton.BackgroundImage = Properties.Resources.Rechteck47;
            radioButton.BackgroundImageLayout = ImageLayout.Center;
        }
        
        private System.Drawing.Pen pen;
        private bool _isDrawing = false;
        private int downX = 0;
        private int downY = 0;
        private int moveX = 0;
        private int moveY = 0;

        public override void SetPen(System.Drawing.Color _currentColor, System.Int32 Pensize)
        {
            this.pen = new Pen(_currentColor, Pensize);            
        }        
        public override void MouseDown(MouseEventArgs e)
        {
            downX = e.X;
            downY = e.Y;   
            _isDrawing = true;
        }
        public override void MouseMove(MouseEventArgs e, Graphics g)
        {
            if (_isDrawing)
            {
                moveX = e.X;
                moveY = e.Y;
            }            
        }
        public override void MouseUp(MouseEventArgs e)
        {
            if (_isDrawing)
            {
                moveX = e.X;
                moveY = e.Y;
                _isDrawing = false;

                using (Graphics g = Graphics.FromImage(Form1._canvas))
                {
                    DrawRectangle(g, pen, downX, downY, moveX, moveY);
                }
            }            
        }
        public override void Paint(PaintEventArgs e)
        {                    
            e.Graphics.DrawImage(Form1._canvas, Point.Empty);
            if (_isDrawing)
            {
                DrawRectangle(e.Graphics, pen, downX, downY, moveX, moveY);
            }            
        }
        private void DrawRectangle(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
        {
            int startX = Math.Min(x1, x2);
            int startY = Math.Min(y1, y2);
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);

            g.DrawRectangle(pen, startX, startY, width, height);
        }
    }
}
