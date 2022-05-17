using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
    public class Shortest
    {
        public static void Dijkstra(MyGraph G, int v0, int[] path, double[] dist)
        {
            int i, j;
            int k = v0;
            int v, w;
            double min;
            int[] s = new int[Guide.max_ver_num];
            for (v = 0; v < G.vernum; v++)
            {
                s[v] = 0;
                dist[v] = G.arcs[v0, v];
                if (dist[v] < Guide.MAX)
                    path[v] = v0;
                else
                    path[v] = -1;
            }
            dist[v0] = 0;
            s[v0] = 1;
            for (i = 1; i < G.vernum; i++)
            {
                min = Guide.MAX;
                for (w = 0; w < G.vernum; w++)
                {
                    if (s[w] == 0 && dist[w] < min)
                    {
                        k = w;
                        min = dist[w];
                    }
                }
                s[k] = 1;
                for (j = 0; j < G.vernum; j++)
                    if (s[j] == 0 && (min + G.arcs[k, j] < dist[j]))
                    {
                        dist[j] = min + G.arcs[k, j];
                        path[j] = k;
                    }
            }
        }//Dijkstra算法，用于求两点间最短路径和单源点最短路径。G为图，v0为起始点，path保存求得的路径，dist保存求得的距离

        public static double GetShortestPath(MyGraph G, int v0, int i, int[] p, double[] d)
        {
            int next, k = 0;
            int[] q = new int[Guide.max_ver_num];
            if (p[i] != -1 && i != v0)
            {
                q[++k] = i;
                next = p[i];
                while (next != v0)
                {
                    q[++k] = next;
                    next = p[next];
                }
                while (k > 0)
                {
                    next = q[k--];
                }
                return d[i];
            }
            else
                if (p[i] == -1 && i != v0)
                    return -1;
            return -1;
        }//用于输出由Dijkstra方法求得的路径和距离。其中g、v0、path和dist同Dijkstra，i为终止点
    }
}
