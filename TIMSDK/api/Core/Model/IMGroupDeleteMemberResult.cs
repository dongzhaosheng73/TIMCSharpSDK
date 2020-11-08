using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMGroupDeleteMemberResult:IMResult
    {
        public List<GroupDeleteMemberResult> GroupDeleterResult { set; get; }
    }
}
