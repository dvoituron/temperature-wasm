using Microsoft.AspNetCore.Components;
namespace Temperature.Pages;

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
        Fahrenheit = Convert.ToInt32((9d / 5d) * Celsius + 32);
    }
}
