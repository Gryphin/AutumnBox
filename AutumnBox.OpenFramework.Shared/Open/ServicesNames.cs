﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/10/31 23:33:53 (UTC +8:00)
** desc： ...
*************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace AutumnBox.OpenFramework.Open
{
    /// <summary>
    /// 开放标准服务的ServiceName
    /// </summary>
    public static class ServicesNames
    {
        /// <summary>
        /// 线程管理器
        /// </summary>
        public const string THREAD_MANAGER = "___thread_manager";
        /// <summary>
        /// 声音管理器服务名
        /// </summary>
        public const string SOUND = "sound_manager";
        /// <summary>
        /// MD5服务器
        /// </summary>
        public const string MD5 = "md5";
        /// <summary>
        /// 资源管理器
        /// </summary>
        public const string RESOURCES = "res";
        /// <summary>
        /// 设备选择器
        /// </summary>
        public const string DEVICE_SELECTOR = "deviceSelector";
        /// <summary>
        /// 该服务提供一些秋之盒封装的与操作系统相关的API
        /// </summary>
        public const string OS = "__os";
    }
}
