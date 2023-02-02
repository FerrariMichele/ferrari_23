using System;
using System.Collections.Generic;
using System.Globalization;
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
                Console.WriteLine("Selezionare un'opzione:\n1 - Aggiunta di un nome\n2 - Cancellazione di un nome singolo\n3 - Ordinamento dei nomi\n4 - Ricerca di un nome\n5 - Visualizzazione nomi ripetuti\n6 - Modifica di un nome\n7 - Visualizzazione di tutti i nomi\n8 - Ricerca del nome più lungo e più corto\n9 - Cancellazione di tutte le occorrenze di un nome\n0 - Uscita dal programma");
                switch (Console.ReadLine())
                {
                    case "1":                                     //aggiunta
                        if (lunghezza < 100)                                    //verifica se l'array è pieno
                        {
                            Console.WriteLine("Inserire nome da aggiungere: ");               
                            string aggiunto = Console.ReadLine();
                            Aggiunta(ref lunghezza, array, aggiunto);           //chiamata della funzione di aggiunta
                            Console.WriteLine("Il nome è stato inserito");
                        }
                        else
                        {
                            Console.WriteLine("Impossibile inserire nome, array pieno");
                        }
                        break;
                    case "2":                                     //cancella
                        if (lunghezza > 0)
                        {
                            Console.WriteLine("Inserire nome da cancellare: ");
                            string cancellato = Console.ReadLine();
                            Cancella(ref lunghezza, array, cancellato);           //chiamata della funzione di cancellazione
                            Console.WriteLine("Il nome è stato cancellato");
                        }
                        else
                        {
                            Console.WriteLine("Impossibile cancellare nome, array vuoto");
                        }
                        break;
                    case "3":                                     //bubblesort x ordine alfabetico
                        BubbleSort(lunghezza, array);
                        Console.WriteLine("Array ordinato in ordine alfabetico");
                        break;
                    case "4":                                     //ricerca sequenziale
                        Console.WriteLine("Inserire nome da ricercare: ");
                        string ricerca = Console.ReadLine();
                        int posizione = RicercaSequenziale(lunghezza, ricerca, array);
                        if (posizione < 0)
                        {
                            Console.WriteLine("Il nome inserito non è presente nell'array");
                        }
                        else
                        {
                            Console.WriteLine($"L'elemento {ricerca} si trova in posizione {posizione}");
                        }
                        break;
                    case "5":                                     //visualizza nomi ripetuti
                        VisualizzaRipetuti(lunghezza, array);
                        break;
                    case "6":                                     //modifica nome
                        Console.WriteLine("Inserire posizione del nome da modificare: ");
                        int posmodifica = int.Parse(Console.ReadLine());
                        if (posmodifica < 0 || posmodifica > lunghezza) 
                        {
                            Console.WriteLine("Posizione non valida");
                        }
                        else
                        {
                            Console.WriteLine($"Nome attuale:\n{array[posmodifica]}\nInserire nuovo nome:");
                            string modifica = Console.ReadLine();
                            ModificaNome(array, modifica, posmodifica);
                        }
                        break;
                    case "7":                                     //visualizza array/nomi
                        Visualizza(array, lunghezza);
                        break;
                    case "8":                                     //ricerca nome più lungo e più corto, visualizzazione
                        LungoCorto(array, lunghezza);
                        break;
                    case "9":                                     //cancella tutti i nomi uguali
                        if (lunghezza > 0)
                        {
                            Console.WriteLine("Inserire nome da cancellare: ");
                            string cancellato = Console.ReadLine();
                            CancellaUguali(ref lunghezza, array, cancellato);           //chiamata della funzione di cancellazione
                            Console.WriteLine("Il nome è stato cancellato");
                        }
                        else
                        {
                            Console.WriteLine("Impossibile cancellare nome, array vuoto");
                        }
                        break;
                    case "0":                                     //uscita
                        continua = true;
                        break;
                };
                Console.WriteLine("Premere un tasto per continuare: ");
                Console.ReadKey();
            } while (continua == false);
        }
        static void Aggiunta(ref int lunghezza, string[] arr, string agg)
        {
                arr[lunghezza] = agg;
                lunghezza++;
        }            //aggiunta
        static void Cancella(ref int lunghezza, string[] arr, string can)
        {
            for (int i = 0; i < lunghezza; i++)
            {
                if (arr[i] == can) 
                {
                    for (; i < lunghezza - 1; i++) 
                    {
                        arr[i] = arr[i + 1];
                    }
                    lunghezza--;
                    break;
                }
            }
        }            //cancella
        static void BubbleSort(int lun, string[] arr) 
        {
            int x, y;
            string temp;
            for (x = 0; x < lun - 1; x++) 
            {
                for (y = 0; y < lun - 1; y++)
                {
                    int comp = string.Compare(arr[y], arr[y + 1]);      
                    if (comp == 1)
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
        }                               //bubblesort
        static int RicercaSequenziale(int lun, string ric, string[] arr) 
        {
            int pos = 0;
            for (int i = 0; i < lun; i++)
            {
                if (arr[i] == ric)
                {
                    pos = i;
                    break;
                }
                else
                {
                    pos = -1;
                }
            }
            return pos;
        }            //ricerca
        static void VisualizzaRipetuti(int lun, string[] arr) 
        {

        }                       //visualizza ripetuti
        static void ModificaNome(string[] arr, string nuovo, int posizione)
        {
            arr[posizione] = nuovo;
        }          //modifica nome
        static void Visualizza(string[] arr, int lun)
        {
            for (int i = 0; i < lun; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }                                //visualizza array
        static void LungoCorto(string[] arr, int lun) 
        {
            string lungo = arr[0], corto = arr[0];
            for (int i = 1; i < lun; i++)
            {
                
                if (arr[i].Length > lungo.Length)
                {
                    lungo = arr[i];
                }
                if (arr[i].Length < corto.Length)
                {
                    corto = arr[i];
                }
            }
            Console.WriteLine($"il nome più lungo è: {lungo}");
            Console.WriteLine($"il nome più corto è: {corto}");
        }                               //ricerca nome più lungo/corto
        static void CancellaUguali(ref int lunghezza, string[] arr, string can)
        {
            for (int i = 0; i < lunghezza; i++)
            {
                if (arr[i] == can) 
                {
                    for (int j = i; j < lunghezza - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[lunghezza] = null;
                    i--;
                    lunghezza--;
                }
            }
        }      //cancella nomi uguali
    }                   
}
