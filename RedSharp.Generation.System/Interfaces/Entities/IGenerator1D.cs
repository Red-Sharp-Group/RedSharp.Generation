using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedSharp.Sys.Interfaces.Shared;

namespace RedSharp.Generation.Sys.Interfaces.Entities
{
    /// <summary>
    /// General interface for all one dimension generators.
    /// </summary>
    /// <typeparam name="TItem">Type of generated item.</typeparam>
    public interface IGenerator1D<TItem>
    {
        /// <summary>
        /// Generates new set of data.
        /// </summary>
        TItem[] GenerateNext(int length);
    }
}
