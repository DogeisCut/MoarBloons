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
    public class Trans : ModBloon
    {
        public override string BaseBloon => BloonType.Red;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.speed *= 3f;
            bloonModel.speedFrames *= 3f;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Blue);
            bloonModel.AddToChildren(BloonType.Pink);
            bloonModel.AddToChildren(BloonType.White);
            bloonModel.AddToChildren(BloonType.White);
            bloonModel.AddToChildren(BloonType.Pink);
            bloonModel.AddToChildren(BloonType.Blue);

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = true;
        }
    }

    public class TransRegrow : ModBloon<Trans>
    {
        public override bool Regrow => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
        }
    }

    public class TransCamo : ModBloon<Trans>
    {
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenCamo();
        }
    }

    public class TransRegrowCamo : ModBloon<Trans>
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
