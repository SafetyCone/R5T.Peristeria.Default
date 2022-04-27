using System;using R5T.T0064;


namespace R5T.Peristeria.Default
{[ServiceImplementationMarker]
    public class DropboxDirectoryNameConvention : IDropboxDirectoryNameConvention,IServiceImplementation
    {
        public const string DropboxDirectoryName = "Dropbox";


        public string GetDropboxDirectoryName()
        {
            return DropboxDirectoryNameConvention.DropboxDirectoryName;
        }
    }
}
