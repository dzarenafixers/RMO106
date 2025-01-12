using Exiled.API.Features;
using InventorySystem.Items;
using System;

namespace RMO106Plugin.Roles
{
    public class RMO106Leader
    {
        public static void Spawn(Player player)
        {
            // تغيير الدور
            player.Role.Set(RoleType.NtfCommander);

            // ضبط الدم
            player.Health = Plugin.Instance.Config.LeaderHealth;

            // تجهيز السلاح
            if (Enum.TryParse(Plugin.Instance.Config.LeaderWeapon, out ItemType weapon))
            {
                player.AddItem(weapon);
            }
            else
            {
                Log.Error($"Invalid weapon type '{Plugin.Instance.Config.LeaderWeapon}' in config!");
            }

            // رسالة للاعب
            player.Broadcast(10, "You have spawned as RMO106 Leader with enhanced health and weapons!");
        }
    }
}