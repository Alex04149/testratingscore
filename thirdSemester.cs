using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testratingscore
{
    public partial class thirdSemester : Form
    {
        public thirdSemester()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Get_Click(object sender, EventArgs e)
        {

            List<Subject> subjects = Subject.getSubject(2);
            subjects[0].Score = int.Parse(higherMath.Text);
            subjects[1].Score = int.Parse(electtricalEngineering.Text);
            subjects[2].Score = int.Parse(physics.Text);
            subjects[3].Score = int.Parse(philosophy.Text);
            subjects[4].Score = int.Parse(programming.Text);
            subjects[5].Score = int.Parse(english.Text);
            subjects[6].Score = int.Parse(mechanics.Text);
            subjects[7].Score = int.Parse(pe.Text);
            double rating = Subject.Calc(subjects);
            MessageBox.Show("Ваш рейтинговий бал = " + rating);
        }

    }
}
