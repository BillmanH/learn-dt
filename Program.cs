using Azure.DigitalTwins.Core;
using Azure.Identity;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Azure;

using System;

namespace learn_dt
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digital twin model uploader running");
            string adtInstanceUrl = "https://home-test-twin.api.wcus.digitaltwins.azure.net";
            var credential = new DefaultAzureCredential();
            DigitalTwinsClient client = new DigitalTwinsClient(new Uri(adtInstanceUrl), credential);
            Console.WriteLine($"Service client created – ready to go");
            Console.WriteLine();
            Console.WriteLine($"Upload a model");
            var typeList = new List<string>();
            string dtdl = File.ReadAllText("models/Patron.json");
            typeList.Add(dtdl);
            // Upload the model to the service
            try
            {
                await client.CreateModelsAsync(typeList);
            }
            catch (RequestFailedException rex)
            {
                Console.WriteLine($"Load model: {rex.Status}:{rex.Message}");
            }
            // Read a list of models back from the service
            Console.WriteLine("Models uploaded to the instance:");
            AsyncPageable<DigitalTwinsModelData> modelDataList = client.GetModelsAsync();
            await foreach (DigitalTwinsModelData md in modelDataList)
            {
                Console.WriteLine($"{md.Id}");
            }
        }
    }
}
