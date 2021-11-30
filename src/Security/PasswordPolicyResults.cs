namespace trnsACT.Core.Security
{
    public static partial class Results
    {
        public static class PasswordPolicy
        {
            private const int prefix = 9320;
            public static (string Message, int ResultCode) PasswordLowerCaseCharacterValidationError => (Message: "Password must include at least one lowercase letter.", ResultCode: (prefix + 1));
            public static (string Message, int ResultCode) PasswordMaxLengthValidationError => (Message: "Your new password must be no longer than {MaxLength} characters.", ResultCode: (prefix + 2));
            public static (string Message, int ResultCode) PasswordMinLengthValidationError => (Message: "Your new password must be at least {MinLength} characters.", ResultCode: (prefix + 3));
            public static (string Message, int ResultCode) PasswordNumericCharacterValidationError => (Message: "Password must include at least one numeral.", ResultCode: (prefix + 4));
            public static (string Message, int ResultCode) PasswordRequiredValidationError => (Message: "A password is required.", ResultCode: (prefix + 5));
            public static (string Message, int ResultCode) PasswordSpecialCharacterValidationError => (Message: @"Password must include at least one special character like one of these: [!@#$%^&*()_+=[{]};:<>|?,-.", ResultCode: (prefix + 6));        
            public static (string Message, int ResultCode) PasswordUpperCaseCharacterValidationError => (Message: "Password must include at least one uppercase letter.", ResultCode: (prefix + 7));
            public static (string Message, int ResultCode) PasswordCommonValidationError => (Message: "The password that you have chosen is commonly used and easily guessed. To preserve the security of your account chose another password.", ResultCode: (prefix + 8));
        }
    }

}