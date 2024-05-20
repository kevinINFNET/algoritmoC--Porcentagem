using System;

class Programa
{
    static void Main()
    {
        int totalHomens = 0;
        int totalMulheres = 0;
        int totalCriancas = 0;
        int totalIdosos = 0;
        int totalIndividuos = 0;

        while (true)
        {
            Console.Write("Entre com um caractere: ");
            char caractere = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (caractere == 'F')
            {
                break;
            }

            switch (caractere)
            {
                case 'H':
                    totalHomens++;
                    break;
                case 'M':
                    totalMulheres++;
                    break;
                case 'C':
                    totalCriancas++;
                    break;
                case 'I':
                    totalIdosos++;
                    break;
                default:
                    Console.WriteLine("Caractere inválido. Tente novamente.");
                    continue;
            }

            totalIndividuos++;
        }

        if (totalIndividuos > 0)
        {
            double percentualHomens = (totalHomens * 100.0) / totalIndividuos;
            double percentualMulheres = (totalMulheres * 100.0) / totalIndividuos;
            double percentualCriancas = (totalCriancas * 100.0) / totalIndividuos;
            double percentualIdosos = (totalIdosos * 100.0) / totalIndividuos;

            Console.WriteLine($"Total de homens = {totalHomens} - {percentualHomens:F2}%");
            Console.WriteLine($"Total de mulheres = {totalMulheres} - {percentualMulheres:F2}%");
            Console.WriteLine($"Total de crianças = {totalCriancas} - {percentualCriancas:F2}%");
            Console.WriteLine($"Total de idosos = {totalIdosos} - {percentualIdosos:F2}%");
        }
        else
        {
            Console.WriteLine("Nenhum indivíduo foi registrado.");
        }
    }
}
