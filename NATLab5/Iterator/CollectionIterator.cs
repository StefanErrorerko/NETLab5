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
            this._collection = collection; // this redundant
            this._reverse = reverse; // this redundant

            if (reverse)
            {
                this._state = collection.Count(); // this redundant
            }
        }

        public override object Current()
        {
            return this._collection.getCollection()[_state]; // this redundant
        }

        public override int Key()
        {
            return this._state; // this redundant
        }

        public override bool MoveNext()
        {
            // var
            int newstate = this._state + (this._reverse ? -1 : 1); // this redundant

            if (newstate >= 0 && newstate < this._collection.Count()) // this redundant
            {
                this._state = newstate; // this redundant
                return true;
            }
            else // else redundant
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._state = this._reverse ? this._collection.Count() - 1 : 0; // this redundant
        }

        
    }
}
