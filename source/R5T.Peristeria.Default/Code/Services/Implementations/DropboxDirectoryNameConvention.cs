using System;


namespace R5T.Peristeria.Default
{
    public class DropboxDirectoryNameConvention : IDropboxDirectoryNameConvention
    {
        public const string DropboxDirectoryName = "Dropbox";


        public string GetDropboxDirectoryName()
        {
            return DropboxDirectoryNameConvention.DropboxDirectoryName;
        }
    }
}
