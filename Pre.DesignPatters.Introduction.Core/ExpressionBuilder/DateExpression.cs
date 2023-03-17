namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public class DateExpression : Expression
{
    private string _pattern;

    public DateExpression(string formula, string pattern) : base(formula)
    {
        _pattern = pattern;
    }
    
    public override string Interpret(string subject, Dictionary<string, string>? context = null)
    {
        return subject.Replace(_formula, DateTime.Now.ToString(_pattern));
    }
}