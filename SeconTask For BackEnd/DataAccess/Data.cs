using SeconTask_For_BackEnd.Models;
using System.Collections.Generic;

namespace SeconTask_For_BackEnd.DataAccess
{
    public class Data
    {
        public static List<Student> Students = new List<Student>()
        {
                new Student{ Id = 1,FullName = "Nadir",Point=96},
                new Student{ Id = 2,FullName = "Faiq",Point=99},
                new Student{ Id = 3,FullName = "Ismayil",Point=100},
                new Student{ Id = 4,FullName = "Asim",Point=78},
                new Student{ Id = 5,FullName = "Neriman",Point=40},
                new Student{ Id = 6,FullName = "Xaliq",Point=86},
        };
    }
}
