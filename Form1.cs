using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using testratingscore.Properties;

namespace testratingscore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void firstSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstSemester firstSemester = new firstSemester();       
            firstSemester.Show(); 
        }
        private void secondSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            secondSemester secondSemester = new secondSemester();
            secondSemester.Show();  
        }

        private void sixSemester_Click(object sender, EventArgs e)
        {

        }

        private void thirdSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            thirdSemester thirdSemester = new thirdSemester();
            thirdSemester.Show();
        }
    }
}
