using System;
using System.Windows.Forms;
using testratingscore.SemestersForm;

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
            var form = new MainForm();
            form.Show();
            form.createTbAndLabel(1);
        }

        private void secondSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainForm();
            form.Show();
            form.createTbAndLabel(2);
        }

        private void thirdSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainForm();
            form.Show();
            form.createTbAndLabel(3);
        }
        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це програма створена студентом 2-го курсу \n" +
             "Шалімовим О.Є.\n" +
             "Telegram для зв'язку та відгуків:@a_sanya_l", "Інформація про ПО");
        }

        
        private void eightSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainForm();  
            form.Show();
        }

        
    }
}
