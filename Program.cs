using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;
            string note1, note2, note3, note4;
            double notaFinal;
            
            Console.Write("Primeira nota:");
            note1 = Console.ReadLine();
            nota1 = double.Parse(note1);
            if (nota1>10 || nota1 <0){
               Console.WriteLine ("Valor inválido");
                            
                
                       }

            Console.Write("Segunda nota:");
            note2 = Console.ReadLine();
            nota2 = double.Parse(note2);

            Console.Write("Terceira nota:");
            note3 = Console.ReadLine();
            nota3 = double.Parse(note3);

            Console.Write("Quarta nota:");
            note4 = Console.ReadLine();
            nota4 = double.Parse(note4);

             notaFinal = (nota1 + nota2 + nota3 + nota4)/4;

             if(notaFinal < 5)
             {
                Console.WriteLine("Media de aproveitamento = " + notaFinal + " Nota final= " + notaFinal + " Reprovado");
             }

             if(notaFinal >= 5 && notaFinal <=6)
             {
                Console.WriteLine("Media de aproveitamento = " + notaFinal + " Nota final= " + notaFinal+ " Recuperação");
             }

             if(notaFinal > 6)
             {
                Console.WriteLine("Media de aproveitamento = " + notaFinal + " Nota final= " + notaFinal+ " Aprovado");
        }
    }
}
