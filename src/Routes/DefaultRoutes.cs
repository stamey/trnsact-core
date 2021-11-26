namespace trnsACT.Core.Routes
{
    public static class DefaultRoute
    {
        public static string AccountHasAnnouncement => "/Announcement";
        public static string AccountIsExpired => "/Account/Expired";
        public static string AccountIsInactive => "/Account/Inactive";
        public static string AccountIsLocked => "/Account/Locked";
        public static string AccountIsNotApproved => "/Approval/Required";
        public static string AccountIsNotConfirmed => "/Confirmation/Required";
        public static string CompanyIsInactive => "/Company/Inactive";
        public static string Home => "/";
        public static string IsFirstVisit => "/Welcome";
        public static string LocationIsUnknown => "/Location/Unknown";
        public static string PasswordIsExpired => "/Password/Expired";
        public static string PasswordIsTemporary => "/Password/Temporary";
        public static string ProfileIsIncomplete => "/Profile/Incomplete";
        public static string TermsNotAgreed => "/Agree/Terms";
        public static string Unauthorized => "/Unauthorized";
        public static string Unavailable => "/Unavailable";
        public static string UserIsImpersonating => "/Impersonating";
    }
}
