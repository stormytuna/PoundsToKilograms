using HarmonyLib;
using TMPro;
using UnityEngine;

namespace PoundsToKilograms.Patches;

[HarmonyPatch(typeof(HUDManager))]
public class HUDManagerPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(HUDManager.Update))]
    public static void PoundsToKilograms(TextMeshProUGUI ___weightCounter) {
        if (GameNetworkManager.Instance.localPlayerController.isPlayerDead) {
            return;
        }

        float num2 = Mathf.RoundToInt(Mathf.Clamp(GameNetworkManager.Instance.localPlayerController.carryWeight - 1f, 0f, 100f) * 105f * 0.453592f);
        ___weightCounter.text = $"{num2} kg";
    }
}
