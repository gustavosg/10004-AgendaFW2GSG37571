using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Util
{
    public class Log: Singleton<Log>
    {
        #region Campos

        LogFile gravaLog = LogFile.GetSingleton();

        #endregion

        public void Info(String message, String user)
        {
            gravaLog.LogWriter(LibraryStrings.Info, message, user);
        }

        public void Error(String message, String user)
        {
            gravaLog.LogWriter(LibraryStrings.Error, message, user);
        }

        public void Debug(String message, String user)
        {
            gravaLog.LogWriter(LibraryStrings.Debug, message, user);
        }
    }
}
