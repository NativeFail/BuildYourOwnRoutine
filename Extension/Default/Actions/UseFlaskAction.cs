﻿using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeRoutine.DefaultBehaviors.Actions;
using TreeRoutine.Menu;
using TreeSharp;

namespace TreeRoutine.Routine.BuildYourOwnRoutine.Extension.Default.Actions
{
    internal class UseFlaskAction : ExtensionAction
    {
        private int flaskIndex { get; set; } = 1;
        private const String flaskIndexString = "flaskIndex";

        public UseFlaskAction(string owner, string name) : base(owner, name)
        {

        }

        public override void Initialise(Dictionary<String, Object> Parameters)
        {
            flaskIndex = Int32.Parse((String)Parameters[flaskIndexString]);
        }

        public override bool CreateConfigurationMenu(ref Dictionary<String, Object> Parameters)
        {
            flaskIndex = ImGuiExtension.IntSlider("Flask Index", flaskIndex, 1, 5);
            Parameters[flaskIndexString] = flaskIndex.ToString();
            return true;
        }

        public override Composite GetComposite(ExtensionParameter profileParameter)
        {
            return new UseHotkeyAction(profileParameter.Plugin.KeyboardHelper, x => profileParameter.Settings.FlaskSettings[flaskIndex - 1].Hotkey);
        }
    }
}