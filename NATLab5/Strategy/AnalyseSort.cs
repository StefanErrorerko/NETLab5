using System.Diagnostics;
using NETLab5.Sort;
using NETLab5.Collection;

namespace NETLab5.Strategy
{
    class AnalyseSort
    {

        private ISort _sorttype; // _sortType
        private double _max;
        private double _min;

        public TimeSpan Elapsed { get; private set; }

        public AnalyseSort()
        {
            //default type
            _sorttype = new BubbleSort();
        }

        public AnalyseSort(ISort _sorttype) // sortType
        {
            this._sorttype = _sorttype; // this redundant
        }

        public void SetSort(ISort _sorttype) // sortType
        {
            this._sorttype = _sorttype;  // this redundant
        }

        public void SortAndShow(DoubleCollection data)
        {
            if (_sorttype != null) // you have initializing of sortType in each constructor, it can not be null
            {
                //var
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                var result = _sorttype.Sort(data);
                stopwatch.Stop();

                Elapsed = stopwatch.Elapsed;
                _min = result[0];
                _max = result[result.Count() - 1];

                ShowArray(result);
            }
            else
            {
                throw new ArgumentNullException("Unchosen sort type");
            }
        }

        public DoubleCollection SortAndReturn(DoubleCollection data)
        {
            return this._sorttype.Sort(data);
        }


        // same
        public double Min
        {
            get => _min;
        }

        // same
        public double Max
        {
            get => _max;
        }
        public void ShowArray(DoubleCollection data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }
    }
}
