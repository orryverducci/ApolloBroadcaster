using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    class ServerType
    {
        /// <summary>
        /// Server type name
        /// </summary>
        private string name;

        /// <summary>
        /// Server default port
        /// </summary>
        private int defaultPort;

        /// <summary>
        /// Represents if the server uses mount points
        /// </summary>
        private bool usesMounts;

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
        /// Server type information
        /// </summary>
        /// <param name="serverTypeName">The name of the server type</param>
        /// <param name="serverDefaultPort">The default port for the server</param>
        /// <param name="serverUsesMounts">Boolean representing if the server uses mount points</param>
        public ServerType(string serverTypeName, int serverDefaultPort, bool serverUsesMounts)
        {
            name = serverTypeName;
            defaultPort = serverDefaultPort;
            usesMounts = serverUsesMounts;
        }
    }
}
