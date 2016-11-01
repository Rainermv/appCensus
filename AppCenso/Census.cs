using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCensus
{
    class Census
    {
        private List<Questionnaire> questionnaire_history = new List<Questionnaire>();

        public void addToHistory(Questionnaire questionnaire)
        {
            questionnaire_history.Add(questionnaire);
        }


        public void run()
        {
            
            int option = 0;

            while (option != 3)
            {
                option = 0;

                Console.WriteLine("Seja bem vindo ao Censo, escolha a opção desejada:");
                Console.WriteLine("1: Realizar questionário.");
                Console.WriteLine("2: Listar questionários respondidos.");
                Console.WriteLine("3: Fechar aplicação.");

                var input = Console.ReadLine();
                Int32.TryParse(input, out option);

                switch (option)
                {
                    case 1:
                        newQuestionnaire();
                        break;

                    case 2:
                        listQuestionnaires();
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;


                }


                Console.WriteLine("================================================");

            }

        }

        void newQuestionnaire()
        {
            Questionnaire questionnaire = QuestionnaireFactory.getInstance().buildQuestionnaire();

            Console.WriteLine("Novo questionário");
            Console.WriteLine("Aperte ENTER para iniciar ");
            Console.ReadLine();

            foreach (var question in questionnaire.questions)
            {
                Type qType = question.GetType();

                question.printQuestion();
                question.readResponse();

            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Questionário finalizado.");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();


            addToHistory(questionnaire);

        }

        void listQuestionnaires()
        {
            Console.WriteLine("Listando questionários respondidos:");
            Console.WriteLine("---------------------------------");
            foreach (Questionnaire questionnaire in questionnaire_history)
            {
                questionnaire.printResponses();
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("Questionários listados");

            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
        }


    }
}
