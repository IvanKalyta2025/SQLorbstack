using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Bmw;
using api.Models;

namespace api.Mappers
{
    public static class BmwMappers
    {
        public static BmwDto ToBmwDto(this BmwM90 bmwModel)

        {
            return new BmwDto
            {
                Id = bmwModel.Id,
                ManagerForCar = bmwModel.ManagerForCar,
                Serie = bmwModel.Serie,
                Years = bmwModel.Years
            };
        }

    }
}