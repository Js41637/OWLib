// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x71B08A4C, "STULocalPersistedSettings")]
    public class STULocalPersistedSettings : STUInstance
    {
        [STUField(0x9F827CDD, ReaderType = typeof(InlineInstanceFieldReader))]
        public STULocalPersistedBinding[] m_bindings;
        
        [STUField(0x27315EFA, ReaderType = typeof(InlineInstanceFieldReader))]
        public STULocalPersistedHeroSetting[] m_settings;
        
        [STUField(0xAB634626, ReaderType = typeof(InlineInstanceFieldReader))]
        public STULocalPersistedGameplaySettings m_gameplaySettings;
        
        [STUField(0x464225DD, ReaderType = typeof(InlineInstanceFieldReader))]
        public STULocalPersistedVoiceChatSettings m_voiceChatSettings;
    }
}
