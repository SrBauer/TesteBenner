using System;

namespace TesteBenner
{
    public class Network
    {
        private readonly int size;
        private readonly List<HashSet<int>> grupos;

        public Network(int size)
        {
            if (size <= 0)
            {
                throw new Exception("O número deve ser maior que zero.");
            }

            this.size = size;
            this.grupos = new List<HashSet<int>>();

            for (int i = 1; i <= size; i++)
            {
                grupos.Add(new HashSet<int> { i });
            }
        }

        public void Connect(int a, int b)
        {
            Validate(a, b);

            var grupoA = grupos.FirstOrDefault(g => g.Contains(a));
            var grupoB = grupos.FirstOrDefault(g => g.Contains(b));

            if (grupoA != grupoB)
            {
                grupoA.UnionWith(grupoB);
                grupos.Remove(grupoB);
            }
        }

        public bool Query(int a, int b)
        {
            return grupos.Any(g => g.Contains(a) && g.Contains(b));
        }

        private void Validate(int a, int b)
        {
            if (a < 1 || a > size || b < 1 || b > size)
            {
                throw new ArgumentOutOfRangeException("Os números devem ser de 1 até " + size);
            }
        }
    }
}
