namespace Prak01
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
            this.quit_button = new System.Windows.Forms.Button();
            this.size_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit_Rect_button = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangle_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // quit_button
            // 
            this.quit_button.BackColor = System.Drawing.Color.LightCoral;
            this.quit_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit_button.ForeColor = System.Drawing.Color.DarkRed;
            this.quit_button.Location = new System.Drawing.Point(674, 394);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(114, 44);
            this.quit_button.TabIndex = 0;
            this.quit_button.Text = "QUIT";
            this.quit_button.UseVisualStyleBackColor = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // size_button
            // 
            this.size_button.BackColor = System.Drawing.Color.PaleGreen;
            this.size_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.size_button.Location = new System.Drawing.Point(12, 12);
            this.size_button.Name = "size_button";
            this.size_button.Size = new System.Drawing.Size(159, 44);
            this.size_button.TabIndex = 1;
            this.size_button.Text = "SIZE";
            this.size_button.UseVisualStyleBackColor = false;
            this.size_button.Click += new System.EventHandler(this.size_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submit_Rect_button);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(584, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 267);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // submit_Rect_button
            // 
            this.submit_Rect_button.BackColor = System.Drawing.Color.LemonChiffon;
            this.submit_Rect_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit_Rect_button.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.submit_Rect_button.Location = new System.Drawing.Point(7, 228);
            this.submit_Rect_button.Name = "submit_Rect_button";
            this.submit_Rect_button.Size = new System.Drawing.Size(97, 31);
            this.submit_Rect_button.TabIndex = 6;
            this.submit_Rect_button.Text = "Submit";
            this.submit_Rect_button.UseVisualStyleBackColor = false;
            this.submit_Rect_button.Click += new System.EventHandler(this.submit_Rect_button_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(7, 200);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 22);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Blue";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(7, 172);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 22);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Green";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(7, 144);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(7, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(7, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите длины сторон (целые числа > 0) и выберите цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rectangle_button
            // 
            this.rectangle_button.BackColor = System.Drawing.Color.PaleGreen;
            this.rectangle_button.Enabled = false;
            this.rectangle_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangle_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.rectangle_button.Location = new System.Drawing.Point(12, 62);
            this.rectangle_button.Name = "rectangle_button";
            this.rectangle_button.Size = new System.Drawing.Size(159, 44);
            this.rectangle_button.TabIndex = 3;
            this.rectangle_button.Text = "RECTANGLE";
            this.rectangle_button.UseVisualStyleBackColor = false;
            this.rectangle_button.Click += new System.EventHandler(this.rectangle_button_Click);
            // 
            // about_button
            // 
            this.about_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.about_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_button.ForeColor = System.Drawing.Color.SaddleBrown;
            this.about_button.Location = new System.Drawing.Point(12, 394);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(159, 44);
            this.about_button.TabIndex = 4;
            this.about_button.Text = "ABOUT";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // main
            // 
            this.main.Controls.Add(this.message);
            this.main.Location = new System.Drawing.Point(185, 10);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(380, 380);
            this.main.TabIndex = 5;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.message.Location = new System.Drawing.Point(3, 6);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 18);
            this.message.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.rectangle_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.size_button);
            this.Controls.Add(this.quit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Логвинов Лев К3220 Вар. 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button size_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_Rect_button;
        private System.Windows.Forms.Button rectangle_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label message;
    }
}

