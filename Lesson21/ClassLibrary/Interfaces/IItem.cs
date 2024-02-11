using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IItem
    {
        string Name { get; init; }
        decimal Price { get; set; }
    }
}
