using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleGrpcService;

namespace VehicleService.Data
{
  public static class Storage
  {
    public static IEnumerable<VehicleModel> Vehicles => new List<VehicleModel> 
    {
       new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = "Dodge",
        ModelYear = 2003,
        Model = " Durango"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = "Honda",
        ModelYear =  2004,
        Model = "Honda"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = "Challenger",
        ModelYear = 2014,
        Model = "Chrysler Canada"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = "Korea (South) (Asia)",
        ModelYear = 2015,
        Model = " Sedona"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = " Subaru",
        ModelYear = 1998,
        Model = "  Legacy Wagon"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = " F-150",
        ModelYear =  2014,
        Model = " Ford"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = "Chevrolet",
        ModelYear = 2003,
        Model = "Suburban"
      },
      new VehicleModel
      {
        Id = Guid.NewGuid().ToString(),
        Manufacturer = "Challenger",
        ModelYear = 2014,
        Model = "Chrysler Canada"
      }
    };

  }
}
