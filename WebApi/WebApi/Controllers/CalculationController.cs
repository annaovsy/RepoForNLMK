using Microsoft.AspNetCore.Mvc;
using WebApi.Log;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger logger;

        public CalculationController(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logger.txt"));
            logger = loggerFactory.CreateLogger("FileLogger");
        }

        [HttpGet("{a}/{b}")]
        public double Get(int a, int b)
        {
            try
            {
                logger.LogInformation($"{DateTime.Now} Method:Get started");
                double result = Convert.ToDouble(a) / Convert.ToDouble(b);
                return Math.Round(result, 3);
            }
            catch(Exception ex)
            {
                logger.LogError($"{DateTime.Now} Dividend:{a} Divider:{b} | {ex.Message}");
                return double.NegativeInfinity;
            }
            
        }
    }
}
