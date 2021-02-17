using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }
}
