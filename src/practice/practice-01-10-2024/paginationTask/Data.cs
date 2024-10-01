using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paginationTask
{
    public class Data
    {
        public static IEnumerable<Pet> Pets = Enumerable.Range(1, 1000000)
            .Select(i => new Pet(i, $"Pet{i * -1}", PetType.Dog, i % 100)).ToArray();
    }
}
