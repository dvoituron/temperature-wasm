namespace MyTemperature.Pages;
using Microsoft.AspNetCore.Components;

public partial class TemperaturePage
{
    [Parameter]
    public int Celsius { get; set; } = 0;

    public int Fahrenheit { get; set; } = 0;

    protected override void OnInitialized()
    {
        btnCalculate_Click();
    }

    public void btnCalculate_Click()
    {
        Fahrenheit = Convert.ToInt32(1.8 * Celsius + 32);
    }
}
