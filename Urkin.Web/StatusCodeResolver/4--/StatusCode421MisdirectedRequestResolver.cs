using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 421 (misdirected request) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode421MisdirectedRequestResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 421 (misdirected request) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 421 (misdirected request)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(421);
        }
    }
}
