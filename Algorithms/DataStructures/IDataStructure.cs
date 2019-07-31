namespace DataStructures
{
    public interface IDataStructure
    {
        int? this[int index] { get; set; }
        void Add(int value);
        void Cross();
        int Count();
    }
}
