using NETLab5.Collection;

namespace NETLab5.Iterator
{
    class CollectionIterator : Iterator
    {
        private DoubleCollection _collection;
        private int _state = -1;
        private bool _reverse = false; // 'false' is already default value for bool vars

        public CollectionIterator(DoubleCollection collection, bool reverse = false)
        {
            _collection = collection; 
            _reverse = reverse; 

            if (reverse)
            {
                this._state = collection.Count(); // this redundant
            }
        }

        public override object Current()
        {
            return _collection.getCollection()[_state]; // this redundant
        }

        public override int Key()
        {
            return this._state; // this redundant
        }

        public override bool MoveNext()
        {
            // var
            int newstate = _state + (this._reverse ? -1 : 1); 

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
