namespace AreaOfFigure
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
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            areaOfFigure = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(areaOfFigure);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(615, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.White;
            trackBar1.Location = new Point(3, 27);
            trackBar1.Maximum = 500;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(194, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 100;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 15);
            label1.TabIndex = 0;
            label1.Text = "Расстояние от центра до вершин:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 450);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 1;
            label2.Text = "Площадь закрашенной фигуры:";
            // 
            // areaOfFigure
            // 
            areaOfFigure.AutoSize = true;
            areaOfFigure.Location = new Point(3, 90);
            areaOfFigure.Name = "areaOfFigure";
            areaOfFigure.Size = new Size(13, 15);
            areaOfFigure.TabIndex = 2;
            areaOfFigure.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(250, 250);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private Label areaOfFigure;
        private Label label2;
    }
}