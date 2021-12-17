using System;

namespace DERS2._3._2.DİZİTEKRARI
{
    class Program
    {
        static void Main(string[] args)
        {
            //


            //int[,] dizi = new int[2, 3];
            //Random r = new Random();
            //for (int i=0; i<2;i++)
            //{
            //    for(int j=0;j<3,j++)
            //    {
            //        dizi[i, j] = Random;
            //    }
            //}



            //// 1 1 1 1 1 
            //// 1 0 0 0 1 
            //// 1 0 0 0 1
            //// 1 0 0 0 1
            //// 1 1 1 1 1


            //int[,] matris = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <5; j++)
            //    {
            //        if(i== 0 || i==4)
            //        matris[i, j] = 1;
            //        else if(j==0 || j==4)
            //            matris[i, j] = 1;
            //        else
            //        matris[i, j] = 0;
            
            //    }
            
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");

            //    }

            //    Console.WriteLine();




                int[,] matris = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == j && j<3)
                            matris[i, j] = 1;
                        else if (i+j ==4 && j<3)
                            matris[i, j] = 1;
                        else
                            matris[i, j] = 0;

                    }

                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(matris[i, j] + " ");

                    }

                    Console.WriteLine();

                }
        }
    }
}
