namespace CloningService
{
    internal partial class Program
    {
        public class MyClass
        {
            [Cloneable(CloningMode.Ignore)]
            public int MyProperty1 { get; set; }

            public string MyProperty2 { get; set; }

            [Cloneable(CloningMode.Deep)]
            public Student Student { get; set; }

            [Cloneable(CloningMode.Deep)]
            public Teacher Teacher { get; set; }

            [Cloneable(CloningMode.Deep)]
            public List<string> Names { get; set; }

            [Cloneable(CloningMode.Deep)]
            public List<ClassRoom> ClassRooms { get; set; }
        }
    }
}
