namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public abstract class Expression
{

    protected string _formula;

    public Expression(string formula)
    {
        _formula = formula;
    }
    public abstract string Interpret(string content, Dictionary<string, string>? context = null);
}