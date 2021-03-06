﻿namespace RJCP.IO.Storage
{
    using System;

    /// <summary>
    /// An enumeration detailing how a GUID for the device is generated.
    /// </summary>
    [Flags]
    public enum DeviceGuidFlags
    {
        /// <summary>
        /// There is no specific source for the GUID. The GUID itself might be <see cref="Guid.Empty"/> which then there
        /// is no GUID.
        /// </summary>
        None = 0,

        /// <summary>
        /// Two devices have the same resource GUID in hardware. To avoid conflicts, this indicates that the GUID
        /// generated is random. Remove the conflict in the system to generate the true GUID.
        /// </summary>
        RandomDeviceGuidReasonConflict = 1,

        /// <summary>
        /// There is no unique information available from the device to generate a GUID.
        /// </summary>
        RandomDeviceGuidReasonNoHwId = 2,

        /// <summary>
        /// The GUID is uniquely generated by a SCSI VPD description, page 83h.
        /// </summary>
        Page83DeviceGuid = 4
    }
}
