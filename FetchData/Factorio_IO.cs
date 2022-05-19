namespace Factorio_IO

{
    public static class Factorio_IO
    {
        /**
         * Fetches all the data from the provided link and writes it into a file @C:\[datalocation]\[filename]
         * 
         * Donothing if the file location is occupied.
         */
        public static async Task FetchDataFromUrl(string url, string dataLocation, string filename)
        {
            Console.Write("Fetching Factorio Data... ");

            // Checks if a file already exists at the location.
            // NOTE: This does not check if the data from the file corresponds with the data at the url, this is fine for now.
            string fullFilePath = dataLocation + "/" + filename;
            if (File.Exists(fullFilePath))
            {
                Console.WriteLine("File location already occupied.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage httpResponse = await client.GetAsync(url))
                    {
                        string responseText = await httpResponse.Content.ReadAsStringAsync();
                        File.WriteAllText(fullFilePath, responseText);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.WriteLine("Done.");
        }
    }
}