using DataStructures;

namespace SortingAlgorithms
{
    public class SelectionSort : ISort
    {
        public IDataStructure Sort(IDataStructure dataStructure)
        {
            var length = dataStructure.Count();

            int? value = null;
            int lastIndex = -1;

            for (int j = 0; j < length; j++)
            {
                value = dataStructure[j];
                int? smaller = dataStructure[j];

                for (int i = j; i < length; i++)
                {
                    if (dataStructure[i] < smaller)
                    {
                        smaller = dataStructure[i];
                        lastIndex = i;
                    }
                }

                if (smaller == value)
                    continue;

                dataStructure[j] = smaller;
                dataStructure[lastIndex] = value;
            }

            return dataStructure;
        }
    }
}
