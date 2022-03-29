using csharppt10;
using System.Reflection;

Console.WriteLine("\n===============Modificando nome via reflection=============================================================");

Relatorio relatorio = new Relatorio("Relatório de Vendas");
var type = relatorio.GetType();
var members = type.GetMembers();
foreach (var item in members)
{
    Console.Write($"\n{item}");
}
var methodInfo = type.GetMethod("set_Nome");
methodInfo?.Invoke(relatorio, new object[] { "Nome_modificado_via_reflection" });
relatorio.Imprimir();

Console.WriteLine("\n===============Tipos do assembly que implementam a interface IRelatorio===================================");

var esteAssembly = Assembly.GetExecutingAssembly();
var typesAssembly = esteAssembly.GetTypes();

foreach (var item in typesAssembly)
{
    if (item.IsInterface)
    {
        continue; /* se meu item (type) for uma interface ele não mostra no console */
    }

    if (typeof(IRelatorio).IsAssignableFrom(item))
    {
        Console.WriteLine(item); /* retorna os tipos que implementam a interface IRelatorio */
    }
}

Console.WriteLine("\n===============Usando LINQ para ver os tipos do assembly ==================================================");
Console.WriteLine("===============Que implementam a interface IRelatorio    ==================================================");

var query = from t in typesAssembly where typeof(IRelatorio).IsAssignableFrom(t) && !t.IsInterface
            select t;

foreach (var t in query)
{

    Console.WriteLine(type);
}

Console.WriteLine("\n===============Verifica se a classe venda define ou não Serializable========================================");

if (Attribute.IsDefined(typeof(Venda), typeof(SerializableAttribute)))
{
    Console.WriteLine("A classe Venda DEFINE o atributo Serializable");
}
else
{
    Console.WriteLine("A classe Venda NÃO DEFINE o atributo Serializable");
}