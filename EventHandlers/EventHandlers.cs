using System.Linq;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace RMO106Plugin.EventHandlers
{
    public class EventHandlers(Plugin plugin)
    {
        public static void Register()
        {
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
        }

        public static void Unregister()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
        }

        private static void OnRoundStarted()
        {
            if (Plugin.Instance.Config.DebugMode)
                Log.Debug("Round started! Spawning RMO106 team.");

            var players = Player.List.ToList();
            Configs.SpawnManager.SpawnRMO106(players);
        }
    }
}