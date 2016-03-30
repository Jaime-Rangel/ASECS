using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using onvif.services;

namespace ASECS
{
    public class DeviceDescriptionHolder
    {
        public Uri[] Uris;
        public string Address;
        public bool IsInvalidUris;
        public NetworkCredential Account;
        public string Name, Location, DeviceIconUri;
        public Profile[] Profiles;
        public string URL;
    }
}
