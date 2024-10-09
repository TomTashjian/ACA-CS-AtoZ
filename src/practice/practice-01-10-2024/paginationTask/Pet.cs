namespace paginationTask
{
    public class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public int Weight { get; set; }
        public int Id { get; set; }

        public Pet(int id, string name, PetType type, int weight)
        {
            Id = id;
            Name = name;
            Type = type;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {Type}, Weight: {Weight}";
        }
    }
}