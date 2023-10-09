using System;
using System.Windows.Forms;


namespace testratingscore
{
    public partial class secondSemester : Form
    {

        public string Symbol { get; private set; }

        public secondSemester()
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
                    var subjects = Subject.getSubject(2);
                    subjects[0].Score = int.Parse(higherMath.Text);
                    subjects[1].Score = int.Parse(physics.Text);
                    subjects[2].Score = int.Parse(informaticks.Text);
                    subjects[3].Score = int.Parse(history.Text);
                    subjects[4].Score = int.Parse(TheoryOfDigitalAutomata.Text);
                    subjects[5].Score = int.Parse(eco.Text);
                    subjects[6].Score = int.Parse(english.Text);
                    subjects[7].Score = int.Parse(pe.Text);
                    if (Subject.check(subjects))
                    {
                        double rating = Subject.Calc(subjects);
                        MessageBox.Show("Ваш рейтинговий бал у діапазоні (0-90)  = " + rating);
                    }
                    higherMath.Text = null;
                    physics.Text = null;
                    informaticks.Text = null;
                    TheoryOfDigitalAutomata.Text = null;
                    history.Text = null;
                    eco.Text = null;
                    english.Text = null;
                    pe.Text = null;

                    higherMath.Enabled = false;
                    physics.Enabled = false;
                    informaticks.Enabled = false;
                    history.Enabled = false;
                    TheoryOfDigitalAutomata.Enabled = false;
                    eco.Enabled = false;
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
                history.Enabled = true;
                TheoryOfDigitalAutomata.Enabled = true;
                eco.Enabled = true;
                english.Enabled = true;
                pe.Enabled = true;
                Get.Text = "Розрахувати";
                higherMath.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new thirdSemester();
            form1.Show();
        }


        private void higherMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new firstSemester();
            form1.Show();
        }

        private void secondSemester_Load(object sender, EventArgs e)
        {

        }
    }
}
