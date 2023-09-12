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
    public partial class secondSemester : Form
    {
        public secondSemester()
        {
            InitializeComponent();
        }

    private void Get_Click(object sender, EventArgs e)
        {

            List<Subject> subjects = Subject.getSubject(2);
            subjects[0].Score = int.Parse(phisics.Text);
            subjects[1].Score = int.Parse(higherMath.Text);
            subjects[2].Score = int.Parse(informaticks.Text);
            subjects[3].Score = int.Parse(history.Text);
            subjects[4].Score = int.Parse(TheoryOfDigitalAutomata.Text);
            subjects[5].Score = int.Parse(eco.Text);
            subjects[6].Score = int.Parse(english.Text);
            subjects[7].Score = int.Parse(pe.Text);
            double rating = Subject.Calc(subjects);
            MessageBox.Show("Ваш рейтинговий бал " + rating);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();  
            form1.Show();
        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void history_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void eco_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondSemester_Load(object sender, EventArgs e)
        {

        }
    }
}
