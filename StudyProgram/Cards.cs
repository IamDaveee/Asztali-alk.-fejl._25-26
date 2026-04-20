using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProgram
{
    class Cards
    {
        public string question, answer;

        public Cards(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public Cards(string sor)
        {
            string[] egysor = sor.Split(';');
            question = egysor[0];
            answer = egysor[1];
        }
    }
}
