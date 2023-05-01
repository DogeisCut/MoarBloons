using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    public class Troll : ModBloon
    {
        public override string BaseBloon => BloonType.Ceramic;

        public override IEnumerable<string> DamageStates => new List<string> { "Troll1", "Troll2", "Troll3" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.speed *= 0.5f;
            bloonModel.speedFrames *= 0.5f;

            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.maxHealth = 4;
            bloonModel.leakDamage = 0;

            bloonModel.RemoveAllChildren();
            for (int i = 0; i < 1000; i++)
            {
                bloonModel.AddToChildren(BloonType.BadFortified);
                bloonModel.AddToChildren(BloonType.DdtFortifiedCamo);
            }

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = false;
        }
    }
}
