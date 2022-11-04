using Microsoft.AspNetCore.Mvc;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class ConverterController : ControllerBase
{
    private readonly ILogger<ConverterController> _logger;

    public ConverterController(ILogger<ConverterController> logger)
    {
        _logger = logger;
    }
    [HttpGet("LitresToGallonConverter")]
    public double LitresToGallon(int liters)
    {
        return 0.26417 * liters;
    }
    [HttpGet("GallonToLitresConverter")]
    public double GallonToLitres(int gallons)
    {
        return 3.78541 * gallons;
    }
    [HttpGet("ConvertMilesConverter")]
    public Distance ConvertMiles(int miles)
    {
        return new Distance() { Miles = miles, Kilometers = miles * 1.609 };
    }
    [HttpPost("ConvertValues")]
    public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest request)
    {
        return new ConversionResponse().Conversions(request);
    }
}