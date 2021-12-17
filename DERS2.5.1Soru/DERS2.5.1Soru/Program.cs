using System;

namespace DERS2._5._1Soru
{
    class Program
    {
        static void Main(string[] args)
        {
//            You have a text that some of the words in reverse order.
//The text also contains some words in the correct order, 
//and they are wrapped in parenthesis.
//Write a function fixes all of the words and,
//remove the parenthesis that is used for marking the correct words.

//Your function should return the same text defined in the constant
//CORRECT_ANSWER
//'''


//INPUT = ("nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon
//         , tsilanruoj(and) laicos.tsivitca((A)reenoip(of) laicremmoc
//         noitcif(and) naciremA, senizagam(he) saw eno(of)(the) tsrif
//         (American) srohtua(to) emoceb(an) lanoitanretni ytirbelec
//         (and) nrae a egral enutrof(from)).gnitirw")

//CORRECT_ANSWER = "John Griffith London was an American novelist, journalist, and social activist.
//(A pioneer of commercial fiction and American magazines, he was one of the first American authors
//to become an international celebrity and earn a large fortune from writing.)"


            string yazi = ("nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon
         , tsilanruoj(and) laicos.tsivitca((A)reenoip(of) laicremmoc
         noitcif(and) naciremA, senizagam(he) saw eno(of)(the) tsrif
         (American) srohtua(to) emoceb(an) lanoitanretni ytirbelec
         (and) nrae a egral enutrof(from)).gnitirw");

            yazi = yazi.Replave("((", "(");
            yazi = yazi.Replace("))", ")");
            yazi = yazi.Replave("(", "(");
            yazi = yazi.Replace(")", ")");

            string[] kelimeler = yazi.Split(" ");
                foreach ( var item in kelimeler)
            {
                if(!item.Contains("(") item.Contains(')'))
                {
                    Console.WriteLine(item);
                }
                Concole.WriteLine(item);
            }


























        }
    }
}
