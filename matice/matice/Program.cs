using System;

namespace matice
{
    internal class Program
    {
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

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
            Console.WriteLine("Zadej souřadnice čísla které budeš chtít měnít (nejdřív řádek, poté enter, pak sloupec)");
            string u = Console.ReadLine();
            int xfirst = int.Parse(u) - 1;  //musím dát u každého - 1, protože index je vždy o jedno menší než velikost řádku/sloupce
            string v = Console.ReadLine();  //tzn. že kdybych tam nedal - 1, tak mi to spadne pokaždý co budu chtít měnit nějakou souřadnici na horním kraji pole
            int yfirst = int.Parse(v) - 1;  //to samé u prohazování řádků a sloupců viz. dole
            Console.WriteLine("Nyní zadej souřadnice čísla se kterým ho budeš chtít měnít (nejdřív řádek, poté enter, pak sloupec)"); //to samé u sloupců
            string s = Console.ReadLine();
            int xsecond = int.Parse(s) - 1;
            string t = Console.ReadLine();
            int ysecond = int.Parse(t) - 1;
            Console.Write("\n");

            Console.WriteLine("Prohození zvolených prvků v poli:");
            //int[,] tempArray1 = new int[Row1, Column1];   překrývali se mi operace a snažil jsem se nějak vymyslet jak to opravit
            //napadlo mě že by to šlo udělat pomocí zkopírování původního pole do dočasného pole pro každý úkol zvlášť (podobně jako s jednotlivými oprvky)
            int[,] swapNumberArray = (int[,])firstArray.Clone(); //musel jsem si najít na chat gtp jak si to meziuložit do tempArray
            //int xfirst = 0;
            //int yfirst = 0;                       //nejdřív si meziuložím prvnmí číslo na temporary/dočasnou proměnou, potom to první číslo přepíšu druhým číslem
            //int xsecond = 1;                      //potom přepíšu druhé číslo dočasným číslem, které má hodnotu prvního čísla
            //int ysecond = 1;
            int first = swapNumberArray[xfirst, yfirst];
            int second = swapNumberArray[xsecond, ysecond];
            int temp = first;
            swapNumberArray[xfirst, yfirst] = second;
            swapNumberArray[xsecond, ysecond] = temp;
            PrintArray(swapNumberArray);
            //for (int i = 0; i < swapNumberArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < swapNumberArray.GetLength(1); j++)
            //    {
            //        Console.Write(swapNumberArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //PROHOZENÍ ŘÁDKŮ
            Console.WriteLine("Zadej řádek, který chceš prohodit");
            string k = Console.ReadLine();
            int nRowSwap = int.Parse(k) - 1;
            Console.WriteLine("Zadej řádek, se kterým ho chceš prohodit");
            string l = Console.ReadLine();
            int mRowSwap = int.Parse(l) - 1;
            Console.Write("\n");

            Console.WriteLine("Prohození řádků v poli:");
            int[,] rowArray = (int[,])firstArray.Clone(); //musím si vytvořit novou pro každou operaci
            //int nRowSwap = 0; //který řádek prohazujeme
            //int mRowSwap = 1; //za který ho chceme prohodit
            int[] tempArrayRow = new int[Row1]; //podobně jako u čísla chci přesunout celý řádek, proto si ho musím meziuložit v dočasném poli
            for (int j = 0; j < rowArray.GetLength(0); j++) //zkopíruju nRowSwap do pomocného pole tempArray
            {
                tempArrayRow[j] = rowArray[nRowSwap, j];
            }
            for (int j = 0; j < rowArray.GetLength(0); j++) //přepíšu nRowSwap na mRowSwap
            {
                rowArray[nRowSwap, j] = rowArray[mRowSwap, j];
            }
            for (int j = 0; j < rowArray.GetLength(0); j++) //přepíšu mRowSwap pomocným polem tempArray
            {
                rowArray[mRowSwap, j] = tempArrayRow[j];
            }
            PrintArray(rowArray);
            //for (int i = 0; i < rowArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < rowArray.GetLength(1); j++)
            //    {
            //        Console.Write(rowArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //PROHAZOVÁNÍ SLOUPCŮ
            Console.WriteLine("Zadej sloupec, který chceš prohodit");            //to samé co u řádků udělám u sloupců
            string m = Console.ReadLine();
            int nColSwap = int.Parse(m) - 1;
            Console.WriteLine("Zadej sloupec, se kterým ho chceš prohodit)");
            string n = Console.ReadLine();
            int mColSwap = int.Parse(n) - 1;
            Console.Write("\n");

            Console.WriteLine("Prohození sloupců v poli:");
            int[,] columnArray = (int[,])firstArray.Clone();
            //int nColSwap = 0;                                   
            //int mColSwap = 1;
            int[] tempArrayColumn = new int[Column1];
            for (int i = 0; i < columnArray.GetLength(0); i++) //ulozím první sloupec do dočasného pole
            {
                tempArrayColumn[i] = columnArray[i, nColSwap];
            }
            for (int i = 0; i < columnArray.GetLength(0); i++) //přepíšu první sloupec druhým sloupcem
            {
                 columnArray[i, nColSwap] = columnArray[i, mColSwap];
            }
            for (int i = 0; i < columnArray.GetLength(0); i++) //přepíšu druhý sloupec dočasným polem
            {
                columnArray[i, mColSwap] = tempArrayColumn[i];
            }
            PrintArray(columnArray);
            //for (int i = 0; i < columnArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < columnArray.GetLength(1); j++)
            //    {
            //        Console.Write(columnArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //PROHOZENÍ POŘADÍ HLAVNÍ DIAGONÁLY
            Console.WriteLine("Prohození pořadí prvků na hlavní diagonále v poli:");
            int[,] swapMDArray = (int[,])firstArray.Clone();                             //swapMD = swap Main Diagonal
            //int[,] tempArray2 = new int[Row1, Column1];
            for (int i = 0; i <= swapMDArray.GetLength(0) / 2; i++) //automaticky zaorouhluje dolů
            {
                int temporary = swapMDArray[i, i];
                int reversindex = swapMDArray.GetLength(0) - i - 1;
                swapMDArray[i, i] = swapMDArray[reversindex, reversindex];
                swapMDArray[reversindex, reversindex] = temporary;
            }
            PrintArray(swapMDArray);
            //for (int i = 0; i < swapMDArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < swapMDArray.GetLength(1); j++)
            //    {
            //        Console.Write(swapMDArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //PROHOZENÍ POŘADÍ VEDLEJŠÍ DIAGONÁLY
            Console.WriteLine("Prohození pořadí prvků na vedlejší diagonále v poli:");
            int[,] swapSDArray = (int[,])firstArray.Clone();                             //swapSD = swap Secondary Diagonal
            for (int i = 0; i < swapSDArray.GetLength(0) / 2; i++) //děleno dvěma aby fro cyklus jel jenom do poloviny řádků matice,
            {                                          //protože kdyby to tam nebylo,tak se mi prvky prohodí 2krát tzn. nic by se nezměnilo
                int temporary2 = swapSDArray[i, swapSDArray.GetLength(0) - i - 1];
                int j = swapSDArray.GetLength(0) - i - 1;
                swapSDArray[i, j] = swapSDArray[j, i]; //zrcadlově prohodím souřadnice
                swapSDArray[j, i] = temporary2;
            }
            PrintArray(swapSDArray);
            //for (int i = 0; i < swapSDArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < swapSDArray.GetLength(1); j++)
            //    {
            //        Console.Write(swapSDArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //NÁSOBENÍ MATICE ČÍSLEM
            Console.WriteLine("Zadejte číslo, kterým chcete matici vynásobit");
            int[,] multiplyArray = (int[,])firstArray.Clone();
            string x = Console.ReadLine();
            int multiplier = int.Parse(x);
            for (int i = 0; i < multiplyArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiplyArray.GetLength(1); j++)
                {
                    multiplyArray[i, j] *= multiplier; // *= zkratka pro násobení a přiřazení, nyvásobí hodnotu i a j tím co je za rovná se
                }
            }
            Console.WriteLine("Zde je původní matice vynásobená vámi zvoleným číslem:");
            PrintArray(multiplyArray);
            //for (int i = 0; i < multiplyArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < multiplyArray.GetLength(1); j++)
            //    {
            //        Console.Write(multiplyArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //DRUHÁ MATICE NA DALŠÍ OPERACE
            //Console.WriteLine("Zadej počet řádků druhé matice");
            //string c = Console.ReadLine();                               nejdřív jsem chtěl ať si druhou matici opět zadá uživatel
            //int Row2 = int.Parse(c);                                     pak mi ale došlo že musí mít stejnou velikost
            //Console.WriteLine("Zadej počet sloupců druhé matice");
            //string d = Console.ReadLine();
            //int Column2 = int.Parse(d);
            int[,] secondArray = new int[Row1, Column1]; //druhá matice, která bude mít stejně řádků a sloupců jako první matice
            Random rng = new Random();
            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    secondArray[i, j] = rng.Next(1, Row1 * Column1);
                }   //naplním ji náhodnými čísly v rozmezí od 1 do maximální velikosti matice(Row*Column)
            }
            Console.WriteLine("Zde je druhá matice naplněná náhodnými čísly:");
            PrintArray(secondArray);
            //for (int i = 0; i < secondArray.GetLength(0); i++) //vypsání druhé matice
            //{
            //    for (int j = 0; j < secondArray.GetLength(1); j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //SČÍTÁNÍ/ODČÍTÁNÍ DVOU MATIC
            Console.WriteLine("Chcete od sebe matice sčítat, nebo odčítat?");
            Console.WriteLine("(pro sčítaní zadejte +)");
            Console.WriteLine("(pro odčítání zadejte -)");
            int[,] toAddArray = (int[,])firstArray.Clone();
            int[,] toSubtractArray = (int[,])firstArray.Clone();
            string choice = Console.ReadLine();
            //choice = Console.ReadLine();
            if (choice == "+")
            {
                for (int i = 0; i < toAddArray.GetLength(0); i++)
                {
                    for (int j = 0; j < toAddArray.GetLength(1); j++)
                    {
                        toAddArray[i, j] = firstArray[i, j] + secondArray[i, j]; //výsledná matice se rovná první matice + druhá matice
                    }
                }
                Console.WriteLine("Zde je výsledná matice po sčítání:");
                PrintArray(toAddArray);
                //for (int i = 0; i < toAddArray.GetLength(0); i++) //vypsání do konzole
                //{
                //    for (int j = 0; j < toAddArray.GetLength(1); j++)
                //    {
                //        Console.Write(toAddArray[i, j] + " ");
                //    }
                //    Console.Write("\n");
                //}
                //Console.Write("\n");
            }
            else if (choice == "-")
            {
                for (int i = 0; i < toSubtractArray.GetLength(0); i++)
                {
                    for (int j = 0; j < toSubtractArray.GetLength(1); j++)
                    {
                        toSubtractArray[i, j] = firstArray[i, j] - secondArray[i, j]; //výsledná matice se rovná první matice - druhá matice
                    }
                }
                Console.WriteLine("Zde je výsledná matice po odčítání:");
                PrintArray(toSubtractArray);
                //for (int i = 0; i < toSubtractArray.GetLength(0); i++) //vypsání do konzole
                //{
                //    for (int j = 0; j < toSubtractArray.GetLength(1); j++)
                //    {
                //        Console.Write(toSubtractArray[i, j] + " ");
                //    }
                //    Console.Write("\n");
                //}
                //Console.Write("\n");
            }
            else
            {
                Console.WriteLine("ŠPATNĚ ZADANÁ MOŽNOST OPERACE");
            }


            //TRANSPOZICE MATICE
            int[,] rotationArray = new int[firstArray.GetLength(1), firstArray.GetLength(0)];
            for (int i = 0; i < rotationArray.GetLength(0); i++)
            {
                for (int j = 0; j < rotationArray.GetLength(1); j++)
                {
                    rotationArray[i, j] = firstArray[j, i]; //v nové matici se prvek na pozici [1, 2] rovná prvku v originální matici na pozici [2, 1]
                }
            }
            Console.WriteLine("Zde je výsledná matice po transpozici = převrácení kolem hlavní diagonály:");
            PrintArray(rotationArray);
            //for (int i = 0; i < rotationArray.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < rotationArray.GetLength(1); j++)
            //    {
            //        Console.Write(rotationArray[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            //NÁSOBENÍ DVOU MATIC
            //nevím jestli jsem to pochopil špatně, ale je to úplně stejný jako to sčítání a odčítání
            int[,] tempArray10 = (int[,])firstArray.Clone();
            for (int i = 0; i < tempArray10.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray10.GetLength(1); j++)
                {
                    tempArray10[i, j] = firstArray[i, j] * secondArray[i, j]; //výsledná matice se rovná první matice * druhá matice
                }
            }
            Console.WriteLine("Zde je výsledná matice po násobení:");
            PrintArray(tempArray10);
            //for (int i = 0; i < tempArray10.GetLength(0); i++) //vypsání do konzole
            //{
            //    for (int j = 0; j < tempArray10.GetLength(1); j++)
            //    {
            //        Console.Write(tempArray10[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");


            Console.WriteLine("KONEC, stiskněte jakoukoli klávesu pro ukončení");
            //program čěká na ukončení
            Console.ReadKey();
        }
    }
}
