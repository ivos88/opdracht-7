using System;
using System.Threading;

namespace Domain
{
    public class Opdracht7


    {

        public static int opdracht7(int index)
        {
            int[] Stap1 = new int[] { 2, 8 };
            int[] Stap2 = new int[] { 5, 12 };
            int[] Stap3 = new int[] { 5, 12 };
            int[] Stap4 = new int[] { 5, 8 };
            int[] Stap5 = new int[] { 1, 2 };
            int[] Stap6 = new int[] { 20, 32 };
            int[] Stap7 = new int[] { 10, 16 };
            int[] Stap8 = new int[] { 3, 6 };
            int[] Stap9 = new int[] { 8, 12 };
            int[] Stap10 = new int[] { 10, 16 };
            int[] Stap11 = new int[] { 12, 20 };
            int[] Stap12 = new int[] { 2, 10 };


            int Route1 = Stap1[index] + Stap2[index] + Stap3[index];
            int Route2 = Stap1[index] + Stap2[index] + Stap8[index];
            int Route3 = Stap4[index] + Stap5[index] + Stap2[index] + Stap3[index];
            int Route4 = Stap4[index] + Stap5[index] + Stap2[index] + Stap8[index];
            int Route5 = Stap9[index] + Stap6[index] + Stap7[index] + Stap8[index];
            int Route6 = Stap9[index] + Stap10[index] + Stap11[index] + Stap12[index];



            if (Route1 > Route2 && Route1 > Route3 && Route1 > Route4 && Route1 > Route5 && Route1 > Route6)
            {
                return (Route1);
            }

            else if (Route2 > Route3 && Route2 > Route4 && Route2 > Route5 && Route2 > Route6)
            {
                return (Route2);
            }
            else if (Route3 > Route4 && Route3 > Route5 && Route3 > Route6)
            {
                return (Route3);
            }
            else if (Route4 > Route5 && Route4 > Route6)
            {
                return (Route4);
            }
            else if (Route5 > Route6)
            {
                return (Route5);
            }
            else
            {
                return (Route6);
            }
        
        }
    }
}