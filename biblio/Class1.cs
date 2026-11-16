//namespace biblio
//{
//    public class Class1
//    {
//        public static int MultiMatrix(int[] matrix)
//        {
//            int sum = 0;
//            for (int i = 0; i < matrix.Length; i++) sum += matrix[i];
//            return sum;
//        }
//    }
//}

namespace biblio
{
    public class OurClassLibrary
    {
        public static double[] MaxRows(double[,] matrix)
        {
            double[] res = new double[6];

            for (int i = 0; i < 6; i++)
            {
                double max = matrix[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                res[i] = max;
            }

            return res;
        }
    }
}