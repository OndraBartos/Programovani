using System;

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
            int[,] tempArray1 = (int[,])firstArray.Clone(); //musel jsem si najít na chat gtp jak si to meziuložit do tempArray
            //int xfirst = 0;
            //int yfirst = 0;                       //nejdřív si meziuložím prvnmí číslo na temporary/dočasnou proměnou, potom to první číslo přepíšu druhým číslem
            //int xsecond = 1;                      //potom přepíšu druhé číslo dočasným číslem, které má hodnotu prvního čísla
            //int ysecond = 1;
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
            Console.WriteLine("Zadej řádek, který chceš prohodit");
            string k = Console.ReadLine();
            int nRowSwap = int.Parse(k) - 1;
            Console.WriteLine("Zadej řádek, se kterým ho chceš prohodit");
            string l = Console.ReadLine();
            int mRowSwap = int.Parse(l) - 1;
            Console.Write("\n");

            Console.WriteLine("Prohození řádků v poli:");
            int[,] tempArray2 = (int[,])firstArray.Clone(); //musím si vytvořit novou pro každou operaci
            //int nRowSwap = 0; //který řádek prohazujeme
            //int mRowSwap = 1; //za který ho chceme prohodit
            int[] tempArrayRow = new int[Row1]; //podobně jako u čísla chci přesunout celý řádek, proto si ho musím meziuložit v dočasném poli
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
            Console.WriteLine("Zadej sloupec, který chceš prohodit");            //to samé co u řádků udělám u sloupců
            string m = Console.ReadLine();
            int nColSwap = int.Parse(m) - 1;
            Console.WriteLine("Zadej sloupec, se kterým ho chceš prohodit)");
            string n = Console.ReadLine();
            int mColSwap = int.Parse(n) - 1;
            Console.Write("\n");

            Console.WriteLine("Prohození sloupců v poli:");
            int[,] tempArray3 = (int[,])firstArray.Clone();
            //int nColSwap = 0;                                   
            //int mColSwap = 1;
            int[] tempArrayColumn = new int[Column1];
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
            Console.WriteLine("Zde je původní matice vynásobená vámi zvoleným číslem:");
            for (int i = 0; i < tempArray6.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray6.GetLength(1); j++)
                {
                    Console.Write(tempArray6[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");


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
            for (int i = 0; i < secondArray.GetLength(0); i++) //vypsání druhé matice
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");


            //SČÍTÁNÍ/ODČÍTÁNÍ DVOU MATIC
            Console.WriteLine("Chcete od sebe matice sčítat, nebo odčítat?");
            Console.WriteLine("(pro sčítaní zadejte +)");
            Console.WriteLine("(pro odčítání zadejte -)");
            int[,] tempArray7 = (int[,])firstArray.Clone();
            int[,] tempArray8 = (int[,])firstArray.Clone();
            string choice = Console.ReadLine();
            //choice = Console.ReadLine();
            if (choice == "+")
            {
                for (int i = 0; i < tempArray7.GetLength(0); i++)
                {
                    for (int j = 0; j < tempArray7.GetLength(1); j++)
                    {
                        tempArray7[i, j] = firstArray[i, j] + secondArray[i, j]; //výsledná matice se rovná první matice + druhá matice
                    }
                }
                Console.WriteLine("Zde je výsledná matice po sčítání:");
                for (int i = 0; i < tempArray7.GetLength(0); i++) //vypsání do konzole
                {
                    for (int j = 0; j < tempArray7.GetLength(1); j++)
                    {
                        Console.Write(tempArray7[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            else if (choice == "-")
            {
                for (int i = 0; i < tempArray8.GetLength(0); i++)
                {
                    for (int j = 0; j < tempArray8.GetLength(1); j++)
                    {
                        tempArray8[i, j] = firstArray[i, j] - secondArray[i, j]; //výsledná matice se rovná první matice - druhá matice
                    }
                }
                Console.WriteLine("Zde je výsledná matice po odčítání:");
                for (int i = 0; i < tempArray8.GetLength(0); i++) //vypsání do konzole
                {
                    for (int j = 0; j < tempArray8.GetLength(1); j++)
                    {
                        Console.Write(tempArray8[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("ŠPATNĚ ZADANÁ MOŽNOST OPERACE");
            }


            //TRANSPOZICE MATICE
            int[,] tempArray9 = (int[,])firstArray.Clone();
            for (int i = 0; i < tempArray9.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray9.GetLength(1); j++)
                {
                    tempArray9[i, j] = firstArray[j, i]; //v nové matici se prvek na pozici [1, 2] rovná prvku v originální matici na pozici [2, 1]
                }
            }
            Console.WriteLine("Zde je výsledná matice po transpozici = převrácení kolem hlavní diagonály:");
            for (int i = 0; i < tempArray9.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray9.GetLength(1); j++)
                {
                    Console.Write(tempArray9[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");


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
            for (int i = 0; i < tempArray10.GetLength(0); i++) //vypsání do konzole
            {
                for (int j = 0; j < tempArray10.GetLength(1); j++)
                {
                    Console.Write(tempArray10[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");


            Console.WriteLine("KONEC, stiskněte jakoukoli klávesu pro ukončení");
            //program čěká na ukončení
            Console.ReadKey();
        }
    }
}
