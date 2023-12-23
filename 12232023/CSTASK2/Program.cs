using System;
using System.Diagnostics;
using System.Threading;

namespace CSTASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək
            Console.Write("Icinde bosluqlar olmayan yeni yazi duzeltmek ucun yazi daxil edin - ");
            string yazi = Console.ReadLine();

            string yeniYazi = "";

            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] == ' ')
                    continue;
                else
                    yeniYazi += yazi[i];
            }

            Console.WriteLine($"Bosluqlari silindikden sonra yazi : {yeniYazi}");

            #endregion

            #region Task2
            //Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
            Console.WriteLine("Verilmis siyahidaki verilmis n ededinin yerlesdiyi indexi tapmaq ucun evvelce,siyahinin uzunlugunu daxil edin:");
            string sayStr = Console.ReadLine();
            int say = int.Parse(sayStr);
            string[] uzunluq = new string[say];

            for (int i = 0; i < uzunluq.Length; i++)
            {
                Console.Write($"{i + 1}. ededi daxil edin: ");
                uzunluq[i] = Console.ReadLine();
            }

            for(int i = 0; i<uzunluq.Length; i++)
                Console.WriteLine($"{uzunluq[i]} Yerlesdiyi index - {i}");

            #endregion

            #region Task3
            //Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
            Console.WriteLine("Verilmis herfin verilmis siyahida sayini tapmaq ucun evvelce,siyahinin uzunlugunu daxil edin:");
            string olcuStr = Console.ReadLine();
            int olcu = int.Parse(olcuStr);
            string[] siyahi = new string[olcu];

            for (int i = 0; i < siyahi.Length; i++)
            {
                Console.Write($"{i + 1}. yazini daxil edin: ");
                siyahi[i] = Console.ReadLine();
            }

            Console.Write("Axtardiginiz herfi daxil edin - ");
            string herf = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < siyahi.Length; i++)
            {
                for (int k = 0; k < siyahi[i].Length; k++)
                {
                    if (siyahi[i][k].ToString() == herf)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"'{herf}' herfi siyahida {count} defe tapildi.");

            #endregion

            #region Task4
            //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
            //(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.
            Console.Write("Verilmis yazinin evvelindaki bosluqlarin silinmesi ucun yazini daxil edin - ");
            string text = Console.ReadLine();

            string newText = "";
            bool bosluqOlmayan = false;  

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' || bosluqOlmayan)
                {
                    newText += text[i];
                    bosluqOlmayan = true;  
                }
            }

            Console.WriteLine($"Yazinin evvelindeki bosluqlarin silinmis hali: <<{newText}>>");

            #endregion

            #region Task5
            //Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır,
            //əks halda simvolu yenidən daxil edilməsi istənilməlidir.
            //(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

            Console.Write("Uzerinde riyazi emeliyyatlar aparmaq ucun 1. ededi daxil edin - ");
            string eded1 = Console.ReadLine();
            int bir = int.Parse( eded1 );

            Console.Write("2. ededi daxil edin - ");
            string eded2 = Console.ReadLine();
            int iki = int.Parse(eded2);

            
            bool input = false;
            do
            {
                Console.WriteLine("Riyazi emeliyyati daxil edin (+,-,* ve ya /): ");
                string emeliyyat = Console.ReadLine();
                

                switch (emeliyyat)
                {
                    case "+":
                        Console.WriteLine(bir+iki);
                        input = true;
                        break;

                    case "-":
                        Console.WriteLine(bir-iki);
                        input = true;
                        break;

                    case "*":
                        Console.WriteLine(bir*iki);
                        input = true;
                        break;

                    case "/":
                        Console.WriteLine(bir/iki);
                        input = true;
                        break;

                    default:
                        Console.WriteLine("Duzgun emeliyyat daxil edin!");
                        break;

                }

            } while (!input);

            #endregion
        }
    }
}
