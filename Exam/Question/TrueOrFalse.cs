
internal class TrueOrFalse : Question
{
    public override string QuestionHeader { get; set; }
    public override string QuestionBody { get; set; }
    public override int QuestionMark { get; set; }
    public override List<Answer> Answers { get; set; }
    public override Answer rightAnswer { get; set; }

    public TrueOrFalse(string questionHeader, string questionBody, int questionMark, List<Answer> answers, Answer rightAnswer)
    {
        QuestionHeader = questionHeader;
        QuestionBody = questionBody;
        QuestionMark = questionMark;
        Answers = answers;
        this.rightAnswer = rightAnswer;
    }
}

