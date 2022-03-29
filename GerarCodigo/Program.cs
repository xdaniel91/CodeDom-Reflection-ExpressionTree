using System.CodeDom.Compiler;
using System.CodeDom;

/* =========================================================================================== */

//criar uma unidade de compilação
var unit = new CodeCompileUnit();

//criar o namespace recursos humanos
var codeNameSpace = new CodeNamespace("RecursosHumanos");

//importar o namespace System
var import = new CodeNamespaceImport("System");
codeNameSpace.Imports.Add(import);

//adicionando namespace a unit
unit.Namespaces.Add(codeNameSpace);

//criar a classe funcionario
var funcionario = new CodeTypeDeclaration("Funcionario");
codeNameSpace.Types.Add(funcionario);

//adicionando campo nome
CodeMemberField nome = new CodeMemberField(typeof(string), "nome");
nome.Attributes = MemberAttributes.Public;
funcionario.Members.Add(nome);

//adicionando campo salario
CodeMemberField salario = new CodeMemberField(typeof(decimal), "salario");
salario.Attributes = MemberAttributes.Public;
funcionario.Members.Add(salario);

//criando o construtor
var ctor = new CodeConstructor();
funcionario.Members.Add(ctor);

//adicionando parametros ao construtor
var _nome = new CodeParameterDeclarationExpression(typeof(string), "nome");
var _salario = new CodeParameterDeclarationExpression(typeof(decimal), "salario");
ctor.Parameters.Add(_nome);
ctor.Parameters.Add(_salario);
ctor.Attributes = MemberAttributes.Public;

//cria o provedor de modelo de código
var provider = CodeDomProvider.CreateProvider("CSharp");

//gerar código e salva o arquivo
using (var writer = new StreamWriter("funcionario.cs"))
{
    provider.GenerateCodeFromCompileUnit(unit, writer, new CodeGeneratorOptions());
};
