using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestApiUdemy.Model;

namespace RestApiUdemy.Services.Implementations
{

    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

            

        }

        private Person MockPerson(int i)
        {

            return new Person
            {

                Id = IncrementAndGet(),
                FirstName = "Leandro "+ i,
                LastName = "Costa " + i,
                Address = "Uberlandia - Minas Gerais - Brasil " + i,
                Gender = "Male " + i

            };

        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public List<Person> FindAll()
        {

            List<Person> persons = new List<Person>();

            for (int i = 0; i < 0; i++)
            {

                Person person = MockPerson(i);

                persons.Add(person);

            }

            return persons;

        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = id,
                FirstName = "Person Name" ,
                LastName = "Person LastName",
                 Address = "Some Address" ,
                 Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

    }

}