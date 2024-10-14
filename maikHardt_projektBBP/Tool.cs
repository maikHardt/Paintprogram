using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace maikHardt_projektBBP
{
    abstract public class Tool
    {
        public readonly Form1 Auswahl;
        public readonly RadioButton radioButton = new RadioButton();
        protected Tool(Form1 Auswahl)
        {
            this.Auswahl = Auswahl;
            this.radioButton.AutoSize = true;
            this.radioButton.Appearance = Appearance.Button;
            this.radioButton.FlatStyle = FlatStyle.Flat;
            this.radioButton.Location = new System.Drawing.Point(5, 12 + 50 * Auswahl.grpBAuswahl.Controls.Count);
            this.radioButton.MinimumSize = new Size(47, 47);
            this.radioButton.FlatAppearance.BorderColor = Color.White;
            this.radioButton.FlatAppearance.BorderSize = 2;
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            Auswahl.grpBAuswahl.Controls.Add(this.radioButton);
        }      
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton.Checked)
            {
                Auswahl.AktuellesTool = this;
                this.radioButton.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                this.radioButton.FlatAppearance.BorderColor = Color.White;
            }
        }
        abstract public void MouseDown(MouseEventArgs e);
        abstract public void MouseMove(MouseEventArgs e, Graphics g);
        abstract public void MouseUp(MouseEventArgs e);        
        abstract public void Paint(PaintEventArgs e);
        abstract public void SetPen(System.Drawing.Color color, System.Int32 PenSize);            
        
    }
}
