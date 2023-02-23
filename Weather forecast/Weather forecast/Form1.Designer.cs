namespace Weather_forecast
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.YouIpLabel = new System.Windows.Forms.Label();
            this.country_name = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.elevation = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.winddirection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YouIpLabel
            // 
            this.YouIpLabel.AutoSize = true;
            this.YouIpLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YouIpLabel.Location = new System.Drawing.Point(25, 45);
            this.YouIpLabel.Name = "YouIpLabel";
            this.YouIpLabel.Size = new System.Drawing.Size(66, 20);
            this.YouIpLabel.TabIndex = 1;
            this.YouIpLabel.Text = "Your IP:";
            // 
            // country_name
            // 
            this.country_name.AutoSize = true;
            this.country_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.country_name.Location = new System.Drawing.Point(25, 80);
            this.country_name.Name = "country_name";
            this.country_name.Size = new System.Drawing.Size(68, 20);
            this.country_name.TabIndex = 2;
            this.country_name.Text = "Country:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city.Location = new System.Drawing.Point(25, 150);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(39, 20);
            this.city.TabIndex = 3;
            this.city.Text = "City:";
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.region.Location = new System.Drawing.Point(25, 115);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(64, 20);
            this.region.TabIndex = 4;
            this.region.Text = "Region:";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.latitude.Location = new System.Drawing.Point(25, 185);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(71, 20);
            this.latitude.TabIndex = 6;
            this.latitude.Text = "Latitude:";
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.longitude.Location = new System.Drawing.Point(25, 220);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(84, 20);
            this.longitude.TabIndex = 5;
            this.longitude.Text = "Longitude:";
            // 
            // elevation
            // 
            this.elevation.AutoSize = true;
            this.elevation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elevation.Location = new System.Drawing.Point(253, 80);
            this.elevation.Name = "elevation";
            this.elevation.Size = new System.Drawing.Size(78, 20);
            this.elevation.TabIndex = 7;
            this.elevation.Text = "Elevation:";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temperature.Location = new System.Drawing.Point(253, 115);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(104, 20);
            this.temperature.TabIndex = 8;
            this.temperature.Text = "Temperature:";
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.windspeed.Location = new System.Drawing.Point(253, 150);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(93, 20);
            this.windspeed.TabIndex = 9;
            this.windspeed.Text = "Windspeed:";
            // 
            // winddirection
            // 
            this.winddirection.AutoSize = true;
            this.winddirection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winddirection.Location = new System.Drawing.Point(253, 185);
            this.winddirection.Name = "winddirection";
            this.winddirection.Size = new System.Drawing.Size(109, 20);
            this.winddirection.TabIndex = 10;
            this.winddirection.Text = "Winddirection:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winddirection);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.elevation);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.region);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country_name);
            this.Controls.Add(this.YouIpLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Weather forecast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label YouIpLabel;
        private System.Windows.Forms.Label country_name;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.Label elevation;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label winddirection;
    }
}

