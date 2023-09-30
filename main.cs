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

        private void sevenSemester_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це програма створена студентом 2-го курсу \n" +
                "Шалімовим О.Є.\n" +
                "Telegram для зв'язку та відгуків:@a_sanya_l");
        
        }

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
