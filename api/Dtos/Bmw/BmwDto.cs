using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Bmw
{
    public class BmwDto
    {
        public List<string> Serie { get; set; } = new List<string>();
        public List<int> Years { get; set; } = new List<int>();
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ManagerForCar { get; set; } = string.Empty;
    }
}