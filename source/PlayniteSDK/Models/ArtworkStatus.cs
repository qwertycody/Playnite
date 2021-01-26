using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.SDK.Models
{
    /// <summary>
    /// Represents game installation status.
    /// </summary>
    public enum ArtworkStatus
    {
        /// <summary>
        /// Game is installed.
        /// </summary>
        [Description("LOCGameIsMissingArtworkTitle")]
        MissingArtwork = 0,

        /// <summary>
        /// Game is not installed.
        /// </summary>
        [Description("LOCGameIsNotMissingArtworkTitle")]
        NotMissingArtwork = 1
    }
}
