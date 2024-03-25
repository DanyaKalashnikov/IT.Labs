using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_4.Models
{
    public interface ISet
    {
        void Add(String item);

        void Remove(String item);

        void Clear();

        Boolean Contains(String item);

        Boolean IsEmpty { get; }
        Int32 Count { get; }
        
    }
}
