using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int num = 0;
            // преобразую строку в число
            if (int.TryParse(s, out num))
            {
                // если получилось  то в заголовок
                this.Text = num.ToString();
            }
            else
            {
                // если нет, то в статус бар
                toolStripStatusLabel1.Text = s;
            }
            
        }
    }
}
