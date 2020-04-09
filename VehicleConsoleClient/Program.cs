using Grpc.Net.Client;
using System;
using System.Threading.Tasks;
using VehicleGrpcService;
using System.Linq;
using System.Text.Json;
namespace VehicleConsoleClient
{
  class Program
  {
    static async Task Main(string[] args)
    {
      try
      {
        Console.WriteLine("Search:");
        var query = Console.ReadLine();

        // The port number(5001) must match the port of the gRPC server.
        using var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new Vehicle.VehicleClient(channel);

        //Get single vehicle
        var vehicles = await client.GetAllAsync(new Request() { Query = query });
        Console.WriteLine($"Founded: {vehicles.Results.Count}");
        vehicles.Results.ToList().ForEach(e =>
        {
          Console.WriteLine(JsonSerializer.Serialize(e));
        });
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.ReadKey();
      }
    }
  }
}
