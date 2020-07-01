using System.Reflection;
using Harmony;
using UnityEngine;
using MelonLoader;

namespace IndoorCampfires
{
    public class IndoorCampfires : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log("[indoor-campfires] Version " + Assembly.GetExecutingAssembly().GetName().Version);
        }
    }

    [HarmonyPatch(typeof(InputManager), "CanStartFireIndoors")]
    internal class InputManager_CanStartFireIndoors
    {
        public static void Postfix(InputManager __instance, ref bool __result)
        {
            __result = true;
        }
    }
}
