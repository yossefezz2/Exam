internal class Program
{
    private static void Main(string[] args)
    {
 
        var tfAnswers = new List<Answer>
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        };

        var mcqAnswers = new List<Answer>
        {
            new Answer(1, "2"),
            new Answer(2, "4"),
            new Answer(3, "6")
        };


        var q1 = new TrueOrFalse(
            "Q1", "C# is an Object Oriented Language?", 5, tfAnswers, tfAnswers[0] 
        );

        var q2 = new MCQ(
            "Q2", "What is 2 + 2?", 5, mcqAnswers, mcqAnswers[1] 
        );


        var examTime = DateTime.Now.AddDays(1); 
        var numberOfQuestions = 2; 
        Exam finalExam = new FinalExam(examTime, numberOfQuestions, new List<Question> { q1, q2 });


        Subject math = new Subject(1, "Mathematics", finalExam);


        math.CreateExam();
    }
}