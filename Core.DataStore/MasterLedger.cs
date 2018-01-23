﻿using System.Collections.Generic;
using Core.Common.Entities;

namespace Core.DataStore
{
    /// <summary>
    /// Provide data persistence.  Implementation will be a generic list using Singleton pattern
    /// </summary>
    public class MasterLedger
    {
        private static MasterLedger _instance = null;
        private static readonly object _mutex = new object();
        private List<Transaction> _ledger;

        private MasterLedger(){ }

        public static MasterLedger GetInstance
        {
            get
            {
                lock (_mutex)
                {
                    if (_instance == null)
                    {
                        return new MasterLedger();
                    }
                    else
                    {
                        return _instance;
                    }
                }
            }
        }

        public List<Transaction> Ledger()
        {
            if (_ledger == null)
            {
                return new List<Transaction>();
            }
            else
            {
                return _ledger;
            }
        }
    }
}
