using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
    public class MyGraph
    {
        public int[] no = new int[Guide.max_ver_num];
        public String[] name = new String[Guide.max_ver_num];
        public double[,] arcs = new double[Guide.max_ver_num, Guide.max_ver_num];
        public int vernum, arcnum;
    }
}
