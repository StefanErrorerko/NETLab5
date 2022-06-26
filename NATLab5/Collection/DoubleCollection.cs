using System.Collections;
using NETLab5.Iterator;

namespace NETLab5.Collection
{
    public class DoubleCollection : IterableCollection
    {
        List<double> _collection = new List<double>();

        bool _reverse = false;

        public override void Reverse()
        {
            _reverse = !_reverse;
        }

        public List<double> getCollection() => _collection;

        public double this[int position]
        {
            get
            {
                return _collection[position];
            }
            set
            {
                _collection[position] = value;
            }
        }

        public override void Add(double value)
        {
            this._collection.Add(value);
        }

        public override IEnumerator GetEnumerator()
        {
            return new CollectionIterator(this, _reverse);
        }
        public override int Count()
        {
            return _collection.Count;
        }
    }
}
