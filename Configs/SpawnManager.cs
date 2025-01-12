using Exiled.API.Features;
using System.Collections.Generic;

namespace RMO106Plugin.Configs
{
    public class SpawnManager
    {
        public static void SpawnRMO106(List<Player> players)
        {
            foreach (var player in players)
            {
                // تخصيص الدور لكل لاعب
                if (player.Id % 2 == 0)
                {
                    Roles.RMO106Leader.Spawn(player);
                }
                else
                {
                    Roles.RMO106Specialist.Spawn(player);
                }
            }
        }
    }
}