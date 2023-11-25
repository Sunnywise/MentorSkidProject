using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Utilities
{
    [Binding]
    [Obsolete]
    class FileLocations
    {
        public string GetFolderLocation(string folder)
        {
            return Directory.GetParent(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString(), @"..\..\")) + @"\" + folder + @"\";

        }

    }
}
