using System;
using System.Runtime.Serialization;

namespace HekimogluWebPortal.Model.Family
{
    public class FamilyMember
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "dateofbirth")]
        public DateTime DateOfBirth { get; set; }
    }
}
