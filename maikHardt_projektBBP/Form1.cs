using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime;
using System.Windows.Forms;

namespace maikHardt_projektBBP
{

    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        private Graphics drawingGraphics;
        public static Bitmap _canvas;
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();
        private double opacity = 255;
        private Color _currentColor = Color.FromArgb(255, Color.Black);


        public Form1()
        {
            InitializeComponent();

            aktuellesTool = new PinselTool(this);
            aktuellesTool.radioButton.Checked = true;

            new RechteckTool(this);
            new DreieckTool(this);
            new KreisTool(this);
            new RadierTool(this);

            InitializeCanvas();
        }

        private Tool aktuellesTool;
        public Tool AktuellesTool
        {
            get => aktuellesTool;
            set
            {
                aktuellesTool = value;
                this.aktuellesTool.SetPen(_currentColor, (int)brushgroesse.Value);
            }
        }
        private void btnNeu_Click(object sender, EventArgs e)
        {
            InitializeCanvas();
        }
        private void InitializeCanvas()
        {
            _canvas = new Bitmap(BildPanel.Width, BildPanel.Height);
            BildPanel.BackColor = Color.White;
            drawingGraphics = Graphics.FromImage(_canvas);
            undoStack.Clear();
            redoStack.Clear();
            BildPanel.Refresh();
        }


        private void BildPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (redoStack.Count < 0)
                SaveState(undoStack);
            else
            {
                redoStack.Clear();
                SaveState(undoStack);
            }

            aktuellesTool.MouseDown(e);
        }
        private void BildPanel_MouseMove(object sender, MouseEventArgs e)
        {
            aktuellesTool.MouseMove(e, drawingGraphics);
            BildPanel.Invalidate();
        }
        private void BildPanel_MouseUp(object sender, MouseEventArgs e)
        {
            aktuellesTool.MouseUp(e);
            BildPanel.Invalidate();
        }
        private void BildPanel_Paint(object sender, PaintEventArgs e)
        {
            aktuellesTool.Paint(e);
        }


        private void SaveState(Stack<Bitmap> stack)
        {

            stack.Push((Bitmap)_canvas.Clone());
        }
        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                SaveState(redoStack);
                _canvas = undoStack.Pop();
                BildPanel.Refresh();
            }
        }
        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                SaveState(undoStack);
                _canvas = redoStack.Pop();
                BildPanel.Invalidate();
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }


        public void btn_farbe_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    btn_farbe.BackColor = colorDialog.Color;
                    _currentColor = Color.FromArgb(((int)opacity), colorDialog.Color);
                    this.aktuellesTool.SetPen(_currentColor, (int)brushgroesse.Value);
                }
            }

        }     
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lDruck.Text = trackBar1.Value.ToString() + " %";
            double opacity = ((Convert.ToDouble(trackBar1.Value) / 100.0) * 255);
            _currentColor = Color.FromArgb(((int)opacity), _currentColor);
            this.aktuellesTool.SetPen(_currentColor, (int)brushgroesse.Value);

        }
        private void brushgroesse_ValueChanged(object sender, EventArgs e)
        {
            this.aktuellesTool.SetPen(_currentColor, (int)brushgroesse.Value);
        }


        
        private void SaveImage(string filePath, ImageFormat format)
        {
            _canvas.Save(filePath, format);
            currentFilePath = filePath;
        }
        private void LoadImage(string filePath)
        {
            using (Bitmap loadedImage = new Bitmap(filePath))
            {

                Bitmap newCanvas = new Bitmap(BildPanel.Width, BildPanel.Height);

                using (Graphics g = Graphics.FromImage(newCanvas))
                {
                    int x = (newCanvas.Width - loadedImage.Width) / 2;
                    int y = (newCanvas.Height - loadedImage.Height) / 2;

                    g.DrawImage(loadedImage, new Rectangle(x, y, loadedImage.Width, loadedImage.Height));
                }
                _canvas = newCanvas;
            }

            currentFilePath = filePath;
            BildPanel.Invalidate();
        }
        private void btndateio_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImage(openFileDialog.FileName);
                }
            }
        }
        private void btnSpeichernAls_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();
                    ImageFormat format = ImageFormat.Png; // Standardwert

                    if (fileExtension == ".jpg")
                    {
                        format = ImageFormat.Jpeg;
                    }
                    else if (fileExtension == ".bmp")
                    {
                        format = ImageFormat.Bmp;
                    }

                    SaveImage(saveFileDialog.FileName, format);
                }
            }
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (currentFilePath != null)
            {
                string fileExtension = System.IO.Path.GetExtension(currentFilePath).ToLower();
                ImageFormat format = ImageFormat.Png;

                SaveImage(currentFilePath, format);
            }
            else
            {
                btnSpeichernAls_Click(sender, e);
            }
        }
        
    }
}