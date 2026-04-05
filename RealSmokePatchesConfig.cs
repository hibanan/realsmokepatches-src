namespace RealSmokePatches;

public class RealSmokePatchesConfig
{
    // Primitive Survival - Smoker
    public bool EnablePrimitiveSurvival { get; set; } = true;
    public int SmokerSmokeProduction { get; set; } = 4;
    public int SmokerTemperature { get; set; } = 300;

    // Panda Hearth
    public bool EnablePandaHearth { get; set; } = true;
    public int PandaHearthSmokeProduction { get; set; } = 4;
    public int PandaHearthTemperature { get; set; } = 700;

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

    // Candlelight - Candelabras
    public bool EnableCandlelight { get; set; } = true;
    public int CandelabraSmokeProduction { get; set; } = 1;
    public int CandelabraTemperature { get; set; } = 200;

    // Eternal Stew - Firepit
    public bool EnablePerpetualStew { get; set; } = true;
    public int PerpetualStewFirepitSmokeProduction { get; set; } = 6;
    public int PerpetualStewFirepitTemperature { get; set; } = 900;
}
