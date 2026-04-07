# Real Smoke Compatibility Patches

Adds [Real Smoke](https://mods.vintagestory.at/realsmoke) physics-based smoke to blocks from a variety of popular mods.

## Patched Mods

| Mod | Block(s) |
|-----|----------|
| [Ancient Tools](https://mods.vintagestory.at/ancienttools) | Pitch Torch |
| [Panda Hearths](https://mods.vintagestory.at/pandahearth) | Hearth (Brick, Cobble, Plain) |
| [Candlelight](https://mods.vintagestory.at/candlelight) | Candelabra (1, 2, 3) |
| [Crucible Furnace](https://mods.vintagestory.at/cruciblefurnace) | Crucible Furnace |
| [Crude Building Elements](https://mods.vintagestory.at/bradycrudebuilding) | Oil Brazier |
| [Expanded Beekeeping](https://mods.vintagestory.at/show/mod/39677) | Hive Smoker |
| [Immersive Lighting](https://mods.vintagestory.at/techyimmersivelighting) | Lamp |
| [Eternal Stew](https://mods.vintagestory.at/eternalstew) | Stove |

- Includes handling for duplicate patches (such as: https://mods.vintagestory.at/realsmokeforancienttools).

## Requirements

- [Real Smoke](https://mods.vintagestory.at/realsmoke)

## ConfigLib Integration

If [ConfigLib](https://mods.vintagestory.at/configlib) is installed, every block gets its own section in the in-game mod configuration menu with the following settings:

- **Enable** — toggle Real Smoke patch for the block
- **Smoke Production** — amount of smoke emitted
- **Temperature** — smoke temperature in degrees, affects how the smoke rises and disperses

Note, you must reload your world for changes to take effect.

## Building from Source

Set the `VINTAGE_STORY` environment variable to your game install path, then:

```
dotnet build -c Release
```
