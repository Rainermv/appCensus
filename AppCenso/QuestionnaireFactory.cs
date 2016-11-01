using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCensus
{
    class QuestionnaireFactory
    {
        #region SINGLETON DECLARATION
        private static QuestionnaireFactory instance;

        private QuestionnaireFactory()
        {

        }

        public static QuestionnaireFactory getInstance()
        {
            if (instance == null)
            {
                instance = new QuestionnaireFactory();
            }

            return instance;

        }

        #endregion

        public Questionnaire buildQuestionnaire()
        {
            Questionnaire q = new Questionnaire();

            q.addQuestion(new Question<String>("Nome:"));
            q.addQuestion(new Question<int>("Idade:"));
            q.addQuestion(new Question<String>("Endereço:"));
            q.addQuestion(new Question<String>("Sexo:"));
            q.addQuestion(new Question<bool>("Possui alguma deficiência? (s/n):"));
            q.addQuestion(new Question<bool>("É casado(a)? (s/n):"));
            q.addQuestion(new Question<int>("Número de filhos:"));
            q.addQuestion(new Question<float>("Altura (em metros - 0,00):"));
            q.addQuestion(new Question<float>("Peso (em quilos - 0,00):"));
            q.addQuestion(new Question<String>("Profissão:"));
            q.addQuestion(new Question<String>("Empresa onde trabalha:"));
            q.addQuestion(new Question<String>("Escola onde estuda:"));

            return q;
        }
    }
}
