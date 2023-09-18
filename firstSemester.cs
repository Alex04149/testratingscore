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
    public partial class firstSemester : Form
    {
        public firstSemester()
        {
            InitializeComponent();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            try
            {
                List<Subject> subjects = Subject.getSubject(1);
                subjects[0].Score = int.Parse(higherMath.Text);
                subjects[1].Score = int.Parse(physics.Text);
                subjects[2].Score = int.Parse(informaticks.Text);
                subjects[3].Score = int.Parse(narisna.Text);
                subjects[4].Score = int.Parse(mova.Text);
                subjects[5].Score = int.Parse(vstup.Text);
                subjects[6].Score = int.Parse(english.Text);
                subjects[7].Score = int.Parse(pe.Text);
                if (Subject.check(subjects))
                {
                    double rating = Subject.Calc(subjects);
                    MessageBox.Show("\"Ваш рейтинговий бал у діапазоні (0-90)  = \" " + rating);
                }
            }
            catch
            {
                MessageBox.Show("Заповніть усі поля");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void higherMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
