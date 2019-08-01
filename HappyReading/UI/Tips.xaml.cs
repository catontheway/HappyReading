﻿using HappyReading.BLL;
using System;
using System.Windows;
using System.Windows.Threading;

namespace HappyReading.UI
{
    /// <summary>
    /// Tips.xaml 的交互逻辑
    /// </summary>
    public partial class Tips : Window
    {
        public Tips(string Value)
        {
            InitializeComponent();

            //赋值提示的文字
            TipsLable.Content = Value;
            Position();
        }


        /// <summary>
        /// 时钟
        /// </summary>
        private DispatcherTimer timer;

        /// <summary>
        /// 初始位置
        /// </summary>
        public void Position()
        {
            //这里根据字符的长度来设置窗体的长度
            this.Width = (Tool.GetStringLength(TipsLable.Content.ToString()) / 2) * 39;
            TipsLable.Width = this.Width;
            //屏幕宽高
            double ScreenWidth = SystemParameters.PrimaryScreenWidth;
            double ScreenHeight = SystemParameters.PrimaryScreenHeight;
            this.Top = ScreenHeight - this.Height - 100;
            this.Left = (ScreenWidth / 2) - (this.Width / 2);
            this.Topmost = true;

            //时钟
            timer = new DispatcherTimer();
            //2秒后自动退出
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        /// <summary>
        /// 时钟事件
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗口初始化
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("OK");
        }
    }
}
