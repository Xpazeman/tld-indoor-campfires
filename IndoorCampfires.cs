using System.Reflection;
using HarmonyLib;
using UnityEngine;
using MelonLoader;
using Il2Cpp;

namespace IndoorCampfires
{
    public class IndoorCampfires : MelonMod
    {
        public override void OnInitializeMelon()
        {
            
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
