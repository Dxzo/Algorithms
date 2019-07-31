using DataStructures;

namespace SortingAlgorithms
{
    public class InsertionSort : ISort
    {
        public IDataStructure Sort(IDataStructure dataStructure)
        {
            var length = dataStructure.Count();

            for (int i = 0; i < length; i++)
            {
                int nextIndex = i + 1;
                int y = i;

                while (dataStructure[nextIndex] < dataStructure[y])
                {
                    var nextValue = dataStructure[nextIndex];
                    var currentValue = dataStructure[y];

                    dataStructure[nextIndex] = currentValue;
                    dataStructure[y] = nextValue;

                    nextIndex--;
                    y--;
                }
            }

            return dataStructure;
        }
    }
}
