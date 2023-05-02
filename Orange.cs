using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    //every single bloon is rotated to face up for some reason, making them look squished. :(
    //orange bloon should be immune to acid attacks (glue and alchemist)
    //Should also get faster when glued instead of slowed
    public class Orange : ModBloon
    {
        public override string BaseBloon => BloonType.Red;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Red;

            bloonModel.speed *= 3.8f;
            bloonModel.speedFrames *= 3.8f;

            bloonModel.AddTag("OrangeProperty");

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Pink);
            bloonModel.AddToChildren(BloonType.Pink);

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = true;
        }
    }

    public class OrangeRegrow : ModBloon<Orange>
    {
        public override bool Regrow => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.RedRegrow;

            bloonModel.MakeChildrenRegrow();
        }
    }

    public class OrangeCamo : ModBloon<Orange>
    {
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Red;

            bloonModel.MakeChildrenCamo();
        }
    }

    public class OrangeCamoRegrow : ModBloon<Orange>
    {
        public override bool Regrow => true;
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.RedRegrow;

            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenCamo();
        }
    }
}
