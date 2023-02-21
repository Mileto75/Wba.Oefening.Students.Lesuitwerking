using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.Oefening.Students.Core.Entities
{
    public class StudentRepository
    {
        public IEnumerable<Student> Students()
        {
            return new List<Student>
            {
                new Student{ Id = 1, Firstname = "Emi", Lastname = "Nem", Course = "WBA"},
                new Student{ Id = 2, Firstname = "Doctor", Lastname = "Dre", Course = "WFA"},
                new Student{ Id = 3, Firstname = "Snoop", Lastname = "Dog", Course = "WBA"},
                new Student{ Id = 4, Firstname = "Ice", Lastname = "Cube", Course = "WFA"},
            };
        }
    }
}
