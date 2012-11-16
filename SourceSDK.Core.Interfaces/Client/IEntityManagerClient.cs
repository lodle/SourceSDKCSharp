﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceSDK.Core.Interfaces.Client
{
    public interface IEntityManagerClient
    {
        bool GenerateClientClasses();

        IClientClass[] ClientClasses { get; }
    }
}
