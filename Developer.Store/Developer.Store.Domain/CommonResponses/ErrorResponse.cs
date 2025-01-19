namespace Developer.Store.Domain.CommonResponses
{
    public class ErrorResponse
    {
        public string Type { get; set; }
        public string Error { get; set; }
        public string Detail { get; set; }
    }
}
