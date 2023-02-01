using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferrari_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = false;
            string[] array = new string[100];
            int lunghezza = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Selezionare un'opzione:\n1 - Aggiunta di un animale\n2 - Cancellazione di un animale singolo\n3 - Ordinamento dei nomi\n4 - Ricerca di un animale\n5 - Visualizzazione animali ripetuti\n6 - Modifica di un nome\n7 - Visualizzazione di tutti i nomi\n8 - Ricerca del nome più lungo e più corto\n9 - Cancellazione di tutte le occorrenze di un animale\n0 - Uscita dal programma");
                switch (Console.ReadLine())
                {
                    case "1":                                     //aggiunta
                        Console.WriteLine("Inserire animale: ");
                        string aggiunto = Console.ReadLine();
                        if (Aggiunta(ref lunghezza, array, aggiunto))
                        {
                            Console.WriteLine("Il numero è stato inserito");
                        }
                        else
                        {
                            Console.WriteLine("Il numero non è stato inserito, array pieno");
                        }
                        break;
                    case "2":                                     //cancella
                        Cancella();
                        break;
                    case "3":                                     //bubblesort x ordine alfabetico
                        break;
                    case "4":                                     //ricerca sequenziale
                        break;
                    case "5":                                     //visualizza animali ripetuti
                        break;
                    case "6":                                     //modifica nome
                        break;
                    case "7":                                     //visualizza array/animali
                        for (int i = 0; i < lunghezza; i++)
                        {
                            Console.Write($"{array[i]} ");
                        }
                        break;
                    case "8":                                     //ricerca nome più lungo e più corto, visualizzazione
                        break;
                    case "9":                                     //cancella tutti i nomi uguali
                        break;
                    case "0":                                     //uscita
                        continua = true;
                        break;
                };
                Console.ReadKey();
            } while (continua == false);
        }
        static bool Aggiunta(ref int lunghezza, string[] arr, string agg)
        {
            bool inserito = false;
            if (lunghezza < 100)
            {
                arr[lunghezza] = agg;
                lunghezza++;
                inserito = true;
            }
            return inserito;
        }                       //aggiunta
        static void Cancella()
        {

        }                                                      //cancella
        //bubblesort
        //ricerca
        //visualizza ripetuti
        //modifica nome
        //visuaizza array
        //ricerca nome più lungo/corto
        //cancella nomi uguali
    }                   
}
