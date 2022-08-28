using System.Diagnostics;
using NETLab5.Sort;
using NETLab5.Collection;

namespace NETLab5.Strategy
{
    class AnalyseSort
    {

        private ISort _sortType;

        public double Min { get; private set; }
        public double Max { get; private set; }
        public TimeSpan Elapsed { get; private set; }

        public AnalyseSort()
        {
            _sortType = new BubbleSort();
        }

        public AnalyseSort(ISort sortType)
        {
            _sortType = sortType; 
        }

        public void SetSort(ISort sortType) 
        {
            _sortType = sortType;
        }

        public void SortAndShow(DoubleCollection data)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = _sortType.Sort(data);
            stopwatch.Stop();

            Elapsed = stopwatch.Elapsed;
            Min = result[0];
            Max = result[result.Count() - 1];

            ShowArray(result);
        }

        public DoubleCollection SortAndReturn(DoubleCollection data)
        {
            return _sortType.Sort(data);
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
