// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0xDDD18945, "STUAnimBlendTreeSet_BlendTreeItem")]
    public class STUAnimBlendTreeSet_BlendTreeItem : STUInstance
    {
        [STUField(0x560940DC, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimBlendTree_OnFinished m_onFinished;
        
        [STUField(0xC0214513)]
        public teStructuredDataAssetRef<STUAnimBlendTree> m_C0214513;
        
        [STUField(0x95877FC5)]
        public teStructuredDataAssetRef<ulong> m_95877FC5;
        
        [STUField(0xF6E6D4B1, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_3B150012 m_F6E6D4B1;
        
        [STUField(0x9AD6CC25, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUAnimGameData_Base m_gameData;
        
        [STUField(0xCCB4CD4A)]
        public ulong m_CCB4CD4A;
        
        [STUField(0x274F833F, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_89F8DBB3 m_274F833F;
        
        [STUField(0x384DE14F, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimBlendTreeSet_RetargetParams m_retargetParams;
        
        [STUField(0xE54B9419)]
        public uint m_uniqueID;
    }
}
