// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x456C3C15, "STUGameModeLoadoutOverride")]
    public class STUGameModeLoadoutOverride : STUInstance
    {
        [STUField(0x37AB13D3)]
        public teStructuredDataAssetRef<STUHero> m_hero;
        
        [STUField(0x7B95AB93)]
        public teStructuredDataAssetRef<STULoadout>[] m_loadouts;
    }
}
