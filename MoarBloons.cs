using Harmony;
using MelonLoader;
using BTD_Mod_Helper;
using MoarBloons;
using Il2CppAssets.Scripts.Unity.Display;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Il2CppSystem.IO;
using Il2CppAssets.Scripts.Simulation.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using System;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Simulation.Bloons;

[assembly: MelonInfo(typeof(MoarBloons.MoarBloons), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace MoarBloons;

public class MoarBloons : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<MoarBloons>("MoarBloons loaded!");
    }

    public static Shader? GetOutlineShader()
    {
        var superMonkey = GetVanillaAsset("Assets/Monkeys/DartMonkey/Graphics/SuperMonkey.prefab")?.Cast<GameObject>();
        if (superMonkey == null) return null;
        superMonkey.AddComponent<UnityDisplayNode>();
        var litOutlineShader = superMonkey.GetComponent<UnityDisplayNode>().GetMeshRenderer().material.shader;
        return litOutlineShader;
    }

    public static UnityEngine.Object? GetVanillaAsset(string name)
    {
        foreach (var assetBundle in AssetBundle.GetAllLoadedAssetBundles().ToArray())
        {
            if (assetBundle.Contains(name))
            {
                return assetBundle.LoadAsset(name);
            }
        }
        return null;
    }

    //[HarmonyLib.HarmonyPatch(typeof(SlowModel.SlowMutator), "Mutate")]
    //class SlowBloon_Patch
    //{
    //    [HarmonyLib.HarmonyPrefix]
    //    internal static bool Prefix(Model baseModel, Model model)
    //    {
    //        return false;
    //    }
    //}
}