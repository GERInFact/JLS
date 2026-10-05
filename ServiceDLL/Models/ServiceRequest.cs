namespace ServiceDLL.Models;

public class ServiceRequest
{
    // TODO: 
    // Eingangszeit
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

    public string Description
    {
        get => this._description;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormatException(
                    $"The description of a service request must be set. It cannot be empty text or undefined. Value: {value}");
            this._description = value;
        }
    }

    public ServiceEnums.Priority Priority { get; set; }
    public ServiceEnums.State State { get; set; }
    public DateTime TimeStamp { get; set; }


    #region Private Member

    private string title;
    private string _description;

    #endregion
}