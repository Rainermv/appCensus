using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCensus
{
    class Question<T> : IQuestion
    {
        String _questionText;
        public String questionText
        {
            get { return _questionText; }
        }

        Response<T> _response;
        public Response<T> response{
            get { return _response; }
        }

        public void setAnswer(T responseObject)
        {
            _response = new Response<T>(responseObject);
        }

        public Question(String questionText)
        {
            this._questionText = questionText;
        }

        
        public void printQuestion()
        {
            Console.Write(this.questionText + " ");
        }

        public void readResponse()
        {
            bool validAnswer = false;

            while (validAnswer == false)
            {
                String userInput = Console.ReadLine();
                T resp = default(T);

                if (typeof(T) == typeof(int))
                {
                    int intInput = 0;
                    if (Int32.TryParse(userInput, out intInput))
                    {
                        validAnswer = true;
                        resp = (T)Convert.ChangeType(intInput, typeof(T));
                    }
                }
                if (typeof(T) == typeof(float))
                {
                    float floatInput = 0;
                    if (float.TryParse(userInput, out floatInput))
                    {
                        validAnswer = true;
                        resp = (T)Convert.ChangeType(floatInput, typeof(T));
                    }
                }
                else if (typeof(T) == typeof(Boolean))
                {
                    if (userInput == "s" || userInput == "n")
                    {
                        bool boolInput = false;

                        if (userInput == "s") boolInput = true;
                        if (userInput == "n") boolInput = false;

                        validAnswer = true;
                        resp = (T)Convert.ChangeType(boolInput, typeof(T));

                    }

                }
                else if (typeof(T) == typeof(String))
                {
                    validAnswer = true;
                    resp = (T)Convert.ChangeType(userInput, typeof(T));
                }
                
                if (!validAnswer)
                {
                    Console.WriteLine("Resposta inválida, digite novamente");
                }
                else
                {
                    this._response = new Response<T>(resp);
                }
               
            }
  
        }

        public void printResponse()
        {
            if (this._response != null)
            {
                Console.Write(questionText + " ");
                _response.print();
            }
        }
        
    }
}
