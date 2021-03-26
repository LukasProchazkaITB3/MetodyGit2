using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime zarok(DateTime dt)
        {
            return dt.AddYears(1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dnes = DateTime.Today;
            DateTime za100dni = dnes.AddDays(100);
            MessageBox.Show("Za rok bude "+zarok(dnes).ToShortDateString());
            label1.Text = za100dni.ToLongDateString();

        }
    }
}
