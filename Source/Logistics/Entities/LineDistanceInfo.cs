using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logistics.Entities
{
    /// <summary>
    /// 路段距离信息
    /// </summary>
    public class LineDistanceInfo
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
        /// 距离 -1表示不能直达
        /// </summary>
        public double Distance
        {
            get;
            set;
        }
    }
}
