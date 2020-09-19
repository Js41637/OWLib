// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x074EDCB9, "STUGameRulesetSchemaEntry")]
    public class STUGameRulesetSchemaEntry : STUInstance
    {
        [STUField(0xAA76FAD1)]
        public teStructuredDataAssetRef<ulong> m_displayText;
        
        [STUField(0x7DF418A5)]
        public teStructuredDataAssetRef<ulong> m_7DF418A5;
        
        [STUField(0x3E783677)]
        public teStructuredDataAssetRef<STUIdentifier> m_3E783677;
        
        [STUField(0x7E3ED979)]
        public teStructuredDataAssetRef<STUTargetTag>[] m_7E3ED979;
        
        [STUField(0x34993B2E)]
        public teStructuredDataAssetRef<STUTargetTag>[] m_34993B2E;
        
        [STUField(0x07DD813E, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_848957AF m_value;
        
        [STUField(0x65184E78, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_96788737 m_65184E78;
        
        [STUField(0x2C54AEAF)]
        public Enum_F2F62E3D m_category;
        
        [STUField(0x37D4F9CD)]
        public int m_37D4F9CD;
    }
}
