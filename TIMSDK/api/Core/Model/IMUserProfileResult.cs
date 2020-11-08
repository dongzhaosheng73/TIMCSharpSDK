using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMUserProfileResult:IMResult
    {
        public List<UserProfile> UserProfiles { set; get; }
    }
}
