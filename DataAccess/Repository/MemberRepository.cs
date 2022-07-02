using BusinessObject;
using DataAccess.ADO;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public bool AddMember(MemberObject member) => MyStoreDbContext.GetDbContext.CreateMember(member);
        public bool UpdateMember(MemberObject member) => MyStoreDbContext.GetDbContext.UpdateMember(member);
        public bool DeleteMember(int memberId) => MyStoreDbContext.GetDbContext.RemoveMember(memberId);
        public IEnumerable<MemberObject>? GetMembersList() => MyStoreDbContext.GetDbContext.GetListMembers();
        public MemberObject? SearchMemberById(int id) => MyStoreDbContext.GetDbContext.FindAccountMemberById(id);
        public MemberObject GetDefaultAdminAccount() => MyStoreDbContext.GetDbContext.GetDefaultAdminAccount();
        public MemberObject? SearchMemberByIdOrEmail(int id, string email) => MyStoreDbContext.GetDbContext.FindAccountMemberByIdOrEmail(id, email);
    }
}
