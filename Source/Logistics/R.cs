using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
    /// <summary>
    ///  用于表示计算结果
    /// </summary>
    public class R : IComparable<R>
    {
        public string ID;//修复的路段名称
        public double E;//修复完毕后的E值

        public int CompareTo(R other)
        {
            if (this.E > other.E)
                return 1;
            else if (this.E == other.E)
                return 0;
            else
                return -1;
        }
    }
}
