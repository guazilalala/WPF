using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Application的生命周期
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 程序运行时
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            System.Windows.Forms.MessageBox.Show("我打开了");
        }

        /// <summary>
        /// 程序关机前调用
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
            System.Windows.Forms.MessageBox.Show("系统关机时调用");
        }

        /// <summary>
        /// 程序关闭前调用
        /// </summary>
        /// <param name="e"></param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            System.Windows.Forms.MessageBox.Show("我离开了");
        }

        /// <summary>
        /// 程序获得焦点
        /// </summary>
        /// <param name="e"></param>
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            System.Windows.Forms.MessageBox.Show("我在焦点");
        }

        /// <summary>
        /// 程序失去焦点
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            System.Windows.Forms.MessageBox.Show("我失去了焦点");

        }
    }
}
