using HatSimulator.HatEffects.UnusualLayerEffects;
using HatSimulator.HatEffects;
using System.Collections.Generic;
using Terraria.ModLoader;
using HatSimulator.Content.Items.Hats.Custom;
using HatSimulator.Content.Items.Hats.Halloween;
using HatSimulator.Content.Items.Hats.Series1;
using HatSimulator.Content.Items.Hats.Series2;
using HatSimulator.Content.Items.Hats.Winter;
using HatSimulator.Content.Items.Hats;
using System.IO;
using Terraria;
using HatSimulator.Common.Players;

namespace HatSimulator
{
	public class HatSimulator : Mod
	{
        internal static HatSimulator Instance { get; private set; }

        public HatSimulator()
        {
            Instance = this;
            RollTable.MakeTable();
            UnusualLayer.dust = new List<FauxDust>();
            FauxDust.mod = this;
        }

        public override void Load()
        {
            AbnormalEffect effect = AbnormalEffect.Unknown;

            // Series 1
            AbnormalItem item = new Anger(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/Anger_Head");

            item = new HongKongCone(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/HongKongCone_Head");

            item = new Hotrod(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/Hotrod_Head");

            item = new KillerExclusive(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/KillerExclusive_Head");

            item = new LegendaryLid(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/LegendaryLid_Head");

            item = new OlSnaggletooth(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/OlSnaggletooth_Head");

            item = new PithyProfessional(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/PithyProfessional_Head");

            item = new PyromancerMask(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/PyromancerMask_Head");

            item = new SamurEye(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/SamurEye_Head");

            item = new StainlessPot(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/StainlessPot_Head");

            item = new StoutShako(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/StoutShako_Head");

            item = new TeamCaptain(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series1/TeamCaptain_Head");

            // Series 2
            item = new DeadCone(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/DeadCone_Head");

            item = new FruitShoot(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/FruitShoot_Head");

            item = new FuriousFukaamigasa(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/FuriousFukaamigasa_Head");

            item = new HeroHachimaki(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/HeroHachimaki_Head");

            item = new HotDogger(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/HotDogger_Head");

            item = new JanissaryKetche(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/JanissaryKetche_Head");

            item = new Law(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/Law_Head");

            item = new MediMask(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/MediMask_Head");

            item = new SurgeonStahlhelm(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/SurgeonStahlhelm_Head");

            item = new ToughStuffMuffs(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Series2/ToughStuffMuffs_Head");

            // Winter
            item = new BrassBucket(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/BrassBucket_Head");

            item = new ColdfrontCommander(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/ColdfrontCommander_Head");

            item = new CondorCap(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/CondorCap_Head");

            item = new Globetrotter(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/Globetrotter_Head");

            item = new MightyMitre(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/MightyMitre_Head");

            item = new PatriotPeak(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/PatriotPeak_Head");

            item = new SinnerShade(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/SinnerShade_Head");

            item = new SurgeonShako(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/SurgeonShako_Head");

            item = new TartanTyrolean(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/TartanTyrolean_Head");

            item = new ToySoldier(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Winter/ToySoldier_Head");

            // Halloween
            item = new CroneDome(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/CroneDome_Head");

            item = new Executioner(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/Executioner_Head");

            item = new Hellmet(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/Hellmet_Head");

            item = new InfernalImpaler(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/InfernalImpaler_Head");

            item = new MacabreMask(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/MacabreMask_Head");

            item = new OneWayTicket(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/OneWayTicket_Head");

            item = new SearedSorcerer(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/SearedSorcerer_Head");

            item = new SirPumpkinton(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Halloween/SirPumpkinton_Head");

            // Orignal Hats
            item = new AutonomousOrb(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/AutonomousOrb_Head");

            item = new BloodWarriorMask(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/BloodWarriorMask_Head");

            item = new GuerrillaRebel(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/GuerrillaRebel_Head");

            item = new Headless(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/Headless_Head");

            item = new ImpregnableHelm(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/ImpregnableHelm_Head");

            item = new MedicalMask(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/MedicalMask_Head");

            item = new NinjaHeadband(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/NinjaHeadband_Head");

            item = new OpenMind(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/OpenMind_Head");

            item = new PaperBag(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/PaperBag_Head");

            item = new SkiMask(effect);
            AddContent(item);
            AddEquipTexture(item, EquipType.Head, "HatSimulator/Content/Items/Hats/Custom/SkiMask_Head");
        }

        public override void Unload()
        {
            RollTable.AbnormalRollTable = null;
            UnusualLayer.dust = null;
            FauxDust.mod = null;
            Instance = null;
        }

        private void AddEquipTexture(ModItem item, EquipType type, string texpath)
        {
            EquipLoader.AddEquipTexture(Instance, texpath, type, item);
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            HatSimulatorMessageType msgType = (HatSimulatorMessageType)reader.ReadByte();
            switch (msgType)
            {
                case HatSimulatorMessageType.HatSimulatorPlayerSyncPlayer:
                    byte playernumber = reader.ReadByte();
                    HatSimulatorPlayer modPlayer = Main.player[playernumber].GetModPlayer<HatSimulatorPlayer>();
                    int unboxed = reader.ReadInt32();
                    modPlayer.unboxed = unboxed;
                    // SyncPlayer will be called automatically, so there is no need to forward this data to other clients.
                    break;
                default:
                    Logger.WarnFormat("HatSimulator: Unknown Message type: {0}", msgType);
                    break;
            }
        }

        internal enum HatSimulatorMessageType : byte
        {
            HatSimulatorPlayerSyncPlayer,
        }
    }
}