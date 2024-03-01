using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace PoundsToKilograms;

[BepInPlugin(ModGuid, ModName, ModVersion)]
public class PoundsToKilogramsBase : BaseUnityPlugin
{
    public const string ModGuid = "stormytuna.PoundsToKilograms";
    public const string ModName = "PoundsToKilograms";
    public const string ModVersion = "1.0.0";

    public static readonly ManualLogSource Log = new(ModGuid);

    private readonly Harmony harmony = new(ModGuid);

    private void Awake() {
        Logger.LogInfo($"{ModName} has awoken!");

        harmony.PatchAll();
    }
}
