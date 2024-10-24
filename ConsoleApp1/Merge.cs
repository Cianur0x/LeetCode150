namespace ConsoleApp1
{
    public class Merge
    {
        public static void Solution(int[] nums1, int m, int[] nums2, int n)
        {

            // primero copiamos el array 

            // for (int i = 0; i < nums2.Length; i++)
            // {
            //     nums1[i + m] = nums2[i];
            // }
            // System.Console.WriteLine(string.Join(' ', nums1));

            // bubble sort, comparamos el de antes con el siguiente, si es mayor se cambia si es menor no y se pasa al siguiente
            for (int j = 0; j < nums1.Length - 1; j++)
            {
                bool swapped = false;
                for (int i = 0; i < nums1.Length - j - 1; i++) // el último elemento del arreglo ya está en su posición correcta y así se reduce el rango de iteración
                {

                    if (nums1[i] > nums1[i + 1])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums1[i + 1];
                        nums1[i + 1] = temp;
                        swapped = true;
                        // tuple to swap values -> (nums1[i], nums1[i + 1]) = (nums1[i + 1], nums1[i]);
                    }
                }

                if (swapped == false)
                    break;

            }
            // O(n2) como escala el tamaño en tiempo de ejecución, donde n es el tamaño, escala de forma cuadratica

            // QUISCKSORT, pivot 
            Console.WriteLine(string.Join(' ', nums1));


        }
    }
}

