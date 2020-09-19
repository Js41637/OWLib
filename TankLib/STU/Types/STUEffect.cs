// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0xCE1A4D26, "STUEffect")]
    public class STUEffect : STUInstance
    {
        [STUField(0x131257CD, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_49A12335 m_root;
        
        [STUField(0xB64D5A14)]
        public teStructuredDataAssetRef<STUModel> m_previewModel;
        
        [STUField(0x6AD1B882)]
        public teStructuredDataAssetRef<STUModelLook> m_6AD1B882;
        
        [STUField(0x05AA9DFE)]
        public teStructuredDataAssetRef<STUHardPoint> m_05AA9DFE;
        
        [STUField(0xF2C4BBBC)]
        public teStructuredDataAssetRef<STUGenericSettings_Base> m_F2C4BBBC;
        
        [STUField(0xE2B2B673)]
        public byte m_E2B2B673;
        
        [STUField(0xBCC3D95D)]
        public Enum_F588EA94 m_BCC3D95D;
    }
}
