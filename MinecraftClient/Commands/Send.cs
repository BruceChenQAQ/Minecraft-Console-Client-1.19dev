﻿using System.Collections.Generic;

namespace MinecraftClient.Commands
{
    public class Send : Command
    {
        public override string CmdName { get { return "send"; } }
        public override string CmdUsage { get { return "send <text>"; } }
        public override string CmdDesc { get { return Translations.cmd_send_desc; } }

        public override string Run(McClient handler, string command, Dictionary<string, object>? localVars)
        {
            if (HasArg(command))
            {
                handler.SendText(GetArg(command));
                return "";
            }
            else return GetCmdDescTranslated();
        }
    }
}
