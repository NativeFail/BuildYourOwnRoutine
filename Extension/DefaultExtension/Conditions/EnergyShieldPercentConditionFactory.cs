﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeRoutine.Routine.BuildYourOwnRoutine.Extension.DefaultExtension.Conditions
{
    internal class EnergyShieldPercentConditionFactory : ExtensionConditionFactory
    {
        public EnergyShieldPercentConditionFactory()
        {
            Owner = "Default";
            Name = "EnergyShieldPercentCondition";
        }

        public override ExtensionCondition GetCondition()
        {
            return new EnergyShieldPercentCondition(Owner, Name);
        }

        public override List<string> GetFilterTypes()
        {
            return new List<string>() { ExtensionComponentFilterType.Player };
        }
    }
}
