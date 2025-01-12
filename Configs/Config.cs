using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RMO106Plugin.Configs
{
    public class Config : IConfig
    {
        public object RMO106Specialist;
        public object RMO106Leader;

        [Description("Whether or not the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages will be shown")]
        public bool Debug { get; set; } = false;

        [Description("Whether or not to block Chaos Entry Announcements")]
        public bool BlockChaosCassie { get; set; } = true;

        [Description("How many seconds before a spawnwave occurs should it calculate the spawn chance. This value **MUST** be lower than 13")]
        public int SpawnWaveCalculation { get; set; } = 10;
        public string WelcomeMessage { get; set; } = "Welcome to RMO106!";
        public bool DebugMode { get; set; } = false;
        public Configs.SpawnManager SpawnManager { get; set; } = new();

        // تخصيص الدم والأسلحة
        public int LeaderHealth { get; set; } = 200;
        public int SpecialistHealth { get; set; } = 150;

        public string LeaderWeapon { get; set; } = "GunE11SR"; // سلاح القائد
        public string SpecialistWeapon { get; set; } = "GunLogicer"; // سلاح المختص
    }
}