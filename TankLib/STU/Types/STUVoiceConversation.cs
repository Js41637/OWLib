// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0xA408D74F, "STUVoiceConversation")]
    public class STUVoiceConversation : STUInstance
    {
        [STUField(0x401F5484)]
        public teStructuredDataAssetRef<STUVoiceStimulus> m_stimulus;
        
        [STUField(0xF79D31F9, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUVoiceConversationLine[] m_voiceConversationLine;
        
        [STUField(0x4FF98D41, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUCriteriaContainer m_criteria;
        
        [STUField(0x9CDDC24D)]
        public float m_weight;
        
        [STUField(0x98F0E612)]
        public byte m_98F0E612;
    }
}
