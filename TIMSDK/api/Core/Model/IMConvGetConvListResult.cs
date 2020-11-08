using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMConvGetConvListResult:IMResult
    {
        public List<ConvInfo> ConvInfoList { set; get; }
    }
}
