// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0xE7BEFDCE, "STUAnimBlendDriverParam")]
    public class STUAnimBlendDriverParam : STUInstance
    {
        [STUField(0xFC9313F1, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_6754CB2C m_FC9313F1;
        
        [STUField(0x00EE3F3C, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_15EF3A7E m_00EE3F3C;
        
        [STUField(0xC62D91EB, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_5861C542 m_source;
        
        [STUField(0x7CDE6A4B)]
        public Enum_E123E435 m_mode;
    }
}
