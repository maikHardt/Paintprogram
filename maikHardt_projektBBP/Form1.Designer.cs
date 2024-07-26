namespace maikHardt_projektBBP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            lDruck = new Label();
            trackBar1 = new TrackBar();
            brushgroesse = new NumericUpDown();
            btn_farbe = new Button();
            label2 = new Label();
            label1 = new Label();
            label13 = new Label();
            btn_Neu = new Button();
            btnSpeichern = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            colorDialog1 = new ColorDialog();
            BildPanel = new PictureBox();
            btndateio = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btnSpeichernals = new Button();
            grpBAuswahl = new GroupBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brushgroesse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BildPanel).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lDruck);
            panel3.Controls.Add(trackBar1);
            panel3.Controls.Add(brushgroesse);
            panel3.Controls.Add(btn_farbe);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(1083, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 109);
            panel3.TabIndex = 7;
            // 
            // lDruck
            // 
            lDruck.AutoSize = true;
            lDruck.BackColor = SystemColors.Control;
            lDruck.FlatStyle = FlatStyle.Flat;
            lDruck.Location = new Point(60, 65);
            lDruck.MinimumSize = new Size(50, 15);
            lDruck.Name = "lDruck";
            lDruck.Size = new Size(50, 15);
            lDruck.TabIndex = 16;
            lDruck.Text = "100 %";
            lDruck.TextAlign = ContentAlignment.TopRight;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(3, 82);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(115, 45);
            trackBar1.TabIndex = 15;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // brushgroesse
            // 
            brushgroesse.BorderStyle = BorderStyle.None;
            brushgroesse.Font = new Font("Segoe UI", 10F);
            brushgroesse.Location = new Point(60, 34);
            brushgroesse.Name = "brushgroesse";
            brushgroesse.ReadOnly = true;
            brushgroesse.RightToLeft = RightToLeft.No;
            brushgroesse.Size = new Size(50, 21);
            brushgroesse.TabIndex = 5;
            brushgroesse.TextAlign = HorizontalAlignment.Right;
            brushgroesse.Value = new decimal(new int[] { 6, 0, 0, 0 });
            brushgroesse.ValueChanged += brushgroesse_ValueChanged;
            // 
            // btn_farbe
            // 
            btn_farbe.BackColor = Color.Black;
            btn_farbe.FlatAppearance.BorderColor = Color.Black;
            btn_farbe.FlatAppearance.BorderSize = 0;
            btn_farbe.ForeColor = SystemColors.ControlText;
            btn_farbe.Location = new Point(58, 5);
            btn_farbe.Name = "btn_farbe";
            btn_farbe.Size = new Size(53, 23);
            btn_farbe.TabIndex = 4;
            btn_farbe.UseVisualStyleBackColor = false;
            btn_farbe.Click += btn_farbe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 3;
            label2.Text = "Druck:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 2;
            label1.Text = "Größe:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(6, 7);
            label13.Name = "label13";
            label13.Size = new Size(46, 19);
            label13.TabIndex = 1;
            label13.Text = "Farbe:";
            // 
            // btn_Neu
            // 
            btn_Neu.BackColor = Color.White;
            btn_Neu.FlatAppearance.BorderSize = 0;
            btn_Neu.FlatStyle = FlatStyle.Flat;
            btn_Neu.Location = new Point(6, 7);
            btn_Neu.Name = "btn_Neu";
            btn_Neu.Size = new Size(56, 25);
            btn_Neu.TabIndex = 10;
            btn_Neu.Text = "Neu";
            btn_Neu.UseVisualStyleBackColor = false;
            btn_Neu.Click += btnNeu_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.BackColor = Color.White;
            btnSpeichern.FlatAppearance.BorderSize = 0;
            btnSpeichern.FlatStyle = FlatStyle.Flat;
            btnSpeichern.Location = new Point(155, 7);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(75, 25);
            btnSpeichern.TabIndex = 11;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = false;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.White;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Location = new Point(343, 7);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 25);
            btnUndo.TabIndex = 12;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.BackColor = Color.White;
            btnRedo.FlatAppearance.BorderSize = 0;
            btnRedo.FlatStyle = FlatStyle.Flat;
            btnRedo.Location = new Point(395, 7);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(45, 25);
            btnRedo.TabIndex = 13;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = false;
            btnRedo.Click += btnRedo_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.HelpRequest += btn_farbe_Click;
            // 
            // BildPanel
            // 
            BildPanel.BackColor = Color.White;
            BildPanel.BorderStyle = BorderStyle.FixedSingle;
            BildPanel.Cursor = Cursors.Cross;
            BildPanel.Location = new Point(67, 36);
            BildPanel.Name = "BildPanel";
            BildPanel.Size = new Size(1010, 505);
            BildPanel.TabIndex = 14;
            BildPanel.TabStop = false;
            BildPanel.Paint += BildPanel_Paint;
            BildPanel.MouseDown += BildPanel_MouseDown;
            BildPanel.MouseMove += BildPanel_MouseMove;
            BildPanel.MouseUp += BildPanel_MouseUp;
            // 
            // btndateio
            // 
            btndateio.BackColor = Color.White;
            btndateio.FlatAppearance.BorderSize = 0;
            btndateio.FlatStyle = FlatStyle.Flat;
            btndateio.Location = new Point(68, 7);
            btndateio.Name = "btndateio";
            btndateio.Size = new Size(80, 25);
            btndateio.TabIndex = 15;
            btndateio.Text = "Datei öffnen";
            btndateio.UseVisualStyleBackColor = false;
            btndateio.Click += btndateio_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSpeichernals
            // 
            btnSpeichernals.BackColor = Color.White;
            btnSpeichernals.FlatAppearance.BorderSize = 0;
            btnSpeichernals.FlatStyle = FlatStyle.Flat;
            btnSpeichernals.Location = new Point(237, 7);
            btnSpeichernals.Name = "btnSpeichernals";
            btnSpeichernals.Size = new Size(99, 25);
            btnSpeichernals.TabIndex = 16;
            btnSpeichernals.Text = "Speichern als";
            btnSpeichernals.UseVisualStyleBackColor = false;
            btnSpeichernals.Click += btnSpeichernAls_Click;
            // 
            // grpBAuswahl
            // 
            grpBAuswahl.BackColor = Color.Transparent;
            grpBAuswahl.FlatStyle = FlatStyle.Flat;
            grpBAuswahl.Location = new Point(5, 29);
            grpBAuswahl.MinimumSize = new Size(57, 264);
            grpBAuswahl.Name = "grpBAuswahl";
            grpBAuswahl.Size = new Size(57, 264);
            grpBAuswahl.TabIndex = 18;
            grpBAuswahl.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DimGray;
            ClientSize = new Size(1208, 563);
            Controls.Add(btnSpeichernals);
            Controls.Add(btndateio);
            Controls.Add(BildPanel);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnSpeichern);
            Controls.Add(btn_Neu);
            Controls.Add(panel3);
            Controls.Add(grpBAuswahl);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)brushgroesse).EndInit();
            ((System.ComponentModel.ISupportInitialize)BildPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label13;
        private Button btn_Neu;
        private Button btnSpeichern;
        private Button btnUndo;
        private Button btnRedo;
        private Label label2;
        private Label label1;
        private Button btn_farbe;
        private ColorDialog colorDialog1;
        private NumericUpDown brushgroesse;
        private TrackBar trackBar1;
        private Label lDruck;
        private Button btndateio;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnSpeichernals;
        public GroupBox grpBAuswahl;
        private PictureBox BildPanel;
    }
}
