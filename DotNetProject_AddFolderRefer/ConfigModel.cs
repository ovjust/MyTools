using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetProject_AddFolderRefer
{
    [Serializable]
    public class ConfigModel
    {
        public string Root { set; get; }
        public string DllPaths { set; get; }
    }
}
