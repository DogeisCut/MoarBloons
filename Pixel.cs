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
    public class Pixel : ModBloon
    {
        public override string BaseBloon => BloonType.Green;
        public override IEnumerable<string> DamageStates => new List<string> { "Mosaic0", "Mosaic1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Green;

            bloonModel.speed *= 1.1f;
            bloonModel.speedFrames *= 1.1f;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Red);
            bloonModel.AddToChildren(BloonType.Green);
            bloonModel.AddToChildren(BloonType.Blue);

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = true;
        }
    }

    public class PixelRegrow : ModBloon<Pixel>
    {
        public override bool Regrow => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.GreenRegrow;

            bloonModel.MakeChildrenRegrow();
        }
    }

    public class PixelCamo : ModBloon<Pixel>
    {
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Green;

            bloonModel.MakeChildrenCamo();
        }
    }

    public class PixelRegrowCamo : ModBloon<Pixel>
    {
        public override bool Regrow => true;
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.GreenRegrow;

            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenCamo();
        }
    }
}
