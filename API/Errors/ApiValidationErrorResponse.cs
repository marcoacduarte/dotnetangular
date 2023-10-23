namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        //better error handling for validations
        public ApiValidationErrorResponse() : base(400)
        {
            
        }
        public IEnumerable<string> Errors { get; set; }
    }
}