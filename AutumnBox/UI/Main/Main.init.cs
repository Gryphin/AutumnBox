﻿using AutumnBox.Basic;
using AutumnBox.Basic.Devices;
using AutumnBox.Debug;
using AutumnBox.UI;
using AutumnBox.Util;
using System;
using System.Threading;
/*此文件存放本类初始化的代码*/
namespace AutumnBox
{
    public partial class Window1
    {
        Core core = new Core();
        RateBox rateBox;
        string TAG = "MainWindow";
        //现在选取的设备
        private string nowDev { get { return DevicesListBox.SelectedItem.ToString(); } }
        public void CustomInit() {
            InitEvents();//绑定各种事件
            ChangeButtonAndImageByStatus(DeviceStatus.NO_DEVICE);//将所有按钮设置成关闭状态

            Log.d("App Version", StaticData.nowVersion.version);
            webFlashHelper.Navigate(AppDomain.CurrentDomain.BaseDirectory + "HTML/flash_help.htm");
            webSaveDevice.Navigate(AppDomain.CurrentDomain.BaseDirectory + "HTML/save_fucking_device.htm");
            webFlashRecHelp.Navigate(AppDomain.CurrentDomain.BaseDirectory + "HTML/flash_recovery.htm");

            //更新检测器
            UpdateChecker updateChecker = new UpdateChecker();
            updateChecker.UpdateCheckFinish += UpdateChecker_UpdateCheckFinish;
            updateChecker.Check();
            //公告获取器
            NoticeGetter noticeGetter = new NoticeGetter();
            noticeGetter.NoticeGetFinish += NoticeGetter_NoticeGetFinish;
            noticeGetter.Get();

#if DEBUG
            bool isDebug = true;
#else
            bool isDebug = false;
#endif
            //这里其实不用这么麻烦的语法的...但是为了记下这个语法,我还是用一下吧...
            this.labelTitle.Content +=
                isDebug ? "  " + StaticData.nowVersion.version + "-Debug" : "  " + StaticData.nowVersion.version + "-Release";
        }

        
    }
}