using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maikHardt_projektBBP
{
    public class DreieckTool : Tool
    {
        public DreieckTool(Form1 Auswahl) : base(Auswahl)
        {
            radioButton.BackgroundImage = Properties.Resources.Dreieck2te;
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
            _isDrawing = true;
            downX = e.X;
            downY = e.Y;
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
                _isDrawing = false;
                moveX = e.X;
                moveY = e.Y;

                using (Graphics g = Graphics.FromImage(Form1._canvas))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Point[] trianglePoints = GetTrianglePoints(downX, downY, moveX, moveY);                    
                    g.DrawPolygon(pen, trianglePoints);
                }
            }            
        }
        public override void Paint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Form1._canvas, Point.Empty);

            if (_isDrawing)
            {                
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Point[] trianglePoints = GetTrianglePoints(downX, downY, moveX, moveY);
                e.Graphics.DrawPolygon(pen, trianglePoints);
            }
        }
        private Point[] GetTrianglePoints(int x1, int y1, int x2, int y2)
        {
            Point basePoint1 = new Point(x1, y2);
            Point basePoint2 = new Point(x2, y2);
            
            Point topPoint = new Point((x1 + x2) / 2, y1);

            return new Point[]
            {
            basePoint1,
            basePoint2,
            topPoint
            };
        }

    }
}
