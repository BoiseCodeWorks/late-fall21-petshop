namespace petshop.Models
{
    public class Cat
    {
        public string? Id { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        
        public Cat( int age, string? name)
        {
            Id = Guid.NewGuid().ToString();
            Age = age;
            Name = name;
        }
    }
}