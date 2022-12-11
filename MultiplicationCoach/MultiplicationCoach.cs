using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationCoach
{
    class MultiplicationCoach
    {
        Random random = new Random();
        public int firstMultiplier;
        public int secondMultiplier;
        public bool CheckTheAnswer(int answer, int firstMultiplier, int secondMultiplier)
        {
            int correctAnswer = firstMultiplier * secondMultiplier;
            if (answer == correctAnswer)
                return true;
            else
                return false;
        }
        public string NextExample()
        {
            firstMultiplier = random.Next(1, 10);
            secondMultiplier = random.Next(1, 10);
            return firstMultiplier + " * " + secondMultiplier + " = ";
        }
    }
}
