namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public class ContextAwareExpression : Expression
{
    private readonly string _contextKey;
    
    public ContextAwareExpression(string formula, string contextKey) : base(formula)
    {
        _contextKey = contextKey;
    }

    public override string Interpret(string subject, Dictionary<string, string>? context = null)
    {
        if (context == null || !context.ContainsKey(_contextKey)) 
            throw new Exception("The provided context does not contain the key");
        return subject.Replace(_formula, context[_contextKey]);
    }
}