using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_TP
{
    public interface IGraph
    {
        List<int> years { get; set; }
        List<float> data { get; set; }
        List<float> percentChanges { get; set; }
        void SetData();
    }
}
