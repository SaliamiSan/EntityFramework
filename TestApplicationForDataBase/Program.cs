using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastore;
using System.Data.Entity;

namespace TestApplicationForDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //context.Database.Initialize(true);
                context.Students.Add(new Student() { EnrollmentDate = DateTime.Now, FirstMidName = "asdf" });
                context.SaveChanges();
            }
        }
    }
}
