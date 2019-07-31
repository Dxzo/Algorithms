using DataStructures;

namespace SortingAlgorithms
{
    public class BubbleSort : ISort
    {
        public IDataStructure Sort(IDataStructure dataStructure)
        {
            var length = dataStructure.Count();

            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i < length - j; i++)
                {
                    int nextIndex = i;
                    int? nextValue = null;
                    nextIndex++;

                    if (dataStructure[nextIndex] == null)
                        break;
                    else
                        nextValue = dataStructure[nextIndex];

                    if (dataStructure[i] > nextValue)
                    {
                        dataStructure[nextIndex] = dataStructure[i];
                        dataStructure[i] = nextValue;
                    }
                }
            }

            return dataStructure;
        }
    }
}
