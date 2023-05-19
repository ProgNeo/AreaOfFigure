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
            majorIncreaseButton = new Button();
            minorIncreaseButton = new Button();
            minorDecreaseButton = new Button();
            majorDecreaseButton = new Button();
            radiusTextBox = new TextBox();
            scaleComboBox = new ComboBox();
            label3 = new Label();
            areaOfFigure = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(majorIncreaseButton);
            panel1.Controls.Add(minorIncreaseButton);
            panel1.Controls.Add(minorDecreaseButton);
            panel1.Controls.Add(majorDecreaseButton);
            panel1.Controls.Add(radiusTextBox);
            panel1.Controls.Add(scaleComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(areaOfFigure);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(586, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 450);
            panel1.TabIndex = 1;
            // 
            // majorIncreaseButton
            // 
            majorIncreaseButton.Location = new Point(194, 28);
            majorIncreaseButton.Name = "majorIncreaseButton";
            majorIncreaseButton.Size = new Size(30, 23);
            majorIncreaseButton.TabIndex = 8;
            majorIncreaseButton.Text = "+5";
            majorIncreaseButton.UseVisualStyleBackColor = true;
            majorIncreaseButton.Click += MajorIncreaseButtonClick;
            // 
            // minorIncreaseButton
            // 
            minorIncreaseButton.Location = new Point(166, 28);
            minorIncreaseButton.Name = "minorIncreaseButton";
            minorIncreaseButton.Size = new Size(31, 23);
            minorIncreaseButton.TabIndex = 7;
            minorIncreaseButton.Text = "+1";
            minorIncreaseButton.UseVisualStyleBackColor = true;
            minorIncreaseButton.Click += MinorIncreaseButtonClick;
            // 
            // minorDecreaseButton
            // 
            minorDecreaseButton.Location = new Point(27, 27);
            minorDecreaseButton.Name = "minorDecreaseButton";
            minorDecreaseButton.Size = new Size(29, 23);
            minorDecreaseButton.TabIndex = 6;
            minorDecreaseButton.Text = "-1";
            minorDecreaseButton.UseVisualStyleBackColor = true;
            minorDecreaseButton.Click += MinorDecreaseButtonClick;
            // 
            // majorDecreaseButton
            // 
            majorDecreaseButton.Location = new Point(3, 27);
            majorDecreaseButton.Name = "majorDecreaseButton";
            majorDecreaseButton.Size = new Size(30, 23);
            majorDecreaseButton.TabIndex = 5;
            majorDecreaseButton.Text = "-5";
            majorDecreaseButton.UseVisualStyleBackColor = true;
            majorDecreaseButton.Click += MajorDecreaseButtonClick;
            // 
            // radiusTextBox
            // 
            radiusTextBox.Enabled = false;
            radiusTextBox.Location = new Point(53, 28);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(117, 23);
            radiusTextBox.TabIndex = 4;
            radiusTextBox.Text = "2";
            // 
            // scaleComboBox
            // 
            scaleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            scaleComboBox.FormattingEnabled = true;
            scaleComboBox.Items.AddRange(new object[] { "50%", "75%", "100%", "125%", "150%", "175%", "200%" });
            scaleComboBox.Location = new Point(3, 75);
            scaleComboBox.Name = "scaleComboBox";
            scaleComboBox.Size = new Size(221, 23);
            scaleComboBox.TabIndex = 1;
            scaleComboBox.SelectedIndexChanged += ScaleComboBoxChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 3;
            label3.Text = "Масштаб изображения:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 15);
            label1.TabIndex = 0;
            label1.Text = "Расстояние до вершин пятиугольника:";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(582, 450);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox;
        private Label areaOfFigure;
        private Label label2;
        private ComboBox scaleComboBox;
        private Label label3;
        private Button majorIncreaseButton;
        private Button minorIncreaseButton;
        private Button minorDecreaseButton;
        private Button majorDecreaseButton;
        private TextBox radiusTextBox;
    }
}