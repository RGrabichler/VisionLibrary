using LibraryVision;
using System;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace LibraryVisionExample
{
    public class Entry
    {
        public static readonly string AmsId = "192.168.1.8.1.1";

        public static LibraryVisionExampleTwinController Plc { get; }

            = new LibraryVisionExampleTwinController(Tc3ConnectorAdapter.Create(AmsId, 852, true));
    }
}
