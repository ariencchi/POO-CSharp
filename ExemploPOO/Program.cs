using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPoo
{
  class Program
  {
    static void Main(string[] args)
    {
      // CLASSES E OBJETOS + POLIMORFISMO (Override/Late Binding)
      // Pessoa p1 = new Pessoa();
      // p1.Nome = "Arien";
      // p1.Idade = 31;
      // p1.Apresentar();

      // Professor p2 = new Professor();
      // p2.Nome = "Gui";
      // p2.Idade = 20;
      // p2.Salario = 2000;
      // p2.Apresentar();

      // Aluno p3 = new Aluno();
      // p3.Nome = "Mel";
      // p3.Idade = 18;
      // p3.Nota = 10;
      // p3.Apresentar();


      // PUBLIC VS PRIVATE (Calcular área de um retângulo)
      // //Valores válidos
      // Retangulo r = new Retangulo();
      // r.DefinirMedidas(30, 30);
      // System.Console.WriteLine($"Área: {r.ObterArea()}");

      // //Valores inválidos
      // Retangulo r2 = new Retangulo();
      // r2.DefinirMedidas(0, 0);
      // System.Console.WriteLine($"Área: {r2.ObterArea()}");


      // POLIMORFISMO (Overload/Early Binding) + IMPLEMENTAÇÃO DE INTERFACE
      // Calculadora calc = new Calculadora();
      // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
      // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

      // ICalculadora calc = new Calculadora();
      // System.Console.WriteLine(calc.Multiplicar(5, 5));


      // CLASSES ABSTRATAS
      // Corrente c = new Corrente();
      // c.Creditar(100);
      // c.ExibirSaldo();


      // MANIPULANDO ARQUIVOS
      var caminho = "C:\\TesteArquivos";
      var caminhoPathCombine = Path.Combine(caminho, "TesteArquivos", "SubpastaTeste");
      var caminhoArquivo = Path.Combine(caminho, "ArquivoTeste.txt");
      var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3", "Linha 4" };
      var novaListaString = new List<string> { "Linha 5", "Linha 6", "Linha 7", "AAAA FUNCIONOU" };

      FileHelper helper = new FileHelper();
      // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
      // helper.CriarDiretorio(caminhoPathCombine);
      // helper.ListarDiretorios(caminho);
      // helper.ListarArquivosDiretorios(caminho);
      // helper.CriarArquivoTexto(caminhoArquivo, "Teste de arquivo de escrita.");
      // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
      // helper.AdicionarTexto(caminhoArquivo, "Teste");
      // FileAllText, por não ser stream, sobrescreve o arquivo todo. Para adicionar mais texto mantendo o anterior, precisa usar o Stream.
      // helper.AdicionarTextoStream(caminhoArquivo, novaListaString);
      // helper.LerArquivoStream(caminhoArquivo);
    }
  }
}