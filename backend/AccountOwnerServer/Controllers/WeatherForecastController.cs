using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IEnumerable<string> Get()
    {
         _logger.LogInfo("Testando o log de Informação pelo controler");
         _logger.LogWarn("Testando o log de aviso pelo controler");
         _logger.LogError("Testando o log de erro pelo controler");
         _logger.LogDebug("Testando o log de Debug pelo controler");
        return new string []{"valor1", "valor2"};
    }
}
