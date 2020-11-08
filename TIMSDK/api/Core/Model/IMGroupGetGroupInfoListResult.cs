using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMGroupGetGroupInfoListResult:IMResult
    {
        public List<GetGroupInfoResult> GetGroupInfoResult { set; get; }
    }
}
