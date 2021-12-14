using System.ComponentModel.DataAnnotations;

namespace petshop.Models
{
  public class Cat
  {
    public string? Id { get; set; }

    [Range(0, int.MaxValue)]
    public int Age { get; set; }

    [Required]
    public string? Name { get; set; }

    // this constructor is not used by from body
    public Cat(int age, string? name)
    {
      Id = Guid.NewGuid().ToString();
      Age = age;
      Name = name;
    }
  }
}