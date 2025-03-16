# Stack

A stack is a very useful tool in the kit of a developer. It allows for the simple management of data, kept in an even simpler order:

![Image of a stack in action](image.png)

A stack can be described as a **LIFO (Last In First Out)** or **FILO (First In Last Out)** data structure. This simply means that the last piece of data put into the structure will be the first to come out when the correct method is called, or vice verse. The many advantages we will go over in this lesson will show why a stack is such a powerful tool.

A stack behaves like a stack of books- _pushing_ adds a book on the top of the stack, and _popping_ takes the top book off.

![Image of a stack of books](bookstack.jpg)

## 1.0 The purpose of a stack

A stack is used for many reasons in programming, but as previously mentioned, the main reason is to keep data organized in a specific order. One common example is handling multiple function calls or recursion, which is **when a function calls itself**. Many compilers rely on stacks to manage function execution.

> "Stacks are a simple and easy-to-understand data structure, making them suitable for a wide range of applications" (Geeks for Geeks, 2024).

### 1.1 A stack's preformance

One of the biggest advantages of a stack is its preformance in regards to the Big O notation of the data structure:

    O(1)

This means that no matter how many "books" or data you put into a stack, it will always take the same amount of time to either **add** a book on top, **remove** a book from the top, or **read** the top book.

## 2.0 The syntax of a stack

When coding in C#, creating a new stack object is fairly straight forward:

```csharp
Stack<int> stack = new Stack<int>();
```

This will initialize a new stack called _"stack"_.

To push something onto the stack, in this case an integer, all you have to do is this:

```csharp
stack.push(1)
stack.push(2)
stack.push(45)
stack.push(10)
```

### 2.1 Where would you use this?

- How would the data structure be used in C# (in some cases you will need to discuss recursion)?

### 2.2 Simple example solution

- What kind of problems can be solved using the data structure?

## 3.0 Pros and Cons of a stack

### 3.1 Advantages

### 3.2 Disadvantages

## 4.0 Problem to solve: ...

[Back to welcome page](0-welcome.md)

## Sources

[Geeks for Geeks](https://geeksforgeeks.org)
