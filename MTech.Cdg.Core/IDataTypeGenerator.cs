﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTech.Cdg.Core
{
    public interface IDataTypeGenerator<T>
    {
        T Generate();
    }
}
