﻿namespace VolumeInfo.Native.Win32
{
    using System.Runtime.InteropServices;
    using IO.Storage;

    internal partial class WinIoCtl
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct STORAGE_DEVICE_NUMBER
        {
            public DeviceType DeviceType;
            public int DeviceNumber;
            public int PartitionNumber;
        }
    }
}