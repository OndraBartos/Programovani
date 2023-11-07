using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).

            int[,] my2DArray = new int[5, 5]; //říkám mu že to bud epole 5x5  !!!!nejdřív zadávám řádky pak sloupce!!!!
            // tím že dám do hranatých závorek cárku značím tím že to bude 2D pole; dvě čárky 3D pole
            int numberToAdd = 1;
            for (int i = 0; i < my2DArray.GetLength(0); i++) //musím tam dát to getlength aby mi nebral celé pole o 25 členech ale jen tech 5 řádků
            {
                for (int j = 0; j < my2DArray.GetLength(0); j++) //to samé udělám u sloupců 
                {
                    my2DArray[i, j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(my2DArray[i, j] + " "); // i jsou řádky, j jsou slopupce - nejdřív zadávám vždy řádky potom sloupce
                }
                Console.Write("\n");  // zkratka \n mi udělá nový řádek
                                      // když jí napíšu s write tak bude psát na další řádek, když ji napíšu s writeline udělá mi ještě enter navíc
            }
            Console.Write("\n");

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0; //řeknu mu který řádak chci aby mi ukázal a ten jedinej napíše, nRow = počet řádků (budu měnit a zkoušet)
            for (int j = 0; j < my2DArray.GetLength(0); j++)
            {
                Console.Write(my2DArray[nRow, j] + " "); //počet řádků zadám manuálně, ale musím naprogramovat sloupce a celé pole
            }
            Console.WriteLine("\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0; //to samé ale u sloupců
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i, nColumn] + " ");
            }
            Console.WriteLine("\n");

            //BONUS TODO: Vypiš do konzole prvky na hlavní diagonále
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i, i] + " ");
            }
            Console.WriteLine("\n");

            //BONUS TODO: Vypiš do konzole prvky na vfedlejší diagonále
            for (int i = my2DArray.GetLength(0) - 1; i >= 0; i--) // fungovalo by taky i = 4
            {
                Console.Write(my2DArray[i, my2DArray.GetLength(0) - i - 1] + " ");
            }
            Console.WriteLine("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý

            //int xFirst = 0;
            //int yFirst = 0;                            //nejdřív si meziuložím prvnmí číslo na temporary/dočasnou proměnou, potom to první číslo přepíšu druhým číslem
            //int xSecond = 1;                           //potom přepíšu druhé číslo dočasným číslem, které má hodnotu prvního čísla
            //int ySecond = 1;
            //int firts = my2DArray[xFirst, yFirst];
            //int second = my2DArray[xSecond, ySecond];
            //int temp = firts;
            //my2DArray[xFirst, yFirst] = second;
            //my2DArray[xSecond, ySecond] = temp;

            //for (int i = 0; i < my2DArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < my2DArray.GetLength(0); j++)
            //    {
            //        Console.Write(my2DArray[i, j] + " "); // i jsou řádky, j jsou slopupce
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0; //který řádek prohazujeme
            int mRowSwap = 1; //za který ho chceme prohodit
            int[] tempArray = new int[5]; //podobně jako u císla chci přesunout celý řádek, proto si ho musím meziuložit v dočasném poli

            for (int j = 0; j < my2DArray.GetLength(0); j++) //zkpíruju nRowSwapu do pomocného pole tempArray
            {
                tempArray[j] = my2DArray[nRowSwap, j];
            }

            /*for (int j = 0; j < my2DArray.GetLength(0); j++) //přepíšu nRowSwap na mRowSwap
            {
                my2DArray[nRowSwap, j] = my2DArray[mRowSwap, j];
            }

            for (int j = 0; j < my2DArray.GetLength(0); j++) //přepíšu mRowSwap pomocným polem tempArray
            {
                my2DArray[mRowSwap, j] = tempArray[j];
            }*/

            for (int i = 0; i < my2DArray.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < my2DArray.GetLength(0); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            int[] tempArrayColumn = new int[5];

            for (int i = 0; i < my2DArray.GetLength(0); i++) //ulozím první sloupec do dočasného pole
            {
                tempArrayColumn[i] = my2DArray[i, nColSwap];
            }

            //for (int i = 0; i < my2DArray.GetLength(0); i++) //přepíšu první sloupec druhým sloupcem
            //{
            //    my2DArray[i, nColSwap] = my2DArray[i, mColSwap];
            //}

            //for (int i = 0; i < my2DArray.GetLength(0); i++) //přepíšu druhý sloupec dočasným polem
            //{
            //    my2DArray[i, mColSwap] = tempArrayColumn[i];
            //}

            for (int i = 0; i < my2DArray.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < my2DArray.GetLength(0); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.

            for (int i = 0; i <= my2DArray.GetLength(0) / 2; i++) //automaticky zaorouhluje dolů
            {
                int temporary = my2DArray[i, i];
                int reversindex = my2DArray.GetLength(0) - i - 1;
                my2DArray[i, i] = my2DArray[reversindex, reversindex];
                my2DArray[reversindex, reversindex] = temporary;
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < my2DArray.GetLength(0); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.



            for (int i = 4; i >= my2DArray.GetLength(0) / 2; i--)
            {
                
                int temporary2 = my2DArray[i, my2DArray.GetLength(0) - i - 1];
                int j = my2DArray.GetLength(0) - i - 1;
                my2DArray[i, j] = my2DArray[j, i]; //zrcadlově prohodím souřadnice
                my2DArray[j, i] = temporary2;
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < my2DArray.GetLength(0); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
