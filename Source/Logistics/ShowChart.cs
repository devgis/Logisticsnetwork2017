using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Logistics
{
    public partial class ShowChart : Form
    {
        List<Double> _listData;
        double _EO;
        public ShowChart(List<Double> listData,double E0)
        {
            InitializeComponent();
            _listData = listData;
            _EO = E0;
        }

        private void ShowChart_Load(object sender, EventArgs e)
        {
            if (_listData == null || _listData.Count <= 0)
                return;
            else
            {
                //绘制表格内容

                //计算面积
                double areaall = 0;
                for (int i = 1; i < 20; i++)
                {
                    double top = 0;
                    double bottom = 0;
                    if (i <= _listData.Count - 1)
                    {
                        top = _EO - _listData[i];
                    }
                    else
                    {
                        top = _EO - _listData[_listData.Count - 1];
                    }
                    if (i-1 <= _listData.Count - 1)
                    {
                        bottom = _EO - _listData[i - 1];
                    }
                    else
                    {
                        bottom = _EO - _listData[_listData.Count - 1];
                    }

                    double area = (top + bottom) * (double)3 / (double)2;
                    areaall += area;
                }
                toostripLable.Text = "面积:" + areaall.ToString();

                PointPairList list = new PointPairList();
                for (int i = 0; i <= 60; i = i + 3)
                {
                    if (i / 3 >= _listData.Count)
                    {
                        list.Add(i, _listData[_listData.Count - 1]);
                    }
                    else
                    {
                        list.Add(i, _listData[i / 3]);
                    }
                }
                GraphPane myPane;
                myPane = zedGraphControl1.GraphPane;
                myPane.Title.Text = "网络效能";
                myPane.Title.FontSpec.Size = 10;
                myPane.XAxis.Scale.BaseTic = 50;
                myPane.YAxis.Title.Text = "E";
                myPane.YAxis.Title.FontSpec.Size = 8;
                myPane.XAxis.Title.Text = "时间";
                myPane.XAxis.Title.FontSpec.Size = 8;
                myPane.XAxis.Type = AxisType.DateAsOrdinal;
                myPane.XAxis.CrossAuto = true;
                myPane.XAxis.Scale.Max = 60;
                myPane.XAxis.Scale.Min = 0;
                myPane.XAxis.Scale.FontSpec.Size = 5;
                myPane.YAxis.Scale.Max = _EO;
                myPane.YAxis.Scale.Min = _listData[0];
                myPane.YAxis.Scale.FontSpec.Size = 5;

                myPane.Legend.Border.Color = Color.White; //去掉图例边框
                myPane.Legend.FontSpec.Size = 8; //图例字体大小
                myPane.XAxis.Scale.Format = "hh:mm:ss";
                LineItem myCurve = myPane.AddCurve("网络效能", list, Color.Red, SymbolType.None);
                myCurve.Line.IsAntiAlias = true;
                myCurve.Line.Width = 1.5F;
                myCurve.Symbol.Fill = new Fill(Color.White);
                myCurve.Symbol.Size = 5;

                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
        }
    }
}