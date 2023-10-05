﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testratingscore
{
    public partial class thirdSemester : Form
    {
        public thirdSemester()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) this.Close(); };
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             this.Hide();
             var form1 = new secondSemester();
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

        private void Get_Click_1(object sender, EventArgs e)
        {
            if (Get.Text == "Розрахувати")
            {
                try
                {
                    List<Subject> subjects = Subject.getSubject(3);
                    subjects[0].Score = int.Parse(higherMath.Text);
                    subjects[1].Score = int.Parse(electtricalEngineering.Text);
                    subjects[2].Score = int.Parse(physics.Text);
                    subjects[3].Score = int.Parse(philosophy.Text);
                    subjects[4].Score = int.Parse(programming.Text);
                    subjects[5].Score = int.Parse(english.Text);
                    subjects[6].Score = int.Parse(mechanics.Text);
                    subjects[7].Score = int.Parse(pe.Text);
                    if (Subject.check(subjects))
                    {
                        double rating = Subject.Calc(subjects);
                        MessageBox.Show("Ваш рейтинговий бал у діапазоні (0-90)  = " + rating);
                    }
                }
                catch
                {
                    MessageBox.Show("Заповніть усі поля");
                }
                higherMath.Text = null;
                electtricalEngineering.Text = null;
                physics.Text = null;    
                philosophy.Text = null;
                programming.Text = null;
                english.Text = null;
                mechanics.Text = null; 
                pe.Text = null;

                higherMath.Enabled = false;
                electtricalEngineering.Enabled = false;
                physics.Enabled = false;
                philosophy.Enabled = false;
                programming.Enabled = false;
                english.Enabled = false;
                mechanics.Enabled = false;
                pe.Enabled = false;
                english.Enabled = false;
                Get.Text = "Почати знов";
            }
            else
            {
                Get.Text = "Розрахувати";
                higherMath.Enabled = true;
                electtricalEngineering.Enabled = true;
                physics.Enabled = true;   
                philosophy.Enabled = true;
                programming.Enabled = true;
                english.Enabled = true;
                mechanics.Enabled = true;
                pe.Enabled = true;
                english.Enabled = true;
                higherMath.Focus();
            }
        }

        private void thirdSemester_Load(object sender, EventArgs e)
        {

        }
    }
}