// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x5C499B8E, "STUAdditionalUnlocks")]
    public class STUAdditionalUnlocks : STUInstance
    {
        [STUField(0xDB803F2F)]
        public teStructuredDataAssetRef<STUUnlock>[] m_unlocks;
        
        [STUField(0x2C01908B)]
        public uint m_level;
    }
}
