using System.Collections.Generic;

public class CommandInvoker
{
    private Queue<ICommand> _queue = new Queue<ICommand>();

    public void AddCommand(ICommand cmd)
    {
        _queue.Enqueue(cmd);
    }
    public void ExecuteAll()
    {
        while(_queue.Count > 0)
        {
            _queue.Dequeue().Execute();
        }
    }
}
