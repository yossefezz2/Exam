

internal class FinalExam : Exam
{
    public override DateTime ExamTime { get ; }
    public override int numberOfQuestions { get;  }

    public override List<Question> Questions { get; }



    public FinalExam(DateTime examTime, int numberOfQuestions, List<Question> questions)
    {
        ExamTime = examTime;
        this.numberOfQuestions = numberOfQuestions;
        Questions = questions;
    }

    public override void ShowExam()
    {
        int score = 0;
        foreach (var question in Questions)
        {
            Console.WriteLine(question);
            int index = 1;
            Console.WriteLine("Please select the correct answer:");
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($"{index}. {answer}");
                index++;
            }
            Console.WriteLine("Enter the number of your answer:");
            int selectedAnswerIndex;
            while (!int.TryParse(Console.ReadLine(), out selectedAnswerIndex) ||
                   selectedAnswerIndex < 1 ||
                   selectedAnswerIndex > question.Answers.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid answer number.");
            }
            var selectedAnswer = question.Answers[selectedAnswerIndex - 1];
            if (selectedAnswer == question.rightAnswer)
            {
                score++;
            }
        }
        Console.WriteLine($"Your score is: {score} out of {Questions.Count}");
    }
}

