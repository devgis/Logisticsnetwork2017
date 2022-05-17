using System;
using System.Collections.Generic;
using System.Text;
using Logistics.Entities;

namespace Logistics
{
    public class ETC
    {
        
        public static int InitGragh(ref MyGraph G,MainForm mainForm)//校园导游图的初始化
        {
            int i, j;
            G.vernum = Guide.max_ver_num;
            G.arcnum = Guide.max_ver_num;
            for (i = 0; i < G.vernum; i++)
                G.no[i] = i;//各景点的编号

            int index = 0;
            foreach (string s in mainForm.listNodes)
            {
                G.name[index] = s;
                index++;
            }
            

            //初始化边矩阵
            for (i = 0; i < G.vernum; i++)
                for (j = 0; j < G.vernum; j++)
                    G.arcs[i, j] = Guide.MAX;

            foreach (LineDistanceInfo info in mainForm.ListLineDistanceInfo)
            {
                if (info.PointID1 != info.PointID2)
                {
                    int index1 = GetIndex(info.PointID1, G);
                    int index2 = GetIndex(info.PointID2, G);
                    G.arcs[index1, index2] = info.Distance;
                    G.arcs[index2, index1] = info.Distance;
                }
            }
            return 1;
        }//图的初始化

        public static int GetIndex(string svalue,MyGraph G)
        {
            for (int i = 0; i < G.name.Length; i++)
            {
                if (svalue.Equals(G.name[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
