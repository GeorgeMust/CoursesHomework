using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface ILogger
    {
        void Info(string message);
        void Warn(string message);

        bool IsAvailable();
    }
}
