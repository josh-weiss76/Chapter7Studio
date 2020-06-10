using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Chapter7Studio
{
    public abstract class Question
    {
        public string QuestionAsked { get; set; }
        public string AnswerToQuestion { get; set; }
        public int PointForCorrectAnswer { get; set; }

        public Question(string questionAsked, string answerToQuestion, int pointForCorrectAnswer)
        {
            QuestionAsked = questionAsked;
            AnswerToQuestion = answerToQuestion;
            PointForCorrectAnswer = pointForCorrectAnswer;
        }
        public virtual void DisplayQuestion()
        {
            Console.WriteLine(QuestionAsked);
        }
        public abstract void GetAnswers();

    }

    public class MultipleChoice : Question
    {
        public string AnswerOptionA { get; set; }
        public string AnswerOptionB { get; set; }
        public string AnswerOptionC { get; set; }
        public string AnswerOptionD { get; set; }

        public MultipleChoice(string questionAsked, string answerOptionA, string answerOptionB, string answerOptionC, string answerOptionD, string answerToQuestion, int pointForCorrectAnswer) : base(questionAsked, answerToQuestion, pointForCorrectAnswer)
        {
            AnswerOptionA = answerOptionA;
            AnswerOptionB = answerOptionB;
            AnswerOptionC = answerOptionC;
            AnswerOptionD = answerOptionD;
        }

        public void DisplayQuestion(string questionAsked, string answerOptionA, string answerOptionB, string answerOptionC, string answerOptionD)
        {
            Console.WriteLine(questionAsked);
            Console.WriteLine("Please select an answer from below (A, B, C, or D): ");
            Console.WriteLine("A. " + answerOptionA);
            Console.WriteLine("B. " + answerOptionB);
            Console.WriteLine("C. " + answerOptionC);
            Console.WriteLine("D. " + answerOptionD);
        }
        public override void GetAnswers()
        {
            string userAnswer = Console.ReadLine();
            string normalizedInput = userAnswer.ToLower();
            if (normalizedInput == AnswerToQuestion)
            {
                PointForCorrectAnswer++;
            }
        }

    }
    public class Checkbox : Question
    {
        public string AnswerChoiceA { get; set; }
        public string AnswerChoiceB { get; set; }
        public string AnswerChoiceC { get; set; }
        public string AnswerChoiceD { get; set; }

        public Checkbox(string questionAsked, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answerToQuestion, int pointForCorrectAnswer) : base(questionAsked, answerToQuestion, pointForCorrectAnswer)
        {
            AnswerChoiceA = answerChoiceA;
            AnswerChoiceB = answerChoiceB;
            AnswerChoiceC = answerChoiceC;
            AnswerChoiceD = answerChoiceD;
        }
        public  void DisplayQuestion(string questionAsked, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD)
        {
            Console.WriteLine(questionAsked);
            Console.WriteLine("Please select the answers from the choices below (A, B, C, or D).  There may be more than one correct answer, if you select more than one option, please do so without any seperation (ex. 12 for selections one and two): ");
            Console.WriteLine("A. " + answerChoiceA);
            Console.WriteLine("B. " + answerChoiceB);
            Console.WriteLine("C. " + answerChoiceC);
            Console.WriteLine("D. " + answerChoiceD);
        }
        public override void GetAnswers()
        {
            string userAnswer = Console.ReadLine();
            string normalizedInput = userAnswer.ToLower();
            if (normalizedInput == AnswerToQuestion)
            {
                PointForCorrectAnswer++;
            }
        }

    }
    public class TrueFalse : Question
    {
        public TrueFalse(string questionAsked, string answerToQuestion, int pointForCorrectAnswer) : base(questionAsked, answerToQuestion, pointForCorrectAnswer)
        {
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine(QuestionAsked + " True or False: ");
        }
        public override void GetAnswers()
        {
            string userAnswer = Console.ReadLine();
            string normalizedInput = userAnswer.ToLower();
            if (normalizedInput == AnswerToQuestion)
            {
                PointForCorrectAnswer++;
            }
        }

    }

}
