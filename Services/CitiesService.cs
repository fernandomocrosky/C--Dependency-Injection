using System.Security.Cryptography.X509Certificates;

namespace Services;
using ServiceContracts;

public class CitiesService : ICitiesService, IDisposable
{
    private List<string> _cities = [];
    private Guid _serviceInstanceId;
    public Guid ServiceInstanceId {
        get
        {
            return _serviceInstanceId;
        } 
    }

    public CitiesService()
    {
        _serviceInstanceId = Guid.NewGuid();
        _cities = new() { 
            "London", "Paris", "New York", "Tokyo", "Rome"
        };

        // Open database connection

    }

    public List<string> GetCities()
    {
        return _cities;
    }

    public void Dispose()
    {
        throw new NotImplementedException();

        //Close database connection
    }
}
