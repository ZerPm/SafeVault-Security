using Xunit;
using SafeVault.Web.Helpers;

public class TestInputValidation
{
    [Fact]
    public void ValidateInput_SafeInput_ReturnsTrue()
    {
        var result = InputValidator.IsValid("safe_input");
        Assert.True(result);
    }
}
