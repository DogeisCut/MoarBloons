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
    public class Obsidian : ModBloon
    {
        public override string BaseBloon => BloonType.Lead;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.bloonProperties = BloonProperties.Purple | BloonProperties.Black | BloonProperties.Lead;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Purple);
            bloonModel.AddToChildren(BloonType.Lead);

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = false;
        }
    }

    public class ObsidianRegrow : ModBloon<Obsidian>
    {
        public override bool Regrow => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
        }
    }

    public class ObsidianCamo : ModBloon<Obsidian>
    {
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenCamo();
        }
    }

    public class ObsidianCamoRegrow : ModBloon<Obsidian>
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

    public class ObsidianFortified : ModBloon<Obsidian>
    {
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenFortified();
        }
    }

    public class ObsidianRegrowFortified : ModBloon<Obsidian>
    {
        public override bool Regrow => true;
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenFortified();
        }
    }

    public class ObsidianCamoFortified : ModBloon<Obsidian>
    {
        public override bool Camo => true;
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenCamo();
            bloonModel.MakeChildrenFortified();
        }
    }

    public class ObsidianCamoRegrowFortified : ModBloon<Obsidian>
    {
        public override bool Regrow => true;
        public override bool Camo => true;
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenCamo();
            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenFortified();
        }
    }
}
