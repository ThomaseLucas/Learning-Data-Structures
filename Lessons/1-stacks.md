# Stack

![Image of a stack in action](images/stack.png)

A stack is a **LIFO (Last In First Out)** or **FILO (First In Last Out)** data structure. This simply means that the last piece of data put into the structure will be the first to come out when the correct method is called, or vice versa. Stacks are used everywhere in computers, you probably use them everyday. Some very simple examples include your browser history, or even the undo button. Thanks to this lesson, you will be able to learn how they work, and where to use them in your code.

A stack behaves like a pile of books- _pushing_ adds a book on the top of the stack, and _popping_ takes the top book off. To effectively use this data structure, it is imperative to learn where you would use a stack, and why its important to have it in your kit as a developer.

![Image of a stack of books](images/bookstack.jpg)

## 1.0 The purpose of a stack

The main reason a stack is used in programming is to keep data organized in a specific order. One common example is handling multiple function calls or recursion, which is **when a function calls itself**. Many compilers rely on stacks to manage function execution as well.

> "Stacks are a simple and easy-to-understand data structure, making them suitable for a wide range of applications" (Geeks for Geeks, 2024).

### 1.1 Why would I use a stack?
A stack gives exact control over order and sequence when it comes to data. Unlike an array, where acces can be from any point, a stack makes sure you are always dealing with the most recent item first. 

Stacks give a tool to developers to easily keep track of an order, whether it be function calls, or return addresses, because of a stack, developers don't have to deal with finding which index that adress went to. Instead, they can just use a stack to keep track of what goes next in the order of calling. 

With stacks simplicity, they are easy to use, but they are the key to some higher-level solutions such as recursion, parsing, and tracking state. 
### 1.2 Where would I use a stack?

Although it is hard to say where exactly to use stacks, there are plenty of examples that show us where stacks have been used in software, such as: 

- Undo/Redo within text editors
- Reversing data strings
- Recursive algorithms
- Web browser history

Obviously, there are many more examples that you can find in different software, these are the most common when it comes to developing well-structured projects and programs. 
## 2.0 Pros and Cons of a stack

As previously mentioned, a stack has many advantages compared to other data structures, to be able to effectively use a stack you must understand where it is good to be used and where it shouldn't be used. This section will help clarify the advantages and disadvantages of a stack. This will help you to know where to use them in your code.

### 2.1 Advantages

- **Not easily corrupted**: Because of its restricted access pattern and simple structure, a stack is a secure and reliable structure. The less complex it is, the harder it is to mess something up within it.


- **Efficient management of data**: The management of data within this structure is very straightforward, as only the top element can be accessed.


- **Function-call management**: A stack is used with recursive or multiple function calls, as there are local variables that exist, they are put onto the stack to be taken off after the compiler returns to the original function.

### 2.2 Disadvantages

- **Memory size limited**: Since a stack's structure is so simple, it does not have dynamic memory, so there is a limit to how much memory can be used for a stack.


- **Stack overflow**: This occurs because of the limited data disadvantage. It is when too many elements are added onto the stack, and it cannot hold anymore. This happens a lot in recursion, because the stack runs out of memory to store each function call.


- **Incapable of doing a search**: You cannot find an element in the middle of stack, you have to pop() until you find the one that you are looking for.


- **Random access**: In a stack, you cannot perform random accessing.

## 3.0 The syntax of a stack

When coding in C#, there are many different methods associated with a stack. This lesson will go over the most commonly used methods, and explain how they work, along with their time complexity in regards to big O notation.

These are the 5 most commonly used methods in C# when using a stack:

1. Push()
1. Pop()
1. Peek()
1. Count
1. Contains()

### 3.1 Stack Initialization

Creating a new stack object is fairly straight forward:

```csharp
Stack<int> stack = new Stack<int>();
```

This will initialize a new stack called _"stack"_.

Complexity: O(1)

### 3.2 Using Push()

With stacks, you can use the method push(), to add an element to the top of a stack. This syntax is very simple:

```csharp
stack.Push("first element!");
//you can add another like this:
stack.Push("second element!");
```

Complexity: O(1)

### 3.3 Using Pop()

As a method, pop() removes the top element from the stack. It is used like this:

```csharp
stack.Pop();
```

This can be used to simply take an element off the stack, or even be put into a variable like this:

```csharp
var top_element = stack.Pop();
```

Complexity: O(1)

### 3.4 Using Peek()

Peek() is used to only "look" at the top element in a stack. This returns the top element without removing it from the stack. It looks like this:

```csharp
var peeked_element = stack.Peek();
```

### 3.5 Using Count

This returns the "height" or amount of elements within a given stack (how many books are stacked on top of one another). This returns an integer, so you could use it in many different ways. Count is actually just a variable within the object, specifically made to count how many elements are in a stack, hence why the complexity is O(1), you're just getting a variable. It looks like this:

```csharp
int size_of_stack = stack.Count;
```

Complexity: O(1)

### 3.6 Using Contains()

Conatains checks if a stack contains the specified element. This returns a boolean if it does or doesn't contain that element. This is the syntax:

```csharp
bool exists = stack.Contains();
//This could be used in an if statement like this:
if (stack.Contains("first element!")){
    //random code
};
```

### 3.7 Overview

| Method     | Description                                                            | Time Complexity |
| ---------- | ---------------------------------------------------------------------- | --------------- |
| Push()     | Adds a specified element to the top of a stack.                        | O(1)            |
| Pop()      | Removes an element from the top of a stack.                            | O(1)            |
| Peek()     | Returns the top element without removing it from the stack             | O(1)            |
| Count      | Returns the number of elements within a stack _integer_                | O(1)            |
| Contains() | Returns true or false based on if the stack contains a specified value | O(n)            |

## 4.0 Problem to solve: Undo Redo Simulation

Problem to solve: [Undo_Redo_Program](../UndoRedoProgram/Stack_Example.cs)

See the solution: [Undo_Redo_Solution](../UndoRedoProgram/Stack_Example_Solution.cs)

[Back to welcome page](0-welcome.md)

## Sources

- [AplusTopper](https://www.aplustopper.com/advantages-and-disadvantages-of-stack/)

- [Geeks for Geeks](https://geeksforgeeks.org)
