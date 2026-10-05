namespace ServiceDLL.Models;

public class ServiceRequest
{
    public string Title
    {
        get => this.title;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormatException(
                    $"Title cannot be empty for a service request. Please define a proper title that is not empty. {value}");
            this.title = value;
        }
    }
    

    #region Private Member

    private string title;

    #endregion
}