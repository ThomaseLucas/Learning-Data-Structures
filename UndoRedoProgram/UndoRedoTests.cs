namespace UndoRedoProgram;
using NUnit.Framework;

[TestFixture]
public class UndoRedoTests
{
    [Test]
    public void PerformActionTest()
    {
        var manager = new UndoRedoManager();
        manager.PreformAction("Hello World");
        
        // This tests if the stack is being used in the code, ensuring that the user is implementing a stack into this undo/redo simulating program.
        Assert.That(manager.PeekUndoStack(), Is.EqualTo("Hello World"));
    }

    [Test]
    public void UndoTest()
    {
        var manager = new UndoRedoManager();
        manager.PreformAction("Hello World");
        manager.PreformAction("How are you?");
        
        manager.UndoAction();
        
        Assert.That(manager.PeekUndoStack(), Is.EqualTo("Hello World"));
        Assert.That(manager.PeekRedoStack(), Is.EqualTo("How are you?"));
    }

    [Test]
    public void RedoTest()
    {
        var manager = new UndoRedoManager();
        manager.PreformAction("Hello World");
        manager.PreformAction("How are you?");
        manager.PreformAction("Delete all");
        
        manager.UndoAction();
        manager.UndoAction();
        manager.RedoAction();

        Assert.That(manager.PeekRedoStack(), Is.EqualTo("Delete all"));
        Assert.That(manager.PeekUndoStack(), Is.EqualTo("How are you?"));
    }

    [Test]
    public void DocumentTest()
    {
        var manager = new UndoRedoManager();
        manager.PreformAction("Hello World");
        manager.PreformAction("How are you?");
        manager.UndoAction();
        
        Assert.That(manager.Document, Is.EqualTo("[Hello World] "));
    }
}