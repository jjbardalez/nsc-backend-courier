namespace Scharff.API.Utils.Models
{
    public class CustomResponse<T>
    {
        public string message { get; set; }
        public T? data { get; set; }
        public List<string> error { get; set; }

        public CustomResponse()
        {
            error = new List<string>();
        }

        public CustomResponse(string message, T data)
        {
            this.message = message;
            this.data = data;
        }
    }
}
