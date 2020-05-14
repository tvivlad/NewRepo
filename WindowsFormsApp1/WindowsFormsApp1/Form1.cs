using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = "Hello World!!!";
            button1.Text = "Кнопка";
            Form1.ActiveForm.BackColor = Color.Aqua;

            textBox1.Text="Заполняем textbox";
            textBox1.Text = "обновление текста";
            Form1.ActiveForm.Text = "Привет мир!!!";
            textBox1.Text = "новое обновление!!!";
            textBox1.Text = "Новое обновление 2!!!";
            textBox1.Text="Новое обновление 3";
        }
    }
}
