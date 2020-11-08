using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMMsgArrayResult : IMResult
    {
        public List<TMessage> IMMessage_Array { set; get; }
    }
}
