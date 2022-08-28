using NETLab5.Collection;

namespace NETLab5.Sort
{
    public class InsertionSort : ISort
    {
        public DoubleCollection Sort(DoubleCollection data)
        {
            for (var i = 1; i < data.Count(); i++)
            {
                var key = data[i];
                var j = i;
                while ((j > 1) && (data[j - 1] > key))
                {
                    (data[j], data[j + 1]) = (data[j + 1], data[j]);
                    j--;
                }
                data[j] = key;
            }
            return data;
        }

    }
}
