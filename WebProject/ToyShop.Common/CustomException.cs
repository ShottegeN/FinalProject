
namespace ToyShop.Common
{
    public class CustomException : Exception
    {
        public string FieldName { get; }

        // Constructor with message and field name
        public CustomException(string message, string fieldName) : base(message)
        {
            FieldName = fieldName;
        }
    }


}
