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

    internal Cat Create(Cat newCat)
    {
      FakeDB.Cats.Add(newCat);
      return newCat;
    }


    internal void Remove(string id)
    {
      Cat cat = Get(id);
      FakeDB.Cats.Remove(cat);
    }

    internal Cat Update(Cat updatedCat)
    {
      Cat oldCat = Get(updatedCat.Id);
      // NOTE updates will be done like this to prevent accidentally setting values to null if they are not passed by the client
      oldCat.Name = updatedCat.Name != null ? updatedCat.Name : oldCat.Name;
      oldCat.Age = updatedCat.Age != 0 ? updatedCat.Age : oldCat.Age;
      // save to DB
      return oldCat;
    }
  }
}