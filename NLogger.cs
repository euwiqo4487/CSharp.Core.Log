using CSharp.Core.Common;
using NLog;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CSharp.Core.Log
{
    /// <summary>
    /// 實作log類別,注意!請在CSharp.Core.Log.dll旁,須有 <c>NLog.config</c> 設定檔
    /// </summary>
    public class NLogger : ILogger
    {
        private Logger logger;
        /// <summary>
        /// 建構子
        /// </summary>
        /// <example>
        /// <code language="cs" title="log">
        /// NLogger log = new NLogger("CSharp.Core.LoadBalancing");//log檔的檔名
        /// log.Info("Hello World!!");
        /// </code>
        /// </example>
        /// <param name="name">產生log檔案名稱</param>
        public NLogger(string name)
        {
            Init();
            logger = LogManager.GetLogger(name);
        }
        /// <summary>
        /// 建構子  
        /// </summary>
        public NLogger()
        {
            Init();
            logger = LogManager.GetCurrentClassLogger();
        }

        private void Init()
        {
            if (LogManager.Configuration.Variables.Count == 0 ||
                LogManager.Configuration.Variables["basedir"] == null)
                LogManager.Configuration.Variables["basedir"] = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        #region ILogger 實作
        /// <summary>
        /// Info
        /// </summary>
        /// <param name="message">訊息</param>
        public void Info(string message)
        {
            logger.Info(message);
#if (DEBUG)
            Console.WriteLine(message);
#endif
            Clear();
        }
        /// <summary>
        /// Info
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="args">參數</param>
        public void Info(string format, params object[] args)
        {
            logger.Info(string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args));
#endif
            Clear();
        }
        /// <summary>
        /// Warn
        /// </summary>
        /// <param name="message">訊息</param>
        public void Warn(string message)
        {
            logger.Warn(message);
#if (DEBUG)
            Console.WriteLine(message);
#endif
            Clear();
        }
        /// <summary>
        /// Warn
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="args">參數</param>
        public void Warn(string format, params object[] args)
        {
            logger.Warn(string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args));
#endif
            Clear();
        }
        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="message">訊息</param>
        public void Debug(string message)
        {
            logger.Debug(message);
#if (DEBUG)
            Console.WriteLine(message);
#endif
            Clear();
        }
        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="args">參數</param>
        public void Debug(string format, params object[] args)
        {
            logger.Debug(string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args));
#endif
            Clear();
        }
        /// <summary>
        /// Trace
        /// </summary>
        /// <param name="message">訊息</param>
        public void Trace(string message)
        {
            logger.Trace(message);
#if (DEBUG)
            Console.WriteLine(message);
#endif
            Clear();
        }
        /// <summary>
        /// Trace
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="args">參數</param>
        public void Trace(string format, params object[] args)
        {
            logger.Trace(string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args));
#endif
            Clear();
        }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message">訊息</param>
        public void Error(string message)
        {
            logger.Error(message);
#if (DEBUG)
            Console.WriteLine(message);
#endif
            Clear();
        }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="args">參數</param>
        public void Error(string format, params object[] args)
        {
            logger.Error(string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args));
#endif
            Clear();
        }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message">訊息</param>
        /// <param name="ex">Exception</param>
        public void Error(string message, Exception ex)
        {
            logger.Error(ex, message);
#if (DEBUG)
            Console.WriteLine(message + LogHelper.BuildExceptionMessage(ex));
#endif
            Clear();
        }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="ex">Exception</param>
        /// <param name="args">參數</param>
        public void Error(string format, Exception ex, params object[] args)
        {
            logger.Error(ex, string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args) + LogHelper.BuildExceptionMessage(ex));
#endif
            Clear();
        }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="ex">Exception</param>
        public void Error(Exception ex)
        {
            logger.Error(ex);
            Clear();
        }
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="message">訊息</param>
        public void Fatal(string message)
        {
            logger.Fatal(message);
#if (DEBUG)
            Console.WriteLine(message);
#endif
            Clear();
        }
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="args">參數</param>
        public void Fatal(string format, params object[] args)
        {
            logger.Fatal(string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args));
#endif
            Clear();
        }
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="message">訊息</param>
        /// <param name="ex">Exception</param>
        public void Fatal(string message, Exception ex)
        {
            logger.Fatal(ex, message);
#if (DEBUG)
            Console.WriteLine(message + LogHelper.BuildExceptionMessage(ex));
#endif
            Clear();
        }
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="format">訊息格式</param>
        /// <param name="ex">Exception</param>
        /// <param name="args">參數</param>
        public void Fatal(string format, Exception ex, params object[] args)
        {
            logger.Fatal(ex, string.Format(format, args));
#if (DEBUG)
            Console.WriteLine(string.Format(format, args) + LogHelper.BuildExceptionMessage(ex));
#endif
            Clear();
        }
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="ex">Exception</param>
        public void Fatal(Exception ex)
        {
            logger.Fatal(ex);
            Clear();
        }
        #endregion

        #region Log清理
        static DateTime? ClearDate { get; set; }

        static void Clear()
        {
            if (ClearDate == null || ClearDate != DateTime.Now.Date)
            {
                ClearDate = DateTime.Now.Date;
                string entryPath = Assembly.GetEntryAssembly().Location,
                    logPath = Path.Combine(Path.GetDirectoryName(entryPath), "App_Data", "Logs");

                if (!Directory.Exists(logPath)) return;

                Configuration config = ConfigurationManager.OpenExeConfiguration(entryPath);
                int days = -30;
                if (config != null && config.AppSettings != null && config.AppSettings.Settings != null && config.AppSettings.Settings["KeepLogDays"] != null &&
                    int.TryParse(config.AppSettings.Settings["KeepLogDays"].Value, out days))
                {
                    if (days > 0)
                        days = 0 - days;
                }
                DateTime baseDate = DateTime.Now.AddDays(days);
                Clear(new DirectoryInfo(logPath), baseDate);
            }
        }

        static void Clear(DirectoryInfo aDir, DateTime bDate)
        {
            if (!Directory.Exists(aDir.FullName)) return;

            DirectoryInfo[] dirs = null;
            FileInfo[] files = null;

            try
            {
                dirs = aDir.GetDirectories();
            }
            catch { }

            if (dirs == null) return;

            foreach (DirectoryInfo dir in dirs)
            {
                files = null;
                try
                {
                    files = dir.GetFiles();
                }
                catch { }

                if (files == null) continue;

                foreach (FileInfo file in files)
                {
                    try
                    {
                        if (File.Exists(file.FullName) && file.LastWriteTime <= bDate)
                            file.Delete();
                    }
                    catch { }
                }

                Clear(dir, bDate);

                int dc = -1, fc = -1;
                try
                {
                    dc = dir.GetDirectories().Count();
                    fc = dir.GetFiles().Count();
                }
                catch { }

                if (fc == 0 && dc == 0)
                {
                    try
                    {
                        dir.Delete();
                    }
                    catch { }
                }
            }
        }
        #endregion
    }
}
