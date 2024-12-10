namespace PizzasHub.Models
{
    public class ErrorViewModel
    {
        public int StatusCode { get; set; }
        public string? ErrorMessage { get; set; }
        public string? RequestId { get; set; }
        public DateTime? Timestamp { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public ErrorViewModel() => Timestamp = DateTime.Now;

        public ErrorViewModel(int statusCode, string errorMessage, string requestId)
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
            RequestId = requestId;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Status: {StatusCode}, Mensagem: {ErrorMessage}, " +
                   $"Requisição: {RequestId}, Hora: {Timestamp}";
        }
    }
}
