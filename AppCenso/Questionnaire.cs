using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCensus
{
    class Questionnaire
    {

        List<IQuestion> _questions = new List<IQuestion>();
        public List<IQuestion> questions
        {
            get { return _questions; }
        }

        public void addQuestion<T>(Question<T> question)
        {
            _questions.Add(question);
        }

        public void printResponses()
        {
            foreach (IQuestion question in _questions)
            {
                question.printResponse();
            }

        }

    }
}
