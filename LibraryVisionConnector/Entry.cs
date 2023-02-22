using System;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace LibraryVision
{
    public class Entry
    {
        public static readonly string AmsId = "192.168.1.8.1.1";

        public static LibraryVisionTwinController Plc { get; }

            = new LibraryVisionTwinController(Tc3ConnectorAdapter.Create(AmsId, 851, true));
    }
}
