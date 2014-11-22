﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP;

namespace RP0
{
    class ModuleShowInfo : PartModule
    {
        public override string GetInfo()
        {
            string tmp = "";
            try
            {
                tmp += "Part name: " + part.name;
                tmp += "\nTech Required: " + part.partInfo.TechRequired;
                tmp += "\nEntry Cost: " + part.partInfo.entryCost;
            }
            catch (Exception e)
            {
                Debug.Log("**RP0 error getting info, exception " + e);
            }
            return tmp;
        }
    }
}
