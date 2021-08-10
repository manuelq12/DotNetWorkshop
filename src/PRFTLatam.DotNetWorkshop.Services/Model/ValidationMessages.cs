        
namespace PRFTLatam.DotNetWorkshop.Services.Model
{
    public static class ValidationMessage
    {
        public static readonly string NullOrEmptyError = "The identification must not be null or empty";
        public static readonly string MinimumLengthError = "The identification doesn't have at least 10 characters";
        public static readonly string MaximumLengthError = "The identification can't have more than 32 characters";
        public static readonly string NoHexadecimalNumber = "The identification contains characters that don't correspond to a hexadecimal number";
        public static readonly string IdentificationNotFoundOnCSV = "The identification doesn't match with the CSV whitelist";
    }
}