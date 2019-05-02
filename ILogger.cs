using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Log
{
    /// <summary>
    /// Log介面定義
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Info
        /// </summary>
        /// <param name="message">訊息</param>
        void Info(string message);
        /// <summary>
        /// Warn
        /// </summary>
        /// <param name="message">訊息</param>
        void Warn(string message);
        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="message">訊息</param>
        void Debug(string message);
        /// <summary>
        /// Trace
        /// </summary>
        /// <param name="message">訊息</param>
        void Trace(String message);
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message">訊息</param>
        void Error(string message);
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message">訊息</param>
        /// <param name="ex">Exception</param>
        void Error(string message, Exception ex);
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="ex">Exception</param>
        void Error(Exception ex);
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="message">訊息</param>
        void Fatal(string message);
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="message">訊息</param>
        /// <param name="ex">Exception</param>
        void Fatal(string message, Exception ex);
        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="ex">Exception</param>
        void Fatal(Exception ex);

    }
}
