using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Prak01
{
    public partial class Form1 : Form
    {
        int A, B;
        Color rect_color;

        Panel rectangle = new Panel();

        public Form1()
        {
            InitializeComponent();
            main.Controls.Add(rectangle);
        }

        private void size_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void submit_Rect_button_Click(object sender, EventArgs e)
        {
            try
            {
                A = int.Parse(textBox1.Text);
                B = int.Parse(textBox2.Text);
            }
            catch (Exception exeption)
            {
                A = -1; B = -1;
            }

            if (radioButton1.Checked) { rect_color = Color.Red; }
            if (radioButton2.Checked) { rect_color = Color.Green; }
            if (radioButton3.Checked) { rect_color = Color.Blue; }

            Thread.Sleep(100);
            panel1.Visible = false;
            rectangle_button.Enabled = true;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            message.Text = "Эта программа написана Логвиновым Львом\nгруппа К3220";
            rectangle.Visible = false;
            message.Visible = true;
        }

        private void rectangle_button_Click(object sender, EventArgs e)
        {
            int maxSize = main.Width;
            
            if (A > 0 & B > 0 & A <= maxSize & B <= maxSize)
            {
                rectangle.Size = new Size(A, B);
                rectangle.BackColor = rect_color;
                message.Visible = false;
                rectangle.Visible = true;
            }
            else
            {
                message.Text = "Вы ввели недопустимый размер";
                rectangle.Visible = false;
                message.Visible = true;
            }
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
