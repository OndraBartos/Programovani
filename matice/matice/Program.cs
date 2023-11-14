using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet řádků první matice"); //uživatel zadá počet rádků, přete mi je to a zkonvertuje na int
            string a = Console.ReadLine();
            int Row1 = int.Parse(a);
            Console.WriteLine("Zadej počet sloupců první matice"); //to samé u sloupců
            string b = Console.ReadLine();
            int Column1 = int.Parse(b);
            Console.Write("\n");

            Console.WriteLine("Vaše původní matice:");
            int[,] firstArray = new int[Row1, Column1]; // v hranatejch závorkách je čárka aby věděl že to je 2D pole
            int numberToAdd1 = 1;
            for (int i = 0; i < firstArray.GetLength(0); i++) //musím tam dát to getlength aby mi nebral celé pole o 25 členech ale jen těch 5 řádků
            {
                for (int j = 0; j < firstArray.GetLength(1); j++) //to samé udělám u sloupců 
                {                                           //firstArray.GetLength(0) určuje počet řádků dané matice/pole!!!!
                    firstArray[i, j] = numberToAdd1;        //firstArray.GetLength(1) určuje počat sloupců dané matice/pole!!!!
                    numberToAdd1++;
                    Console.Write(firstArray[i, j] + " "); // i jsou řádky, j jsou slopupce - nejdřív zadávám vždy řádky potom sloupce
                }
                Console.Write("\n");  // zkratka \n mi udělá nový řádek
                                      // když jí napíšu s write tak bude psát na další řádek, když ji napíšu s writeline udělá mi ještě enter navíc
            }
            Console.Write("\n");

            //PROHOZENÍ PRVKŮ 
            Console.WriteLine("Prohození prvků v poli:");
            //int[,] tempArray1 = new int[Row1, Column1];   překrývali se mi operace a snažil jsem se nějak vymyslet jak to opravit
            //napadlo mě že by to šlo udělat pomocí zkopírování původního pole do dočasného pole pro každý úkol zvlášť (podobně jako s jednotlivými oprvky)
            int[,] tempArray1 = (int[,])firstArray.Clone(); //musel jsem si najít na chat gtp jak si to meziuložit do tempArray
            int xfirst = 0;
            int yfirst = 0;                            //nejdřív si meziuložím prvnmí číslo na temporary/dočasnou proměnou, potom to první číslo přepíšu druhým číslem
            int xsecond = 1;                           //potom přepíšu druhé číslo dočasným číslem, které má hodnotu prvního čísla
            int ysecond = 1;
            int first = tempArray1[xfirst, yfirst];
            int second = tempArray1[xsecond, ysecond];
            int temp = first;
            tempArray1[xfirst, yfirst] = second;
            tempArray1[xsecond, ysecond] = temp;

            for (int i = 0; i < tempArray1.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray1.GetLength(1); j++)
                {
                    Console.Write(tempArray1[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //PROHOZENÍ ŘÁDKŮ
            Console.WriteLine("Prohození řádků v poli:");
            int[,] tempArray2 = (int[,])firstArray.Clone(); //musím si vytvořit novou pro každou operaci
            int nRowSwap = 0; //který řádek prohazujeme
            int mRowSwap = 1; //za který ho chceme prohodit
            int[] tempArrayRow = new int[5]; //podobně jako u císla chci přesunout celý řádek, proto si ho musím meziuložit v dočasném poli

            for (int j = 0; j < tempArray2.GetLength(0); j++) //zkopíruju nRowSwap do pomocného pole tempArray
            {
                tempArrayRow[j] = tempArray2[nRowSwap, j];
            }

            for (int j = 0; j < tempArray2.GetLength(0); j++) //přepíšu nRowSwap na mRowSwap
            {
                tempArray2[nRowSwap, j] = tempArray2[mRowSwap, j];
            }

            for (int j = 0; j < tempArray2.GetLength(0); j++) //přepíšu mRowSwap pomocným polem tempArray
            {
                tempArray2[mRowSwap, j] = tempArrayRow[j];
            }

            for (int i = 0; i < tempArray2.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray2.GetLength(1); j++)
                {
                    Console.Write(tempArray2[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //PROHAZOVÁNÍ SLOUPCŮ
            Console.WriteLine("Prohození sloupců v poli:");
            int[,] tempArray3 = (int[,])firstArray.Clone();
            int nColSwap = 0;
            int mColSwap = 1;
            int[] tempArrayColumn = new int[5];

            for (int i = 0; i < tempArray3.GetLength(0); i++) //ulozím první sloupec do dočasného pole
            {
                tempArrayColumn[i] = tempArray3[i, nColSwap];
            }

            for (int i = 0; i < tempArray3.GetLength(0); i++) //přepíšu první sloupec druhým sloupcem
            {
                tempArray3[i, nColSwap] = tempArray3[i, mColSwap];
            }

            for (int i = 0; i < tempArray3.GetLength(0); i++) //přepíšu druhý sloupec dočasným polem
            {
                tempArray3[i, mColSwap] = tempArrayColumn[i];
            }

            for (int i = 0; i < tempArray3.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray3.GetLength(1); j++)
                {
                    Console.Write(tempArray3[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //PROHOZENÍ POŘADÍ HLAVNÍ DIAGONÁLY
            Console.WriteLine("Prohození pořadí prvků na hlavní diagonále v poli:");
            int[,] tempArray4 = (int[,])firstArray.Clone();
            //int[,] tempArray2 = new int[Row1, Column1];
            for (int i = 0; i <= tempArray4.GetLength(0) / 2; i++) //automaticky zaorouhluje dolů
            {
                int temporary = tempArray4[i, i];
                int reversindex = tempArray4.GetLength(0) - i - 1;
                tempArray4[i, i] = tempArray4[reversindex, reversindex];
                tempArray4[reversindex, reversindex] = temporary;
            }

            for (int i = 0; i < tempArray4.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray4.GetLength(1); j++)
                {
                    Console.Write(tempArray4[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //PROHOZENÍ POŘADÍ VEDLEJŠÍ DIAGONÁLY
            Console.WriteLine("Prohození pořadí prvků na vedlejší diagonále v poli:");
            int[,] tempArray5 = (int[,])firstArray.Clone();
            for (int i = 0; i < tempArray5.GetLength(0) / 2; i++) //děleno dvěma aby fro cyklus jel jenom do poloviny řádků matice,
            {                                          //protože kdyby to tam nebylo,tak se mi prvky prohodí 2krát tzn. nic by se nezměnilo
                int temporary2 = tempArray5[i, tempArray5.GetLength(0) - i - 1];
                int j = tempArray5.GetLength(0) - i - 1;
                tempArray5[i, j] = tempArray5[j, i]; //zrcadlově prohodím souřadnice
                tempArray5[j, i] = temporary2;
            }

            for (int i = 0; i < tempArray5.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray5.GetLength(1); j++)
                {
                    Console.Write(tempArray5[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //NÁSOBENÍ MATICE ČÍSLEM
            Console.WriteLine("Zadejte číslo, kterým chcete matici vynásobit");
            int[,] tempArray6 = (int[,])firstArray.Clone();
            string x = Console.ReadLine();
            int multiplier = int.Parse(x);
            for (int i = 0; i < tempArray6.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray6.GetLength(1); j++)
                {
                    tempArray6[i, j] *= multiplier; // *= zkratka pro násobení a přiřazení, nyvásobí hodnotu i a j tím co je za rovná se
                }
            }
            for (int i = 0; i < tempArray6.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray6.GetLength(1); j++)
                {
                    Console.Write(tempArray6[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");




            //druhá matice na další operace
            Console.WriteLine("Zadej počet řádků druhé matice");
            string c = Console.ReadLine();
            int Row2 = int.Parse(c);
            Console.WriteLine("Zadej počet sloupců druhé matice");
            string d = Console.ReadLine();
            int Column2 = int.Parse(d);

            int[,] secondArray = new int[Row2, Column2];
            int numberToAdd2 = 1;
            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    secondArray[i, j] = numberToAdd2;
                    numberToAdd2++;
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");


            Console.ReadKey();
        }
    }
}
