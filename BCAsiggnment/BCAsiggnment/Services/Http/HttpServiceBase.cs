
namespace BCAsiggnment.Services;

public class HttpServiceBase
{
    protected static readonly HttpClient client = new HttpClient();

    public HttpServiceBase()
    {
        client.BaseAddress = new Uri(RouteConstants.RouteBase);
    }
}
