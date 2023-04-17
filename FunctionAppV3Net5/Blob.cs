using System;
using System.IO;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionAppV3Net5
{
    public class Blob
    {
        private readonly ILogger _logger;

        public Blob(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Blob>();
        }

        [Function("Blob")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "AzureWebJobsStorage")] string myBlob, string name)
        {
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {myBlob}");
        }
    }
}
