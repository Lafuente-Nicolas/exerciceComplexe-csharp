
using System.ComponentModel.Design;

namespace exerciceComplexe
    
{

    internal class Program

    {
        static void Main(string[] args)
        {
            NotesUtil.CalculerMoyenne(3, 2);
            int nombreNotes = 0;
            Console.Write("le nombre de notes : ");
            nombreNotes = Convert.ToInt32(Console.ReadLine());
            List<int> stock = new List<int>();
            Console.WriteLine("Saisissez les notes: ");
            for (int count = 0; count < nombreNotes; count++)
            {
                stock.Add(Convert.ToInt32(Console.ReadLine()));
            }
            NotesUtil.CalculerMoyenne(stock);
            Console.WriteLine($"la moyenne est de {NotesUtil.CalculerMoyenne(stock)}");

            NotesUtil stats = new NotesUtil();
            stats.AfficherStats(stock); ;
        }
        

    }
};

