using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalesQuiz
{
    public partial class ScalesQuiz : Form
    {
        public static string[] selectedScale;

        public ScalesQuiz()
        {
            InitializeComponent();
        }

        private void nextScale(int m)
        {
            
            Label[] allLabels = { Note1, Note2, Note3, Note4, Note5, Note6, Note7, Note8 };


            Random randm = new Random();

            if (m == 0)
            {
                selectedScale = CircleOfFifths.getMajorScale(randm.Next(1, 15));
                ScaleIntro.Text = "Please give the " + selectedScale[0] + " major scale!";
            }
            else
            {
                selectedScale = CircleOfFifths.getMinorScale(randm.Next(1, 15));
                ScaleIntro.Text = "Please give the " + selectedScale[0] + " minor scale!";
            }
            
            int noteNumber = Notes.findNote(selectedScale[0]);

            Note1.Text = selectedScale[0];
            Note8.Text = selectedScale[0];
            for (int i = 1; i < allLabels.Length - 1; i++)
            {
                noteNumber++;
                allLabels[i].Text = Notes.allNotes[noteNumber % 7];
            }
            
        }

        private void Form1_Load(object sender, EventArgs ev)
        {
            nextScale(0);
            


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        // Note 2
        private void Note2Sharp_Click(object sender, EventArgs e)
        {
            Note2.Text = Note2.Text[0].ToString() + "#";
        }
        private void Note2Natural_Click(object sender, EventArgs e)
        {
            Note2.Text = Note2.Text[0].ToString();
        }
        private void Note2Flat_Click(object sender, EventArgs e)
        {
            Note2.Text = Note2.Text[0].ToString() + "b";
        }
        
        
        // Note 3
        private void Note3Sharp_Click(object sender, EventArgs e)
        {
            Note3.Text = Note3.Text[0].ToString() + "#";
        }

        private void Note3Natural_Click(object sender, EventArgs e)
        {
            Note3.Text = Note3.Text[0].ToString();
        }

        private void Note3Flat_Click(object sender, EventArgs e)
        {
            Note3.Text = Note3.Text[0].ToString() + "b";
        }

        // Note 4
        private void Note4Sharp_Click(object sender, EventArgs e)
        {
            Note4.Text = Note4.Text[0].ToString() + "#";
        }

        private void Note4Natural_Click(object sender, EventArgs e)
        {
            Note4.Text = Note4.Text[0].ToString();
        }

        private void Note4Flat_Click(object sender, EventArgs e)
        {
            Note4.Text = Note4.Text[0].ToString() + "b";
        }

        // Note 5
        private void Note5Sharp_Click(object sender, EventArgs e)
        {
            Note5.Text = Note5.Text[0].ToString() + "#";
        }

        private void Note5Natural_Click(object sender, EventArgs e)
        {
            Note5.Text = Note5.Text[0].ToString();
        }

        private void Note5Flat_Click(object sender, EventArgs e)
        {
            Note5.Text = Note5.Text[0].ToString() + "b";
        }

        // Note 6
        private void Note6Sharp_Click(object sender, EventArgs e)
        {
            Note6.Text = Note6.Text[0].ToString() + "#";
        }

        private void Note6Natural_Click(object sender, EventArgs e)
        {
            Note6.Text = Note6.Text[0].ToString();
        }

        private void Note6Flat_Click(object sender, EventArgs e)
        {
            Note6.Text = Note6.Text[0].ToString() + "b";
        }

        // Note 7
        private void Note7Sharp_Click(object sender, EventArgs e)
        {
            Note7.Text = Note7.Text[0].ToString() + "#";
        }

        private void Note7Natural_Click(object sender, EventArgs e)
        {
            Note7.Text = Note7.Text[0].ToString();
        }

        private void Note7Flat_Click(object sender, EventArgs e)
        {
            Note7.Text = Note7.Text[0].ToString() + "b";
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                nextScale(0);
            }
            else
            {
                nextScale(1);
            }
        }

        private void CheckAnswer_Click(object sender, EventArgs e)
        {
            Label[] allLabels = { Note1, Note2, Note3, Note4, Note5, Note6, Note7, Note8 };

            string wrongAnswers = "";

            for (int i = 0; i < allLabels.Length; i++)
            {
                if (selectedScale[i] != allLabels[i].Text)
                {
                    wrongAnswers += "\n" + selectedScale[i] + " not " + allLabels[i].Text;
                }
            }
            if (wrongAnswers == "")
            {
                MessageBox.Show("Correct! Well Done", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(wrongAnswers, "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (radioButton1.Checked)
            {
                nextScale(0);
            }
            else
            {
                nextScale(1);
            }
        }
    }

    public static class Notes
    {
        public static string[] allNotes = { "A", "B", "C", "D", "E", "F", "G" };

        public static int findNote(string note)
        {
            for (int i = 0; i < allNotes.Length; i++)
            {
                if (allNotes[i] == note[0].ToString())
                {
                    return i;
                }
            }
            return -1;
        }

    }
        public static class CircleOfFifths
        {



            // ================== Major ===========================

            // C
            public static string[] C = new string[8] { "C", "D", "E", "F", "G", "A", "B", "C" };

            // Sharps
            public static string[] G = new string[8] { "G", "A", "B", "C", "D", "E", "F#", "G" };
            public static string[] D = new string[8] { "D", "E", "F#", "G", "A", "B", "C#", "D" };
            public static string[] A = new string[8] { "A", "B", "C#", "D", "E", "F#", "G#", "A" };
            public static string[] E = new string[8] { "E", "F#", "G#", "A", "B", "C#", "D#", "E" };
            public static string[] B = new string[8] { "B", "C#", "D#", "E", "F#", "G#", "A#", "B" };
            public static string[] Fs = new string[8] { "F#", "G#", "A#", "B", "C#", "D#", "E#", "F#" };
            public static string[] Cs = new string[8] { "C#", "D#", "E#", "F#", "G#", "A#", "B#", "C#" };

            // Flats
            public static string[] F = new string[8] { "F", "G", "A", "Bb", "C", "D", "E", "F" };
            public static string[] Bb = new string[8] { "Bb", "C", "D", "Eb", "F", "G", "A", "Bb" };
            public static string[] Eb = new string[8] { "Eb", "F", "G", "Ab", "Bb", "C", "D", "Eb" };
            public static string[] Ab = new string[8] { "Ab", "Bb", "C", "Db", "Eb", "F", "G", "Ab" };
            public static string[] Db = new string[8] { "Db", "Eb", "F", "Gb", "Ab", "Bb", "C", "Db" };
            public static string[] Gb = new string[8] { "Gb", "Ab", "Bb", "Cb", "Db", "Eb", "F", "Gb" };
            public static string[] Cb = new string[8] { "Cb", "Db", "Eb", "Fb", "Gb", "Ab", "Bb", "Cb" };

            // ===================================================

            // ================= Minor ===========================

            // Am
            public static string[] Am = new string[8] { "A", "B", "C", "D", "E", "F", "G", "A" };

            // Sharps
            public static string[] Em = new string[8] { "E", "F#", "G", "A", "B", "C", "D", "E" };
            public static string[] Bm = new string[8] { "B", "C#", "D", "E", "F#", "G", "A", "B" };
            public static string[] Fsm = new string[8] { "F#", "G#", "A", "B", "C#", "D", "E", "F#" };
            public static string[] Csm = new string[8] { "C#", "D#", "E", "F#", "G#", "A", "B", "C#" };
            public static string[] Gsm = new string[8] { "G#", "A#", "B", "C#", "D#", "E", "F#", "G#" };
            public static string[] Dsm = new string[8] { "D#", "E#", "F#", "G#", "A#", "B", "C#", "D#" };
            public static string[] Asm = new string[8] { "A#", "B#", "C#", "D#", "E#", "F#", "G#", "A#" };

            // Flats
            public static string[] Dm = new string[8] { "D", "E", "F", "G", "A", "Bb", "C", "D" };
            public static string[] Gm = new string[8] { "G", "A", "Bb", "C", "D", "Eb", "F", "G" };
            public static string[] Cm = new string[8] { "C", "D", "Eb", "F", "G", "Ab", "Bb", "C" };
            public static string[] Fm = new string[8] { "F", "G", "Ab", "Bb", "C", "Db", "Eb", "F" };
            public static string[] Bbm = new string[8] { "Bb", "C", "Db", "Eb", "F", "Gb", "Ab", "Bb" };
            public static string[] Ebm = new string[8] { "Eb", "F", "Gb", "Ab", "Bb", "Cb", "Db", "Eb" };
            public static string[] Abm = new string[8] { "Ab", "Bb", "Cb", "Db", "Eb", "Fb", "Gb", "Ab" };

            // ===================================================
           


        public static string[] getMajorScale(int i)
        {
            switch (i)
            {
                case 1:
                    return C;
                case 2:
                    return G;
                case 3:
                    return D;
                case 4:
                    return A;
                case 5:
                    return E;
                case 6:
                    return B;
                case 7:
                    return Fs;
                case 8:
                    return Cs;
                case 9:
                    return F;
                case 10:
                    return Bb;
                case 11:
                    return Eb;
                case 12:
                    return Ab;
                case 13:
                    return Db;
                case 14:
                    return Gb;
                case 15:
                    return Cb;
            }
            return C;
        } 
        public static string[] getMinorScale(int i)
        {
            switch (i)
            {
                case 1:
                    return Am;
                case 2:
                    return Em;
                case 3:
                    return Bm;
                case 4:
                    return Fsm;
                case 5:
                    return Csm;
                case 6:
                    return Gsm;
                case 7:
                    return Dsm;
                case 8:
                    return Asm;
                case 9:
                    return Dm;
                case 10:
                    return Gm;
                case 11:
                    return Cm;
                case 12:
                    return Fm;
                case 13:
                    return Bbm;
                case 14:
                    return Ebm;
                case 15:
                    return Abm;
            }
            return C;
        }
    }
}
