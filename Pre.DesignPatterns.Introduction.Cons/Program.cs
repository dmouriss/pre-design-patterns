// See https://aka.ms/new-console-template for more information

using Pre.DesignPatters.Introduction.Core.ExpressionBuilder;
using Pre.DesignPatters.Introduction.Core.Singleton;

Console.WriteLine(Counter.Instance.Value);
Console.WriteLine(Counter.Instance.Value);
Console.WriteLine(Counter.Instance.Value);

string template = "Brugge, <date>\n\nReferentienummer <id>\n\nBeste klant\nlorem ipsum\nMet vriendelijke groeten\nDieter";

List<Dictionary<string, string>> allContexts = new List<Dictionary<string, string>>()
{
    new() {{"name", "Alice"}},
    new() {{"name", "Bob"}},
};

ContentParser parser = new ContentParser();
parser.AddExpression(new DateExpression("<date>", "dddd, dd MMMM yyyy"));
parser.AddExpression(new ContextAwareExpression("<name>", "name"));

PdfReport report = new PdfReport("letter", template, 0);
report.SetParser(parser);

foreach (Dictionary<string, string> context in allContexts)
{
    Console.WriteLine(report.GenerateReport(context));
}


