using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Interfaces.Responses
{
    public interface IUserResponse : IContactResponse
    {
        List<Claim> Claims { get; }
        int CompanyId { get; set; }
        bool HasAnnouncement { get; set; }
        bool IsActive { get; set; }
        bool IsAgreed { get; set; }
        bool IsApproved { get; set; }
        bool IsAvailable { get; set; }
        bool IsCompanyActive { get; set; }
        bool IsConfirmed { get; set; }
        bool IsExpired { get; set; }
        bool IsImpersonating { get; set; }
        bool IsImpersonationAllowed { get; set; }
        bool IsLocationKnown { get; set; }
        bool IsLocked { get; set; }
        bool IsPasswordExpired { get; set; }
        bool IsPasswordTemporary { get; set; }
        bool IsProfileIncomplete { get; set; }
        bool IsUser { get; set; }
        string Name { get; set; }
        string Role { get; set; }
        string SecurityStamp { get; set; }
        int UserId { get; set; }
        int Visits { get; set; }
    }
}
