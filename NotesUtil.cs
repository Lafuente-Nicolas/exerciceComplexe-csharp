using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceComplexe
{
    internal class NotesUtil
    {

        public static void CalculerMoyenne(int totalPoints, int nombreNotes)
        {
            double moyenne = totalPoints / nombreNotes;
            Console.WriteLine($"La moyenne est : {moyenne}");

        }
        // Surcharge de la fonction

        public static double CalculerMoyenne(List<int> notes)
        {
            double sommes = 0;
            double moyenne = 0;

            foreach (int n in notes)
                sommes += n;

            moyenne = sommes / notes.Count;

            return moyenne;
        }


     
        public void AfficherStats(List<int> notesList)
        {
            double moyenneList = CalculerMoyenne(notesList);
            Console.WriteLine($"La valeur maximale est {notesList.Max()}");
            Console.WriteLine($"La valeur minimale est {notesList.Min()}");
            Console.WriteLine($"La moyenne est {moyenneList}");
        }


    }
};

/*Console.WriteLine("le total des points obtenus : ");
totalPoints = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("le nombre de notes : ");
nombreNotes = Convert.ToInt32(Console.ReadLine());*/