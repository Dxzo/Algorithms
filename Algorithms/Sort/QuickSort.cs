using DataStructures;

namespace SortingAlgorithms
{
    public class QuickSort : ISort
    {
        public IDataStructure Sort(IDataStructure dataStructure)
        {
            return Pivot(dataStructure);
        }
        public IDataStructure Pivot(IDataStructure dataStructure)
        {
            int length = dataStructure.Count();

            if (length == 1)
                return dataStructure;

            int? pivotValue = dataStructure[length - 1];
            int iPivot = 0;
            int i = 0;

            while (i < length)
            {
                if (dataStructure[i] < pivotValue)
                {
                    int temp = (int)dataStructure[i];
                    dataStructure[i] = dataStructure[iPivot];
                    dataStructure[iPivot] = temp;

                    iPivot++;
                }
                i++;
            }

            dataStructure[length - 1] = (int)dataStructure[iPivot];
            dataStructure[iPivot] = pivotValue;

            return QuickRecursion(dataStructure, iPivot);
        }
        public IDataStructure QuickRecursion(IDataStructure dataStructure, int iPivot)
        {
            int length = dataStructure.Count();

            if (length == 1)
                return dataStructure;

            IDataStructure dsLeft = new LinkedList();
            IDataStructure dsRight = new LinkedList();

            for (int i = 0; i < length; i++)
            {
                if (i != iPivot)
                {
                    if (dataStructure[i] < dataStructure[iPivot])
                        dsLeft.Add((int)dataStructure[i]);
                    else
                        dsRight.Add((int)dataStructure[i]);
                }
            }

            int iLeft = dsLeft.Count();
            int iRight = dsRight.Count();

            if (iLeft > 0)
                dsLeft = Pivot(dsLeft);
            if (iRight > 0)
                dsRight = Pivot(dsRight);

            IDataStructure ds = new LinkedList();

            for (int i = 0; i < iLeft; i++)
                ds.Add((int)dsLeft[i]);

            ds.Add((int)dataStructure[iPivot]);

            for (int i = 0; i < iRight; i++)
                ds.Add((int)dsRight[i]);

            return ds;
        }
    }
}
