using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IPersonRepository
    {
       Task<IEnumerable<Person> >FindAllAsync();
       Task<IEnumerable<Person>> getbyIDAsync(int Id);
       Task<String> insertAsync(String Name,int Age);
       Task<String> updateAsync(Person p);
       Task<String> deleteAsync(int Id);
    }
}
