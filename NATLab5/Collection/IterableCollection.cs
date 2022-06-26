using System.Collections;

namespace NETLab5.Collection
{
    public abstract class IterableCollection : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
        public abstract int Count();
        public abstract void Reverse();
        public abstract void Add(double data);
    }
}
