namespace paginationTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            PaginationRequest request = new PaginationRequest
            {
                PageNumber = 1,
                PageSize = 10,
                OrderingField = "Id",
                Ascending = true
            };

            PaginationResult<Pet> result = new PaginationResult<Pet>
            {
                Items = Data.Pets.OrderBy(p => p.Id)
                    .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToArray(),
                TotalItems = Data.Pets.Count()
            };

            Console.ReadKey();
        }
    }

    public class PaginationRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? OrderingField { get; set; }
        public bool Ascending { get; set; }

    }

    public class PaginationResult<T>
    {
        public int TotalItems { get; set; }
        public T[] Items { get; set; }
    }
}
