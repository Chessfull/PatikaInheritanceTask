using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaInheritanceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Instance for teacher and defining with ctor ▼
            Teacher teacher=new Teacher("Sertan","Bozkuş",60000);
            // ▼ Showing infos of teacher ▼
            teacher.DisplayInfo();

            // ▼ Instance for student and defining with ctor ▼
            Student student =new Student("Mert","Topcu",3);
            // ▼ Showing infos of student ▼
            student.DisplayInfo();
        }
    }
}
