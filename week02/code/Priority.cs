public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities and dequeue them.
        // Expected Result: Task 3, Task 1, Task 2
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 2);
        priorityQueue.Enqueue("Task 2", 1);
        priorityQueue.Enqueue("Task 3", 3);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Tasks do not dequeue because remove function not used

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue items with same priorities and dequeue them with FIFO.
        // Expected Result: Dequeue in this order: Task 3, Task 1, Task 2
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 1);
        priorityQueue.Enqueue("Task 2", 1);
        priorityQueue.Enqueue("Task 3", 1);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: Items not dequeuing in order (FIFO) when the priority level is the same

        Console.WriteLine("---------");

         // Test 3
        // Scenario: First item is highest priority, middle two items have same priorities, last has the lowest priority
        // Expected Result: Dequeue in this order: Task 1, Task 2, Task 3, Task 4
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 3);
        priorityQueue.Enqueue("Task 2", 2);
        priorityQueue.Enqueue("Task 3", 2);
        priorityQueue.Enqueue("Task 4", 1);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: Items not dequeuing in order (FIFO) when the priority level is the same

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 4
        // Scenario: Error when queue is empty
        // Expected Result: Error message displayed
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None; 'The queue is empty' is displayed.

        Console.WriteLine("---------");
    }
}