using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testratingscore
{         public class Subject
        {
        public const double maxAssessmentOfDiscipline = 90.0;
        public const int maxAssessmentOfRating = 100;
        public int Coefficient;
        public  string name { get; set; }
        public static List<Subject> getSubject(int semester)
            {
                List<Subject> subject = new List<Subject>();
                subject.Add(new Subject());
                switch (semester)
                {
                    case 1:
                        subject.AddRange(new Subject[7]);
                        for (int i = 0; i < subject.Count; i++)
                        { subject[i] = new Subject(); }
                        subject[0].name = LanguageSubject.Math;
                        subject[0].Coefficient = 6;
                        subject[1].name = LanguageSubject.Physics;
                        subject[1].Coefficient = 5;
                        subject[2].name = LanguageSubject.Informatics;
                        subject[2].Coefficient = 4;
                        subject[3].name = LanguageSubject.Grafics;
                        subject[3].Coefficient = 5;
                        subject[4].name = LanguageSubject.ukrainianLanguage;
                        subject[4].Coefficient = 3;
                        subject[5].name = LanguageSubject.introductionToSpecialty;
                        subject[5].Coefficient = 3;
                        subject[6].name = LanguageSubject.english;
                        subject[6].Coefficient = 2;
                        subject[7].name = LanguageSubject.PE;
                        subject[7].Coefficient = 2;
                        break;
                    case 2:
                        subject.AddRange(new Subject[8]);
                        for (int i = 0; i < subject.Count; i++)
                        { subject[i] = new Subject(); }
                        subject[0].name = LanguageSubject.Math;
                        subject[0].Coefficient = 6;
                        subject[1].name = LanguageSubject.Physics;
                        subject[1].Coefficient = 5;
                        subject[2].name = LanguageSubject.Informatics;
                        subject[2].Coefficient = 4;
                        subject[3].name = LanguageSubject.history;
                        subject[3].Coefficient = 4;
                        subject[4].name = LanguageSubject.theoryOfDigitalAutomata;
                        subject[4].Coefficient = 4;
                        subject[5].name = LanguageSubject.ecology;
                        subject[5].Coefficient = 3;
                        subject[6].name = LanguageSubject.english;
                        subject[6].Coefficient = 2;
                        subject[7].name = LanguageSubject.PE;
                        subject[7].Coefficient = 2;
                        break;
                    case 3:
                        subject.AddRange(new Subject[8]);
                        for (int i = 0; i < subject.Count; i++)
                        { subject[i] = new Subject(); }
                        subject[0].name = LanguageSubject.Math;
                        subject[0].Coefficient = 6;
                        subject[1].name = LanguageSubject.electricalEngineeringAndElectromechanics;
                        subject[1].Coefficient = 6;
                        subject[2].name = LanguageSubject.Physics;
                        subject[2].Coefficient = 3;
                        subject[3].name = LanguageSubject.informationTechnologyAndProgramming;
                        subject[3].Coefficient = 5;
                        subject[4].name = LanguageSubject.phylosophy;
                        subject[4].Coefficient = 3;
                        subject[5].name = LanguageSubject.english;
                        subject[5].Coefficient = 2;
                        subject[6].name = LanguageSubject.appliedMechanics;
                        subject[6].Coefficient = 2;
                        subject[7].name = LanguageSubject.PE;
                        subject[7].Coefficient = 2;
                        break;

                    default:
                        break;
                }
                return subject;
            }
            private int score;
            public int Score
            {
                get { return score; }
                set
                {
                    if (score >= 0 && score <= 100)
                {

                    score = value;
                }
                else
                {
                    MessageBox.Show("Введіть бал в діапазоні 0-100 з дисципліни" + name);
                        score = int.MaxValue;
                }
            }

        }
        static public bool check(List<Subject> subjects)
        {
            bool check = true;
            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].Score<0 || subjects[i].Score > 100)
                {
                    check = false;
                    MessageBox.Show("Введіть верні значення з предмету" + subjects[i].name);
                }
            }
            return check;
        }
        static public double Calc(List<Subject> subjects)
        {
            int sumScoreAndCoefficient = 0;
            int sumCoefficient = 0;
            double rating;
             for (int i = 0; i < subjects.Count; i++)
                {
                    int temp;
                    temp = subjects[i].Score * subjects[i].Coefficient;
                    sumScoreAndCoefficient += temp;
                    sumCoefficient += subjects[i].Coefficient;
                }
                rating = (Subject.maxAssessmentOfDiscipline * sumScoreAndCoefficient) / (sumCoefficient * Subject.maxAssessmentOfRating);
                return rating; 
            
        }
        }
    }
