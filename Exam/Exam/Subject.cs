
internal class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Exam Exam { get; set; }

    public Subject(int id, string name,Exam exam)
    {
        Id = id;
        Name = name;
        Exam = exam;
    }

    public void CreateExam()
    {
        Exam.ShowExam();
    }
}

