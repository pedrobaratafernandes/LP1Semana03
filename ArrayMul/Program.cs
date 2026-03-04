using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[,] a = new float[2, 2];
            float[] b = new float[2];
            a[0, 0] = float.Parse(args[0]);
            a[0, 1] = float.Parse(args[1]);
            a[1, 0] = float.Parse(args[2]);
            a[1, 1] = float.Parse(args[3]);
            b[0] = float.Parse(args[4]);
            b[1] = float.Parse(args[5]);
            float[] result = new float[a.GetLength(0)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                float sum = 0f;
                for (int j = 0; j < b.Length; j++)
                {
                    sum += a[i, j] * b[j];
                }

                result[i] = sum;

            }

            foreach (float x in result)
            {
                Console.WriteLine($"| {x,7:f2} |");
            }
        }
    }
}
