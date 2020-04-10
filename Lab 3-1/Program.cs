using System;

namespace Lab_3_1
{
    class Arrs
    {
        private static Random rnd;
        static Arrs()
        {
            rnd = new Random();
        }

       

        public static void CreateOneDimAr(int[] mas)
        {
            for (int i=0;i<mas.Length;i++)
            {
                mas[i] = rnd.Next(0,50);
            }
        }
        public static void CreateAr2(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = rnd.Next(0,50);
                }
        }

        public static void CreateAr3(int[][] mnog)
        {

            for (int i = 0; i < mnog.Length; i++)
                for (int j = 0; j < mnog[i].Length; j++)
                {
                    mnog[i][j] = rnd.Next(0,50);
                }
            
        }

        public static void PrintArr1(string name, int[] mas2)
        {
            Console.WriteLine("Массив {0}", name);
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i]+" ");
            }
            Console.Write("\n");
        }
        public static void PrintArr2(string name, int[,] matr3)
        {
            int rows = matr3.GetUpperBound(0) + 1;
            int cols = matr3.Length / rows;

            Console.WriteLine("Матрица {0}", name);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matr3[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void PrintArr3(string name, int[][] mm)
        {
            Console.WriteLine("Массив массивов {0}", name);
            for (int i = 0; i < mm.Length; i++)
            {
                for (int j = 0; j < mm[i].Length; j++)
                {
                    Console.Write(mm[i][j] + " ");
                }
                Console.Write("\n");
            }
        }
        public static int[,] MultMatr(int[,] mat1, int[,] mat2)
        {        
            int rows1 = mat1.GetUpperBound(0) + 1;
            int cols1 = mat1.Length/rows1;
            int rows2 = mat2.GetUpperBound(0) + 1;
            int cols2 = mat2.Length / rows2;
            int[,] matmul = new int[cols1, rows2];
            if (cols1 == rows2)
            {
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        matmul[i, j] = 0;
                        for (int k = 0; k < cols1; k++)
                        {
                            matmul[i, j] += mat1[i, k] * mat2[k, j];
                        }
                    }
                }
            }
            else Console.WriteLine("Умножение матриц невозможно");
            return matmul;
        }
        ~Arrs()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            int[] A = new int[5], B = new int[5], C = new int[5];
            Arrs.CreateOneDimAr(A);
            Arrs.CreateOneDimAr(B);

            for (int i = 0; i < 5; i++)
            {
                C[i] = A[i] + B[i];
            }

            int[] X = { 5, 5, 6, 6, 7, 7 };
            int[] U, V;
            U = new int[3];
            for (int i = 0; i < 3; i++) { U[i] = i + 1; }
            //V = {1,2,3};
            V = new int[3];
            for (int i = 0; i < 3; i++) { V[i] = U[i]; }
            V[0] = 9;
            Arrs.PrintArr1("A", A);
            Arrs.PrintArr1("B", B);
            Arrs.PrintArr1("C", C);
            Arrs.PrintArr1("X", X);
            Arrs.PrintArr1("U", U);
            Arrs.PrintArr1("V", V);
            Console.WriteLine("Введите размерность массива:");
            int size = int.Parse(Console.ReadLine());
            int[] D;
            D = new int[size];
            Arrs.CreateOneDimAr(D);
            Arrs.PrintArr1("D", D);
            
            //Задание 2
            int[,] dm1 = new int[3, 3];
            int[,] dm2 = new int[3, 3];
            Arrs.CreateAr2(dm1);
            Arrs.CreateAr2(dm2);
            Arrs.PrintArr2("dm1", dm1);
            Arrs.PrintArr2("dm2", dm2);
            Arrs.PrintArr2("mult", Arrs.MultMatr(dm1,dm2));
            
            //Задание 3
            int[][] R =
            {
                new int[1], new int[2], new int[3], new int[4], new int[5],
                new int[6], new int[7], new int[8], new int[9], new int[10],
            };
            Arrs.CreateAr3(R);
            Arrs.PrintArr3("R", R);
        }
    }
}
