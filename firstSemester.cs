using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testratingscore
{
    public partial class firstSemester : Form
    {
        public firstSemester()
        {
            this.ActiveControl = physiks; 
            InitializeComponent();
        }

        private void Get_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Subject> subjects = Subject.getSubject(1);
                subjects[0].Score = int.Parse(physiks.Text);
                subjects[1].Score = int.Parse(physiks.Text);
                subjects[2].Score = int.Parse(informaticks.Text);
                subjects[3].Score = int.Parse(graficks.Text);
                subjects[4].Score = int.Parse(mova.Text);
                subjects[5].Score = int.Parse(vstup.Text);
                subjects[6].Score = int.Parse(english.Text);
                subjects[7].Score = int.Parse(pe.Text);
                double rating = Subject.Calc(subjects);
                MessageBox.Show("Ваш рейтинговий бал " + rating);
            }
            catch { MessageBox.Show("Введіть коректні значення");}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void highertMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
