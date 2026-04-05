using System.Linq;
using Newtonsoft.Json.Linq;
using Vintagestory.API.Common;

namespace RealSmokePatches;

public class RealSmokePatchesModSystem : ModSystem
{
    private const string ConfigFile = "realsmokepatches.json";
    private const string BehaviorName = "BlockEntityBehaviorRealSmokeEmitter";

    private RealSmokePatchesConfig config = new();

    public override void Start(ICoreAPI api)
    {
        config = api.LoadModConfig<RealSmokePatchesConfig>(ConfigFile) ?? new RealSmokePatchesConfig();
        api.StoreModConfig(config, ConfigFile);
    }

    public override void AssetsFinalize(ICoreAPI api)
    {
        foreach (var block in api.World.Blocks)
        {
            if (block?.Code == null || block.BlockEntityBehaviors == null) continue;

            string domain = block.Code.Domain;
            string path = block.Code.Path;

            switch (domain)
            {
                case "primitivesurvival":
                    Apply(block, config.EnablePrimitiveSurvival,
                        config.SmokerSmokeProduction, config.SmokerTemperature);
                    break;

                case "pandahearth":
                    Apply(block, config.EnablePandaHearth,
                        config.PandaHearthSmokeProduction, config.PandaHearthTemperature);
                    break;

                case "cruciblefurnace":
                    Apply(block, config.EnableCrucibleFurnace,
                        config.CrucibleFurnaceSmokeProduction, config.CrucibleFurnaceTemperature);
                    break;

                case "bradycrudebuilding":
                    Apply(block, config.EnableBradyCrudeBuilding,
                        config.OilBrazierSmokeProduction, config.OilBrazierTemperature);
                    break;

                case "expandedbeekeeping":
                    Apply(block, config.EnableExpandedBeekeeping,
                        config.HiveSmokerSmokeProduction, config.HiveSmokerTemperature);
                    break;

                case "immersivelighting":
                    Apply(block, config.EnableImmersiveLighting,
                        config.LampSmokeProduction, config.LampTemperature);
                    break;

                case "candlelight":
                    Apply(block, config.EnableCandlelight,
                        config.CandelabraSmokeProduction, config.CandelabraTemperature);
                    break;

                case "perpetualstew":
                    Apply(block, config.EnablePerpetualStew,
                        config.PerpetualStewFirepitSmokeProduction, config.PerpetualStewFirepitTemperature);
                    break;
            }
        }
    }

    private void Apply(Block block, bool enabled, int smokeProduction, int temperature)
    {
        if (!enabled)
        {
            Remove(block);
            return;
        }

        var beh = block.BlockEntityBehaviors.FirstOrDefault(b => b.Name == BehaviorName);
        if (beh?.properties?.Token is JObject obj)
        {
            obj["smokeProduction"] = smokeProduction;
            obj["temperature"] = temperature;
        }
    }

    private static void Remove(Block block)
    {
        block.BlockEntityBehaviors = block.BlockEntityBehaviors
            .Where(b => b.Name != BehaviorName)
            .ToArray();
    }
}
