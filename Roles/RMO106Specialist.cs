using Exiled.API.Features;
using InventorySystem.Items;
using System;
using PlayerRoles;

namespace RMO106Plugin.Roles
{
    public class RMO106Specialist
    {
        public static void Spawn(Player player)
        {
            // تغيير الدور
            player.Role.Set(RoleType.NtfSpecialist);

            // ضبط الدم
            player.Health = Plugin.Instance.Config.SpecialistHealth;

            // تجهيز السلاح
            if (Enum.TryParse(Plugin.Instance.Config.SpecialistWeapon, out ItemType weapon))
            {
                player.AddItem(weapon);
            }
            else
            {
                Log.Error($"Invalid weapon type '{Plugin.Instance.Config.SpecialistWeapon}' in config!");
            }

            // رسالة للاعب
            player.Broadcast(10, "You have spawned as RMO106 Specialist with enhanced health and weapons!");
        }
    }

    public class RoleType
    {
        public static RoleTypeId NtfSpecialist { get; set; }
        public static RoleTypeId NtfCommander { get; set; }
    }
}