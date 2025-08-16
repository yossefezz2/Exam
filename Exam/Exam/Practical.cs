
internal class Practical : Exam
{
    public override DateTime ExamTime { get; }
    public override int numberOfQuestions { get; }
    public override List<Question> Questions { get; }

    public Practical(DateTime examTime, int numberOfQuestions, List<Question> questions)
    {
        ExamTime = examTime;
        this.numberOfQuestions = numberOfQuestions;
        foreach (var question in questions)
        {
            if (question is MCQ)
            {
                Questions.Add(question);
            }
            else
            {
                new Exception("Invalid question type for practical exam. Only MCQ questions are allowed.");
            }
        }
    }


    public override void ShowExam()
    {
        foreach (var question in Questions)
        {
            Console.WriteLine(question);
        }
    }
}
