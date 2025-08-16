
internal class Answer
{
    public int id { get; set; }
    public string AnswerText { get; set; }

    public Answer(int id, string answerText)
    {
        this.id = id;
        AnswerText = answerText;
    }
}

