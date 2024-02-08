using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Logic
{
    public class ArrayNew
    {
        //atributos
        private int[] array;
        private int top;

        //constructor
        public ArrayNew(int num)
        {
            array = new int[num];
            N = num;
            top = 0;
        }

        //propiedades
        public int N { get; }

        public bool IsFull => top == N;
        public bool IsEmpty => top == 0;

        public void Fill(int min, int max)
        {
            Random randomico = new Random();

            for (int i = 0; i < N; i++) 
            {
                array[i] = randomico.Next(min, max);
            }
            top = N;
        }

        public override string ToString()
        {
            var output = "";
            if (IsEmpty)
            {
                return "Array Empty";
            }

            var count = 0;

            for (int i = 0; i < N; i++)
            {
                if(count == 10)
                {
                    output += "\n";
                    count = 0;
                }
                output += $"{array[i]}\t";
                count++;
            }
            return output;
        }
    }
}
