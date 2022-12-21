using System.Collections.ObjectModel;
using GothicModComposer.UI.Models;

namespace GothicModComposer.UI.Helpers;

public static class GothicVdfsConfigHelper
{
    public static GothicVdfsConfig DefaultGothicVdfsConfig
            => new()
            {
                Filename = "DK.mod",
                Directories = new ObservableCollection<string>
                {
                    
                    "_work\\Data\\Anims\\_compiled",
                    "_work\\Data\\Meshes\\_compiled",
                    "_work\\Data\\Textures\\_compiled",
                    "_work\\Data\\Scripts\\_compiled",
                    "_work\\Data\\Scripts\\Content\\Cutscene\\OU.bin",
                    "_work\\Data\\Sound\\Speech",
                    "_work\\Data\\Sound\\SFX",
                    "_work\\Data\\Worlds"
                },
                Include = new ObservableCollection<string>(),
                Exclude = new ObservableCollection<string>
                {
                    "_work\\Data\\Worlds\\DK_SUBZENS\\*",
                    "_work\\Data\\Worlds\\VOBTREE\\*",
                    "_work\\Data\\Scripts\\Content\\Cutscene\\OU.csl"
                },
                Comment = "Gothic II - The History of Khorinis (%%D)%%N(C) 2021 SoulFire"
            };
}