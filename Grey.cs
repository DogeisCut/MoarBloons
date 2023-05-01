using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Bloons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    public class Grey : ModBloon
    {
        public override string BaseBloon => BloonType.Red;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.speed *= 2.5f;
            bloonModel.speedFrames *= 2.5f;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Black);
            bloonModel.AddToChildren(BloonType.White);

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = true;
        }
    }

    public class GreyRegrow : ModBloon<Grey>
    {
        public override bool Regrow => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
        }
    }

    public class GreyCamo : ModBloon<Grey>
    {
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenCamo();
        }
    }

    public class GreyRegrowCamo : ModBloon<Grey>
    {
        public override bool Regrow => true;
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenCamo();
        }
    }
}
