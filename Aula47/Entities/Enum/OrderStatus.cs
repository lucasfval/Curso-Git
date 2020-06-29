using System;
using System.Collections.Generic;
using System.Text;

namespace Aula47.Entities.Enum
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
