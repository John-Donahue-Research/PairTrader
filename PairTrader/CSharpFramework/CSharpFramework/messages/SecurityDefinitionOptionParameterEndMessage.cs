﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFramework.ui
{
    class SecurityDefinitionOptionParameterEndMessage : IBMessage
    {
        private int reqId;

        public SecurityDefinitionOptionParameterEndMessage(int reqId)
        {
            this.Type = MessageType.SecurityDefinitionOptionParameterEnd;
            this.reqId = reqId;
        }
    }
}
