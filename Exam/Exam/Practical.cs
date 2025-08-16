
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
            int index = 1;
            Console.WriteLine("Please select the correct answer:");
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($"{index} {answer}");
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
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine("Incorrect answer. The correct answer is: " + question.rightAnswer);
            }
        }
    }
}
