using System;
using System.Collections.Generic;
using System.Text;

namespace IntoToClasses.Common_Design_Patterns.Repository_Design_Pattern
{
    /// <summary>
    /// Interface for the repository. This will be used for Dependency Injection.
    /// </summary>
    interface IMemeberRepository
    {
        bool AddMember(Member member);
        bool RemoveMember(Member member);
    }

    /// <summary>
    /// Concrete Implementation of IMemberRepsoitory
    /// </summary>
    class MemberRepository : IMemeberRepository
    {
        private List<Member> _members;
        public MemberRepository()
        {
            _members = new List<Member>();
        }
        public bool AddMember(Member member)
        {
            if (!_members.Contains(member))
            {
                _members.Add(member);
                return true;
            }
            else
                return false;
        }

        public bool RemoveMember(Member member)
        {
            return _members.Remove(member);
        }
    }

    /// <summary>
    /// Repository "item" class
    /// </summary>
    class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
