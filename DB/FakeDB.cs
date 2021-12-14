using petshop.Models;

namespace petshop.DB
{
  // static means the class is always avaliable and cannot be instantiated
  public static class FakeDB
    {
        public static List<Cat>? Cats { get; set; } = new List<Cat>(){
            new Cat(400, "Mr. Snibbley"),
            new Cat(5, "Mittens"),
            new Cat(53, "Bozko"),
            new Cat(1, "Snowball"),
            new Cat(15, "Madame Blackwell")
        };
    }
}