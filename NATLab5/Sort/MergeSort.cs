using NETLab5.Collection;

namespace NETLab5.Sort
{
    public class MergeSort : ISort
    {
        public DoubleCollection Sort(DoubleCollection data)
        {
            return Sort(data, 0, data.Count() - 1);
        }
        void Merge(DoubleCollection data, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new double[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (data[left] < data[right])
                {
                    tempArray[index] = data[left];
                    left++;
                }
                else
                {
                    tempArray[index] = data[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = data[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = data[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                data[lowIndex + i] = tempArray[i];
            }
        }

        //сортування злиттям
        public DoubleCollection Sort(DoubleCollection data, int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex)
            {
                return data; 
            }
            var middleIndex = (lowIndex + highIndex) / 2;
            Sort(data, lowIndex, middleIndex);
            Sort(data, middleIndex + 1, highIndex);
            Merge(data, lowIndex, middleIndex, highIndex);
            return data;
        }
    }
}
