#pragma warning disable
using System.Reflection;
using TiposReflection;

//AssemblyNameVersionModulesTypesMembers();
Tipos();

#region methods
void AssemblyNameVersionModulesTypesMembers()
{
    var assembly = Assembly.GetExecutingAssembly();
    Console.WriteLine(assembly.FullName);
    Console.WriteLine($"Major > {assembly.GetName().Version?.Major}\nMinor > {assembly.GetName().Version?.Minor}\nBuild > {assembly.GetName().Version?.Build}\n");
    Console.WriteLine($"está no assembly global cache? {assembly?.GlobalAssemblyCache + "\n"}");
    foreach (var modulo in assembly.GetModules())
    {
        Console.WriteLine("\t" + modulo.Name);

        foreach (var item in modulo.GetTypes())
        {
            Console.WriteLine("\t\t" + item.Name);

            foreach (var member in item.GetMembers())
            {
                Console.WriteLine("\t\t\t" + member.Name + $"({member.MemberType})");
            }
        }
    }
}
void Tipos()
{
    var tipo = typeof(CarrinhoCliente);
    var propiedades = tipo.GetProperties();

    foreach (var item in propiedades)
    {
        Console.WriteLine(item.Name);
        if (item.CanRead)
        {
            Console.WriteLine("\tpode ler");
            Console.WriteLine("\t\t" + item.GetMethod);
        }
        if (item.CanWrite)
        {
            Console.WriteLine("\tpode escrever");
            Console.WriteLine("\t\t" + item.SetMethod);
        }
    }
}
#endregion


