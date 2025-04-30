global using static SaveSavior.Utility;

namespace SaveSavior
{
    public class Main : MelonMod
    {
        public bool isLoaded = false;

        public static string modsPath;

        public override void OnInitializeMelon()
        {
            modsPath = Path.GetFullPath(typeof(MelonMod).Assembly.Location + "/../../../Mods/");
        }
    }
}




