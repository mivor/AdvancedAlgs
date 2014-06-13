namespace Algs.Common
{
    public interface ICommand
    {
        int Result { get; set; }
        void Execute();
    }
}