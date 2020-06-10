using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz testQuiz = new Quiz(new List<Question>());

            
            TrueFalse firstQuestion = new TrueFalse("This course is difficult?", "true", 1);
            MultipleChoice secondQuestion = new MultipleChoice("What is the meaning of life, the universe, and everything?", "love", "money", "42", "coding", "42", 1);
            Checkbox thirdQuestion = new Checkbox("What are viable pets to own in a house?", "shark", "dog", "cat", "elephant", "bc", 1);

            testQuiz.AddQuestionToQuiz(firstQuestion);
            testQuiz.AddQuestionToQuiz(secondQuestion);
            testQuiz.AddQuestionToQuiz(thirdQuestion);
            testQuiz.TakeQuiz();
            testQuiz.GradeQuiz();
            firstQuestion.DisplayQuestion();
        }
    }
}
