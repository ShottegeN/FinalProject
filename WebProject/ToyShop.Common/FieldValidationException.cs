
namespace ToyShop.Common
{
    public class FieldValidationException : Exception
    {
        public string FieldName { get; }

        // Constructor with message and field name
        public FieldValidationException(string message, string fieldName) : base(message)
        {
            FieldName = fieldName;
        }
    }


}
