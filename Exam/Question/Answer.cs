
internal class Answer
{
    public int id { get; set; }
    public string AnswerText { get; set; }

    public Answer(int id, string answerText)
    {
        this.id = id;
        AnswerText = answerText;
    }

    public override string ToString()
    {
        return $"{AnswerText}";
    }
    public override bool Equals(object obj)
    {
        if (obj is Answer otherAnswer)
        {
            return id == otherAnswer.id && AnswerText == otherAnswer.AnswerText;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(id, AnswerText);
    }
    public static bool operator ==(Answer left, Answer right)
    {
        return Equals(left, right);
    }
    public static bool operator !=(Answer left, Answer right)
    {
        return !Equals(left, right);
    }
}

