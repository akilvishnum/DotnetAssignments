namespace TempService.Tests;

public class UnitTests
{
    [Fact]
    public void TestCTF()
    {
        Temp t = new Temp();
        double Temperature_in_Celsius = 27.0;
        double Temperature_in_Farenheit = t.CTF(Temperature_in_Celsius);

        Assert.Equal(80.6, Temperature_in_Farenheit);
    }

    [Fact]
    public void TestFTC()
    {
        Temp t = new Temp();
        double Temperature_in_Farenheit = 80.6;
        double Temperature_in_Celsius = t.FTC(Temperature_in_Farenheit);

        Assert.Equal(27.0, Temperature_in_Celsius);
    }
}