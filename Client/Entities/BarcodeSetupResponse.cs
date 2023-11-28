using Newtonsoft.Json;

namespace BarcodeScanner.Entities
{
    public class BarcodeSetupResponse
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        public List<Value> value { get; set; }
    }

    public class Value
    {
        [JsonProperty("@odata.etag")]
        public string odataetag { get; set; }
        public string id { get; set; }
        public string worksheetTemplateName { get; set; }
        public string journalBatchName { get; set; }
    }
}

