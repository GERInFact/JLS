namespace ServiceDLL;

public static class ServiceEnums
{
    public enum Priority
    {
        Low,
        Normal,
        High,
        Critical
    }

    public enum State
    {
        Todo,
        InProgress,
        Completed,
        Review
    }
}
