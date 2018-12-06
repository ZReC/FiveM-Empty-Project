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
            AddTextComponentSubstringPlayerName("Hello World!");
            DrawNotification(true, true);
        }
    }
}
