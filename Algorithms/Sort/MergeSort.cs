using DataStructures;

namespace SortingAlgorithms
{
    public class MergeSort : ISort
    {
        public IDataStructure Sort(IDataStructure dataStructure)
        {
            return Divide(dataStructure);
        }
        public IDataStructure Merge(IDataStructure dataStructure1, IDataStructure dataStructure2)
        {
            IDataStructure ds = new LinkedList();

            int i1 = 0;
            int i2 = 0;

            int length1 = dataStructure1.Count();
            int length2 = dataStructure2.Count();

            bool exit = true;

            while (exit)
            {
                if (dataStructure1[i1] == null)
                {
                    exit = false;
                    for (int i = i2; i < length2; i++)
                        ds.Add((int)dataStructure2[i]);
                }
                if (dataStructure2[i2] == null)
                {
                    exit = false;
                    for (int i = i1; i < length1; i++)
                        ds.Add((int)dataStructure1[i]); 
                }

                if (exit)
                {
                    if (dataStructure1[i1] < dataStructure2[i2])
                    {
                        ds.Add((int)dataStructure1[i1]);
                        i1++;
                    }
                    else
                    {
                        ds.Add((int)dataStructure2[i2]);
                        i2++;
                    }
                }
            }

            return ds;
        }
        public IDataStructure Divide(IDataStructure dataStructure)
        {
            int length = dataStructure.Count();

            if (length < 2)
                return dataStructure;

            int iterations = 0;

            IDataStructure ds1 = new LinkedList();
            IDataStructure ds2 = new LinkedList();

            iterations = length / 2;

            for (int i = 0; i < iterations; i++)
                ds1.Add((int)dataStructure[i]);

            for (int i = iterations; i < length; i++)
                ds2.Add((int)dataStructure[i]);

            if (length == 2)
                return Merge(ds1, ds2);

            return Merge(Divide(ds1), Divide(ds2));
        }
    }
}
