using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testratingscore
{
    public partial class firstSemester : Form
    {
        public firstSemester()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) this.Close(); };
        }

        private void Get_Click(object sender, EventArgs e)
        {
            if (Get.Text == "Розрахувати")
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
                    Subject.check(subjects);
                    if (Subject.check(subjects))
                    {
                        double rating = Subject.Calc(subjects);
                        MessageBox.Show("Ваш рейтинговий бал у діапазоні (0-90)  = " + rating);
                    }
                    higherMath.Text = null;
                    physics.Text = null;
                    informaticks.Text = null;
                    narisna.Text = null;
                    mova.Text = null;
                    vstup.Text = null;
                    english.Text = null;
                    pe.Text = null;

                    higherMath.Enabled = false;
                    physics.Enabled = false;
                    informaticks.Enabled = false;
                    narisna.Enabled = false;
                    mova.Enabled = false;
                    vstup.Enabled = false;
                    english.Enabled = false;
                    pe.Enabled = false;
                    Get.Text = "Почати знову";
                }
                catch
                {
                    MessageBox.Show("Заповніть усі поля");
                }
            }
            else
            {
                higherMath.Enabled = true;
                physics.Enabled = true;
                informaticks.Enabled = true;
                narisna.Enabled = true;
                mova.Enabled = true;
                vstup.Enabled = true;
                english.Enabled = true;
                pe.Enabled = true;
                Get.Text = "Розрахувати";
                higherMath.Focus();
            }
        }
        private void higherMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var secondSemester = new secondSemester();
            secondSemester.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main main = new main();
            main.Show();
        }
    }
}
