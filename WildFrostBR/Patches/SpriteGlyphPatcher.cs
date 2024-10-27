//using HarmonyLib;
//using TMPro;
//using UnityEngine.Localization.Settings;
//using UnityEngine.TextCore;

//namespace WildFrostBR.Patches
//{
//    [HarmonyPatch(typeof(Glyph), nameof(Glyph.scale), MethodType.Getter)]
//    internal static class SpriteGlyphPatcher
//    {
//        private static float defaultValue = float.NegativeInfinity;

//        static void Postfix(Glyph __instance, ref float __result)
//        {
//            if (!(__instance is TMP_SpriteGlyph))
//            {
//                return;
//            }

//            if (defaultValue == float.NegativeInfinity)
//            {
//                defaultValue = __result;
//            }

//            if (LocalizationSettings.SelectedLocale.Identifier == WildfrostBR.WildfrostBR.ModLanguage)
//            {
//                __instance.scale = 1.5f;
//                __result = 1.5f;
//            }
//            else
//            {
//                // default value
//                __instance.scale = defaultValue;
//                __result = defaultValue;
//            }
//        }
//    }
//}
