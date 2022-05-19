namespace Factorio
{
    class Startup
    {
        static string factorioRawDumpURL = @"https://gist.githubusercontent.com/Bilka2/6b8a6a9e4a4ec779573ad703d03c1ae7/raw";
        static string filepath = @"C:\Workspace\Programming\Factorio";
        static string filename = @"RawFactorioDump.txt";

        public static void Main()
        {
            UseDataFetch();
            PruneFactorioDump();
        }

        public static void PruneFactorioDump()
        {

        }

        public static void UseDataFetch()
        {
            Factorio_IO.Factorio_IO.FetchDataFromUrl(factorioRawDumpURL, filepath, filename).GetAwaiter().GetResult();
        }
    }
}