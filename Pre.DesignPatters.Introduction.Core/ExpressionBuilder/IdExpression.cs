using Pre.DesignPatters.Introduction.Core.Singleton;

namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public class IdExpression : Expression
{
    public IdExpression(string formula) : base(formula)
    {
    }

    public override string Interpret(string content, Dictionary<string, string>? context = null)
    {
        return content.Replace(_formula, Counter.Instance.Value.ToString());
    }
}