using StudentsSystem.Data;
using StudentsSystem.Data.Models;

namespace StudentsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentSystemDbContext();

            var resources = context.Resources
                .ToArray();

            foreach (var resource in resources)
            {
                
                Console.WriteLine($"{resource.Name} {resource.ResourceType}");
            }
        }
    }
}
