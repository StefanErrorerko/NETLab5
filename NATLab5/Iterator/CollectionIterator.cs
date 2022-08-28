using NETLab5.Collection;

namespace NETLab5.Iterator
{
    class CollectionIterator : Iterator
    {
        private DoubleCollection _collection;
        private int _state = -1;
        private bool _reverse;

        public CollectionIterator(DoubleCollection collection, bool reverse = false)
        {
            _collection = collection; 
            _reverse = reverse; 

            if (reverse)
            {
                _state = collection.Count();
            }
        }

        public override object Current()
        {
            return _collection.GetCollection()[_state];
        }

        public override int Key()
        {
            return _state; 
        }

        public override bool MoveNext()
        {
            var newstate = _state + (this._reverse ? -1 : 1); 

            if (newstate >= 0 && newstate < _collection.Count()) 
            {
                _state = newstate;
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            _state = _reverse ? _collection.Count() - 1 : 0; 
        }        
    }
}
