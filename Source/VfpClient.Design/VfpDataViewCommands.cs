using System;
using System.ComponentModel.Design;

namespace VfpClient.Design {
    internal static class VfpDataViewCommands {
        public static readonly CommandID GlobalNewQuery = new CommandID(new Guid("501822E1-B5AF-11d0-B4DC-00A0C91506EF"), 13587);
        public static readonly CommandID NewQuery = new CommandID(new Guid("501822E1-B5AF-11d0-B4DC-00A0C91506EF"), 13608);

        public static readonly Guid GuidVfpDataProviderCommandSet = new Guid("0F89050C-B87C-431e-8C36-35FA838372E1");
        public const int CommandIddDeleteTable = 0x01FF;
        public const int CommandIdDeleteView = 0x02FF;
        public const int CommandIdViewProcedure = 0x0300;
        public const int CommandIdDeleteProcedure = 0x03FF;
    }
}