
using System;

namespace NuGetInstall {

   public class NuGetApi
    {
        private string _url;

        public enum Version
        {
            V1 = 1,
            V2 = 2,
            V3 = 3,
        }

        public NuGetApi(NuGetApi.Version version)
        {
            switch (version)
            {
                case NuGetApi.Version.V1:
                    _url = "https://www.nuget.org/api/v1/";
                    break;
                case NuGetApi.Version.V2:
                    _url = "https://www.nuget.org/api/v2/";
                    break;
                case NuGetApi.Version.V3:
                    _url = "https://www.nuget.org/api/v2/";
                    break;
                default:
                    throw new Exception("Invalid API version " + version.ToString());
            }
        }
    }
}
