﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IMMsgBatchSendResult:IMResult
    {
        public List<MsgBatchSendResult> BatchSendResult { set; get; }
    }
}
