namespace SafeVault.Web.Helpers
{
    public static class InputValidator
    {
        public static bool IsValid(string input)
        {
            return !string.IsNullOrEmpty(input) && !input.Contains("--");
        }
    }
}
