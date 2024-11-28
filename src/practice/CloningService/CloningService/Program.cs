
namespace CloningService
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass
            {
                MyProperty1 = 1,
                MyProperty2 = "MyProperty2",
                Student = new Student { Name = "Student1", Age = 20 },
                Teacher = new Teacher { Name = "Teacher1", Age = 30 },
                Names = new List<string> { "Name1", "Name2" },
                ClassRooms = new List<ClassRoom> { new ClassRoom { Number = 1 }, new ClassRoom { Number = 2 } }
            };

            var cloned = new MyClass
            {
                MyProperty1 = myClass.MyProperty1,
                MyProperty2 = myClass.MyProperty2,
                Student = new Student { Name = myClass.Student.Name, Age = myClass.Student.Age },
                Teacher = new Teacher { Name = myClass.Teacher.Name, Age = myClass.Teacher.Age },
                Names = new List<string>(myClass.Names.Count),
                ClassRooms = new List<ClassRoom>(myClass.ClassRooms.Count)
            };

            foreach (var name in myClass.Names)
            {
                cloned.Names.Add(name);
            }

            foreach (var classRoom in myClass.ClassRooms)
            {
                cloned.ClassRooms.Add(new ClassRoom { Number = classRoom.Number });
            }

            //// Test cases for cloned object
            //Assert.Equal(myClass.MyProperty1, cloned.MyProperty1);
            //Assert.Equal(myClass.MyProperty2, cloned.MyProperty2);
            //Assert.NotSame(myClass.Student, cloned.Student);
            //Assert.Equal(myClass.Student.Name, cloned.Student.Name);
            //Assert.Equal(myClass.Student.Age, cloned.Student.Age);
            //Assert.NotSame(myClass.Teacher, cloned.Teacher);
            //Assert.Equal(myClass.Teacher.Name, cloned.Teacher.Name);
            //Assert.Equal(myClass.Teacher.Age, cloned.Teacher.Age);
            //Assert.Equal(myClass.Names, cloned.Names);
            //Assert.Equal(myClass.ClassRooms.Count, cloned.ClassRooms.Count);
            //for (int i = 0; i < myClass.ClassRooms.Count; i++)
            //{
            //    Assert.Equal(myClass.ClassRooms[i].Number, cloned.ClassRooms[i].Number);
            //}
        }
    }
}
