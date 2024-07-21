namespace WeatherApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            lbCity = new Label();
            txtCityName = new TextBox();
            btnSearchCity = new Button();
            pbSmallWeather = new PictureBox();
            lbTemp = new Label();
            lbDegCenti = new Label();
            label2 = new Label();
            ldDegFren = new Label();
            lbWatherHeader = new Label();
            lbDayTime = new Label();
            lbWeatherStatus = new Label();
            pbLargeWeather = new PictureBox();
            PanelInfo = new Panel();
            lbWindSpeed = new Label();
            lbHumidity = new Label();
            lb2 = new Label();
            lb1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSmallWeather).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLargeWeather).BeginInit();
            PanelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lbCity
            // 
            lbCity.Anchor = AnchorStyles.Top;
            lbCity.AutoSize = true;
            lbCity.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbCity.ForeColor = Color.White;
            lbCity.Location = new Point(288, 107);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(54, 30);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // txtCityName
            // 
            txtCityName.Anchor = AnchorStyles.Top;
            txtCityName.BackColor = Color.White;
            txtCityName.Location = new Point(379, 107);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(387, 31);
            txtCityName.TabIndex = 1;
            // 
            // btnSearchCity
            // 
            btnSearchCity.Anchor = AnchorStyles.Top;
            btnSearchCity.BackColor = Color.White;
            btnSearchCity.Cursor = Cursors.Hand;
            btnSearchCity.FlatStyle = FlatStyle.Flat;
            btnSearchCity.Location = new Point(803, 103);
            btnSearchCity.Name = "btnSearchCity";
            btnSearchCity.Size = new Size(168, 38);
            btnSearchCity.TabIndex = 2;
            btnSearchCity.Text = "Search";
            btnSearchCity.UseVisualStyleBackColor = false;
            btnSearchCity.Click += btnSearchCity_Click;
            // 
            // pbSmallWeather
            // 
            pbSmallWeather.BackColor = Color.Transparent;
            pbSmallWeather.Image = Properties.Resources.Sun;
            pbSmallWeather.Location = new Point(224, 239);
            pbSmallWeather.Name = "pbSmallWeather";
            pbSmallWeather.Size = new Size(70, 70);
            pbSmallWeather.SizeMode = PictureBoxSizeMode.Zoom;
            pbSmallWeather.TabIndex = 3;
            pbSmallWeather.TabStop = false;
            // 
            // lbTemp
            // 
            lbTemp.AutoSize = true;
            lbTemp.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lbTemp.ForeColor = Color.White;
            lbTemp.Location = new Point(285, 215);
            lbTemp.Name = "lbTemp";
            lbTemp.Size = new Size(109, 106);
            lbTemp.TabIndex = 4;
            lbTemp.Text = "--";
            // 
            // lbDegCenti
            // 
            lbDegCenti.Anchor = AnchorStyles.Top;
            lbDegCenti.AutoSize = true;
            lbDegCenti.Cursor = Cursors.Hand;
            lbDegCenti.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbDegCenti.ForeColor = Color.White;
            lbDegCenti.Location = new Point(379, 205);
            lbDegCenti.Name = "lbDegCenti";
            lbDegCenti.Size = new Size(35, 30);
            lbDegCenti.TabIndex = 0;
            lbDegCenti.Text = "°C";
            lbDegCenti.Click += lbDegCenti_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(409, 206);
            label2.Name = "label2";
            label2.Size = new Size(20, 30);
            label2.TabIndex = 0;
            label2.Text = "|";
            // 
            // ldDegFren
            // 
            ldDegFren.Anchor = AnchorStyles.Top;
            ldDegFren.AutoSize = true;
            ldDegFren.Cursor = Cursors.Hand;
            ldDegFren.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ldDegFren.ForeColor = Color.Gainsboro;
            ldDegFren.Location = new Point(422, 206);
            ldDegFren.Name = "ldDegFren";
            ldDegFren.Size = new Size(32, 30);
            ldDegFren.TabIndex = 0;
            ldDegFren.Text = "°F";
            ldDegFren.Click += ldDegFren_Click;
            // 
            // lbWatherHeader
            // 
            lbWatherHeader.AutoSize = true;
            lbWatherHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbWatherHeader.ForeColor = Color.White;
            lbWatherHeader.Location = new Point(835, 215);
            lbWatherHeader.Name = "lbWatherHeader";
            lbWatherHeader.Size = new Size(137, 41);
            lbWatherHeader.TabIndex = 4;
            lbWatherHeader.Text = "Weather";
            // 
            // lbDayTime
            // 
            lbDayTime.AutoSize = true;
            lbDayTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbDayTime.ForeColor = Color.White;
            lbDayTime.Location = new Point(835, 256);
            lbDayTime.Name = "lbDayTime";
            lbDayTime.Size = new Size(202, 32);
            lbDayTime.TabIndex = 4;
            lbDayTime.Text = "Tuesday 8:00 pm\r\n";
            // 
            // lbWeatherStatus
            // 
            lbWeatherStatus.AutoSize = true;
            lbWeatherStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbWeatherStatus.ForeColor = Color.White;
            lbWeatherStatus.Location = new Point(835, 289);
            lbWeatherStatus.Name = "lbWeatherStatus";
            lbWeatherStatus.Size = new Size(72, 32);
            lbWeatherStatus.TabIndex = 4;
            lbWeatherStatus.Text = "Clear";
            // 
            // pbLargeWeather
            // 
            pbLargeWeather.Image = Properties.Resources.Sun;
            pbLargeWeather.Location = new Point(1026, -20);
            pbLargeWeather.Name = "pbLargeWeather";
            pbLargeWeather.Size = new Size(298, 209);
            pbLargeWeather.SizeMode = PictureBoxSizeMode.Zoom;
            pbLargeWeather.TabIndex = 5;
            pbLargeWeather.TabStop = false;
            // 
            // PanelInfo
            // 
            PanelInfo.BackColor = SystemColors.Control;
            PanelInfo.Controls.Add(lbWindSpeed);
            PanelInfo.Controls.Add(lbHumidity);
            PanelInfo.Controls.Add(lb2);
            PanelInfo.Controls.Add(lb1);
            PanelInfo.Location = new Point(346, 396);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(566, 105);
            PanelInfo.TabIndex = 6;
            // 
            // lbWindSpeed
            // 
            lbWindSpeed.AutoSize = true;
            lbWindSpeed.Location = new Point(317, 60);
            lbWindSpeed.Name = "lbWindSpeed";
            lbWindSpeed.Size = new Size(59, 25);
            lbWindSpeed.TabIndex = 1;
            lbWindSpeed.Text = "label1";
            // 
            // lbHumidity
            // 
            lbHumidity.AutoSize = true;
            lbHumidity.Location = new Point(317, 23);
            lbHumidity.Name = "lbHumidity";
            lbHumidity.Size = new Size(59, 25);
            lbHumidity.TabIndex = 1;
            lbHumidity.Text = "label1";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb2.Location = new Point(49, 57);
            lb2.Name = "lb2";
            lb2.Size = new Size(125, 28);
            lb2.TabIndex = 0;
            lb2.Text = "Wind Speed";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb1.Location = new Point(49, 20);
            lb1.Name = "lb1";
            lb1.Size = new Size(100, 28);
            lb1.TabIndex = 0;
            lb1.Text = "Humidity";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1259, 608);
            Controls.Add(PanelInfo);
            Controls.Add(ldDegFren);
            Controls.Add(lbDegCenti);
            Controls.Add(label2);
            Controls.Add(pbSmallWeather);
            Controls.Add(lbWeatherStatus);
            Controls.Add(lbDayTime);
            Controls.Add(lbWatherHeader);
            Controls.Add(lbTemp);
            Controls.Add(btnSearchCity);
            Controls.Add(txtCityName);
            Controls.Add(lbCity);
            Controls.Add(pbLargeWeather);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "6";
            ((System.ComponentModel.ISupportInitialize)pbSmallWeather).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLargeWeather).EndInit();
            PanelInfo.ResumeLayout(false);
            PanelInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCity;
        private TextBox txtCityName;
        private Button btnSearchCity;
        private PictureBox pbSmallWeather;
        private Label lbTemp;
        private Label lbDegCenti;
        private Label label2;
        private Label ldDegFren;
        private Label lbWatherHeader;
        private Label lbDayTime;
        private Label lbWeatherStatus;
        private PictureBox pbLargeWeather;
        private Panel PanelInfo;
        private Label lb1;
        private Label lbWindSpeed;
        private Label lbHumidity;
        private Label lb2;
    }
}