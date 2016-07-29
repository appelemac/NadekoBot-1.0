using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NadekoBot.Models.JSON
{
    /// <summary>
    /// The configuration of the bot
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Whether the bot should join new servers
        /// </summary>
        public bool JoinServers { get; set; }
        /// <summary>
        /// Whether the bot should forward its DMs to the bot owner
        /// </summary>
        public bool ForwardDirectMessages { get; set; }
        /// <summary>
        /// Whether the bot should forward its DMs to all owners. 
        /// </summary>
        public bool ForwardToAllOwners { get; set; }
        /// <summary>
        /// Whether the bot is rotating its status
        /// </summary>
        public bool IsRotatingStatuses { get; set; }
        /// <summary>
        /// The size of the Buffer
        /// </summary>
        public ulong BufferSize { get; set; }
        /// <summary>
        /// The template for remind messages
        /// </summary>
        public string RemindMessageTemplate { get; set; }
        /// <summary>
        /// The prefixes belonging to each module
        /// </summary>
        public Dictionary<string, string> ModulePrefixes { get; set; }
        /// <summary>
        /// Sign and Name of the Currency
        /// </summary>
        public Tuple<string, string> Currency { get; set; }
        /// <summary>
        /// Message to respond with when DMed   
        /// </summary>
        public string DMHelpString { get; set; }
    }
}
