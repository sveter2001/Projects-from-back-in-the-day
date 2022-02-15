using System;

namespace _2ЛабаАлгоритмыШарпКонсоль
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int m=1, n=4,x=4,y=4;
            int i, j, k;
            double[,] Arr = new double[n, n];
            double[] X = new double[x];
            double[] Y = new double[y];
            vivodarray(Arr, 4);

            X[0] = -5;
            Y[0] = 0;
            X[1] = 0;
            Y[1] = -5;
            X[2] = 0;
            Y[2] = 5;
            X[3] = 5;
            Y[3] = 0;


            double A=1, B=1;
            for (i=0;i<n;i++)
            {
                for(j=i+1; j<n ;j++)
                {
                    Arr[i, j] = Dlina(X[i], Y[i], X[j], Y[j]);
                    for (k=1;k<n-2;k++)
                    {
                        A=intersectX(X[i], Y[i], X[j], Y[j], X[k], Y[k], X[k+1], Y[k+1]);
                        B=intersectY(X[i], Y[i], X[j], Y[j], X[k], Y[k], X[k + 1], Y[k + 1]);
                        Console.Write(A); Console.Write(B);
                        if (A > X[k] && A < X[k+1] || B > Y[k] && B < Y[k + 1])
                        {
                            Arr[i, j] = 9999;
                        }
                    }
                }
            }
            vivodarray(Arr, 4);

        }
        static void vivodarray(double[,] mas,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(String.Format("{0,3}", mas[i, j]));
                Console.WriteLine();
            }
        }
        static double Dlina(double xi,double yi, double xj, double yj)
        {
            double r;
            r = Math.Sqrt((xi-xj)*(xi-xj)+(yi-yj)*(yi-yj));
            return r;
        }
        static double intersectX(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a1, a2, b1, b2, c1, c2;
            a1 = y1 - y2;
            b1 = x2 - x1;
            c1 = x1 * y2 - x2 * y1;
            a2 = y3 - y4;
            b2 = x4 - x3;
            c2 = x3 * y4 - x4 * y3;
            double det = a1 * b2 - a2 * b1;
            double x;
            x = (b1 * c2 - b2 * c1) / det;
            return x;
           
        }
        static double intersectY(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a1, a2, b1, b2, c1, c2;
            a1 = y1 - y2;
            b1 = x2 - x1;
            c1 = x1 * y2 - x2 * y1;
            a2 = y3 - y4;
            b2 = x4 - x3;
            c2 = x3 * y4 - x4 * y3;
            double det = a1 * b2 - a2 * b1;
            double y;
            y = (a2 * c1 - a1 * c2) / det;
            return y;
        }

    }
}
