namespace PushPullMechanism
{
    public interface IListener
    {
        void FireValueUpdate(string location);
        void FireError(string message);
    }
}
