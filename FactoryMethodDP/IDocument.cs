﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP
{
    public interface IDocument
    {
        string GetDocumentTitle();
        string GetDocumentContent();
    }
}
