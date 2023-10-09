using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace testratingscore.SemestersForm
{
    public partial class MainForm : Form
    {
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private int semester = 0;

        public MainForm()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) this.Close(); };
        }
        public  void createTbAndLabel(int semester)
        {
            label1.Visible = true;
            label10.Visible = false;
            var subjects = Subject.getSubject(semester);
            label2.Text = subjects[0].name;
            label3.Text = subjects[1].name;
            label4.Text = subjects[2].name;
            label5.Text = subjects[3].name;
            label6.Text = subjects[4].name;
            label7.Text = subjects[5].name;
            label8.Text = subjects[6].name;
            label9.Text = subjects[7].name;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;


            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

            button1.Visible = true;
        }

        private void getCoefficient(int semester)
        {
            label10.Visible = false;
            label1.Visible = true;
            var subjects = Subject.getSubject(semester);
            label1.Text = "Коефіцієнти " + semester + " семестру ";
            label2.Text = subjects[0].name;
            label3.Text = subjects[1].name;
            label4.Text = subjects[2].name;
            label5.Text = subjects[3].name;
            label6.Text = subjects[4].name;
            label7.Text = subjects[5].name;
            label8.Text = subjects[6].name;
            label9.Text = subjects[7].name;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            textBox1.Visible = true;
            textBox1.Text = subjects[0].Coefficient.ToString();
            textBox2.Visible = true;
            textBox2.Text = subjects[1].Coefficient.ToString();
            textBox3.Visible = true;
            textBox3.Text = subjects[2].Coefficient.ToString();
            textBox4.Visible = true;
            textBox4.Text = subjects[3].Coefficient.ToString();
            textBox5.Visible = true;
            textBox5.Text = subjects[4].Coefficient.ToString();
            textBox6.Visible = true;
            textBox6.Text = subjects[5].Coefficient.ToString();
            textBox7.Visible = true;
            textBox7.Text = subjects[6].Coefficient.ToString();
            textBox8.Visible = true;
            textBox8.Text = subjects[7].Coefficient.ToString();
        }

        private void семестерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            semester = 1;
            createTbAndLabel(semester);
        }

        private void семестерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            semester = 2;
            createTbAndLabel(semester);
        }

        private void семестерToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            semester = 3;
            createTbAndLabel(semester);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Розрахувати")
            {
                var subjects = Subject.getSubject(semester);
                subjects[0].Score = int.Parse(textBox1.Text);
                subjects[1].Score = int.Parse(textBox2.Text);
                subjects[2].Score = int.Parse(textBox3.Text);
                subjects[3].Score = int.Parse(textBox4.Text);
                subjects[4].Score = int.Parse(textBox5.Text);
                subjects[5].Score = int.Parse(textBox6.Text);
                subjects[6].Score = int.Parse(textBox7.Text);
                subjects[7].Score = int.Parse(textBox8.Text);
                if (Subject.check(subjects))
                {
                    double rating = Subject.Calc(subjects);
                    MessageBox.Show("Ваш рейтинговий бал у діапазоні (0-90)  = " + rating, "Рейтинговий бал");
                }
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                button1.Text = "Розрахувати";
            }
        }

        private void семестрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            semester = 1;
            getCoefficient(semester);
        }

        private void семестрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            semester = 2;
            getCoefficient(semester);
        }

        private void семестерToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            semester = 3;
            getCoefficient(semester);
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це програма створена студентом 2-го курсу \n" +
              "Шалімовим О.Є.\n" +
              "Telegram для зв'язку та відгуків:@a_sanya_l", "Інформація про ПО");
        }

        private void формулаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
