using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MoarBloons.Displays
{
    internal class LmaoBloon : ModCustomDisplay
    {
        public override string AssetBundleName => "moarbloons";
        public override string PrefabName => "LmaoBloonPrefab";
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            node.GetMeshRenderer().material.shader = MoarBloons.GetOutlineShader();
            node.GetMeshRenderer().SetMainTexture(GetTexture("LmaoStandardDiffuse"));
            node.GetMeshRenderer().SetOutlineColor(Color.cyan);
        }
    }
}
