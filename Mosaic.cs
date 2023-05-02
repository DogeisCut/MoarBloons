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
    public class Mosaic : ModBloon
    {
        public override string BaseBloon => BloonType.Ceramic;

        public override IEnumerable<string> DamageStates => new List<string> { "Mosaic1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.speed *= 1.2f;
            bloonModel.speedFrames *= 1.2f;

            bloonModel.overlayClass = BloonOverlayClass.Blue;

            bloonModel.maxHealth = 2;
            bloonModel.leakDamage = 2;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<Pixel>();

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = true;
        }
    }

    public class MosaicRegrow : ModBloon<Mosaic>
    {
        public override bool Regrow => true;

        public override IEnumerable<string> DamageStates => new List<string> { "MosaicRegrow1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.BlueRegrow;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<PixelRegrow>();
            bloonModel.GetBehavior<GrowModel>().overrideChildWithColor = BloonType.Green;
        }
    }

    public class MosaicCamo : ModBloon<Mosaic>
    {
        public override bool Camo => true;

        public override IEnumerable<string> DamageStates => new List<string> { "MosaicCamo1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Blue;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<PixelCamo>();
        }
    }

    public class MosaicCamoRegrow : ModBloon<Mosaic>
    {
        public override bool Regrow => true;
        public override bool Camo => true;

        public override IEnumerable<string> DamageStates => new List<string> { "MosaicCamoRegrow1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.BlueRegrow;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<PixelCamoRegrow>();
            bloonModel.GetBehavior<GrowModel>().overrideChildWithColor = BloonType.Green;
        }
    }

    public class MosaicFortified : ModBloon<Mosaic>
    {
        public override bool Fortified => true;
        public override IEnumerable<string> DamageStates => new List<string> { "MosaicFortified1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Blue;
        }
    }

    public class MosaicRegrowFortified : ModBloon<Mosaic>
    {
        public override bool Regrow => true;
        public override bool Fortified => true;

        public override IEnumerable<string> DamageStates => new List<string> { "MosaicRegrowFortified1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.BlueRegrow;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<PixelRegrow>();
            bloonModel.GetBehavior<GrowModel>().overrideChildWithColor = BloonType.Green;
        }
    }

    public class MosaicCamoFortified : ModBloon<Mosaic>
    {
        public override bool Camo => true;
        public override bool Fortified => true;

        public override IEnumerable<string> DamageStates => new List<string> { "MosaicCamoFortified1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Blue;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<PixelCamo>();
        }
    }

    public class MosaicCamoRegrowFortified : ModBloon<Mosaic>
    {
        public override bool Regrow => true;
        public override bool Camo => true;
        public override bool Fortified => true;

        public override IEnumerable<string> DamageStates => new List<string> { "MosaicCamoRegrowFortified1" };

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.BlueRegrow;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren<PixelCamoRegrow>();
            bloonModel.GetBehavior<GrowModel>().overrideChildWithColor = BloonType.Green;
        }
    }
    //public class MosaicDisplay : ModBloonDisplay<Mosaic>
    //{
    //    public override string BaseDisplay => GetBloonDisplay(BloonType.Ceramic, Damage);

    //    public override string Name => base.Name + "Display" + Damage;

    //    public MosaicDisplay()
    //    {

    //    }

    //    public override int Damage { get; }

    //    public MosaicDisplay(int damage)
    //    {
    //        Damage = damage;
    //    }
    //    public override IEnumerable<ModContent> Load()
    //    {
    //        for (var damage = 0; damage < 2; damage++)
    //        {
    //            yield return new MosaicDisplay(damage);
    //        }
    //    }
    //    public override void ModifyDisplayNode(UnityDisplayNode node)
    //    {
    //        Set2DTexture(node,Name);
    //    }
    //}
}
