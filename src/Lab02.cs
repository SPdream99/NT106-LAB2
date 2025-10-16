using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void Bai1Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai01();
            form.ShowDialog();
        }

        private void Bai2Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai02();
            form.ShowDialog();
        }

        private void Bai3Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai03();
            form.ShowDialog();
        }

        private void Bai4Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai04();
            form.ShowDialog();
        }

        private void Bai5Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai05();
            form.ShowDialog();
        }

        private void Bai6Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai06();
            form.ShowDialog();
        }

        private void Bai7Button_Click(object sender, EventArgs e)
        {
            var form = new Lab02_Bai07();
            form.ShowDialog();
        }
    }
}
