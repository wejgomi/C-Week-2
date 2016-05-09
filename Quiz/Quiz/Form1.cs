using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        bool isTrue;
        int score = 0;
        int n = 0;
        int time = 60;

        string[] questions = new string[]
        {
                "Which company developed C# ?",
                "Inside which element is the Javascript put in HTML ?",
                "Which one is not a datatype in Javascript ?",
        };

        string[,] choices = new string[,]
        {
                { "Microsoft", "Apple", "IBM" },
                { "script", "javascript", "scripting" },
                { "Integer", "string", "var" },
        };

        int[] answers = new int[]
        {
                0,
                0,
                1,
        };

        List<Question> dquestions = new List<Question>();
        List<List<String>> dchoices = new List<List<String>>();
        List<String> danswers = new List<String>();

        public void pulldata()
        {

            using (QuestionsEntities myEntities = new QuestionsEntities())
            {
                var question = from Question in myEntities.Questions select Question;
                dquestions = question.ToList();
            }
            showdynamic();
        }

        public void showdynamic()
        {
            answerBox.Visible = true;
            answerBox.Text = dquestions[0].Questions;
        }

        public void showquestion()
        {
            choiceButton1.Checked = false;
            choiceButton2.Checked = false;
            choiceButton3.Checked = false;
            timer1.Start();

            questionNo.Visible = true;
            questionBox.Visible = true;
            Submit.Visible = true;
            label2.Visible = true;
            label4.Visible = true;

            for (int a = 1; a < 4; a++)
            {
                Controls.Find("choiceButton" + a, true)[0].Visible = true;
            }

            foreach (string question in questions)
            {
                questionBox.Text = questions[n];
                questionNo.Text = "Question No " + (n + 1);

                for (int a = 0; a < 3; a++)
                {
                    Controls.Find("choiceButton" + (a + 1), true)[0].Text = choices[n, a];
                }
            }
            choiceButton1.CheckedChanged += (s, e) => value(0, e);
            choiceButton2.CheckedChanged += (s, e) => value(1, e);
            choiceButton3.CheckedChanged += (s, e) => value(2, e);
        }

        public void value(object sender, EventArgs e)
        {
                RadioButton button = (RadioButton)this.Controls.Find("choiceButton" + (answers[n] + 1), true)[0];
                if (button.Checked == true && Convert.ToInt32(sender) == answers[n])
                {
                    isTrue = true;
                }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void questionBox_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            switch (isTrue)
            {
                case true:
                    timer1.Stop();
                    label3.Visible = true;
                    label5.Visible = true;
                    TrueFalse.Visible = true;
                    TrueFalse.Text = "Correct!";
                    score++;
                    time = 60;
                    break;

                case false:
                    timer1.Stop();
                    label3.Visible = true;
                    label5.Visible = true;
                    TrueFalse.Visible = true;
                    TrueFalse.Text = "Wrong!";
                    time = 60;
                    break;
            }

            answerBox.Visible = true;
            answerBox.Text = "The correct answer was: " + choices[n, answers[n]];
            isTrue = false;
            label5.Text = String.Format("{0}/{1}", score, questions.Length);
            button1.Visible = true;
            Submit.Visible = false;

            if (n++ == (questions.Length-1))
            {
                timer1.Stop();
                button1.Text = "Finish";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrueFalse.Visible = false;
            answerBox.Visible = false;
            button1.Visible = false;
            Submit.Visible = true;
            if (n == questions.Length) { this.Close(); } else { showquestion(); }
        }

        private void start_Click(object sender, EventArgs e)
        {
            switch(this.dataSelect.GetItemText(this.dataSelect.SelectedItem))
            {
                case "Static":
                    showquestion();
                    break;
                case "Dynamic":
                    pulldata();
                    break;
            }
            start.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                var timespan = TimeSpan.FromSeconds(time);
                label4.Text = timespan.ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                label4.Text = "Out of time!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSelect.SelectedItem = "Static";
        }
    }
}