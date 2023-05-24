using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Simulation.Bloons.Behaviors;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace MoarBloons
{
    public class Cash : ModBloon
    {
        public override string BaseBloon => BloonType.Red;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Red;

            bloonModel.maxHealth = -100;
            bloonModel.leakDamage = -99;

            AudioSourceReference blah = CreateAudioSourceReference("48e9ef01c64d78a4db3e9c36f2bf6bb9");
            //bloonModel.GetBehavior<PopEffectModel>().displayAssetId = new PrefabReference() { guidRef = "80178409df24b3b479342ed73cffb63d" };
            bloonModel.GetBehavior<PopEffectModel>().soundEffect1Id = blah;
            bloonModel.GetBehavior<PopEffectModel>().soundEffect2Id = blah;
            bloonModel.GetBehavior<PopEffectModel>().soundEffect3Id = blah;
            bloonModel.GetBehavior<PopEffectModel>().soundEffect4Id = blah;

            

            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.speed *= 5f;
            bloonModel.speedFrames *= 5f;

            bloonModel.RemoveAllChildren();
            for (int i = 0; i < 99; i++)
            {
                bloonModel.AddToChildren(BloonType.Red);
            }

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = true;
        }
    }
}
