using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Utils;
using MoarBloons.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    /// <summary>
    /// Lethal Military Airship of Oblivion
    /// </summary>
    //place holder model, please figure out custom models and textures
    public class Lmao : ModBloon
    {
        public override string BaseBloon => BloonType.Moab;

        public override string DisplayName => "LMAO";
        public override string DisplayNamePlural => "LMAOs";

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.speed *= 1.2f;
            bloonModel.speedFrames *= 1.2f;

            bloonModel.maxHealth *= 2;
            bloonModel.leakDamage *= 2;
            bloonModel.danger++;
            bloonModel.layerNumber++;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.PurpleRegrow);
            bloonModel.AddToChildren(BloonType.PurpleRegrow);
            bloonModel.AddToChildren(BloonType.ZebraRegrow);
            bloonModel.AddToChildren(BloonType.ZebraRegrow);
            bloonModel.AddToChildren<GreyRegrow>();
            bloonModel.AddToChildren<GreyRegrow>();
            bloonModel.AddToChildren(BloonType.PurpleRegrow);
            bloonModel.AddToChildren(BloonType.PurpleRegrow);
            bloonModel.AddToChildren(BloonType.ZebraRegrow);
            bloonModel.AddToChildren(BloonType.ZebraRegrow);
            bloonModel.AddToChildren<GreyRegrow>();
            bloonModel.AddToChildren<GreyRegrow>();

            bloonModel.bloonProperties = Il2Cpp.BloonProperties.Black | Il2Cpp.BloonProperties.White | Il2Cpp.BloonProperties.Purple;

            bloonModel.ApplyDisplay<LmaoBloon>();
        }
    }

    public class LmaoFortified : ModBloon<Lmao>
    {
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.maxHealth *= 2;
            bloonModel.leakDamage *= 2;

            bloonModel.MakeChildrenFortified();
        }
    }
}
