namespace MyTemperature.Tests;
using Bunit;
using Microsoft.Fast.Components.FluentUI;
using MyTemperature.Pages;

public class TemperatureTests
{
    [Fact]
    public void Temperature_20Celsius_68Fahrenheit()
    {
        // Arrange
        using var ctx = new TestContext();

        // Act
        var page = ctx.RenderComponent<TemperaturePage>(parameters =>
        {
            parameters.Add(p => p.Celsius, 20);
        });

        // Assert
        Assert.Contains("value=\"68\"", page.Markup);

        var fahrenheit = page.FindComponents<FluentNumberField<int>>().Last();
        Assert.Equal(68, fahrenheit.Instance.Value);
    }
}