﻿using System;
using System.Collections.Generic;

namespace SimpleServer.Persisters
{
    /// <summary>
    /// Interface for the persister used by server
    /// Because it's created only for demo purposes:
    /// it hasn't delete methods, optimizations methods, and it isn't generic
    /// </summary>
    public interface IPersister
    {
        /// <summary>
        /// Add record to database
        /// </summary>
        /// <param name="record">Pair of name-value</param>
        void AddRecord(Tuple<string, string> record);
        
        /// <summary>
        /// Get all records stored in database
        /// </summary>
        /// <returns>List of all name-value pairs stored in database</returns>
        IEnumerable<Tuple<string,string>> GetAllRecords();
    }
}
