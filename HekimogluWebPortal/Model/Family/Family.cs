using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HekimogluWebPortal.Model.Family
{
    public class Family
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        [DataMember(Name = "members")]
        public List<FamilyMember> Members { get; set; }
    }
}
