using NETLab5.Collection;

namespace NETLab5.Iterator
{
    class CollectionIterator : Iterator
    {
        private DoubleCollection _collection;
        private int _state = -1;
        private bool _reverse = false;

        public CollectionIterator(DoubleCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._state = collection.Count();
            }
        }

        public override object Current()
        {
            return this._collection.getCollection()[_state];
        }

        public override int Key()
        {
            return this._state;
        }

        public override bool MoveNext()
        {
            int newstate = this._state + (this._reverse ? -1 : 1);

            if (newstate >= 0 && newstate < this._collection.Count())
            {
                this._state = newstate;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._state = this._reverse ? this._collection.Count() - 1 : 0;
        }

        
    }
}
