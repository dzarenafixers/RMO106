using System;
using Exiled.API.Features;

namespace RMO106Plugin
{
    public class Plugin : Plugin<Configs.Config>
    {
        public override string Name => "RMO106Plugin";
        public override string Author => "MONCEF50G";
        public override Version Version => new Version("1.0.0");
        public override Version RequiredExiledVersion => new(9, 3, 0);

        public static Plugin Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            Config.RMO106Specialist.GetType();
            Config.RMO106Leader.GetType();
            EventHandlers.EventHandlers eventHandlers = new EventHandlers.EventHandlers(this);

            Instance = this;
            base.OnEnabled();

            // تسجيل رسالة إذا كان DebugMode مفعلاً
            if (Config.DebugMode)
                Log.Debug("RMO106 Plugin Debug Mode Enabled!");

            Log.Info(Config.WelcomeMessage);
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
            Log.Info("RMO106 Plugin Disabled!");
        }

        private void RegisterEvents()
        {
            EventHandlers.EventHandlers.Register();
        }

        private void UnregisterEvents()
        {
            EventHandlers.EventHandlers.Unregister();
        }
    }
}