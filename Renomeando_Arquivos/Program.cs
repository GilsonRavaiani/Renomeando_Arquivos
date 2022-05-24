using System;

namespace Renomeando_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "=M_e-u Nome é &&Gils)on";
            string[] charsToRemove = new string[] {"=","-","&",")","_"};//caracteres a serem eliminados
            foreach (var c in charsToRemove)                             //verificar se existe comando unico 
            {                                                           
                nome = nome.Replace(c, string.Empty);
            }
            Console.WriteLine(nome);
        }
    }
}

//O foreach é um recurso do C# que possibilita executar um conjunto de comandos para cada elemento presente em uma coleção (Array, List, Stack, Queue e outras).