using petshop.DB;
using petshop.Models;

namespace petshop.Services
{
  public class CatsService
  {
    internal List<Cat> Get()
    {
      // this is only temporary
      return FakeDB.Cats;
    }

    internal Cat Get(string id)
    {
      Cat found = FakeDB.Cats.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal void Remove(string id)
    {
      Cat cat = Get(id);
      FakeDB.Cats.Remove(cat);
    }
  }
}