using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleGrpcService;
using VehicleService.Data;

namespace VehicleService.Services
{
  public class VehicleService : Vehicle.VehicleBase
  {
    private readonly ILogger<VehicleService> _logger;
    public VehicleService(ILogger<VehicleService> logger)
    {
      _logger = logger;
    }

    public override Task<VehicleModel> GetVehicle(SingleRequest request, ServerCallContext context)
    {
      _logger.LogInformation($"Search vehicle with id: {request.Id}");
      var response = Storage.Vehicles.FirstOrDefault(e => e.Id == request.Id);
      return Task.FromResult(response);
    }

    public override Task<QueryResponse> GetAll(Request request, ServerCallContext context)
    {
      _logger.LogInformation("Search vehicles from request.", request);
      var result = string.IsNullOrWhiteSpace(request.Query)
        ? Storage.Vehicles
        : Storage.Vehicles.Where(e => e.Model.Contains(request.Query) 
          || e.Manufacturer.Contains(request.Query));

      var response = new QueryResponse
      {
        Request = request,
      };
      response.Results.AddRange(result);
      return Task.FromResult(response);
    }

  }
}
