#define SKIP
#if !SKIP

using ModSettings;

namespace Template
{
    internal static class Settings
    {
        public static void OnLoad()
        {
            Settings.options = new TemplateSettings();
            Settings.options.AddToModSettings("Template Settings");
        }

        public static TemplateSettings options;
    }

    internal class TemplateSettings : JsonModSettings
    {
        [Section("Template")]

        [Name("Template")]
        [Description("")]
        public bool boolOption = false;


        protected override void OnConfirm()
        {
            base.OnConfirm();
        }
    }
}
#endif