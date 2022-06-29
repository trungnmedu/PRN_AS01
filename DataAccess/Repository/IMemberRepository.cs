using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<MemberObject>? GetMembersList();
        public bool AddMember(MemberObject member);
        public bool UpdateMember(MemberObject member);
        public bool DeleteMember(int memberId);
        public MemberObject? SearchMemberById(int id);
        public MemberObject GetDefaultAdminAccount();
        public MemberObject? SearchMemberByIdOrEmail(int id, String email);
    }
}
