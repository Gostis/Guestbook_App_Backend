using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guestbook_App_Backend.Models
{
    public class GuestbookDatabaseSettings : IGuestbookDatabaseSettings
    {
        public string DataBaseName { get; set; }
        public string ConnectionString { get; set; }

        public string UserCollectionName { get; set; }

        public string PostCollectionName { get; set; }

    }

    public interface IGuestbookDatabaseSettings
    {
        string DataBaseName { get; set; }

        string ConnectionString { get; set; }

        string UserCollectionName { get; set; }

        string PostCollectionName { get; set; }

    }
}