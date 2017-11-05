using System;
using System.Linq;

namespace MvcExample.Dependencies
{
    /// <summary>
    /// 抽象：把一个过滤器抽象出来，过滤器注入到一个Razor视图中
    /// Simple dependency to show injection into a Razor view.
    /// </summary>
    public interface IViewDependency
    {
        /// <summary>
        /// Gets the unique instance ID for the dependency.
        /// </summary>
        /// <value>
        /// A <see cref="System.Guid"/> that indicates the unique ID for the
        /// instance.
        /// </value>
        Guid InstanceId { get; }
    }
}