using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    public class ServerType
    {
        /// <summary>
        /// Server type name
        /// </summary>
        private string name;

        /// <summary>
        /// Server protocol
        /// </summary>
        private string protocol;

        /// <summary>
        /// Server default port
        /// </summary>
        private int defaultPort;

        /// <summary>
        /// Represents if the server uses mount points
        /// </summary>
        private bool usesMounts;

        /// <summary>
        /// Represents if the server requires a password
        /// </summary>
        private bool requiresPassword;

        /// <summary>
        /// Server type name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Server protocol
        /// </summary>
        public string Protocol
        {
            get
            {
                return protocol;
            }
        }

        /// <summary>
        /// Server default port
        /// </summary>
        public int DefaultPort
        {
            get
            {
                return defaultPort;
            }
        }

        /// <summary>
        /// Represents if the server uses mount points
        /// </summary>
        public bool UsesMounts
        {
            get
            {
                return usesMounts;
            }
        }

        /// <summary>
        /// Represents if the server requires a password
        /// </summary>
        public bool RequiresPassword
        {
            get
            {
                return requiresPassword;
            }
        }

        /// <summary>
        /// Server type information
        /// </summary>
        /// <param name="serverTypeName">The name of the server type</param>
        /// <param name="serverProtocol">The protocol used by the server</param>
        /// <param name="serverDefaultPort">The default port for the server</param>
        /// <param name="serverUsesMounts">Boolean representing if the server uses mount points</param>
        /// <param name="serverRequiresPassword">Boolean representing if the server requires a password</param>
        public ServerType(string serverTypeName, string serverProtocol, int serverDefaultPort, bool serverUsesMounts, bool serverRequiresPassword)
        {
            name = serverTypeName;
            protocol = serverProtocol;
            defaultPort = serverDefaultPort;
            usesMounts = serverUsesMounts;
            requiresPassword = serverRequiresPassword;
        }
    }
}
