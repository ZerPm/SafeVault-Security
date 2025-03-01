using Xunit;
using SafeVault.Web.Services;
using SafeVault.Web.Models;

public class TestAuth
{
    [Fact]
    public void Authenticate_ValidUser_ReturnsTrue()
    {
        var authService = new AuthService();
        var result = authService.Authenticate("admin", "password123");
        Assert.True(result);
    }
}
