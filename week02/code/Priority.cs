public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Checking the base level functions to determine that everything is Enqueing and Dequeing properly
        // Expected Result: The items are Enqueued properly, but the Dequeue returns vibes rather than priorities
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("vibes",1);
        priorityQueue.Enqueue("chill",2);
        priorityQueue.Enqueue("priorities",3);
//
        var testChosenDequeue = priorityQueue.Dequeue();
        Console.WriteLine(testChosenDequeue);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        // Defect(s) Found: Dequeue returned incorrectly (correct hypothesis), easily fixed via indexing

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Testing error return on extra dequeue
        // Expected Result: I expect it to work
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("vibes",1);
        priorityQueue.Enqueue("chill",2);
        priorityQueue.Enqueue("priorities",3);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        var errorCheck =priorityQueue.Dequeue();
        Console.WriteLine(errorCheck);

        // Defect(s) Found: Returned an object that was not an error (items not being removed)

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}