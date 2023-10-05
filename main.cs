using System;
using System.Windows.Forms;

namespace testratingscore
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) this.Close(); };
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
        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це програма створена студентом 2-го курсу \n" +
              "Шалімовим О.Є.\n" +
              "Telegram для зв'язку та відгуків:@a_sanya_l","Інформація про ПО");
        }

        private void коефіцієнти1СеместруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject.GetCoefficients(1);
        }

        private void коефіцієнти1СеместруToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Subject.GetCoefficients(2);
        }

        private void коефіцієнти3СеместруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject.GetCoefficients(3);
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
