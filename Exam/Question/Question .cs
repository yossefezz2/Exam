
internal abstract class Question
{
    public abstract string QuestionHeader { get; set; }
    public abstract string QuestionBody { get; set; }
    public abstract int QuestionMark { get; set; }
    public abstract List<Answer> Answers { get; set; }
    public  abstract Answer rightAnswer { get; set; }

    public override string ToString()
    {
        return $"{QuestionHeader} - {QuestionBody} (Mark: {QuestionMark})\n";
    }
}

