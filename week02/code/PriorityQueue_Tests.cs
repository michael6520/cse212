using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with 4 items where two of them are tied with the highest priority, being cherry and 
    // dragonfruit with a priority of 3, and dequeue it until there's no items left in the list
    // Expected Result: Cherry gets dequeued first, then dragonfruit, then banana, then apple.
    // Defect(s) Found: None (I rewrote the code before making the tests)
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 1);
        priorityQueue.Enqueue("Banana", 2);
        priorityQueue.Enqueue("Cherry", 3);
        priorityQueue.Enqueue("Dragonfruit", 3);

        Assert.AreEqual(priorityQueue.Dequeue(), "Cherry");
        Assert.AreEqual(priorityQueue.Dequeue(), "Dragonfruit");
        Assert.AreEqual(priorityQueue.Dequeue(), "Banana");
        Assert.AreEqual(priorityQueue.Dequeue(), "Apple");
    }

    [TestMethod]
    // Scenario: The queue is empty
    // Expected Result: It throws an error
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}