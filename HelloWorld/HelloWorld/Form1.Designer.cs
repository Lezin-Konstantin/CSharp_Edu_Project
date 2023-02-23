namespace HelloWorld
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
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.AutoSize = true;
            this.HelloWorldLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloWorldLabel.Location = new System.Drawing.Point(310, 44);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(194, 29);
            this.HelloWorldLabel.TabIndex = 0;
            this.HelloWorldLabel.Text = "HelloWorldLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HelloWorldLabel);
            this.Name = "Form1";
            this.Text = "Hello World!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloWorldLabel;
        private System.Windows.Forms.Button button1;
    }
}

