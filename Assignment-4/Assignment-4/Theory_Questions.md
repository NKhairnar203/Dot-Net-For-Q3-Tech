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
  `int i = 1;
  do
  {
      Console.WriteLine("Iteration: " + i);
      i++;
  } while (i <= 5);
  `

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
  `string[] fruits = { "Apple", "Banana", "Cherry" };

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


# **Section 2: Intermediate Questions**

## **What is an infinite loop? Provide examples using for, while, and do-while.**
Ans: 
  An infinite loop is a loop that never stops because its condition always evaluates to true.
**Example Using for Loop:**
`for (;;)
{
    Console.WriteLine("This is an infinite loop.");
}
`
Explanation: Since there is no condition, the loop runs indefinitely.

**Example Using while Loop:**
`while (true)
{
    Console.WriteLine("This is an infinite loop.");
}
`
Explanation: true is always true, so the loop never exits.

**Example Using do-while Loop:**
`do
{
    Console.WriteLine("This is an infinite loop.");
} while (true);
`
Explanation: The do-while executes once and then checks true, so it keeps running.
- To break an infinite loop, use break, return, or Ctrl+C (in console apps).



## **How does the break statement work inside loops?**
**Ans**
The break statement terminates a loop immediately and exits its execution.
**Example: Breaking Out of a for Loop**
`for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        break;  // Exits the loop when i == 3
    }
    Console.WriteLine("Iteration: " + i);
}`
**Output:**
`Iteration: 1  
Iteration: 2`

The loop stops at 3, and 4,5 are never printed.

**Example: Breaking Out of a while Loop**
`int x = 1;
while (x <= 5)
{
    if (x == 3)
    {
        break;  // Exits the loop
    }
    Console.WriteLine("Value: " + x);
    x++;
}
`
**Output:**
`Value: 1  
Value: 2`



## **What is the role of the continue statement in loops?**
**Ans:**
The `continue` statement skips the current iteration and moves to the next iteration.
**Example: Skipping an Iteration**
`for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;  // Skips printing when i == 3
    }
    Console.WriteLine("Iteration: " + i);
}
`
**Output**
`Iteration: 1  
Iteration: 2  
Iteration: 4  
Iteration: 5 ` 

 The loop skips `3` and continues with `4`.


## **How can you exit multiple nested loops at once?**
**Ans:**
To exit multiple nested loops, use a labeled break statement.
**Example: Using Labeled `break`**
`outerLoop:
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        if (i == 2 && j == 2)
        {
            break outerLoop;  // Exits both loops
        }
        Console.WriteLine($"i={i}, j={j}");
    }
}
`
**Output:**
`i=1, j=1  
i=1, j=2  
i=1, j=3  
i=2, j=1  
`
When `i=2`, `j=2`, the break outerLoop; exits both loops.


## **What is the difference between break and return inside a loop?**
**Ans:**
**break**
- Exits only the loop
- Used inside loops & `switch`
- Execution continues after the loop

**return**
- Exits the entire method
- Used to return a value from a function
- Execution stops immediately

**Example of break:**
`for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        break;  // Exits the loop
    }
    Console.WriteLine(i);
}
Console.WriteLine("Loop finished.");
`
**ouput**
`1  
2  
Loop finished.
`

**Example of return:**
`void TestMethod()
{
    for (int i = 1; i <= 5; i++)
    {
        if (i == 3)
        {
            return;  // Exits the method
        }
        Console.WriteLine(i);
    }
    Console.WriteLine("Loop finished.");
}

TestMethod();
Console.WriteLine("Method finished.");
`
**Output:**
`1  
2  
Method finished.
`
`return;` exits the entire method and does not print `"Loop finished."`


## **How do you iterate through an array using loops?**
**Ans:**
You can use for, while, or foreach to iterate through an array.
**Using `for` Loop**
`int[] arr = { 10, 20, 30, 40 };

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
`
**Using `foreach` Loop**:
`foreach (int num in arr)
{
    Console.WriteLine(num);
}
`


## **Write a C# program to find the largest and smallest number in an array using loops.**
**Ans:**

`
using System;
class Program
{
    static void Main()
    {
        int[] arr = { 10, 25, 8, 36, 45, 2 };

        int min = arr[0];  // Assume first element is the smallest
        int max = arr[0];  // Assume first element is the largest

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];  // Update min if a smaller value is found
            }
            if (arr[i] > max)
            {
                max = arr[i];  // Update max if a larger value is found
            }
        }

        Console.WriteLine("Smallest: " + min);
        Console.WriteLine("Largest: " + max);
    }
}`

**Output**

`
Smallest: 2  
Largest: 45  
`


# Section 3: Advanced Questions
## **Can a for loop run indefinitely? If yes, how?**
**Ans:**
- Yes, a for loop can run indefinitely if its termination condition is always true or missing.
*Example: Infinite for Loop*
`for (;;)
{
    Console.WriteLine("This loop runs forever!");
}`

**Explanation**
- Since there is no condition, the loop never exits unless a break, return, or external event (Ctrl+C) stops it.

*Example: Infinite Loop with Condition Always true*
`for (int i = 0; i >= 0; i++)
{
    Console.WriteLine("Infinite loop: " + i);
}`

**Explanation**
- The condition i >= 0 is always true, so the loop runs indefinitely.


## **How do you implement a loop using recursion instead of traditional looping constructs?**
**Ans:**
- Recursion can replace loops by calling the same function repeatedly with a different argument.
**Example: Printing Numbers Recursively Instead of Using a Loop**
`using System;
class Program
{
    static void PrintNumbers(int n)
    {
        if (n == 0) return; // Base condition to stop recursion

        Console.WriteLine(n);
        PrintNumbers(n - 1); // Recursive call
    }

    static void Main()
    {
        PrintNumbers(5); // Simulates a loop from 5 to 1
    }
}`

*Output*
`5  
4  
3  
2  
1`  


**Explanation**
- Instead of a loop, the function calls itself until n reaches 0, where recursion stops.


## **What is the impact of using goto inside loops? Is it recommended? Explain with an example.**
**Ans:**
- The goto statement allows jumping to a specific label in the code, bypassing normal flow control.

**Example: Using goto to Exit a Loop**
`using System;
class Program
{
    static void Main()
    {
        int i = 1;
        startLoop:
        if (i <= 5)
        {
            Console.WriteLine(i);
            i++;
            goto startLoop; // Jumps back to the label
        }
    }
}`

*Output*

`1  
2  
3  
4  
5 `


**Why is goto not recommended?**

- Makes code harder to read and debug
- Introduces spaghetti code
- Can cause infinite loops if not carefully handled
    - Instead, use loops or recursion whenever possible.



## **How does a *foreach* loop work internally in C#?**
**Ans:**
- A `foreach` loop in C# internally uses an enumerator (`IEnumerator<T>`) to iterate through a collection.

*Explanation*

- **MoveNext()** advances the enumerator to the next element.
- **Current** retrieves the value at the current position.
- **foreach** internally uses this mechanism.



## **Can a *foreach* loop be replaced with a for loop? If yes, in what cases?**
**Ans:**
- Yes, *foreach* can be replaced with for when indexing is needed (e.g., modifying elements).

**Example: When *foreach* CAN be replaced by *for***
`int[] arr = { 1, 2, 3, 4, 5 };

// Using `for` allows modification
for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= 2;
}`


*Best Use Case for for*: When you need index-based access or modification.
*Best Use Case for foreach:* When modification is NOT required, and you just need to iterate.


## **How do you optimize performance in loops when working with large datasets?**
**Ans:**
*Best Practices for Performance Optimization:*
 - Use `for` instead of `foreach` for arrays (faster due to direct indexing).
 - Cache `arr.Length` instead of calling it in each iteration (reduces function calls).
 - Use parallelism (`Parallel.ForEach`) for independent operations.
 - Avoid redundant calculations inside loops.
 - Use StringBuilder instead of string concatenation in loops.

**Example: Optimized Loop (Cache Length & Avoid Redundant Calls)**
`int[] arr = new int[100000];
int len = arr.Length; // Cache length

for (int i = 0; i < len; i++) 
{
    arr[i] = i * 2; // Avoid unnecessary function calls
}`

**Optimization Impact**
 -  Avoids multiple calls to `.Length`, improving performance.



## **What are the best practices for writing efficient loops in C#?**
**Ans:**
- Use for instead of foreach for large datasets (better indexing performance).
- Use StringBuilder for string manipulations in loops.
- Use Parallel.ForEach for independent operations on large datasets.
- Minimize operations inside the loop (e.g., avoid unnecessary calculations).
- Break out of loops early if possible (break, return).

## **How does the *Parallel.ForEach* loop differ from a normal *foreach* loop? Provide an example.**
**Ans:**
- *Parallel.ForEach* executes iterations in parallel, utilizing multiple CPU cores, whereas *foreach* executes sequentially.

**Example: *foreach* vs *Parallel.ForEach***

`using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Normal foreach (sequential execution)
        foreach (var num in numbers)
        {
            Console.WriteLine($"Processing {num} in thread {Task.CurrentId}");
        }

        Console.WriteLine("\nUsing Parallel.ForEach\n");

        // Parallel.ForEach (parallel execution)
        Parallel.ForEach(numbers, num =>
        {
            Console.WriteLine($"Processing {num} in thread {Task.CurrentId}");
        });
    }
}`

**Advantages of `Parallel.ForEach`:**
- Faster processing for large datasets.
- Utilizes multiple CPU cores (better performance).
- Best suited for independent operations (no shared data modifications).

**When NOT to Use `Parallel.ForEach`:**
- When operations depend on the previous iteration’s result.
- When the loop modifies shared resources (causing race conditions).

