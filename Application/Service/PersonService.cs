using Application.ViewModel;
using Domain.Person;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class PersonService : IPersonService
    {
        readonly IPersonRepository personRepository;
        public PersonService(IPersonRepository _personRepository)
        {
            this.personRepository = _personRepository;
        }

        public async Task<string> Delete(int Id)
        {
            return await personRepository.deleteAsync(Id);
        }

        public async Task<IEnumerable<Person>> GetById(int Id)
        {
            return await personRepository.getbyIDAsync(Id);
        }

        public async Task<IEnumerable<Person>> GetData()
        {
            return await personRepository.FindAllAsync();
        }

        public async Task<String> Insert(PersonViewModel PersonEx)
        {
            return await personRepository.insertAsync(PersonEx.Name, PersonEx.Age);
        }

        public async Task<string> Update(Person PersonEx)
        {
            return await personRepository.updateAsync(PersonEx);
        }
    }
}
