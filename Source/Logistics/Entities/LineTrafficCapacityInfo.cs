using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logistics.Entities
{
    /// <summary>
    /// 线路同行能力
    /// </summary>
    public class LineTrafficCapacityInfo
    {
        /// <summary>
        /// 坐标点1
        /// </summary>
        public string PointID1
        {
            get;
            set;
        }

        /// <summary>
        /// 坐标点2
        /// </summary>
        public string PointID2
        {
            get;
            set;
        }

        /// <summary>
        /// 同行能力小于0为断开
        /// </summary>
        public int Capacity
        {
            get;
            set;
        }
    }
}
