using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private readonly MenuItem[] _itens;
        private int currentIndex;

        public DinerMenuIterator(MenuItem[] itens)
        {
            currentIndex = 0;
            _itens = itens;
        }
        public MenuItem Current => _itens[currentIndex];

        object IEnumerator.Current => _itens[currentIndex];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(currentIndex == _itens.Length-1)
            {
                return false;
            }
            else
            {
                currentIndex++;
                return true;
            }
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
