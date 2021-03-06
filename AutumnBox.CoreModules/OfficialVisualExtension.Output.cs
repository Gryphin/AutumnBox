﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/9/19 20:54:58 (UTC +8:00)
** desc： ...
*************************************************/

using AutumnBox.Basic.Calling;
using AutumnBox.Basic.Data;
using AutumnBox.Logging;

namespace AutumnBox.CoreModules
{
    partial class OfficialVisualExtension
    {
        protected string MsgInit => Res("ExtensionIniting");
        protected string MsgWaitingForUser => Res("ExtensionWaitingForUser");
        protected string MsgExitCodeIs => Res("ExtensionExitCodeIs");
        protected string MsgRunning => Res("ExtensionRunning");
        protected string MsgCancelledByUser => Res("ExtensionCancelByUser");
        protected void WriteLineAndSetTip(string msg)
        {
            WriteLine(msg);
            Tip = msg;
        }
        protected virtual void OutputPrinter(OutputReceivedEventArgs e)
        {
            WriteLine(e.Text);
        }
        protected virtual void OutputLogger(OutputReceivedEventArgs e)
        {
            Logger.Info(e.Text);
        }
        protected string PublicRes(string key)
        {
            string result = key;
            App.RunOnUIThread(() =>
            {
                result = App.GetPublicResouce(key)?.ToString() ?? key;
            });
            return result;
        }
        protected void WriteExitCode(int exitCode)
        {
            WriteLine(MsgExitCodeIs + exitCode);
        }
        protected void WriteInitInfo()
        {
            WriteLine(MsgInit);
        }
        protected void WriteWaitingForUser()
        {
            WriteLine(MsgWaitingForUser);
        }
        protected void WriteRunning()
        {
            WriteLine(MsgRunning);
        }
        protected void WriteCommand(IProcessBasedCommand command)
        {
            string msg = string.Format(Res("ExtensionExecutingCommandFmt"), command);
            WriteLine(msg);
        }
    }
}
