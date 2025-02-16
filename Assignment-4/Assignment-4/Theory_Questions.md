### **Section 1: Basic Questions**


## **What are the different types of loops in C#?**
**Ans:** C# provides four types of loops:
  - for loop – Used when the number of iterations is known.
  - while loop – Used when the number of iterations is not known and depends on a condition.
  - do-while loop – Similar to while but executes at least once before checking the condition.
  - foreach loop – Used to iterate over collections like arrays or lists.

## **Explain the syntax and working of the `for` loop in C#.**
**Ans:** The `for` loop is used when we know the number of times a loop should execute.
    **Syntax:**
      `for(initialization; condition; increment/decrement)
      {
          // Code to be executed
      }`
      **Example:**
      `using System;
      class Program
      {
          static void Main()
          {
              for (int i = 1; i <= 5; i++) 
              {
                  Console.WriteLine("Iteration: " + i);
              }
          }
      }
      `
      Output:
      `Iteration: 1  
      Iteration: 2  
      Iteration: 3  
      Iteration: 4  
      Iteration: 5  `

**How it Works?**
  - Initialization → int i = 1; (Runs once before the loop starts).
  - Condition → i <= 5; (Loop runs while this is true).
  - Increment → i++ (Increases i after each iteration).



## **How does a while loop work?**
**Ans:** The `while` loop runs as long as a condition is `true`.
 ** Syntax:**
    `while (condition)
    {
        // Code to execute
    }
    `
    **Example:**
    `int i = 1;
    while (i <= 5)
    {
        Console.WriteLine("Count: " + i);
        i++;  // Increment the counter
    }`

    **Output**
    `Count: 1  
    Count: 2  
    Count: 3  
    Count: 4  
    Count: 5  `
 

 **How it Works?**
   - It checks the condition (i <= 5).
   - If true, it executes the block.
   - It increments i and checks again.
   - If false, the loop stops.


## **What is the difference between a while loop and a do-while loop?**
**Ans:**
  **while loop**
  - Execution Condition is checked first.
  - Might not execute even once if the condition is false initially.
  - Syntax - `while (condition) { code }`

 **do-while loop**
  - Executes at least once before checking condition.
  - Executes at least once.
  - Syntax - `do { code } while (condition);`

  ### Example of `do-while`:
  ` int i = 1;
    do
    {
        Console.WriteLine("Iteration: " + i);
        i++;
    } while (i <= 5);`

    Even if `i` starts with `10`, the loop will execute at least once.



## **What happens if the loop condition in a while loop is initially false?**
**Ans:** If the condition is false from the start, the while loop will not execute even once.
  **Example:**
    `int x = 10;
    while (x < 5)  // Condition is false
    {
        Console.WriteLine("This won't run.");
    }
    Console.WriteLine("Loop ended.");
    `
    
  **Output:**
  `Loop ended.`

  The loop body is skipped entirely.


## **How do you use a foreach loop in C#?**
**Ans:** The foreach loop is used to iterate over collections like arrays or lists without using an index.
  **Syntax:**
  `foreach (datatype item in collection)
    {
        // Code to execute
    }
    `

  **Example:**
  ` string[] fruits = { "Apple", "Banana", "Cherry" };

    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
    `

   **Output:**
   `Apple  
    Banana  
    Cherry  `

  **How it Works?**
  - Each item from the collection is accessed one by one.
  - The loop automatically stops when the collection ends.



## **Can we modify elements inside a foreach loop? Why or why not?**
**Ans:** No, we cannot modify elements inside a foreach loop because the loop iterates over elements as read-only.
**Example:**
  `int[] numbers = { 1, 2, 3 };

  foreach (int num in numbers)
  {
      num = num * 2;  // Compilation Error
  }
  `

  Error: foreach iteration variable num cannot be assigned to.
  Solution: Use a for loop instead.

  `for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * 2;  // Works fine
    }
    `
