using System.Linq.Expressions;

Func<float, float> metade = num => num / 2;
Console.WriteLine("Metade de 9 é: " + metade(9));

//criar expressões individuais
var quociente = Expression.Parameter(typeof(float), "quo");
var divisor = Expression.Constant(2f, typeof(float));
var opDivisao = Expression.Divide(quociente, divisor);

var metadeExp = Expression.Lambda<Func<float, float>>(opDivisao, new ParameterExpression[] { quociente });
var metadeCompilada = metadeExp.Compile();
Console.WriteLine("metade de 27 é " + metadeCompilada(27));


var num1 = Expression.Parameter(typeof(int), "num");     // parametro q vou receber
var multiplicador = Expression.Constant(2, typeof(int)); // constante que nesse caso é o valor é 2, e o tipo é int
var operacao = Expression.Multiply(num1, multiplicador); // operação a ser feita (Mulyiply) minha constante pelo o parametro q vou receber

var multiplyExp = Expression.Lambda<Func<int, int>>(operacao, new ParameterExpression[] { num1 }); // definição da expressão que é uma função que recebe int, retorna int, e usa minha var operacao 
var result = multiplyExp.Compile();
Console.WriteLine("result is: " + result(28));

// trocando a operação de divisão por multiplicação !
var troca = new TrocarDivisao();
var dobrar = (Expression<Func<float, float>>)troca.Modificar(metadeExp);
var trocaCompilada = dobrar.Compile();
Console.WriteLine("troca de div por mul de 75 = " + trocaCompilada(75));

//trocando a operação de multiplicação por soma !
var troca2 = new TrocarMultiplicacao();
var trocarMulti = (Expression<Func<int, int>>)troca2.Modificar(multiplyExp);
var troca2Compilada = trocarMulti.Compile();
Console.WriteLine("troquei multi por sum e olha no que deu, (5) " + troca2Compilada(5));

class TrocarMultiplicacao : ExpressionVisitor
{
    public Expression Modificar(Expression expression)
    {
        return Visit(expression);
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
        if (node.NodeType == ExpressionType.Multiply)
        {
            return Expression.Add(node.Left, node.Right);
        }
        return base.VisitBinary(node);
    }
}

class TrocarDivisao : ExpressionVisitor
{
    public Expression Modificar(Expression expression)
    {
        return Visit(expression);
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
        if (node.NodeType == ExpressionType.Divide)
        {
            return Expression.Multiply(node.Left, node.Right);
        }
        return base.VisitBinary(node);
    }
}