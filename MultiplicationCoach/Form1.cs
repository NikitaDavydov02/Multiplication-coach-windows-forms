using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationCoach
{
    public partial class Form1 : Form
    {
        int correct = 0;
        int incorrect = 0;
        int total = 0;
        int accuracy = 0;
        int answer;
        MultiplicationCoach multiplicationCoach;
        public Form1()
        {
            InitializeComponent();
            multiplicationCoach = new MultiplicationCoach();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            statsLabel.Text = "";
            resultLabel.Text = "";
            exampleLabel.Text = multiplicationCoach.NextExample();
            total++;
        }

        private void answerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && answerBox.Text != "" && total <= 20)
            {
                answer = Convert.ToInt32(answerBox.Text);
                if (multiplicationCoach.CheckTheAnswer(answer, multiplicationCoach.firstMultiplier, multiplicationCoach.secondMultiplier))
                {
                    resultLabel.Text = "Ответ верный!";
                    correct++;
                }
                else
                {
                    resultLabel.Text = "Ошибка!";
                    incorrect++;
                }
                answerBox.Text = "";
                if (total < 20)
                {
                    exampleLabel.Text = multiplicationCoach.NextExample(); ;
                    total++;
                }
                else
                {
                    statsLabel.Text = "";
                    resultLabel.Text = "";
                    accuracy = 100 * correct / (correct + incorrect);
                    statsLabel.Text = "Тренеровка окончена! Результаты:\n" + "Решено примеров: " + total + "\n" + "Правильно: " + correct
                        + "\n" + "Неправильно: " + incorrect + "\n" + "Правильность решения: " + accuracy + "%";
                }
            }
        }
    }
}
