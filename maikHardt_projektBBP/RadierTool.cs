using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maikHardt_projektBBP
{
    public class RadierTool : Tool
    {
        public RadierTool(Form1 Auswahl) : base(Auswahl)
        {
            radioButton.BackgroundImage = Properties.Resources.Radierer;
            radioButton.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private System.Drawing.Brush brush;
        private System.Int32 pensize;
        private bool _isDrawing = false;
        private Point lastPoint;
        public override void SetPen(System.Drawing.Color _currentColor, System.Int32 Pensize)
        {
            this.brush = new SolidBrush(Color.White);
            this.pensize = Pensize;
        }
        public override void MouseDown(MouseEventArgs e)
        {
            _isDrawing = true;
            lastPoint = e.Location;
        }
        public override void MouseMove(MouseEventArgs e, Graphics g)
        {
            if (_isDrawing)
            {
                DrawPoint(lastPoint, e.Location);
                lastPoint = e.Location;
            }
        }
        public override void MouseUp(MouseEventArgs e)
        {
            _isDrawing = false;
        }
        public override void Paint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Form1._canvas, Point.Empty);
        }
        private void DrawPoint(Point start, Point end)
        {
            using (Graphics g = Graphics.FromImage(Form1._canvas))
            {
                int dx = Math.Abs(end.X - start.X);
                int dy = Math.Abs(end.Y - start.Y);
                int steps = Math.Max(dx, dy);

                float xIncrement = (float)(end.X - start.X) / steps;
                float yIncrement = (float)(end.Y - start.Y) / steps;

                float x = start.X;
                float y = start.Y;

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (int i = 0; i <= steps; i++)
                {
                    g.FillEllipse(brush, x - pensize / 2, y - pensize / 2, pensize, pensize);
                    x += xIncrement;
                    y += yIncrement;
                }
            }
        }
    }
}
