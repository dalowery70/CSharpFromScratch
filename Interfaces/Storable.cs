using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public enum ReturnStatus
    {
        OK,
        Fail
    }

    public interface Storable
    {
        void Write(object obj);
        String Read();
        ReturnStatus Status { get; set; }
    }
}
