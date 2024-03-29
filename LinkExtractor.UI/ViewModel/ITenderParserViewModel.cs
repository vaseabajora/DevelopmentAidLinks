﻿using LinkExtractor.UI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkExtractor.UI.ViewModel
{
    public interface ITenderParserViewModel
    {
        void AddTenders(string html);
        void StartParse();
        void StartLogin();
        void SetupArgs(List<TenderRequestEventArgs> args, int quantity);
        int GetCurrentPage();
    }
}
