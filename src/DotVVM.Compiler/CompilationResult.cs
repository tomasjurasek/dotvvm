﻿using DotVVM.Framework.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotVVM.Compiler
{
    public class CompilationResult
    {
        public Dictionary<string, FileCompilationResult> Files { get; set; } = new Dictionary<string, FileCompilationResult>();
        public DotvvmConfiguration Configuration { get; set; }
    }
}
