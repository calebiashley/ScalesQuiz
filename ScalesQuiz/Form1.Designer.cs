using System;

namespace ScalesQuiz
{
    partial class ScalesQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Note2Natural = new System.Windows.Forms.Button();
            this.Note2Sharp = new System.Windows.Forms.Button();
            this.Note2Flat = new System.Windows.Forms.Button();
            this.Note1 = new System.Windows.Forms.Label();
            this.Note2 = new System.Windows.Forms.Label();
            this.Note3 = new System.Windows.Forms.Label();
            this.Note3Flat = new System.Windows.Forms.Button();
            this.Note3Sharp = new System.Windows.Forms.Button();
            this.Note3Natural = new System.Windows.Forms.Button();
            this.Note4 = new System.Windows.Forms.Label();
            this.Note4Flat = new System.Windows.Forms.Button();
            this.Note4Sharp = new System.Windows.Forms.Button();
            this.Note4Natural = new System.Windows.Forms.Button();
            this.Note5 = new System.Windows.Forms.Label();
            this.Note5Flat = new System.Windows.Forms.Button();
            this.Note5Sharp = new System.Windows.Forms.Button();
            this.Note5Natural = new System.Windows.Forms.Button();
            this.Note6 = new System.Windows.Forms.Label();
            this.Note6Flat = new System.Windows.Forms.Button();
            this.Note6Sharp = new System.Windows.Forms.Button();
            this.Note6Natural = new System.Windows.Forms.Button();
            this.Note7 = new System.Windows.Forms.Label();
            this.Note7Flat = new System.Windows.Forms.Button();
            this.Note7Sharp = new System.Windows.Forms.Button();
            this.Note7Natural = new System.Windows.Forms.Button();
            this.Note8 = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.ScaleIntro = new System.Windows.Forms.Label();
            this.CheckAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Your Scale Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(388, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Major Scales";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(492, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Minor Scales";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Note2Natural
            // 
            this.Note2Natural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note2Natural.Location = new System.Drawing.Point(117, 269);
            this.Note2Natural.Name = "Note2Natural";
            this.Note2Natural.Size = new System.Drawing.Size(31, 23);
            this.Note2Natural.TabIndex = 3;
            this.Note2Natural.Text = "♮";
            this.Note2Natural.UseVisualStyleBackColor = true;
            this.Note2Natural.Click += new System.EventHandler(this.Note2Natural_Click);
            // 
            // Note2Sharp
            // 
            this.Note2Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note2Sharp.Location = new System.Drawing.Point(117, 240);
            this.Note2Sharp.Name = "Note2Sharp";
            this.Note2Sharp.Size = new System.Drawing.Size(31, 23);
            this.Note2Sharp.TabIndex = 4;
            this.Note2Sharp.Text = "♯";
            this.Note2Sharp.UseVisualStyleBackColor = true;
            this.Note2Sharp.Click += new System.EventHandler(this.Note2Sharp_Click);
            // 
            // Note2Flat
            // 
            this.Note2Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note2Flat.Location = new System.Drawing.Point(117, 298);
            this.Note2Flat.Name = "Note2Flat";
            this.Note2Flat.Size = new System.Drawing.Size(31, 23);
            this.Note2Flat.TabIndex = 5;
            this.Note2Flat.Text = "♭";
            this.Note2Flat.UseVisualStyleBackColor = true;
            this.Note2Flat.Click += new System.EventHandler(this.Note2Flat_Click);
            // 
            // Note1
            // 
            this.Note1.AutoSize = true;
            this.Note1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note1.Location = new System.Drawing.Point(12, 269);
            this.Note1.Name = "Note1";
            this.Note1.Size = new System.Drawing.Size(87, 31);
            this.Note1.TabIndex = 6;
            this.Note1.Text = "Note1";
            // 
            // Note2
            // 
            this.Note2.AutoSize = true;
            this.Note2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note2.Location = new System.Drawing.Point(154, 269);
            this.Note2.Name = "Note2";
            this.Note2.Size = new System.Drawing.Size(87, 31);
            this.Note2.TabIndex = 7;
            this.Note2.Text = "Note2";
            // 
            // Note3
            // 
            this.Note3.AutoSize = true;
            this.Note3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note3.Location = new System.Drawing.Point(279, 269);
            this.Note3.Name = "Note3";
            this.Note3.Size = new System.Drawing.Size(87, 31);
            this.Note3.TabIndex = 11;
            this.Note3.Text = "Note3";
            // 
            // Note3Flat
            // 
            this.Note3Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note3Flat.Location = new System.Drawing.Point(242, 298);
            this.Note3Flat.Name = "Note3Flat";
            this.Note3Flat.Size = new System.Drawing.Size(31, 23);
            this.Note3Flat.TabIndex = 10;
            this.Note3Flat.Text = "♭";
            this.Note3Flat.UseVisualStyleBackColor = true;
            this.Note3Flat.Click += new System.EventHandler(this.Note3Flat_Click);
            // 
            // Note3Sharp
            // 
            this.Note3Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note3Sharp.Location = new System.Drawing.Point(242, 240);
            this.Note3Sharp.Name = "Note3Sharp";
            this.Note3Sharp.Size = new System.Drawing.Size(31, 23);
            this.Note3Sharp.TabIndex = 9;
            this.Note3Sharp.Text = "♯";
            this.Note3Sharp.UseVisualStyleBackColor = true;
            this.Note3Sharp.Click += new System.EventHandler(this.Note3Sharp_Click);
            // 
            // Note3Natural
            // 
            this.Note3Natural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note3Natural.Location = new System.Drawing.Point(242, 269);
            this.Note3Natural.Name = "Note3Natural";
            this.Note3Natural.Size = new System.Drawing.Size(31, 23);
            this.Note3Natural.TabIndex = 8;
            this.Note3Natural.Text = "♮";
            this.Note3Natural.UseVisualStyleBackColor = true;
            this.Note3Natural.Click += new System.EventHandler(this.Note3Natural_Click);
            // 
            // Note4
            // 
            this.Note4.AutoSize = true;
            this.Note4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note4.Location = new System.Drawing.Point(405, 269);
            this.Note4.Name = "Note4";
            this.Note4.Size = new System.Drawing.Size(87, 31);
            this.Note4.TabIndex = 15;
            this.Note4.Text = "Note4";
            // 
            // Note4Flat
            // 
            this.Note4Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note4Flat.Location = new System.Drawing.Point(368, 298);
            this.Note4Flat.Name = "Note4Flat";
            this.Note4Flat.Size = new System.Drawing.Size(31, 23);
            this.Note4Flat.TabIndex = 14;
            this.Note4Flat.Text = "♭";
            this.Note4Flat.UseVisualStyleBackColor = true;
            this.Note4Flat.Click += new System.EventHandler(this.Note4Flat_Click);
            // 
            // Note4Sharp
            // 
            this.Note4Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note4Sharp.Location = new System.Drawing.Point(368, 240);
            this.Note4Sharp.Name = "Note4Sharp";
            this.Note4Sharp.Size = new System.Drawing.Size(31, 23);
            this.Note4Sharp.TabIndex = 13;
            this.Note4Sharp.Text = "♯";
            this.Note4Sharp.UseVisualStyleBackColor = true;
            this.Note4Sharp.Click += new System.EventHandler(this.Note4Sharp_Click);
            // 
            // Note4Natural
            // 
            this.Note4Natural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note4Natural.Location = new System.Drawing.Point(368, 269);
            this.Note4Natural.Name = "Note4Natural";
            this.Note4Natural.Size = new System.Drawing.Size(31, 23);
            this.Note4Natural.TabIndex = 12;
            this.Note4Natural.Text = "♮";
            this.Note4Natural.UseVisualStyleBackColor = true;
            this.Note4Natural.Click += new System.EventHandler(this.Note4Natural_Click);
            // 
            // Note5
            // 
            this.Note5.AutoSize = true;
            this.Note5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note5.Location = new System.Drawing.Point(529, 269);
            this.Note5.Name = "Note5";
            this.Note5.Size = new System.Drawing.Size(87, 31);
            this.Note5.TabIndex = 19;
            this.Note5.Text = "Note5";
            // 
            // Note5Flat
            // 
            this.Note5Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note5Flat.Location = new System.Drawing.Point(492, 298);
            this.Note5Flat.Name = "Note5Flat";
            this.Note5Flat.Size = new System.Drawing.Size(31, 23);
            this.Note5Flat.TabIndex = 18;
            this.Note5Flat.Text = "♭";
            this.Note5Flat.UseVisualStyleBackColor = true;
            this.Note5Flat.Click += new System.EventHandler(this.Note5Flat_Click);
            // 
            // Note5Sharp
            // 
            this.Note5Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note5Sharp.Location = new System.Drawing.Point(492, 240);
            this.Note5Sharp.Name = "Note5Sharp";
            this.Note5Sharp.Size = new System.Drawing.Size(31, 23);
            this.Note5Sharp.TabIndex = 17;
            this.Note5Sharp.Text = "♯";
            this.Note5Sharp.UseVisualStyleBackColor = true;
            this.Note5Sharp.Click += new System.EventHandler(this.Note5Sharp_Click);
            // 
            // Note5Natural
            // 
            this.Note5Natural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note5Natural.Location = new System.Drawing.Point(492, 269);
            this.Note5Natural.Name = "Note5Natural";
            this.Note5Natural.Size = new System.Drawing.Size(31, 23);
            this.Note5Natural.TabIndex = 16;
            this.Note5Natural.Text = "♮";
            this.Note5Natural.UseVisualStyleBackColor = true;
            this.Note5Natural.Click += new System.EventHandler(this.Note5Natural_Click);
            // 
            // Note6
            // 
            this.Note6.AutoSize = true;
            this.Note6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note6.Location = new System.Drawing.Point(644, 269);
            this.Note6.Name = "Note6";
            this.Note6.Size = new System.Drawing.Size(87, 31);
            this.Note6.TabIndex = 23;
            this.Note6.Text = "Note6";
            // 
            // Note6Flat
            // 
            this.Note6Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note6Flat.Location = new System.Drawing.Point(607, 298);
            this.Note6Flat.Name = "Note6Flat";
            this.Note6Flat.Size = new System.Drawing.Size(31, 23);
            this.Note6Flat.TabIndex = 22;
            this.Note6Flat.Text = "♭";
            this.Note6Flat.UseVisualStyleBackColor = true;
            this.Note6Flat.Click += new System.EventHandler(this.Note6Flat_Click);
            // 
            // Note6Sharp
            // 
            this.Note6Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note6Sharp.Location = new System.Drawing.Point(607, 240);
            this.Note6Sharp.Name = "Note6Sharp";
            this.Note6Sharp.Size = new System.Drawing.Size(31, 23);
            this.Note6Sharp.TabIndex = 21;
            this.Note6Sharp.Text = "♯";
            this.Note6Sharp.UseVisualStyleBackColor = true;
            this.Note6Sharp.Click += new System.EventHandler(this.Note6Sharp_Click);
            // 
            // Note6Natural
            // 
            this.Note6Natural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note6Natural.Location = new System.Drawing.Point(607, 269);
            this.Note6Natural.Name = "Note6Natural";
            this.Note6Natural.Size = new System.Drawing.Size(31, 23);
            this.Note6Natural.TabIndex = 20;
            this.Note6Natural.Text = "♮";
            this.Note6Natural.UseVisualStyleBackColor = true;
            this.Note6Natural.Click += new System.EventHandler(this.Note6Natural_Click);
            // 
            // Note7
            // 
            this.Note7.AutoSize = true;
            this.Note7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note7.Location = new System.Drawing.Point(768, 269);
            this.Note7.Name = "Note7";
            this.Note7.Size = new System.Drawing.Size(87, 31);
            this.Note7.TabIndex = 27;
            this.Note7.Text = "Note7";
            // 
            // Note7Flat
            // 
            this.Note7Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note7Flat.Location = new System.Drawing.Point(731, 298);
            this.Note7Flat.Name = "Note7Flat";
            this.Note7Flat.Size = new System.Drawing.Size(31, 23);
            this.Note7Flat.TabIndex = 26;
            this.Note7Flat.Text = "♭";
            this.Note7Flat.UseVisualStyleBackColor = true;
            this.Note7Flat.Click += new System.EventHandler(this.Note7Flat_Click);
            // 
            // Note7Sharp
            // 
            this.Note7Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note7Sharp.Location = new System.Drawing.Point(731, 240);
            this.Note7Sharp.Name = "Note7Sharp";
            this.Note7Sharp.Size = new System.Drawing.Size(31, 23);
            this.Note7Sharp.TabIndex = 25;
            this.Note7Sharp.Text = "♯";
            this.Note7Sharp.UseVisualStyleBackColor = true;
            this.Note7Sharp.Click += new System.EventHandler(this.Note7Sharp_Click);
            // 
            // Note7Natural
            // 
            this.Note7Natural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note7Natural.Location = new System.Drawing.Point(731, 269);
            this.Note7Natural.Name = "Note7Natural";
            this.Note7Natural.Size = new System.Drawing.Size(31, 23);
            this.Note7Natural.TabIndex = 24;
            this.Note7Natural.Text = "♮";
            this.Note7Natural.UseVisualStyleBackColor = true;
            this.Note7Natural.Click += new System.EventHandler(this.Note7Natural_Click);
            // 
            // Note8
            // 
            this.Note8.AutoSize = true;
            this.Note8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note8.Location = new System.Drawing.Point(869, 269);
            this.Note8.Name = "Note8";
            this.Note8.Size = new System.Drawing.Size(87, 31);
            this.Note8.TabIndex = 28;
            this.Note8.Text = "Note8";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(436, 105);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 29;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ScaleIntro
            // 
            this.ScaleIntro.AutoSize = true;
            this.ScaleIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleIntro.Location = new System.Drawing.Point(190, 167);
            this.ScaleIntro.Name = "ScaleIntro";
            this.ScaleIntro.Size = new System.Drawing.Size(126, 46);
            this.ScaleIntro.TabIndex = 30;
            this.ScaleIntro.Text = "label2";
            // 
            // CheckAnswer
            // 
            this.CheckAnswer.Location = new System.Drawing.Point(403, 367);
            this.CheckAnswer.Name = "CheckAnswer";
            this.CheckAnswer.Size = new System.Drawing.Size(131, 23);
            this.CheckAnswer.TabIndex = 31;
            this.CheckAnswer.Text = "Check Answer";
            this.CheckAnswer.UseVisualStyleBackColor = true;
            this.CheckAnswer.Click += new System.EventHandler(this.CheckAnswer_Click);
            // 
            // ScalesQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.CheckAnswer);
            this.Controls.Add(this.ScaleIntro);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Note8);
            this.Controls.Add(this.Note7);
            this.Controls.Add(this.Note7Flat);
            this.Controls.Add(this.Note7Sharp);
            this.Controls.Add(this.Note7Natural);
            this.Controls.Add(this.Note6);
            this.Controls.Add(this.Note6Flat);
            this.Controls.Add(this.Note6Sharp);
            this.Controls.Add(this.Note6Natural);
            this.Controls.Add(this.Note5);
            this.Controls.Add(this.Note5Flat);
            this.Controls.Add(this.Note5Sharp);
            this.Controls.Add(this.Note5Natural);
            this.Controls.Add(this.Note4);
            this.Controls.Add(this.Note4Flat);
            this.Controls.Add(this.Note4Sharp);
            this.Controls.Add(this.Note4Natural);
            this.Controls.Add(this.Note3);
            this.Controls.Add(this.Note3Flat);
            this.Controls.Add(this.Note3Sharp);
            this.Controls.Add(this.Note3Natural);
            this.Controls.Add(this.Note2);
            this.Controls.Add(this.Note1);
            this.Controls.Add(this.Note2Flat);
            this.Controls.Add(this.Note2Sharp);
            this.Controls.Add(this.Note2Natural);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "ScalesQuiz";
            this.Text = "Scales Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Note2Natural;
        private System.Windows.Forms.Button Note2Sharp;
        private System.Windows.Forms.Button Note2Flat;
        private System.Windows.Forms.Label Note1;
        private System.Windows.Forms.Label Note2;
        private System.Windows.Forms.Label Note3;
        private System.Windows.Forms.Button Note3Flat;
        private System.Windows.Forms.Button Note3Sharp;
        private System.Windows.Forms.Button Note3Natural;
        private System.Windows.Forms.Label Note4;
        private System.Windows.Forms.Button Note4Flat;
        private System.Windows.Forms.Button Note4Sharp;
        private System.Windows.Forms.Button Note4Natural;
        private System.Windows.Forms.Label Note5;
        private System.Windows.Forms.Button Note5Flat;
        private System.Windows.Forms.Button Note5Sharp;
        private System.Windows.Forms.Button Note5Natural;
        private System.Windows.Forms.Label Note6;
        private System.Windows.Forms.Button Note6Flat;
        private System.Windows.Forms.Button Note6Sharp;
        private System.Windows.Forms.Button Note6Natural;
        private System.Windows.Forms.Label Note7;
        private System.Windows.Forms.Button Note7Flat;
        private System.Windows.Forms.Button Note7Sharp;
        private System.Windows.Forms.Button Note7Natural;
        private System.Windows.Forms.Label Note8;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label ScaleIntro;
        private System.Windows.Forms.Button CheckAnswer;
    }
}

