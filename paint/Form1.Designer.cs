namespace Paint
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
            pictureBox1 = new PictureBox();
            bthsave = new Button();
            bthclear = new Button();
            color = new Panel();
            button1 = new Button();
            bthpink = new Button();
            bthvelvet = new Button();
            bthblue = new Button();
            bthgreen = new Button();
            bthyelloy = new Button();
            byhorahge = new Button();
            bthred = new Button();
            bthwhite = new Button();
            vabor = new Panel();
            trackBar1 = new TrackBar();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            color.SuspendLayout();
            vabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(607, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // bthsave
            // 
            bthsave.Location = new Point(613, 370);
            bthsave.Name = "bthsave";
            bthsave.Size = new Size(173, 23);
            bthsave.TabIndex = 1;
            bthsave.Text = "Save";
            bthsave.UseVisualStyleBackColor = true;
            bthsave.Click += bthsave_Click;
            // 
            // bthclear
            // 
            bthclear.Location = new Point(613, 399);
            bthclear.Name = "bthclear";
            bthclear.Size = new Size(173, 23);
            bthclear.TabIndex = 2;
            bthclear.Text = "Clear";
            bthclear.UseVisualStyleBackColor = true;
            bthclear.Click += bthclear_Click;
            // 
            // color
            // 
            color.BorderStyle = BorderStyle.Fixed3D;
            color.Controls.Add(button1);
            color.Controls.Add(bthpink);
            color.Controls.Add(bthvelvet);
            color.Controls.Add(bthblue);
            color.Controls.Add(bthgreen);
            color.Controls.Add(bthyelloy);
            color.Controls.Add(byhorahge);
            color.Controls.Add(bthred);
            color.Controls.Add(bthwhite);
            color.Dock = DockStyle.Top;
            color.Location = new Point(607, 0);
            color.Name = "color";
            color.Size = new Size(193, 100);
            color.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(147, 39);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bthpink
            // 
            bthpink.BackColor = Color.FromArgb(255, 192, 255);
            bthpink.FlatStyle = FlatStyle.Flat;
            bthpink.Location = new Point(75, 39);
            bthpink.Name = "bthpink";
            bthpink.Size = new Size(30, 30);
            bthpink.TabIndex = 7;
            bthpink.UseVisualStyleBackColor = false;
            bthpink.Click += bthwhite_Click;
            // 
            // bthvelvet
            // 
            bthvelvet.BackColor = Color.FromArgb(192, 192, 255);
            bthvelvet.FlatStyle = FlatStyle.Flat;
            bthvelvet.Location = new Point(39, 39);
            bthvelvet.Name = "bthvelvet";
            bthvelvet.Size = new Size(30, 30);
            bthvelvet.TabIndex = 6;
            bthvelvet.UseVisualStyleBackColor = false;
            bthvelvet.Click += bthwhite_Click;
            // 
            // bthblue
            // 
            bthblue.BackColor = Color.FromArgb(192, 255, 255);
            bthblue.FlatStyle = FlatStyle.Flat;
            bthblue.Location = new Point(3, 39);
            bthblue.Name = "bthblue";
            bthblue.Size = new Size(30, 30);
            bthblue.TabIndex = 5;
            bthblue.UseVisualStyleBackColor = false;
            bthblue.Click += bthwhite_Click;
            // 
            // bthgreen
            // 
            bthgreen.BackColor = Color.FromArgb(192, 255, 192);
            bthgreen.FlatStyle = FlatStyle.Flat;
            bthgreen.Location = new Point(147, 3);
            bthgreen.Name = "bthgreen";
            bthgreen.Size = new Size(30, 30);
            bthgreen.TabIndex = 4;
            bthgreen.UseVisualStyleBackColor = false;
            bthgreen.Click += bthwhite_Click;
            // 
            // bthyelloy
            // 
            bthyelloy.BackColor = Color.FromArgb(255, 255, 192);
            bthyelloy.FlatStyle = FlatStyle.Flat;
            bthyelloy.Location = new Point(111, 3);
            bthyelloy.Name = "bthyelloy";
            bthyelloy.Size = new Size(30, 30);
            bthyelloy.TabIndex = 3;
            bthyelloy.UseVisualStyleBackColor = false;
            bthyelloy.Click += bthwhite_Click;
            // 
            // byhorahge
            // 
            byhorahge.BackColor = Color.FromArgb(255, 224, 192);
            byhorahge.FlatStyle = FlatStyle.Flat;
            byhorahge.Location = new Point(75, 3);
            byhorahge.Name = "byhorahge";
            byhorahge.Size = new Size(30, 30);
            byhorahge.TabIndex = 2;
            byhorahge.UseVisualStyleBackColor = false;
            byhorahge.Click += bthwhite_Click;
            // 
            // bthred
            // 
            bthred.BackColor = Color.FromArgb(255, 192, 192);
            bthred.FlatStyle = FlatStyle.Flat;
            bthred.Location = new Point(39, 3);
            bthred.Name = "bthred";
            bthred.Size = new Size(30, 30);
            bthred.TabIndex = 1;
            bthred.UseVisualStyleBackColor = false;
            bthred.Click += bthwhite_Click;
            // 
            // bthwhite
            // 
            bthwhite.BackColor = Color.White;
            bthwhite.FlatStyle = FlatStyle.Flat;
            bthwhite.Location = new Point(3, 3);
            bthwhite.Name = "bthwhite";
            bthwhite.Size = new Size(30, 30);
            bthwhite.TabIndex = 0;
            bthwhite.UseVisualStyleBackColor = false;
            bthwhite.Click += bthwhite_Click;
            // 
            // vabor
            // 
            vabor.Controls.Add(trackBar1);
            vabor.Controls.Add(label1);
            vabor.Dock = DockStyle.Top;
            vabor.Location = new Point(607, 100);
            vabor.Name = "vabor";
            vabor.Size = new Size(193, 100);
            vabor.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 55);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(193, 45);
            trackBar1.TabIndex = 1;

            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 21);
            label1.TabIndex = 0;
            label1.Text = "Выбор толщины";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vabor);
            Controls.Add(color);
            Controls.Add(bthclear);
            Controls.Add(bthsave);
            Controls.Add(pictureBox1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            color.ResumeLayout(false);
            vabor.ResumeLayout(false);
            vabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bthsave;
        private Button bthclear;
        private Panel color;
        private Button bthwhite;
        private Panel vabor;
        private Button button1;
        private Button bthpink;
        private Button bthvelvet;
        private Button bthblue;
        private Button bthgreen;
        private Button bthyelloy;
        private Button byhorahge;
        private Button bthred;
        private Label label1;
        private TrackBar trackBar1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
