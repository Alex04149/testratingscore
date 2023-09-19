using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testratingscore
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void firstSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstSemester form = new firstSemester();   
            form.Show();
        }

        private void secondSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            secondSemester form = new secondSemester();
            form.Show();
        }

        private void thirdSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            thirdSemester form = new thirdSemester();   
            form.Show();
        }

        private void sevenSemester_Click(object sender, EventArgs e)
        {

        }
    }
}
