using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: We queue your priorities but with their respective number so that it works
    // Expected Result: High,5
    // Defect(s) Found: 0
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("Low", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result);
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Check which is the country with the largest population in the world
    // Expected Result: Japon
    // Defect(s) Found: 0
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Japon", 10);
        priorityQueue.Enqueue("Brasil", 6);
        priorityQueue.Enqueue("Peru", 3);
        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Japon", result);


        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}