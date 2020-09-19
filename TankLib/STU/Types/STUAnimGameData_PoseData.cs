// Generated by TankLibHelper
using TankLib.Math;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x978A87DE, "STUAnimGameData_PoseData")]
    public class STUAnimGameData_PoseData : STUInstance
    {
        [STUField(0x44B8E377)]
        public teVec3A m_44B8E377;
        
        [STUField(0x0B5E9CF6, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_7C02B6CA m_0B5E9CF6;
        
        [STUField(0x03E0A520)]
        public teVec3A[] m_poseDataVecs;
        
        [STUField(0xD65E1B08, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimGameData_GeoSetFlags[] m_geoSetFlags;
        
        [STUField(0xDB11C2C0)]
        public uint m_animationID;
        
        [STUField(0xE0D91786)]
        public uint m_E0D91786;
        
        [STUField(0x7EEFB57A)]
        public ushort m_flags;
        
        [STUField(0xAE2D8911)]
        public ushort m_index;
        
        [STUField(0x3016B9A1)]
        public ushort m_3016B9A1;
        
        [STUField(0xC1B611DF)]
        public ushort m_C1B611DF;
    }
}
