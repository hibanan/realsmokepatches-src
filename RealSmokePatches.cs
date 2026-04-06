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
                case "ancienttools":
                    Apply(block, config.EnableAncientTools,
                        config.PitchTorchSmokeProduction, config.PitchTorchTemperature);
                    break;

                case "pandahearth":
                    if (path.Contains("brick"))
                        Apply(block, config.EnablePandaHearthBrick,
                            config.PandaHearthBrickSmokeProduction, config.PandaHearthBrickTemperature);
                    else if (path.Contains("cobble"))
                        Apply(block, config.EnablePandaHearthCobble,
                            config.PandaHearthCobbleSmokeProduction, config.PandaHearthCobbleTemperature);
                    else if (path.Contains("plain"))
                        Apply(block, config.EnablePandaHearthPlain,
                            config.PandaHearthPlainSmokeProduction, config.PandaHearthPlainTemperature);
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
                    if (path.Contains("candelabra1"))
                        Apply(block, config.EnableCandelabra1,
                            config.Candelabra1SmokeProduction, config.Candelabra1Temperature);
                    else if (path.Contains("candelabra2"))
                        Apply(block, config.EnableCandelabra2,
                            config.Candelabra2SmokeProduction, config.Candelabra2Temperature);
                    else if (path.Contains("candelabra3"))
                        Apply(block, config.EnableCandelabra3,
                            config.Candelabra3SmokeProduction, config.Candelabra3Temperature);
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

        // Deduplicate: if another compat mod also patched this block, collapse to one entry
        bool seen = false;
        block.BlockEntityBehaviors = block.BlockEntityBehaviors
            .Where(b => b.Name != BehaviorName || !seen && (seen = true))
            .ToArray();

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
