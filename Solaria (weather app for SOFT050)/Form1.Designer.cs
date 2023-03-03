namespace Solaria__weather_app_for_SOFT050_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.searchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.curTempLabel = new System.Windows.Forms.Label();
            this.curWeatherLabel = new System.Windows.Forms.Label();
            this.tempMax = new System.Windows.Forms.Label();
            this.tempMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visibilityLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.feelsLike = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(209, 547);
            this.panelMenu.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox.Location = new System.Drawing.Point(416, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(254, 33);
            this.textBox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox.StateActive.Border.Rounding = 10;
            this.textBox.StateActive.Content.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox.StateCommon.Border.Rounding = 10;
            this.textBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox.StateDisabled.Border.Rounding = 10;
            this.textBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox.StateNormal.Border.Rounding = 10;
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.Location = new System.Drawing.Point(685, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 25);
            this.searchButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.StateCommon.Border.Rounding = 4;
            this.searchButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.StateDisabled.Border.Rounding = 4;
            this.searchButton.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.StateNormal.Border.Rounding = 4;
            this.searchButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.StatePressed.Border.Rounding = 4;
            this.searchButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.StateTracking.Border.Rounding = 4;
            this.searchButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.TabIndex = 1;
            this.searchButton.Values.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = false;
            this.searchLabel.Location = new System.Drawing.Point(312, 12);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(98, 38);
            this.searchLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.searchLabel.StateCommon.ShortText.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Values.Text = "Location :";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(482, 91);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(138, 102);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("SF Pro Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.locationLabel.Location = new System.Drawing.Point(489, 196);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(131, 35);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curTempLabel
            // 
            this.curTempLabel.AutoSize = true;
            this.curTempLabel.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTempLabel.ForeColor = System.Drawing.Color.White;
            this.curTempLabel.Location = new System.Drawing.Point(536, 231);
            this.curTempLabel.Name = "curTempLabel";
            this.curTempLabel.Size = new System.Drawing.Size(47, 29);
            this.curTempLabel.TabIndex = 5;
            this.curTempLabel.Text = "18°";
            this.curTempLabel.Click += new System.EventHandler(this.curTempLabel_Click);
            // 
            // curWeatherLabel
            // 
            this.curWeatherLabel.AutoSize = true;
            this.curWeatherLabel.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curWeatherLabel.ForeColor = System.Drawing.Color.White;
            this.curWeatherLabel.Location = new System.Drawing.Point(521, 260);
            this.curWeatherLabel.Name = "curWeatherLabel";
            this.curWeatherLabel.Size = new System.Drawing.Size(71, 25);
            this.curWeatherLabel.TabIndex = 6;
            this.curWeatherLabel.Text = "cloudy";
            this.curWeatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.curWeatherLabel.Click += new System.EventHandler(this.curWeatherLabel_Click);
            // 
            // tempMax
            // 
            this.tempMax.AutoSize = true;
            this.tempMax.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMax.ForeColor = System.Drawing.Color.White;
            this.tempMax.Location = new System.Drawing.Point(514, 285);
            this.tempMax.Name = "tempMax";
            this.tempMax.Size = new System.Drawing.Size(38, 14);
            this.tempMax.TabIndex = 7;
            this.tempMax.Text = "H: 20°";
            // 
            // tempMin
            // 
            this.tempMin.AutoSize = true;
            this.tempMin.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMin.ForeColor = System.Drawing.Color.White;
            this.tempMin.Location = new System.Drawing.Point(567, 285);
            this.tempMin.Name = "tempMin";
            this.tempMin.Size = new System.Drawing.Size(34, 14);
            this.tempMin.TabIndex = 8;
            this.tempMin.Text = "L: 10°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Humidity:";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(367, 358);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(35, 13);
            this.humidityLabel.TabIndex = 10;
            this.humidityLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "visibility:";
            // 
            // visibilityLabel
            // 
            this.visibilityLabel.AutoSize = true;
            this.visibilityLabel.ForeColor = System.Drawing.Color.White;
            this.visibilityLabel.Location = new System.Drawing.Point(366, 445);
            this.visibilityLabel.Name = "visibilityLabel";
            this.visibilityLabel.Size = new System.Drawing.Size(36, 13);
            this.visibilityLabel.TabIndex = 13;
            this.visibilityLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(735, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wind:";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.ForeColor = System.Drawing.Color.White;
            this.windSpeed.Location = new System.Drawing.Point(805, 357);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(35, 13);
            this.windSpeed.TabIndex = 15;
            this.windSpeed.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(715, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Feels like:";
            // 
            // feelsLike
            // 
            this.feelsLike.AutoSize = true;
            this.feelsLike.ForeColor = System.Drawing.Color.White;
            this.feelsLike.Location = new System.Drawing.Point(817, 445);
            this.feelsLike.Name = "feelsLike";
            this.feelsLike.Size = new System.Drawing.Size(36, 13);
            this.feelsLike.TabIndex = 17;
            this.feelsLike.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(963, 547);
            this.Controls.Add(this.feelsLike);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.visibilityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempMin);
            this.Controls.Add(this.tempMax);
            this.Controls.Add(this.curWeatherLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.curTempLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel searchLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label curTempLabel;
        private System.Windows.Forms.Label curWeatherLabel;
        private System.Windows.Forms.Label tempMax;
        private System.Windows.Forms.Label tempMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label visibilityLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label feelsLike;
    }
}

