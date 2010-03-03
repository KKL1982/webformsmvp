﻿using System;

namespace WebFormsMvp
{
    /// <summary>
    /// A bespoke substitute for the lack of System.Web.Abstractions.TraceContextBase.
    /// Lazy Microsoft.
    /// </summary>
    public interface ITraceContext
    {
        /// <summary>
        /// Writes trace information to the trace log.
        /// </summary>
        /// <param name="source">The object writing the trace message.</param>
        /// <param name="messageCallback">A callback that builds the trace message to write to the log.</param>
        void Write(object source, Func<string> messageCallback);

        /// <summary>
        /// Writes trace information to the trace log.
        /// </summary>
        /// <param name="sourceType">The type of the object writing the trace message.</param>
        /// <param name="messageCallback">A callback that builds the trace message to write to the log.</param>
        void Write(Type sourceType, Func<string> messageCallback);
    }
}