using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestArea
{
    internal class ShapeException:Exception
    {
        public ShapeException(string message):base(message) { }

    }
}
