﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HearkenContainer.Model
{
    public class FunctionInfo
    {
        public MethodInfo Method { get; set; }
        public string EventName { get; set; }
    }
}
