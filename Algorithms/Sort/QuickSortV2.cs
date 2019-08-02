using DataStructures;

namespace SortingAlgorithms
{
    public class QuickSortV2
    {
        public static void Sort(IDataStructure dataStructure)
        {
            Quick(0, dataStructure.Count() - 1, dataStructure);
        }
        public static void Swap(int i1, int i2, IDataStructure dataStructure)
        {
            int temp = (int)dataStructure[i1];
            dataStructure[i1] = dataStructure[i2];
            dataStructure[i2] = temp;
        }
        public static int Particion(int start, int end, IDataStructure dataStructure)
        {
            int pivot = 0;
            int iPivot = 0;
            int n = 0;

            pivot = (int)dataStructure[end];
            iPivot = start;

            for (n = start; n < end; n++)
            {
                if (dataStructure[n] <= pivot)
                {
                    Swap(n, iPivot, dataStructure);
                    iPivot++;
                }
            }
            Swap(iPivot, end, dataStructure);

            return iPivot;
        }
        public static void Quick(int start, int end, IDataStructure dataStructure)
        {
            int iPivot = 0;

            if (start >= end)
                return;

            iPivot = Particion(start, end, dataStructure);

            Quick(start, iPivot - 1, dataStructure);
            Quick(iPivot + 1, end, dataStructure);
        }
    }
}
