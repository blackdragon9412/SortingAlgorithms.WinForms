using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortieralgorithmen_MT
{
    internal class Test
    {
        public void AutomatischerTest(int wiederholungen)
        {
            string filePath = "SortierTestErgebnisse.txt";

            // Zufällige Zahlen
            int[] zufallsZahlen = GeneriereZufallszahlen(100);
            int[] aufsteigendSortiert = (int[])zufallsZahlen.Clone();
            Array.Sort(aufsteigendSortiert);
            int[] absteigendSortiert = (int[])zufallsZahlen.Clone();
            Array.Sort(absteigendSortiert);
            Array.Reverse(absteigendSortiert);

            // Dictionary, um die durchschnittlichen Laufzeiten der Algorithmen zu speichern
            Dictionary<string, double> durchschnittsZeiten = new Dictionary<string, double>();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Ergebnisse der Sortieralgorithmen:");
                writer.WriteLine($"Anzahl der Wiederholungen: {wiederholungen}");
                writer.WriteLine();

                durchschnittsZeiten["Bubblesort"] = TesteSortieralgorithmus(writer, "Bubblesort", Algo.Bubblesort, zufallsZahlen, aufsteigendSortiert, absteigendSortiert, wiederholungen);
                durchschnittsZeiten["Insertionsort"] = TesteSortieralgorithmus(writer, "Insertionsort", Algo.Insertionsort, zufallsZahlen, aufsteigendSortiert, absteigendSortiert, wiederholungen);
                durchschnittsZeiten["Selektionsort"] = TesteSortieralgorithmus(writer, "Selektionsort", Algo.Selectionsort, zufallsZahlen, aufsteigendSortiert, absteigendSortiert, wiederholungen);
                durchschnittsZeiten["Quicksort"] = TesteSortieralgorithmus(writer, "Quicksort", (arr) => Algo.Quicksort(arr, 0, arr.Length - 1), zufallsZahlen, aufsteigendSortiert, absteigendSortiert, wiederholungen);
                durchschnittsZeiten["Sort (built-in)"] = TesteSortieralgorithmus(writer, "Sort (built-in)", Algo.Sort, zufallsZahlen, aufsteigendSortiert, absteigendSortiert, wiederholungen);

                writer.WriteLine("Vergleich der durchschnittlichen Laufzeiten (aufsteigend sortiert):");

                // Sortiere die Algorithmen nach den durchschnittlichen Zeiten
                foreach (var algorithmus in durchschnittsZeiten.OrderBy(x => x.Value))
                {
                    writer.WriteLine($"{algorithmus.Key}: {algorithmus.Value} microsec");
                }
            }

            Console.WriteLine($"Testergebnisse wurden in {filePath} gespeichert.");
        }

        private double TesteSortieralgorithmus(StreamWriter writer, string algorithmusName, Func<int[], int[]> sortierMethode, int[] zufallsZahlen, int[] aufsteigendSortiert, int[] absteigendSortiert, int wiederholungen)
        {
            writer.WriteLine($"--- {algorithmusName} ---");

            writer.WriteLine("Zufällige Zahlen:");
            double durchschnittZufallsZahlen = TesteUndBerechneDurchschnitt(writer, sortierMethode, zufallsZahlen, wiederholungen);
            writer.WriteLine($"Durchschnittliche Laufzeit: {durchschnittZufallsZahlen} microsec");
            writer.WriteLine();

            writer.WriteLine("Aufsteigend sortierte Zahlen:");
            double durchschnittAufsteigend = TesteUndBerechneDurchschnitt(writer, sortierMethode, aufsteigendSortiert, wiederholungen);
            writer.WriteLine($"Durchschnittliche Laufzeit: {durchschnittAufsteigend} microsec");
            writer.WriteLine();

            writer.WriteLine("Absteigend sortierte Zahlen:");
            double durchschnittAbsteigend = TesteUndBerechneDurchschnitt(writer, sortierMethode, absteigendSortiert, wiederholungen);
            writer.WriteLine($"Durchschnittliche Laufzeit: {durchschnittAbsteigend} microsec");
            writer.WriteLine();

            // Berechne den Durchschnitt über alle drei Datensätze
            double gesamtDurchschnitt = (durchschnittZufallsZahlen + durchschnittAufsteigend + durchschnittAbsteigend) / 3;

            writer.WriteLine($"Gesamtdurchschnittliche Laufzeit: {gesamtDurchschnitt} microsec");
            writer.WriteLine();

            return gesamtDurchschnitt;
        }

        private double TesteUndBerechneDurchschnitt(StreamWriter writer, Func<int[], int[]> sortierMethode, int[] arr, int wiederholungen)
        {
            double gesamtZeit = 0;

            for (int i = 0; i < wiederholungen; i++)
            {
                int[] kopie = (int[])arr.Clone();

                Stopwatch sw = Stopwatch.StartNew();
                sortierMethode(kopie);
                sw.Stop();

                gesamtZeit += sw.Elapsed.TotalNanoseconds;
                writer.WriteLine($"Laufzeit bei Durchgang {i + 1}: {sw.Elapsed.TotalNanoseconds} microsec");
            }

            return gesamtZeit / wiederholungen;
        }

        private int[] GeneriereZufallszahlen(int anzahl)
        {
            Random rnd = new Random();
            int[] arr = new int[anzahl];

            for (int i = 0; i < anzahl; i++)
            {
                arr[i] = rnd.Next(1000); // Zufallszahlen zwischen 0 und 999
            }

            return arr;
        }
}   }
