using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Knowledge.RelicKnowledge;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppSystem;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    internal class Moar : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Empty;

        public override int DefinedRounds => 100;

        public override string DisplayName => "Moar";

        public override bool CustomHints => true;

        public override void ModifyEasyRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                case 0:
                    roundModel.AddBloonGroup(BloonType.Red, 5, 0, 300);
                    break;
                case 1:
                    roundModel.AddBloonGroup(BloonType.Red, 10, 0, 600);
                    break;
                case 2:
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Red, 10, 300, 600);
                    break;
                case 3:
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 0, 600);
                    break;
                case 4:
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 600);
                    break;
                case 5:
                    roundModel.AddBloonGroup(BloonType.Green, 10, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 600);
                    break;
                case 6:
                    roundModel.AddBloonGroup(BloonType.Green, 40, 0, 333);
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 333, 666);
                    roundModel.AddBloonGroup(BloonType.Red, 40, 666, 999);
                    break;
                case 7:
                    roundModel.AddBloonGroup(BloonType.Green, 100, 0, 600);
                    break;
                case 8:
                    roundModel.AddBloonGroup(BloonType.Blue, 500, 0, 3000);
                    break;
                case 9:
                    roundModel.AddBloonGroup(BloonType.Yellow, 10, 0, 300);
                    roundModel.AddBloonGroup(BloonType.Green, 40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 300, 900);
                    break;
                case 10:
                    roundModel.AddBloonGroup(BloonType.Yellow, 50, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Green, 50, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Blue, 50, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Red, 50, 0, 3000);
                    break;
                case 11:
                    roundModel.AddBloonGroup(BloonType.Yellow, 40, 0, 333);
                    roundModel.AddBloonGroup(BloonType.Green, 40, 333, 666);
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 666, 999);
                    break;
                case 12:
                    roundModel.AddBloonGroup<Pixel>(30, 0, 200);
                    break;
                case 13:
                    roundModel.AddBloonGroup<Pixel>(60, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Yellow, 10, 0, 300);
                    roundModel.AddBloonGroup(BloonType.Green, 40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 300, 900);
                    break;
                case 14:
                    roundModel.AddBloonGroup(BloonType.Red, 150, 0, 1500);
                    roundModel.AddBloonGroup<Pixel>(62, 0, 250);
                    break;
                case 15:
                    roundModel.AddBloonGroup<Mosaic>(30, 0, 200);
                    break;
                case 16:
                    roundModel.AddBloonGroup<Pixel>(30, 0, 200);
                    roundModel.AddBloonGroup<Mosaic>(30, 0, 200);
                    break;
                case 17:
                    roundModel.AddBloonGroup<Pixel>(20, 0, 1000);
                    roundModel.AddBloonGroup<Orange>(20, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Green, 20, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 1000);
                    break;
                case 18:
                    roundModel.AddBloonGroup<Mosaic>(15, 0, 1000);
                    roundModel.AddBloonGroup<Pixel>(15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Pink, 15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Yellow, 15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Green, 15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Blue, 15, 0, 1000);
                    break;
                case 19:
                    roundModel.AddBloonGroup(BloonType.YellowRegrow, 30, 0, 1000);
                    roundModel.AddBloonGroup<Orange>(15, 0, 1300);
                    break;
                case 20:
                    roundModel.AddBloonGroup(BloonType.Black, 6, 0, 300);
                    break;
                case 21:
                    roundModel.AddBloonGroup(BloonType.Pink, 16, 0, 1100);
                    roundModel.AddBloonGroup(BloonType.Yellow, 50, 0, 1000);
                    break;
                case 22:
                    roundModel.AddBloonGroup(BloonType.Black, 6, 0, 300);
                    roundModel.AddBloonGroup(BloonType.White, 6, 25, 300);
                    break;
                case 23:
                    roundModel.AddBloonGroup<Trans>(15, 0, 1300);
                    roundModel.AddBloonGroup<OrangeCamo>(1, 500, 501);
                    break;
                case 24:
                    roundModel.AddBloonGroup<OrangeRegrow>(30, 0, 1300);
                    roundModel.AddBloonGroup(BloonType.Purple, 15, 0, 1300);
                    break;
                case 25:
                    roundModel.AddBloonGroup(BloonType.Zebra, 5, 0, 1306);
                    roundModel.AddBloonGroup(BloonType.Pink, 47, 0, 1300);
                    break;
                case 26:
                    roundModel.AddBloonGroup<Grey>(9, 0, 1306);
                    roundModel.AddBloonGroup<Trans>(48, 0, 1300);                   
                    break;
                case 27:
                    roundModel.AddBloonGroup(BloonType.Lead, 5, 0, 547);
                    break;
                case 28:
                    roundModel.AddBloonGroup<TransRegrow>(36, 0, 1300);
                    roundModel.AddBloonGroup<Grey>(30, 0, 1300);
                    break;
                case 29:
                    roundModel.AddBloonGroup<TransRegrow>(36, 0, 1300);
                    roundModel.AddBloonGroup<Grey>(30, 0, 1300);
                    break;
                case 30:
                    roundModel.AddBloonGroup(BloonType.Lead, 20, 500, 1300);
                    roundModel.AddBloonGroup<GreyRegrow>(40, 0, 1300);
                    break;
                case 31:
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 40, 0, 333);
                    roundModel.AddBloonGroup(BloonType.BlackRegrow, 40, 333, 666);
                    roundModel.AddBloonGroup(BloonType.WhiteRegrow, 40, 666, 999);
                    break;
                case 32:
                    roundModel.AddBloonGroup<PixelCamo>(10, 0, 600);
                    roundModel.AddBloonGroup(BloonType.GreenCamo, 20, 0, 300);
                    roundModel.AddBloonGroup(BloonType.BlueCamo, 40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.RedCamo, 60, 300, 900);
                    break;
                case 33:
                    roundModel.AddBloonGroup<Orange>(150, 0, 1500);
                    roundModel.AddBloonGroup<MosaicCamo>(30, 0, 1500);
                    break;
                case 34:
                    roundModel.AddBloonGroup<OrangeCamo>(10, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Pink, 40, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Zebra, 20, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Rainbow, 8, 700, 1000);
                    break;
                case 35:
                    roundModel.AddBloonGroup<Orange>(130, 0, 1000);
                    roundModel.AddBloonGroup<OrangeCamoRegrow>(20, 0, 1000);
                    break;
                case 36:
                    roundModel.AddBloonGroup<MosaicCamo>(15, 300, 1300);
                    roundModel.AddBloonGroup<GreyCamo>(15, 100, 1100);
                    roundModel.AddBloonGroup(BloonType.Lead, 15, 500, 1500);
                    roundModel.AddBloonGroup(BloonType.Zebra, 15, 200, 1200);
                    roundModel.AddBloonGroup(BloonType.Pink, 25, 400, 1400);
                    roundModel.AddBloonGroup(BloonType.Purple, 25, 0, 1000);
                    break;
                case 37:
                    roundModel.AddBloonGroup(BloonType.Rainbow, 35, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Ceramic, 5, 900, 1000);
                    break;
                case 38:
                    roundModel.AddBloonGroup(BloonType.Ceramic, 19, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Red, 800, 1000, 1000);
                    break;
                case 39:
                    roundModel.AddBloonGroup(BloonType.Moab, 1, 200, 201);
                    roundModel.AddBloonGroup(BloonType.Moab, 1, 800, 801);
                    break;
            }
        }
        public override void ModifyMediumRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                case 40:
                    roundModel.AddBloonGroup<Grey>(40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.Zebra, 60, 300, 900);
                    break;
                case 41:
                    roundModel.AddBloonGroup(BloonType.RainbowRegrow, 15, 0, 500);
                    roundModel.AddBloonGroup(BloonType.RainbowCamo, 15, 250, 500);
                    break;
                case 42:
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 65, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Ceramic, 10, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(1, 1100, 1100);
                    break;
                case 43:
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 32, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Ceramic, 5, 0, 1000);
                    roundModel.AddBloonGroup<Obsidian>(12, 0, 1000);
                    roundModel.AddBloonGroup<GreyCamoRegrow>(25, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(2, 1100, 1100);
                    break;
                case 44:
                    roundModel.AddBloonGroup<OrangeCamoRegrow>(25, 0, 1000);
                    roundModel.AddBloonGroup<Obsidian>(50, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(3, 0, 1000);
                    break;
                case 45:
                    roundModel.AddBloonGroup(BloonType.ZebraRegrow, 42, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 37, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicFortified, 5, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(4, 0, 1000);
                    break;
                case 46:
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 32, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 27, 0, 1000);
                    roundModel.AddBloonGroup<MosaicFortified>(24, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(5, 0, 1000);
                    break;
                case 47:
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 27, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 11, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicRegrowCamo, 7, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(8, 0, 1000);
                    break;
                case 48:
                    roundModel.AddBloonGroup<OrangeCamoRegrow>(48, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 32, 0, 1000);
                    roundModel.AddBloonGroup<MosaicCamoRegrow>(24, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 16, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicRegrowCamo, 12, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(10, 0, 1000);
                    break;
                case 49:
                    roundModel.AddBloonGroup<Lmao>(1, 200, 201);
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 1, 800, 801);
                    break;
                case 50:
                    roundModel.AddBloonGroup(BloonType.Moab, 4, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.ZebraRegrow, 42-5, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 37-5, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicFortified, 10, 0, 1000);
                    break;
                case 51:
                    roundModel.AddBloonGroup(BloonType.Moab, 6, 0, 800);
                    roundModel.AddBloonGroup<ObsidianFortified>(50, 0, 800);
                    break;
                case 52:
                    roundModel.AddBloonGroup(BloonType.Moab, 8, 0, 600);
                    roundModel.AddBloonGroup<ObsidianFortified>(60, 0, 800);
                    break;
                case 53:
                    roundModel.AddBloonGroup(BloonType.Moab, 5, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Moab, 5, 100, 1100);
                    roundModel.AddBloonGroup<ObsidianRegrowFortified>(70, 0, 800); //rbe: 2520 (36 per fortified obsidian)
                    break;
                case 54:
                    roundModel.AddBloonGroup(BloonType.Moab, 6, 0, 1500); // 3696 (616 per moab)
                    roundModel.AddBloonGroup(BloonType.Moab, 6, 200, 1700); // 3696
                    roundModel.AddBloonGroup<ObsidianCamoRegrow>(70, 0, 800); //rbe: 2450 (35 per obsidian)
                    //total rbe: 9842
                    break;
                case 55:
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 8, 0, 600);
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 42 - 5, 0, 600);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 37 - 5, 0, 600);
                    roundModel.AddBloonGroup(BloonType.CeramicFortifiedCamo, 10, 0, 600);
                    break;
                case 56:
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 5, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 5, 100, 1100);
                    roundModel.AddBloonGroup<ObsidianCamoRegrowFortified>(80, 0, 1100);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 200, 0, 1100);
                    break;
                case 57:
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 6, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 6, 100, 1100);
                    roundModel.AddBloonGroup<ObsidianCamoRegrowFortified>(80, 0, 1100);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 250, 0, 1100);
                    break;
                case 58:
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 6, 0, 1500);
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 6, 200, 1700);
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 6, 400, 1900);
                    break;
                case 59: //round 60
                    roundModel.AddBloonGroup(BloonType.Bfb, 1, 200, 201);//rbe: 3164
                    roundModel.AddBloonGroup(BloonType.Bfb, 1, 800, 801);//rbe: 3164
                    roundModel.AddBloonGroup<Lmao>(1, 1500, 1501);
                    //total rbe: 6328
                    break;
            }
        }
        public override void ModifyHardRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                case 60:
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 6, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Moab, 6, 100, 1100);
                    roundModel.AddBloonGroup<Lmao>(3, 0, 1000);
                    break;
                case 61:
                    break;
                case 62:
                    //3 Ceramic and Obsidian rushes
                    roundModel.AddBloonGroup(BloonType.Lead, 70, 0, 2300);

                    roundModel.AddBloonGroup(BloonType.Ceramic, 32, 0, 100);
                    roundModel.AddBloonGroup<Obsidian>(32, 0, 100);

                    roundModel.AddBloonGroup(BloonType.Ceramic, 32, 1200, 1300);
                    roundModel.AddBloonGroup<Obsidian>(32, 1200, 1300);

                    roundModel.AddBloonGroup(BloonType.CeramicFortified, 32, 2200, 2300);
                    roundModel.AddBloonGroup<ObsidianFortified>(32, 2200, 2300);
                    break;
                case 63:
                    break;
                case 64:
                    break;
                case 65:
                    break;
                case 66:
                    break;
                case 67:
                    break;
                case 68:
                    break;
                case 69:
                    break;
                case 70:
                    break;
                case 71:
                    break;
                case 72:
                    break;
                case 73:
                    break;
                case 74:
                    break;
                case 75:
                    break;
                case 76:
                    break;
                case 77:
                    break;
                case 78:
                    break;
                case 79:
                    break;
            }
        }
        public override void ModifyImpoppableRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                case 80:
                    break;
                case 81:
                    break;
                case 82:
                    break;
                case 83:
                    break;
                case 84:
                    break;
                case 85:
                    break;
                case 86:
                    break;
                case 87:
                    break;
                case 88:
                    break;
                case 89:
                    //First Fortified LMAO appearance
                    roundModel.AddBloonGroup(BloonType.LeadCamo, 32, 0, 300);
                    roundModel.AddBloonGroup<MosaicCamo>(32, 0, 300);

                    roundModel.AddBloonGroup(BloonType.Ddt, 1, 800, 801);
                    roundModel.AddBloonGroup<LmaoFortified>(1, 900, 901);
                    break;
                case 90:
                    roundModel.AddBloonGroup<MosaicCamoFortified>(800, 0, 2000);

                    roundModel.AddBloonGroup<Lmao>(3, 1000, 1500);
                    roundModel.AddBloonGroup(BloonType.Bfb, 10, 1000, 1100);

                    roundModel.AddBloonGroup<Cash>(1, 1200, 1201);
                    break;
                case 91:
                    break;
                case 92:
                    break;
                case 93:
                    break;
                case 94:
                    //Round 95 copy
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 500, 0, 1000);
                    roundModel.AddBloonGroup<MosaicCamoRegrow>(250, 250, 1250);
                    //LMAO and Ddt
                    roundModel.AddBloonGroup(BloonType.Ddt, 15, 900, 2000);
                    roundModel.AddBloonGroup<LmaoFortified>(15, 900, 2000);
                    //Moab Final Rush
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 15, 2000, 2600);
                    break;
                case 95:
                    break;
                case 96:
                    break;
                case 97:
                    break;
                case 98:
                    break;
                case 99:
                    roundModel.AddBloonGroup(BloonType.Bad, 1, 200, 201);
                    roundModel.AddBloonGroup(BloonType.Bad, 1, 800, 801);
                    break;
            }
        }
        public override string GetHint(int round)
        {
            switch (round) { 
            
                case 0:
                    return "Err... is this thing on?";
                case 1:
                    return "Well, Hello, I, DogeisCut, has prepared a collection of rounds for you to pop your way through. Enjoy the new custom bloons and see how far you can get! But first, we must start with the basics.";
                case 2:
                    return "That means, a lot of the basic bloons, like reds,";
                case 3:
                    return "and blues.";
                default:
                    return "";
            }
        }
    }
}
