using System;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace Client
{
    public class Client : BaseScript
    {
        public Client()
        {
            SetNotificationTextEntry("STRING");
            AddTextComponentSubstringPlayerName("Example notification");
            DrawNotification(true, true);
        }
    }
}
