namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public class PdfReport : Report
{
    private ContentParser _parser;
    public string Content { get; set; }
    public double Margin { private get; set; }

    public PdfReport(string name, double margin)
    {
        Name = name;
        Margin = margin;
    }

    public PdfReport(string name, string content, double margin) : this(name, margin)
    {
        Content = content;
    }

    public void SetParser(ContentParser parser)
    {
        _parser = parser;
    }

    public string GenerateReport(Dictionary<string, string>? context = null)
    {
        return _parser.Parse(Content, context);
    }
}