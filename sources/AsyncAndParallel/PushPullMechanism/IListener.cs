namespace PushPullMechanism
{
    public interface IListener
    {
        void FireValueUpdate(int value);
        void FireError(string message);
    }
}
