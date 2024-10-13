using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortieralgorithmen_MT
{
    class Algo
    {

        public static int[] Bubblesort(int[] arra) // Bubblesort Methode
        {
            int temp; // für den Tausch
            for (int i = 0; i < arra.Length - 1; i++)// äußere schleife fürs ganze array
            {

                for (int j = 0; j < arra.Length - i - 1; j++) // innere schleife für jeden durchgang der kleiner wird
                {
                    if (arra[j] > arra[j + 1])// tasuch abfrage
                    {

                        temp = arra[j];//tausch
                        arra[j] = arra[j + 1];
                        arra[j + 1] = temp;

                    }
                }

            }
            return arra;// gibt array wieder
        }

        public static int[] Insertionsort(int[] arra) // Methode für Insertionsort
        {



            
            for (int i = 1; i < arra.Length; ++i)
            {
                int val = arra[i];// aktueller wert, rechts neben sortiertem array
                int j = i - 1;// ganz rechts im sortierten array

                
                while (j >= 0 && arra[j] > val) // schaut ob der linke nachbar größer ist als der linke bis j ganz links ist
                {
                    arra[j + 1] = arra[j]; // tausch
                    j = j - 1; // rückt weiter nach liks
                }
                arra[j + 1] = val;// tausch
            }
            return arra; // gibt array wieder
        }
    
    

        public static int[] Selectionsort(int[] arra) // Methode für Selectionsort
        {

            for (int i = 0; i < arra.Length - 1; i++) // Loop für ganze array
            {

                int min = i;// minimum wird zur aktuellen postion gesetzt
                for (int j = i + 1; j < arra.Length; j++) // geht durch das restliche array und sucht nach min
                {
                    if (arra[j] < arra[min])// wenn min gefunden dann neuer index wird zu min
                    {

                        min = j;


                    }
                }

                if (min != i) // wenn min ein neuer index ist dann vertausche
                {
                    int temp = arra[i];// tausch
                    arra[i] = arra[min];
                    arra[min] = temp;
                }

            }

            return arra; // gibt array zurück

        }

        public static int[] Quicksort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;// linker index 
            var j = rightIndex; // rechter index
            var pivot = array[leftIndex]; //pivot für die vergleiche

            while (i <= j) // schleife um zu schauen ob durch das array schon durch gegangen wurde
            {
                while (array[i] < pivot) // schaut ob der wert kleiner ist als der pivot 
                {
                    i++; // erhöht den linken index, wenn es passt
                }

                while (array[j] > pivot) //schaut ob der rechte index größer ist
                {
                    j--;// reduziert den rchten index, wenn es passt
                }

                if (i <= j)// schaut ob der linke index kleiner ist als der rechte index
                {
                    int temp = array[i]; // tascht den linken und rechten index
                    array[i] = array[j];
                    array[j] = temp;
                    i++;// erhöht den linken index
                    j--;//rechöt den rechten index
                }
            }

            if (leftIndex < j) // schaut ob der linke index kleiner ist als der rechte index
                Quicksort(array, leftIndex, j); // rekursion, sortiert das linke sub-array endet dort wo der pivot ist

            if (i < rightIndex) // schaut ob der rechte index größer ist als der linke index
                Quicksort(array, i, rightIndex);// rekursion, sortiert das rechte sub-array endet dort wo der pivot ist

            return array;
        }

        public static int[] Sort(int[] arra)
        {
            Array.Sort(arra);

            return arra;
        }




    }
}
