namespace Pre.DesignPatters.Introduction.Core.ExpressionBuilder;

public class ContentParser
{
    private ICollection<Expression> _expressions;

    public ContentParser()
    {
        _expressions = new List<Expression>();
    }

    public string Parse(string expressionValue, Dictionary<string, string>? context = null)
    {
        return _expressions.Aggregate(expressionValue, (current, expression) =>
            expression.Interpret(current, context)
        );
    }

    public void AddExpression(Expression expression)
    {
        _expressions.Add(expression);
    }
}