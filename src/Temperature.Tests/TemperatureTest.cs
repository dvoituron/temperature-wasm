using Bunit;
using MudBlazor;
using MudBlazor.Services;
using Temperature.Pages;
namespace Temperature.Tests;

public class TemperatureTest
{
    [Fact]
    public void Temperature_20Celsius_68Fahrenheit()
    {
        // Arrange
        using var ctx = new TestContext();
        ctx.Services.AddMudServices();
        ctx.JSInterop.Mode = JSRuntimeMode.Loose;

        // Act
        var page = ctx.RenderComponent<TemperaturePage>(parameters =>
        {
            parameters.Add(p => p.Celsius, 20);
        });

        // Assert
        Assert.Contains("value=\"68\"", page.Markup);

        var fahrenheit = page.FindComponent<MudTextField<int>>();
        Assert.Equal(68, fahrenheit.Instance.Value);
    }
}