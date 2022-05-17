namespace Logistics
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbResourceB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMoneyS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMethod3 = new System.Windows.Forms.RadioButton();
            this.rbMethod2 = new System.Windows.Forms.RadioButton();
            this.rbMethod1 = new System.Windows.Forms.RadioButton();
            this.btCompute = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pMap = new System.Windows.Forms.Panel();
            this.cbSetULS = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbSetULS);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(795, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(251, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbMoneyS);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.tbResourceB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(235, 140);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "资源预算";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "15000";
            // 
            // tbResourceB
            // 
            this.tbResourceB.Location = new System.Drawing.Point(101, 65);
            this.tbResourceB.Margin = new System.Windows.Forms.Padding(4);
            this.tbResourceB.Name = "tbResourceB";
            this.tbResourceB.Size = new System.Drawing.Size(99, 25);
            this.tbResourceB.TabIndex = 6;
            this.tbResourceB.Text = "36000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "m/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "公路货车行驶速度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "m/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ULS行驶速度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ULS总里程：";
            // 
            // tbMoneyS
            // 
            this.tbMoneyS.Location = new System.Drawing.Point(101, 31);
            this.tbMoneyS.Margin = new System.Windows.Forms.Padding(4);
            this.tbMoneyS.Name = "tbMoneyS";
            this.tbMoneyS.Size = new System.Drawing.Size(99, 25);
            this.tbMoneyS.TabIndex = 3;
            this.tbMoneyS.Text = "1000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbMethod3);
            this.groupBox2.Controls.Add(this.rbMethod2);
            this.groupBox2.Controls.Add(this.rbMethod1);
            this.groupBox2.Location = new System.Drawing.Point(8, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(235, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "地下物流三种方式";
            // 
            // rbMethod3
            // 
            this.rbMethod3.AutoSize = true;
            this.rbMethod3.Location = new System.Drawing.Point(8, 69);
            this.rbMethod3.Margin = new System.Windows.Forms.Padding(4);
            this.rbMethod3.Name = "rbMethod3";
            this.rbMethod3.Size = new System.Drawing.Size(66, 19);
            this.rbMethod3.TabIndex = 5;
            this.rbMethod3.Text = "方法3";
            this.rbMethod3.UseVisualStyleBackColor = true;
            // 
            // rbMethod2
            // 
            this.rbMethod2.AutoSize = true;
            this.rbMethod2.Location = new System.Drawing.Point(8, 45);
            this.rbMethod2.Margin = new System.Windows.Forms.Padding(4);
            this.rbMethod2.Name = "rbMethod2";
            this.rbMethod2.Size = new System.Drawing.Size(66, 19);
            this.rbMethod2.TabIndex = 4;
            this.rbMethod2.Text = "方法2";
            this.rbMethod2.UseVisualStyleBackColor = true;
            // 
            // rbMethod1
            // 
            this.rbMethod1.AutoSize = true;
            this.rbMethod1.Checked = true;
            this.rbMethod1.Location = new System.Drawing.Point(8, 20);
            this.rbMethod1.Margin = new System.Windows.Forms.Padding(4);
            this.rbMethod1.Name = "rbMethod1";
            this.rbMethod1.Size = new System.Drawing.Size(66, 19);
            this.rbMethod1.TabIndex = 3;
            this.rbMethod1.TabStop = true;
            this.rbMethod1.Text = "方法1";
            this.rbMethod1.UseVisualStyleBackColor = true;
            // 
            // btCompute
            // 
            this.btCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCompute.Location = new System.Drawing.Point(811, 500);
            this.btCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btCompute.Name = "btCompute";
            this.btCompute.Size = new System.Drawing.Size(100, 29);
            this.btCompute.TabIndex = 2;
            this.btCompute.Text = "计算";
            this.btCompute.UseVisualStyleBackColor = true;
            this.btCompute.Click += new System.EventHandler(this.btCompute_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(933, 500);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 29);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "关闭";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pMap
            // 
            this.pMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMap.BackgroundImage = global::Logistics.Properties.Resources.img;
            this.pMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMap.Location = new System.Drawing.Point(-1, 0);
            this.pMap.Margin = new System.Windows.Forms.Padding(4);
            this.pMap.Name = "pMap";
            this.pMap.Size = new System.Drawing.Size(788, 542);
            this.pMap.TabIndex = 0;
            // 
            // cbSetULS
            // 
            this.cbSetULS.AutoSize = true;
            this.cbSetULS.Location = new System.Drawing.Point(13, 28);
            this.cbSetULS.Name = "cbSetULS";
            this.cbSetULS.Size = new System.Drawing.Size(83, 19);
            this.cbSetULS.TabIndex = 2;
            this.cbSetULS.Text = "建立ULS";
            this.cbSetULS.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 544);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pMap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "城市地下物流对城市地上物流网络的影响分析";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCompute;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.RadioButton rbMethod3;
        private System.Windows.Forms.RadioButton rbMethod2;
        private System.Windows.Forms.RadioButton rbMethod1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResourceB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMoneyS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSetULS;
    }
}

