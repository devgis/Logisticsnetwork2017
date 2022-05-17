using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Logistics.Entities;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Logistics
{
    public partial class MainForm : Form
    {
        #region 公共变量定义
        public List<ODRequireInfo> ListODRequireInfo = null; //OD需求列表
        public List<LineDistanceInfo> ListLineDistanceInfo = null; //线路距离列表
        public List<LineTrafficCapacityInfo> ListLineTrafficCapacityInfo = null; //线路通行能力列表

        public List<string> listNodes = new List<string>(); //存储网络的所有节点

        int[] path;
        double[] dist;
        public static int NodeCount = 0;
        #endregion

        public MyGraph g = new MyGraph();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        
        private void btCompute_Click(object sender, EventArgs e)
        {
            
            Step1();

            Step2();

            if (cbSetULS.Checked)//建立ULS
            {
                for (int i = 0; i < 20; i++) //重复20次的过程不需要每次都输出曲线，但是若想调用任意一次的曲线及各时刻所对应的值，需要能够调用出来。
                {
                    if (rbMethod1.Checked) //方法1
                    {
                        Step3_1();
                        Step4_1();
                    }
                    else if (rbMethod2.Checked) //方法2
                    {
                        Step3_2();
                        Step4_2();
                    }
                    else if (rbMethod3.Checked) //方法3
                    {
                        Step3_3();
                        Step4_3();
                    }
                }
            }
            else //不建立ULS
            {
                StepNoULS();
                
            }
            
        }
        
        
        //步骤1：导入网络，选择道路的阻抗模式（三种任选一种）。
        private void Step1()
        {
            #region "ODRequire.xlsx"中初始化OD需求信息
            ListODRequireInfo = new List<ODRequireInfo>();

            string fileODRequireInfo = Path.Combine(Application.StartupPath, "ODRequire.xlsx");
            FileStream fsODRequireInfo = new FileStream(fileODRequireInfo, FileMode.Open, FileAccess.Read);
            IWorkbook workbookODRequireInfo = new XSSFWorkbook(fsODRequireInfo);
            ISheet sheetODRequireInfo = workbookODRequireInfo.GetSheetAt(0);
            for (int i = 1; i <= sheetODRequireInfo.LastRowNum; i++)
            {
                ODRequireInfo odinfo = new ODRequireInfo();
                odinfo.PointID = sheetODRequireInfo.GetRow(i).Cells[0].ToString();
                odinfo.x = sheetODRequireInfo.GetRow(i).Cells[1].NumericCellValue;
                odinfo.y = sheetODRequireInfo.GetRow(i).Cells[2].NumericCellValue;
                try 
                {
                    odinfo.D1Require = (int)sheetODRequireInfo.GetRow(i).Cells[4].NumericCellValue;
                }
                catch
                {
                    odinfo.D1Require = 0;
                }

                try
                {
                    odinfo.D2Require = (int)sheetODRequireInfo.GetRow(i).Cells[6].NumericCellValue;
                }
                catch
                {
                    odinfo.D2Require = 0;
                }
                
                
                ListODRequireInfo.Add(odinfo);

                //MessageBox.Show(sheetODRequireInfo.GetRow(i).Cells[0].ToString());
            }
            #endregion

            #region "LineDistance.xlsx"中初始化线路距离信息
            ListLineDistanceInfo = new List<LineDistanceInfo>();
            string fileLineDistanceInfo = Path.Combine(Application.StartupPath, "LineDistance.xlsx");
            FileStream fsLineDistanceInfo = new FileStream(fileLineDistanceInfo, FileMode.Open, FileAccess.Read);
            IWorkbook workbookLineDistance = new XSSFWorkbook(fsLineDistanceInfo);
            ISheet sheetLineDistance = workbookLineDistance.GetSheetAt(0);
            
            for (int i = 1; i <= sheetLineDistance.LastRowNum; i++)
            {
                listNodes.Add(sheetLineDistance.GetRow(i).Cells[0].ToString());
                for (int j = 1; j < sheetLineDistance.GetRow(i).LastCellNum; j++)
                {
                    LineDistanceInfo lineDistanceInfo = new LineDistanceInfo();
                    lineDistanceInfo.PointID1 = sheetLineDistance.GetRow(i).Cells[0].ToString();
                    lineDistanceInfo.PointID2 = sheetLineDistance.GetRow(0).Cells[j].ToString();
                    if (sheetLineDistance.GetRow(i).Cells[j].CellType == CellType.Numeric)
                    {
                        lineDistanceInfo.Distance = sheetLineDistance.GetRow(i).Cells[j].NumericCellValue;
                    }
                    else
                    {
                        lineDistanceInfo.Distance = double.MaxValue;
                    }
                    ListLineDistanceInfo.Add(lineDistanceInfo);
                }
            }
            #endregion
            
            #region "LineTrafficCapacity.xlsx"中初始化线路最大通行能力
            ListLineTrafficCapacityInfo = new List<LineTrafficCapacityInfo>();
            string fileTrafficCapacityInfo = Path.Combine(Application.StartupPath, "LineTrafficCapacity.xlsx");
            FileStream fsTrafficCapacityInfo = new FileStream(fileTrafficCapacityInfo, FileMode.Open, FileAccess.Read);
            IWorkbook workbookTrafficCapacityInfo = new XSSFWorkbook(fsTrafficCapacityInfo);
            ISheet sheetTrafficCapacityInfo = workbookTrafficCapacityInfo.GetSheetAt(0);
            for (int i = 1; i <= sheetTrafficCapacityInfo.LastRowNum; i++)
            {
                for (int j = 1; j < sheetTrafficCapacityInfo.GetRow(i).LastCellNum; j++)
                {
                    LineTrafficCapacityInfo lineTrafficCapacityInfo = new LineTrafficCapacityInfo();
                    lineTrafficCapacityInfo.PointID1 = sheetLineDistance.GetRow(i).Cells[0].ToString();
                    lineTrafficCapacityInfo.PointID2 = sheetLineDistance.GetRow(0).Cells[j].ToString();
                    if (sheetTrafficCapacityInfo.GetRow(i).Cells[j].CellType == CellType.Numeric)
                    {
                        lineTrafficCapacityInfo.Capacity = (int)sheetTrafficCapacityInfo.GetRow(i).Cells[j].NumericCellValue;
                    }
                    else
                    {
                        lineTrafficCapacityInfo.Capacity = 0;
                    }
                    ListLineTrafficCapacityInfo.Add(lineTrafficCapacityInfo);
                }
            }
            #endregion

            #region 初始化路径计算相关数据
            

            Guide.max_ver_num = listNodes.Count;

            path = new int[Guide.max_ver_num];
            dist = new double[Guide.max_ver_num];
            g = new MyGraph();
            

            #region 初始化路径信息
            ETC.InitGragh(ref g, this);
            #endregion

            #endregion

            //MessageBox.Show(ListLineTrafficCapacityInfo.Count.ToString());
        }

        //步骤2：计算不建立ULS时，网络达到平衡配流状态时，输出网络效率、经过各节点的流量和，各边的流量和阻抗值、以及网络总阻抗。
        //网络效率计算方法： 
        // 是指网络路段 的对数， 是指货物运输网络达到平衡时，路段 所分配的物流量，网络路段 存在， ，否则为0。
        //路段阻抗：  
        //其中， 表示路段 的初始阻抗，即物流的自由流时间，且 ， ； 和 分别表示路段 的物流运输距离和运输工具的速度（ULS或者货车，其行驶速度不同）； 其中，在这次程序计算汇总，对于地上物流，每条 ， ，分别为0.15，0.4， 取值为详见附件，为路段的实际通过能力，但是允许路段的实际通行数量大于其实际通行能力（只需最小化目标函数）。对于ULS，每条 ， ，分别为0，即只取自由流时间。
        //网络总阻抗（目标函数）： 
        //同时，输出所有边的流量 ，节点的流量和 。
        private void Step2()
        { }


        //方法1：步骤3：网络重要度排序：（具体做法就是删除每一条线路，看效能值的下降程度，下降程度越大，物流线路越重要，若删除后某OD对的连通中断，其需求自动变为0）
        private void Step3_1()
        { }


        //步骤4：，依次将最重要的线路建立地下物流，即通过构建地下物流，在每一条线路建立后，都要输出网络效率、经过各节点的流量和，各边的流量和阻抗值、以及网络总阻抗。每建立一条线，t的值自动加1，最后，输出网络效率随建立地下物流t的变化曲线。
        private void Step4_1()
        { }

        //方法2：步骤3：随机选择一条路段，首先建立地下物流，然后沿着这条路段，依次建立地下物流。例如，1-2建立地下物流，那么下一条沿着这条路段，为2-8，紧接着为8-D1或8-22。。。。，若路段成环或中断，再随机选择一个未建立地下物流的路段依次进行。每建立一个路段地下物流，t的值自动加1，
        private void Step3_2()
        { }

        //步骤4：依次将最重要的线路建立地下物流，即通过构建地下物流，在每一条线路建立后，都要输出网络效率、经过各节点的流量和，各边的流量和阻抗值、以及网络总阻抗。最后，输出网络效率随建立地下物流t的变化曲线。为了统计分析，需要计算20次。
        private void Step4_2()
        { }

        //方法3：步骤3：随机选择网络中任意两个节点，建立地下物流（不依赖于路段）。例如，1-D1建立地下物流。每建立一个路段地下物流，t的值自动加1，
        private void Step3_3()
        { }

        //步骤4：依次将最重要的线路建立地下物流，即通过构建地下物流，在每一条线路建立后，都要输出网络效率、经过各节点的流量和，各边的流量和阻抗值、以及网络总阻抗。最后，输出网络效率随建立地下物流t的变化曲线。为了统计分析，需要计算20次。（节点的位置间excel数据表）
        private void Step4_3()
        { }

        private void StepNoULS() // 不建立ULS的步骤
        {
            
            //计算网络的直径
            double MaxDij = 0;
            for (int i = 0; i < listNodes.Count; i++)
            {
                int iIndex = ETC.GetIndex(listNodes[i], g);
                Shortest.Dijkstra(g, iIndex, path, dist);
                
                for (int j = 0; j < listNodes.Count; j++)
                {
                    if (i != j)
                    { 
                        
                        int jIndex = ETC.GetIndex(listNodes[j], g);

                        double d = Shortest.GetShortestPath(g, iIndex, jIndex, path, dist);
                        if (d > MaxDij)
                        {
                            MaxDij = d;
                        }
                    }
                }
            }
            MessageBox.Show("网络直径：" + MaxDij);
            //网络均衡（网络总阻抗最小）

            //输出网络边重要度，并相应排序

            //输出网络效率、各节点的流量，各边的流量和阻抗
        }
    }
}