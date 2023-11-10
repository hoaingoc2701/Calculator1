using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            Class1 c = new Class1(a, b);

            kq = c.Execute("+");
            txtKq.Text = kq.ToString();


        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            Class1 c = new Class1(a, b);

            kq = c.Execute("-");
            txtKq.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            Class1 c = new Class1(a, b);

            kq = c.Execute("*");
            txtKq.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            Class1 c = new Class1(a, b);
            if (b != 0)
            {
                kq = c.Execute("/");
                txtKq.Text = kq.ToString();
            }
            else
                txtKq.Text = "Không thể chia cho 0!";
        }
    }
}
