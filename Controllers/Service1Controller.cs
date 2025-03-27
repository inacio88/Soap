using Microsoft.AspNetCore.Mvc;
using soap.Model;
using soap.SOAP.Model;

namespace soap.Controllers;

[ApiController]
[Route("[controller]")]
public class Service1Controller : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<Service1Controller> _logger;

    public Service1Controller(ILogger<Service1Controller> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Consumes("application/xml")]
    [Produces("application/xml")]
    public IActionResult Post([FromBody] SOAPRequestEnvelop envelop)
    {
        var res = new SOAPResponseEnvelope();
        res.Body.GetWetherForecast = new GetWetherForecastResponse()
        {
            WeatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray()
        };
        return Ok(res);
    }

}
