namespace UndoRedoProgram;
public class UndoRedoManager
{
    //This program is designed to simulate a document editor with a redo and undo stack. Just like in Microsoft Word, you are able to press a button
    //(Or call a method) that undoes the last action. Because I didn't have time to design a whole document editor, I made it so we simulate actions with strings instead of actually logging actions
    //This is to show the functionality of a stack, while still keeping a relatively simple solution in the project. Please look at the Stack_Exmaple_Solution.cs file once you have finished to see where 
    //you could have messed up or gotten stuck. 
    private Stack<string> _undoStack = new Stack<string>();
    private Stack<string> _redoStack = new Stack<string>();
    private List<string> _fullHistory = new List<string>();
    public string Document = "";

    public string PeekUndoStack()
    {
        return _undoStack.Peek();
    }

    public string PeekRedoStack()
    {
        return _redoStack.Peek();
    }

    public void PreformAction(string action)
    {
        //TODO: Add logic to push the action preformed onto the undo stack
        _fullHistory.Add($"Performed: {action}");
        _redoStack.Clear();

        Document += $"[{action}] ";
    }

    public void UndoAction()
    {
        if (_undoStack.Count > 0)
        {
            //TODO: Add logic that takes the top element of the undo stack, and places it on the redo stack. 
            var undone = "";
            _fullHistory.Add($"Undid: {undone}");

            string toRemove = $"[{undone}] ";
            if (Document.EndsWith(toRemove))
            {
                Document = Document.Substring(0, Document.Length - toRemove.Length);
            }   
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
        
    }

    public void RedoAction()
    {
        if (_redoStack.Count > 0)
        {
            //TODO: Add logic to redo the action, essentially the inverse of the UndoAction() method.
            var redone = "";
            _fullHistory.Add($"Redid: {redone}");
        
            string toAdd = $"[{redone}] ";
            Document += toAdd;    
        }
        else
        {
            Console.WriteLine("Nothing to redo.");
        }
    }

    public void PrintState()
    {
        Console.WriteLine("Current state:");
        if (_undoStack.Count > 0)
        {
            Console.WriteLine($"- {_undoStack.Peek()}");
        }
        else
            Console.WriteLine("Nothing in the undo stack.");
        
        Console.WriteLine("Full History:");
        foreach (var action in _fullHistory)
        {
            Console.WriteLine($"- {action}");
        }
    }

    public void PrintDocument()
    {
        Console.WriteLine("Document:");
        Console.WriteLine(Document == "" ? "(empty)" : Document);
    }
}