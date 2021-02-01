using System;
 
namespace Desafio_1
{
  class Program
  {
    static void Main(string[] args)
     {
       
       //Declarações de variáveis.
       string[] entrada;
       var distancia = 0;
       var horas = 0;
       var viagem = 0;
       decimal gasolina = 0;
       
       //Split: Cada espaço dado ele quebra o array, sendo assim tornando a vírgula do array.
       entrada = (Console.ReadLine().Split(' '));
       //Alterando as posições do array de string, para int.
       horas = Convert.ToInt32(entrada[0]);
       distancia = Convert.ToInt32(entrada[1]);
       //Km total do percurso(viagem).
       viagem = (horas * distancia);
       //total do percurso div/ por 12.
       gasolina = ((decimal)viagem / 12);
       //retornando uma string com três casas decimais.
       Console.WriteLine(gasolina.ToString("N3"));
      }
   }
}