using System.Security.Cryptography.X509Certificates;

namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public class TextExpression : Expression
{

    private string _value;

    public TextExpression(string formula, string value) : base(formula)
    {
        _value = value;
    }
    
    public override string Interpret(string subject, Dictionary<string, string>? context = null)
    {
        return subject.Replace(_formula, _value);
    }
}