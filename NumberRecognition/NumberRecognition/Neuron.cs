using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberRecognition
{
    class Neuron
    {
        public int[,] scale;

        public int[,] weight;

        public int[,] input;

        public int limit = 100;

        public int sum;

        public Neuron(int x, int y, int[,] inp) 
        {
            weight = new int[x, y];
            scale = new int[x, y];
            input = new int[x, y];
            input = inp;
        }

        public bool Result()
        {
            sum = 0;
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    scale[x, y] = input[x, y] * weight[x, y];
                    sum += scale[x, y];
                }
            }
            return sum >= limit;
        }

        public void Increment(int[,] inp)
        {
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    weight[x, y] += inp[x, y];
                }
            }
        }

        public void Decrement(int[,] inp)
        {
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    weight[x, y] -= inp[x, y];
                }
            }
        }
    }
}
