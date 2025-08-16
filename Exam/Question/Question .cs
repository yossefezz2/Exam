
internal abstract class Question
{
    public string QuestionHeader { get; set; }
    public string QuestionBody { get; set; }
    public string QuestionMark { get; set; }
    public Answer[] Answers { get; set; }
    public Answer rightAnswer { get; set; }

    public override string ToString() => $"{QuestionHeader} - {QuestionBody} (Mark: {QuestionMark})";
}

