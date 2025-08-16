internal abstract class Exam
{
    public abstract DateTime ExamTime { get;}
    public abstract int numberOfQuestions { get; }

    public abstract List<Question> Questions { get;}

    public abstract void ShowExam();
}
