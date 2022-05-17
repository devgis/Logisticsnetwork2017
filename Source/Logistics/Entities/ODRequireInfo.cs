using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logistics.Entities
{
    /// <summary>
    /// OD需求信息
    /// </summary>
    public class ODRequireInfo
    {
        /// <summary>
        /// 坐标点
        /// </summary>
        public string PointID
        {
            get;
            set;
        }

        /// <summary>
        /// x坐标
        /// </summary>
        public double x
        {
            get;
            set;
        }

        /// <summary>
        /// y坐标
        /// </summary>
        public double y
        {
            get;
            set;
        }

        /// <summary>
        /// D1需求量
        /// </summary>
        public int D1Require
        {
            get;
            set;
        }

        /// <summary>
        /// D2需求量
        /// </summary>
        public int D2Require
        {
            get;
            set;
        }
    }
}
