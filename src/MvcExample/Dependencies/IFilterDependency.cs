using System;
using System.Linq;

namespace MvcExample.Dependencies
{
    /// <summary>
    /// 抽象：把一个过滤器抽象出来，过滤器注入到一个Action中
    /// Simple dependency to show injection into an action filter.
    /// </summary>
    public interface IFilterDependency
    {
        /// <summary>
        /// Gets the current date and time as ticks.
        /// </summary>
        /// <value>
        /// An <see cref="System.Int64"/> with the current date and time as ticks.
        /// </value>
        long CurrentTicks { get; }
    }
}