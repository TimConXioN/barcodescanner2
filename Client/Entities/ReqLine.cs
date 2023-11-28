namespace BarcodeScanner.Entities
{
    public class ReqLine
    {
        public string number { get; set; }
        public string worksheetTemplateName { get; set; }
        public string journalBatchName { get; set; }
        public string Type { get; set; }
        public decimal quantity { get; set; }
    }
}
