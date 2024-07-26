namespace aspTask1.Interfaces
{
    public interface IProduct : IId
    {
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set;}
    }
}
