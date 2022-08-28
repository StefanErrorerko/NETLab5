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
                    //you can swap var like - (data[j], data[j + 1]) = (data[j + 1], data[j]);
                    var temp = data[j - 1];
                    data[j - 1] = data[j];
                    data[j] = temp;
                    j--;
                }

                data[j] = key;
            }

            return data;
        }

    }
}
