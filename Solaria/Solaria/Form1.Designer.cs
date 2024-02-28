namespace Solaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox = new TextBox();
            pictureBox = new PictureBox();
            locationLabel = new Label();
            curTempLabel = new Label();
            curWatherLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            tempMax = new Label();
            tempMin = new Label();
            label4 = new Label();
            humidityLabel = new Label();
            label6 = new Label();
            pressureLabel = new Label();
            label8 = new Label();
            windSpeedLabel = new Label();
            label10 = new Label();
            feelsLikeLabel = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(214, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter location:";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.None;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.Location = new Point(342, 24);
            textBox.Margin = new Padding(4, 3, 4, 3);
            textBox.Name = "textBox";
            textBox.Size = new Size(284, 23);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Location = new Point(441, 122);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(83, 68);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // locationLabel
            // 
            locationLabel.Anchor = AnchorStyles.None;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.ForeColor = SystemColors.Control;
            locationLabel.Location = new Point(142, 193);
            locationLabel.Margin = new Padding(4, 0, 4, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(690, 43);
            locationLabel.TabIndex = 3;
            locationLabel.Text = "Location";
            locationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // curTempLabel
            // 
            curTempLabel.Anchor = AnchorStyles.None;
            curTempLabel.BackColor = Color.Transparent;
            curTempLabel.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            curTempLabel.ForeColor = SystemColors.Control;
            curTempLabel.Location = new Point(422, 272);
            curTempLabel.Name = "curTempLabel";
            curTempLabel.Size = new Size(132, 27);
            curTempLabel.TabIndex = 4;
            curTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // curWatherLabel
            // 
            curWatherLabel.Anchor = AnchorStyles.None;
            curWatherLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            curWatherLabel.ForeColor = SystemColors.Control;
            curWatherLabel.Location = new Point(410, 239);
            curWatherLabel.Name = "curWatherLabel";
            curWatherLabel.Size = new Size(157, 29);
            curWatherLabel.TabIndex = 6;
            curWatherLabel.Text = "weather";
            curWatherLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(446, 296);
            label2.Name = "label2";
            label2.Size = new Size(19, 19);
            label2.TabIndex = 7;
            label2.Text = "H";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(506, 296);
            label3.Name = "label3";
            label3.Size = new Size(16, 19);
            label3.TabIndex = 8;
            label3.Text = "L";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tempMax
            // 
            tempMax.Anchor = AnchorStyles.None;
            tempMax.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tempMax.ForeColor = SystemColors.Control;
            tempMax.Location = new Point(420, 313);
            tempMax.Name = "tempMax";
            tempMax.Size = new Size(72, 35);
            tempMax.TabIndex = 10;
            tempMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tempMin
            // 
            tempMin.Anchor = AnchorStyles.None;
            tempMin.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tempMin.ForeColor = SystemColors.Control;
            tempMin.Location = new Point(504, 315);
            tempMin.Name = "tempMin";
            tempMin.Size = new Size(70, 29);
            tempMin.TabIndex = 12;
            tempMin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(109, 380);
            label4.Name = "label4";
            label4.Size = new Size(112, 29);
            label4.TabIndex = 13;
            label4.Text = "Humidity:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // humidityLabel
            // 
            humidityLabel.Anchor = AnchorStyles.None;
            humidityLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            humidityLabel.ForeColor = SystemColors.Control;
            humidityLabel.Location = new Point(213, 379);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new Size(118, 31);
            humidityLabel.TabIndex = 14;
            humidityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(110, 472);
            label6.Name = "label6";
            label6.Size = new Size(108, 29);
            label6.TabIndex = 15;
            label6.Text = "Pressure:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pressureLabel
            // 
            pressureLabel.Anchor = AnchorStyles.None;
            pressureLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pressureLabel.ForeColor = SystemColors.Control;
            pressureLabel.Location = new Point(214, 472);
            pressureLabel.Name = "pressureLabel";
            pressureLabel.Size = new Size(155, 30);
            pressureLabel.TabIndex = 16;
            pressureLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(630, 376);
            label8.Name = "label8";
            label8.Size = new Size(140, 29);
            label8.TabIndex = 17;
            label8.Text = "Wind Speed:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // windSpeedLabel
            // 
            windSpeedLabel.Anchor = AnchorStyles.None;
            windSpeedLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            windSpeedLabel.ForeColor = SystemColors.Control;
            windSpeedLabel.Location = new Point(765, 374);
            windSpeedLabel.Name = "windSpeedLabel";
            windSpeedLabel.Size = new Size(137, 32);
            windSpeedLabel.TabIndex = 18;
            windSpeedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(638, 472);
            label10.Name = "label10";
            label10.Size = new Size(111, 29);
            label10.TabIndex = 19;
            label10.Text = "Feels like:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // feelsLikeLabel
            // 
            feelsLikeLabel.Anchor = AnchorStyles.None;
            feelsLikeLabel.BackColor = Color.Transparent;
            feelsLikeLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            feelsLikeLabel.ForeColor = SystemColors.Control;
            feelsLikeLabel.Location = new Point(744, 470);
            feelsLikeLabel.Name = "feelsLikeLabel";
            feelsLikeLabel.Size = new Size(106, 32);
            feelsLikeLabel.TabIndex = 20;
            feelsLikeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.Thistle;
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(638, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 1, 10);
            ClientSize = new Size(954, 611);
            Controls.Add(btnSearch);
            Controls.Add(feelsLikeLabel);
            Controls.Add(label10);
            Controls.Add(windSpeedLabel);
            Controls.Add(label8);
            Controls.Add(pressureLabel);
            Controls.Add(label6);
            Controls.Add(humidityLabel);
            Controls.Add(label4);
            Controls.Add(tempMin);
            Controls.Add(tempMax);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(curWatherLabel);
            Controls.Add(curTempLabel);
            Controls.Add(locationLabel);
            Controls.Add(pictureBox);
            Controls.Add(textBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(900, 650);
            Name = "Form1";
            Text = "Solaria";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private PictureBox pictureBox;
        private Label locationLabel;
        private Label curTempLabel;
        private Label curWatherLabel;
        private Label label2;
        private Label label3;
        private Label tempMax;
        private Label tempMin;
        private Label label4;
        private Label humidityLabel;
        private Label label6;
        private Label pressureLabel;
        private Label label8;
        private Label windSpeedLabel;
        private Label label10;
        private Label feelsLikeLabel;
        private Button btnSearch;
    }
}