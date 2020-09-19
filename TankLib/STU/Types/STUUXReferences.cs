// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x10764043, "STUUXReferences")]
    public class STUUXReferences : STUInstance
    {
        [STUField(0x213692AE)]
        public teStructuredDataAssetRef<ulong>[] m_resourceDictionaries;
        
        [STUField(0xB1B74816, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUUXResource[] m_resources;
    }
}
