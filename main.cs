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
        
        private void eightSemester_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainForm();  
            form.Show();
        }    }
}
