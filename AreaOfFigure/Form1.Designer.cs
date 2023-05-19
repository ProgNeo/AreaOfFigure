namespace AreaOfFigure
{
    partial class MainForm
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
            scaleComboBox = new ComboBox();
            label3 = new Label();
            areaOfFigure = new Label();
            label2 = new Label();
            trackBar = new TrackBar();
            label1 = new Label();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(scaleComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(areaOfFigure);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(615, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 1;
            // 
            // scaleComboBox
            // 
            scaleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            scaleComboBox.FormattingEnabled = true;
            scaleComboBox.Items.AddRange(new object[] { "50%", "75%", "100%", "125%", "150%", "175%", "200%" });
            scaleComboBox.Location = new Point(3, 75);
            scaleComboBox.Name = "scaleComboBox";
            scaleComboBox.Size = new Size(192, 23);
            scaleComboBox.TabIndex = 1;
            scaleComboBox.SelectedIndexChanged += ScaleComboBoxChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 3;
            label3.Text = "Расстояние от центра до вершин:";
            // 
            // areaOfFigure
            // 
            areaOfFigure.AutoSize = true;
            areaOfFigure.Location = new Point(3, 116);
            areaOfFigure.Name = "areaOfFigure";
            areaOfFigure.Size = new Size(13, 15);
            areaOfFigure.TabIndex = 2;
            areaOfFigure.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 101);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 1;
            label2.Text = "Площадь закрашенной фигуры:";
            // 
            // trackBar
            // 
            trackBar.BackColor = Color.White;
            trackBar.Location = new Point(3, 27);
            trackBar.Maximum = 20;
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(194, 45);
            trackBar.TabIndex = 0;
            trackBar.Value = 2;
            trackBar.ValueChanged += TrackBarValueChanged;
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
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(609, 450);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(pictureBox);
            Controls.Add(panel1);
            MinimumSize = new Size(250, 250);
            Name = "MainForm";
            Text = "Площадь закрашенной фигуры";
            SizeChanged += FormSizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox;
        private TrackBar trackBar;
        private Label areaOfFigure;
        private Label label2;
        private ComboBox scaleComboBox;
        private Label label3;
    }
}