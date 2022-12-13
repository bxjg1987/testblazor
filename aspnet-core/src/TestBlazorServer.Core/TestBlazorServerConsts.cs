using TestBlazorServer.Debugging;

namespace TestBlazorServer
{
    public class TestBlazorServerConsts
    {
        public const string LocalizationSourceName = "TestBlazorServer";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2b43219a8a124e1ebf969aa48edbdb13";
    }
}
