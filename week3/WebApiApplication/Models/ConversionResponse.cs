using System.Collections.Generic;
namespace WebApiApplication.Models;
public class ConversionResponse
{
    public double Value { get; set; }
    public string ValueType { get; set; }

    public List<ConversionResponse> Conversions(ConversionRequest request)
    {
        List<ConversionResponse> response = new List<ConversionResponse>();
        if (request.TypeToConvert == ConversionRequest.ValueType.Gallons)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Gallons).ToString();
            var convertedType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Liters).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 3.785, ValueType = convertedType });
        }
        if (request.TypeToConvert == ConversionRequest.ValueType.Liters)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Liters).ToString();
            var convertedType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Gallons).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.26417, ValueType = convertedType });
        }
        if (request.TypeToConvert == ConversionRequest.ValueType.Miles)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Miles).ToString();
            var convertedType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilometeres).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 1.609, ValueType = convertedType });
        }
        if (request.TypeToConvert == ConversionRequest.ValueType.Pounds)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Pounds).ToString();
            var convertedType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilograms).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.453, ValueType = convertedType });
        }
        if (request.TypeToConvert == ConversionRequest.ValueType.Yards)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Yards).ToString();
            var convertedType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Meters).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.914, ValueType = convertedType });
        }
        return response;
    }
}