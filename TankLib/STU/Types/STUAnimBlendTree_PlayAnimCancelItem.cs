// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x38F4E107, "STUAnimBlendTree_PlayAnimCancelItem")]
    public class STUAnimBlendTree_PlayAnimCancelItem : STUInstance
    {
        [STUField(0xB4FF0E2F)]
        public teStructuredDataAssetRef<STUAnimAlias> m_animAlias;
        
        [STUField(0xDB084D42, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimBlendTree_PlayAnimCancelCategory[] m_DB084D42;
        
        [STUField(0x28E3DD84)]
        public Enum_613C4AA2 m_28E3DD84;
    }
}
