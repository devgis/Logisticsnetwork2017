using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Logistics
{
    public partial class RandomTree : Form
    {
        List<List<double>> _listRandomResult;
        double _E0;
        public RandomTree(List<List<double>> listRandomResult,double E0)
        {
            InitializeComponent();
            _listRandomResult = listRandomResult;
            _E0 = E0;
        }

        private void RandomTree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            int i = 0;
            double avgArea = 0;
            foreach (List<double> listOne in _listRandomResult)
            {
                TreeNode tn = new TreeNode(i.ToString());
                tn.Tag = listOne;
                avgArea += GetArea(listOne) / 500;
                treeView1.Nodes.Add(tn);
                i++;
            }
            tsArea.Text = "平均面积:" + avgArea.ToString();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is List<double>)
            {
                ShowChart frmShowChart = new ShowChart(e.Node.Tag as List<double>, _E0);
                frmShowChart.ShowDialog();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private double GetArea(List<double> _listData)
        {
            double areaall = 0;
            for (int i = 1; i < 20; i++)
            {
                double top = 0;
                double bottom = 0;
                if (i <= _listData.Count - 1)
                {
                    top =_E0- _listData[i];
                }
                else
                {
                    top = _E0 - _listData[_listData.Count - 1];
                }
                if (i - 1 <= _listData.Count - 1)
                {
                    bottom = _E0 - _listData[i - 1];
                }
                else
                {
                    bottom = _E0 - _listData[_listData.Count - 1];
                }

                double area = (top + bottom) * (double)3 / (double)2;
                areaall += area;
            }
            return areaall;
        }
    }
}