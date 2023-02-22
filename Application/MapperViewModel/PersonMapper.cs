using Application.ViewModel;
using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MapperViewModel
{
    public class PersonMapper
    {
        static PersonViewModel MapperToSecondStudent(Person model)
        {
            var PersonEx = new PersonViewModel()
            {
                Age = model.Age,
                Name = model.Name
            };
            return PersonEx;
        }
    }
}
