using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmExample.Models
{
    class Mocks
    {
        public static StudentModel GetMock()
        {
            return new StudentModel { Name = "Вася", Group = new List<string> { "Конструктор", "Технолог" } };
        }
        

    }
}
