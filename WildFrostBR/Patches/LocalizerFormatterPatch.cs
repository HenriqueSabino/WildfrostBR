using HarmonyLib;
using UnityEngine.Localization;

namespace WildFrostBR.Patches
{
    [HarmonyPatch(typeof(LocalizedString), nameof(LocalizedString.GetLocalizedString), typeof(object[]))]
    internal static class LocalizerFormatterPatch
    {
        static void Postfix(ref string __result, object[] arguments) => __result = __result.Format(arguments);
    }
}
