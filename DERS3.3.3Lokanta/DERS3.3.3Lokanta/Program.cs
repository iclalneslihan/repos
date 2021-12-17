using System;

namespace DERS3._3._3Lokanta
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lokanta Yazılımı
                 * BelediyeHarcOde() isminde metot var.
                 * Genelde harç ücreti 6 aylık 3000 TL iken aşağıdaki illerde farklılık göstermekte.
                 * LokantaTokat : 2000
                 * LokantaYozgat: 1500
                 * LokantaMersin: 3500
                 * Bu illler için polimorfizm yapısnı kullanarak farklı metot tanımlayınız.

                 * BelediyeHarcOde()
                 * {
                 *      Console.WriteLine("Harç Ödemesi: 3000 TL'dir.");
                 * } 
                 */


            Mersin mersin = new Mersin();
            Tokat tokat = new Tokat();
            Yozgat yozgat = new Yozgat();
        }
    }
}
