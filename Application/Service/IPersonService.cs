using Application.ViewModel;
using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetData();
        Task<IEnumerable<Person>> GetById(int Id);
        Task<String> Insert(PersonViewModel PersonEx);
        Task<String> Update(Person PersonEx);
        Task<String> Delete(int Id);
    }
}
