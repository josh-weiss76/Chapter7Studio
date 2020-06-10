using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Studio
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int PointsEarned { get; set; } = 0;
        public int TotalPointsPossible { get; set; } = 0;
        public double Score { get; set; } = 0;

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            PointsEarned = 0;
            TotalPointsPossible = 0;
            Score = 0;
            for (int i = 0; i <questions.Count; i++)
            {
                TotalPointsPossible += questions[i].PointForCorrectAnswer;
            }
        }
        public void AddQuestionToQuiz(Question newQuestion)
        {
            Questions.Add(newQuestion);
            TotalPointsPossible += newQuestion.PointForCorrectAnswer;
        }
        public void TakeQuiz()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].DisplayQuestion();
                Questions[i].GetAnswers();
                TotalPointsPossible++;
            }
        }
        public void GradeQuiz()
        {
            Console.WriteLine("You answered " + PointsEarned + " out of " + TotalPointsPossible + " questions correct for a score of " + PointsEarned / TotalPointsPossible);
        }
    }
}
