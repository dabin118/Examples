using System;
using System.Linq;

namespace MvcExample.Dependencies
{
    /// <summary>
    /// 实现一个视图的过滤器
    /// Implementation of a simple dependency to inject into a view.
    /// </summary>
    /// <seealso cref="MvcExample.Dependencies.IViewDependency" />
    public class ViewDependency : IViewDependency
    {
        /// <summary>
        /// 得到Guid
        /// Initializes a new instance of the <see cref="BaseDependency"/> class.
        /// </summary>
        public ViewDependency()
        {
            this.InstanceId = Guid.NewGuid();
        }

        /// <summary>
        /// Gets the unique instance ID for the dependency.
        /// </summary>
        /// <value>
        /// A <see cref="System.Guid"/> that indicates the unique ID for the
        /// instance.
        /// </value>
        public Guid InstanceId { get; private set; }
    }
}