﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zmq;

namespace NetMQ
{
    public class RouterSocket : DuplexSocket<RouterSocket>
    {
        public RouterSocket(SocketBase socketHandle)
            : base(socketHandle)
        {
        }

        protected override RouterSocket This
        {
            get { return this; }
        }
    }
}
