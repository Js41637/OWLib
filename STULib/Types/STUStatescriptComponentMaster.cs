// File auto generated by STUHashTool
using static STULib.Types.Generic.Common;

namespace STULib.Types {
    [STU(0x73BB2F3A)]
    public class STUStatescriptComponentMaster : STUInstance {
        [STUField(0x8B9A461F)]
        public STUGUID m_8B9A461F;  // STU_73BB2F3A

        [STUField(0x04A8896C)]
        public STUGUID m_04A8896C;  // STU_73BB2F3A

        [STUField(0xF29E4995)]
        public StatesciptComponents.STUSubModelReferenceComponent[] SubModels; // why not a component

        [STUField(0x8AF8F4F5)]
        public STUHashMap<StatesciptComponents.STUStatescriptComponent> Components;  // key = instance checksum

        [STUField(0x87916047)]
        public StatesciptComponents.Enums.STUEnum_790E517D m_87916047;
    }
}
