namespace RealSmokePatches;

public class RealSmokePatchesConfig
{
    // Ancient Tools - Pitch Torch
    public bool EnableAncientTools { get; set; } = true;
    public int PitchTorchSmokeProduction { get; set; } = 2;
    public int PitchTorchTemperature { get; set; } = 1100;

    // Panda Hearth - Brick
    public bool EnablePandaHearthBrick { get; set; } = true;
    public int PandaHearthBrickSmokeProduction { get; set; } = 4;
    public int PandaHearthBrickTemperature { get; set; } = 700;

    // Panda Hearth - Cobble
    public bool EnablePandaHearthCobble { get; set; } = true;
    public int PandaHearthCobbleSmokeProduction { get; set; } = 4;
    public int PandaHearthCobbleTemperature { get; set; } = 700;

    // Panda Hearth - Plain
    public bool EnablePandaHearthPlain { get; set; } = true;
    public int PandaHearthPlainSmokeProduction { get; set; } = 4;
    public int PandaHearthPlainTemperature { get; set; } = 700;

    // Crucible Furnace
    public bool EnableCrucibleFurnace { get; set; } = true;
    public int CrucibleFurnaceSmokeProduction { get; set; } = 5;
    public int CrucibleFurnaceTemperature { get; set; } = 1300;

    // Brady's Crude Building - Oil Brazier
    public bool EnableBradyCrudeBuilding { get; set; } = true;
    public int OilBrazierSmokeProduction { get; set; } = 3;
    public int OilBrazierTemperature { get; set; } = 800;

    // Expanded Beekeeping - Hive Smoker
    public bool EnableExpandedBeekeeping { get; set; } = true;
    public int HiveSmokerSmokeProduction { get; set; } = 3;
    public int HiveSmokerTemperature { get; set; } = 200;

    // Immersive Lighting - Lamp
    public bool EnableImmersiveLighting { get; set; } = true;
    public int LampSmokeProduction { get; set; } = 1;
    public int LampTemperature { get; set; } = 400;

    // Candlelight - Candelabra 1
    public bool EnableCandelabra1 { get; set; } = true;
    public int Candelabra1SmokeProduction { get; set; } = 1;
    public int Candelabra1Temperature { get; set; } = 200;

    // Candlelight - Candelabra 2
    public bool EnableCandelabra2 { get; set; } = true;
    public int Candelabra2SmokeProduction { get; set; } = 1;
    public int Candelabra2Temperature { get; set; } = 200;

    // Candlelight - Candelabra 3
    public bool EnableCandelabra3 { get; set; } = true;
    public int Candelabra3SmokeProduction { get; set; } = 1;
    public int Candelabra3Temperature { get; set; } = 200;

    // Eternal Stew - Firepit
    public bool EnablePerpetualStew { get; set; } = true;
    public int PerpetualStewFirepitSmokeProduction { get; set; } = 6;
    public int PerpetualStewFirepitTemperature { get; set; } = 900;
}
