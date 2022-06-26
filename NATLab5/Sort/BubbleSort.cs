using NETLab5.Collection;

namespace NETLab5.Sort
{
    public class BubbleSort : ISort
    {
        public DoubleCollection Sort(DoubleCollection data)
        {
            var len = data.Count();
            for (var i = 1; i < data.Count(); i++)
            {
                for (var j = 0; j < data.Count() - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }

            return data;
        }

    }
}
