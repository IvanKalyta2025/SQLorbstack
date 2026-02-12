
namespace api.Models
{
    public class BmwM90
    {
        public List<string> Serie { get; set; } = new List<string>();
        public List<int> Years { get; set; } = new List<int>();

        public Guid Id { get; set; } = Guid.NewGuid();

        public string ManagerForCar { get; set; } = string.Empty;

    }
}