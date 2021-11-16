using System;

namespace ConsoleApp4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch case 

            // Klavyeden 2 sayı ve işlem bilgisi alıp
            // switch kullanarak seçilen işleme göre sonucu gösterecek prog. yazınız
            // topla, bol, carp,cıkar

            //Console.Write("Sayı 1: ");
            //float sayi1 = Convert.ToSingle(Console.ReadLine());
            //Console.Write("Sayı 2: ");
            //float sayi2 = Convert.ToSingle(Console.ReadLine());
            //Console.Write("İşlem: ");
            //string islem = Console.ReadLine();


            //switch (islem)
            //{
            //    case "toplama":
            //        Console.WriteLine($"A+B ={sati1 + sayi2");
            //    case "cıkarma":
            //        Console.WriteLine($"Toplam ={sati1 - sayi2");
            //     case "carpma":
            //        Console.WriteLine($"Toplam ={sati1 * sayi2");
            //                case "bolme":
            //        Console.WriteLine($"A/B ={sati1 / sayi2");
            //            default :
            //            Concole.WriteLine("incorrect operation! ");
            //        break;
            //(düzenli değil)


            //WHİLE


            //int prim = 3500;
            //bool kosul = prim < 7200;
            //while (kosul==true)
            //{
            //    Console.WriteLine("Emekliliğe daha var.Çalışmaya devam.");
            //    prim += 360;
            //    kosul = prim < 7200;

            //}


            //ÖR: 1-10 arasındaki
            //byte s = 1;
            //while (s <= 10)
            //{
            //    Console.WriteLine(s);
            //    s++;
            //}

            //ÖR: 1'den klavyeden girilen sayıya kadar olan sayıları ekrana yazdıran prog.

            //Console.Write("Sayı: ");
            //int s = Convert.ToInt32(Console.ReadLine());

            //byte b = 1;
            //while (b <= s)
            //{
            //    Console.WriteLine(b);
            //    b++;
            //}


            //ÖR: Klavyeden girilen değer  "ÇIK" olmadığı sürece ekrana yazılanları yazdıran prog.

            //Console.Write("Mesajınızı yazınız ya da çıkmak için ÇIK yazınız.");
            //string yazi = Console.ReadLine();
            //while (yazi.ToLower() != "çık")
            //{
            //    Console.WriteLine(yazi);
            //    Console.WriteLine("Mesajınızı yazınız ya da çıkmak için ÇIK yazınız.");
            //    yazi = Console.ReadLine();
            //}
            //Console.WriteLine("Program sonlandı!");


            //ÖR: Klavyeden girilen değer  "bitir " olmadığı sürece alınan sayıları 
            //toplayıp en son ekrana toplamı yazdıran p.

            //Console.WriteLine("Sayı Giriniz:");
            //string str = Console.ReadLine();
            //bool isNumeric = int.TryParse(str, out _);
            //Console.WriteLine($"{str} -> {isNumeric}");
            //int toplam = 0;
            //int sayi = 0;

            //while(str.ToLower() != "bitir")
            //{
            //    if(isNumeric == true)
            //    {
            //        sayi = Convert.ToInt32(str);
            //        toplam += sayi;

            //    }
            //    Console.Write("Sayı giriniz: ");
            //    str = Console.ReadLine();
            //    isNumeric = int.TryParse(str, out _);

            //}
            //Console.WriteLine($"TOPLAM = {toplam}");


            //ÖR: Klavyeden girilen ifade "bitir" değil ise girilen sayıların karesini toplayıp ekrana yazdıran program
            // Koşul: Girilen sayı 5 ve 5'in katı ise de programdan çıkılacak.


            //Console.WriteLine("Sayı Giriniz:");
            //string str = Console.ReadLine();
            //int toplam = 0;
            //int sayi = 0;

            //while (str.ToLower() != "bitir")
            //{


            //        sayi = Convert.ToInt32(str);

            //        if ( sayi%5 == 0)
            //    {
            //        Console.WriteLine("5'in katı girildiği için çıkış yapıldı. ");
            //        str = "bitir"; bu satır yerine aşağıdaki olur
            //        break;

            //    }
            //    else
            //    {
            //        toplam += (sayi * sayi);

            //        Console.Write("Sayı giriniz: ");
            //        str = Console.ReadLine();
            //     }

            //}
            //Console.WriteLine($"TOPLAM = {toplam}");




            //ÖR: 1-100 arasındaki her sayı için tek mi çift mi yazan prog.

            //int i = 1;

            //while (i <= 100)
            //{

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} çift ");
            //    }
            //    else
            //    {
            //       Console.Write($"{i} tek ");
            //    }
            //    i++;
            //}

            //ÖR: Klavyeden girilen sayıları ekrana yazdıran program
            // Koşullar: 5'in katlarında "BOM" yazsın. 19' un katında çıksın.


            //int i;

            //while(true)

            //{   
            //Console.WriteLine("Sayı Giriniz:");
            //i = Convert.ToInt32(Console.ReadLine());
            //    if(i%5 == 0)
            //    { 
            //    Console.WriteLine($"BOM");
            //    }
            //    else if(i%19 == 0)
            //    { Console.WriteLine("19'un katı girildi.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sayı :{i}");
            //    }
            //}

            //Console.WriteLine("Program sonlandı!");




            //continue kavramı

            //ÖR: 1-10 arasındaki sayıları ekrana yazdıran prog yaz.
            // 7ye geldiğinde bir şey yazdırmasın.
            // 9a gldiğinde proramdan çıksın

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;
            //    }
            //    else if (i == 9)

            //        break;
            //    Console.WriteLine(i);
            //    i++;

            //}


            // do while döngüsünde döngü koşula bakılmaksızın 1 defa çalışır, sonraki çalışmalar için koşul kontrol edilir.

            //ÖR: Klavyeden alınan sayıları toplayıp ekrana yaz prog.
            // 0 yazınca çıkış


            //int toplam = 0;
            //int s;
            //do
            //{
            //    Console.Write("sayı : ");
            //    s = Convert.ToInt32(Console.ReadLine());
            //    toplam += s;

            //}
            //while (s != 0);

            //Console.WriteLine($"toplam= {toplam}");



            //ÖR: Kullanıcıdan eposta ve parola bilgisi alıp kontrol edecek pr.yaz
            // eposta = network@akademi.net parola=nA543
            // bilgiler doğru değilse tekrar istesin.

            string eposta = "network@akademi.net";
            string parola = "nA543";
            string ep, p;
            do
            {
                Console.WriteLine("Eposta:");
                ep = Console.ReadLine();
                Console.WriteLine("parola:");
                p = Console.ReadLine();
            }

            while (ep != eposta || p != parola);









        }
    }
    }

