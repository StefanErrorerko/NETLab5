using System.Diagnostics;
using NETLab5.Sort;
using NETLab5.Collection;

namespace NETLab5.Strategy
{
    class AnalyseSort
    {

        private ISort _sorttype;
        private TimeSpan _elapsed;
        private double _max;
        private double _min;

        public AnalyseSort()
        {
            //default type
            _sorttype = new BubbleSort();
        }

        public AnalyseSort(ISort _sorttype)
        {
            this._sorttype = _sorttype;
        }

        public void SetSort(ISort _sorttype)
        {
            this._sorttype = _sorttype;
        }

        public void SortAndShow(DoubleCollection data)
        {
            if (_sorttype != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var result = _sorttype.Sort(data);
                stopwatch.Stop();

                _elapsed = stopwatch.Elapsed;
                _min = result[0];
                _max = result[result.Count() - 1];

                ShowArray(result);                    
            }
            else
            {
                throw new NullReferenceException("Unchosen sort type");
            }
        }

        public DoubleCollection SortAndReturn(DoubleCollection data)
        {
            return this._sorttype.Sort(data);
        }

        public TimeSpan Elapsed
        {
            get => _elapsed;
        }
        public double Min
        {
            get => _min;
        }
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
