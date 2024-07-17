namespace TemplatingRazor.Models
{
    public class Expenditure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public Expenditure(int id, string name, DateTime date, double price)
        {
            Id = id;
            Name = name;
            Date = date;
            Price = price;
        }
    }

}
