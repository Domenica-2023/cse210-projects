class MathAssignment: Assignment 
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment (string studentName, string topic, string textbookSection, string problems): base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problem;
    }
    public string GetHomeworkList()
    {
        // return $"{*variables*}" textbook section and problems (Section: ... Problems ...)
    }
}