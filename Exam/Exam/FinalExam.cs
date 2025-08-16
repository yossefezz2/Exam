

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
        foreach (var question in Questions)
        {
            Console.WriteLine(question);
        }
    }
}

