using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMGroupInviteMemberResult:IMResult
    {
        public  List<GroupInviteMemberResult> GroupInviteResult { set; get; }
    }
}
