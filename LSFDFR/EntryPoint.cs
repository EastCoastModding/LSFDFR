[assembly: Rage.Attributes.Plugin("Los Santos Fire Department First Response", Description = "This is my first plugin.", Author = "Squad 65")]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using System.String;

namespace MyFirstPlugin
{
    public static class EntryPoint
    {
        public static void Main()
        {
            Rage.GameFiber.StartNew(delegate)
        {

                Rage.Game.DisplayHelp("Welcome to LSFD:FR")
            Rage.Game.DisplayNotification("Join the Discord Today")
        });
                    }
    }
}