namespace trnsACT.Core.Security
{

    /// <summary>

    /// Defines the claim types that are supported by this solution.

    /// </summary>

    public static class CustomClaimTypes
    {
        internal const string CustomClaimTypeNamespace = "http://schemas.microsoft.com/ws/2008/06/identity/claims";

        public const string CompanyId = CustomClaimTypeNamespace + "/companyid";

        public const string AdditionalName = CustomClaimTypeNamespace + "/additionalname";

        public const string UserClaim1 = CustomClaimTypeNamespace + "/userclaim1";

        public const string UserClaim2 = CustomClaimTypeNamespace + "/userclaim2";

        public const string UserClaim3 = CustomClaimTypeNamespace + "/userclaim3";

        public const string Impersonating = CustomClaimTypeNamespace + "/impersonating";

    }
}
