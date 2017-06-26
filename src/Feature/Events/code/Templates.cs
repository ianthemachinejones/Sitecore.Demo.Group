using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feature.Events
{
    public struct Templates
    {
        public struct Event
        {
            public static readonly ID ID = new ID("{A4E0A7C1-02E0-426C-9791-378128258D3B}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{E4ADA13F-0C99-4392-BD56-9FFD43F3EFDA}");
                public static readonly ID Description = new ID("{0831BB3B-7826-4560-9593-A10590F2BB42}");
                public static readonly ID Date = new ID("{CA126E46-4DF1-4EF7-8936-4818FBCBB817}");
                public static readonly ID Venue = new ID("{68ABA7DC-46E1-445B-8B4C-6D7C3B024B11}");
                public static readonly ID VenueAddress = new ID("{998567AC-C4C3-4CFD-838E-DACA65AF1454}");
            }
        }
    }
}