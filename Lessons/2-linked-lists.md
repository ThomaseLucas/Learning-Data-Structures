# Linked List

A linked list is a linear data structure, similar to an array, that is made up of individual elements called nodes. Each of these nodes holds the data, and a reference pointer that holds the adress of the next node in the list. The thing that differs from arrays, however, is that linked lists are much more able to have dynamic memory. 

The most common types of linked lists are: 

- Singly Linked List (one reference pointer, only pointing forward)
- Doubly Linked List (two reference pointers, one pointing forward, the other backwards)

## 1.0 The purpose of a Linked List
Linked lists mostly act as a means to efficiently insert and delete elements from a list. They are mainly used to implement other data structures, which is why you see linked lists used less commonly within developers who are writing code, but they are like a backbone data structures. Linked lists walk so that other structures can fly. 


### 1.1 Why would I use a linked list?

### 1.2 Where would I use a linked list?

## 2.0 Pros and Cons of a linked list

As previously mentioned, linked lists are different from arrays in small ways. They offer a unique strategy for storing and organizing data, but also comes with trade-offs when using them. Because they are stored in nodes, with pointers, it impacts how well we are able insert nodes into the list. An understanding of these pros and cons is essential for being able to know when to use a linked list and when to avoid using one.

### 2.1 Advantages

- **Insert/Delete O(1) Time Complexity**: Because you are only interacting with the pointers of the nodes, that is all you have to change in order to insert or delete something from the list. If you have access to these pointers, you are able to easily shift.


- **No Predetermined Size**: As a linked list is just floating memory with references pointing to one another, you can make it as big or as small as you want with little to no consequences (memory allocation wise).


- **No shifting of Elements**: When an element is inserted into an array, the compiler copies it, then adds your number. With a linked list this doesn't happen, you just reassign the pointers and you have a new node in the list!


- **Simple to understand**: It's as simple as this: to remove an element, you reference the next behind it to it, and the next of the new node to the one after that one. Done! To remove, you just reference the one before the node to be removed to the one after the node. Very simple!

### 2.2 Disadvantages

- **O(n) Search Time**: Unlike an array, searching through a linked list requires the program to search through each node, then follow the pointer to the next node, and make comparisons to each.


- **Large Memory Usage**: Each node allocates ~16 bytes of memory. This is seperated between an int (4 bytes), padding (4 bytes), pointer (8 bytes). If it's doubly linked, then it allocates 24 bytes (2 pointers).


- **No Direct Access to Nodes (No indexing)**: It isn't possible to jump directly to a specific value in the list. You have to iterate through each node until you find the one you are looking for.


## 3.0 The syntax of a linked list

When coding in C#, there are many different methods associated with a linked list. The section here will go over the most commonly used methods, and explain how they work, along with their time within big O notation.

These are the 5 most commonly used methods in C# when using a stack:

1. .AddLast()
1. .AddFirst()
1. .AddBefore(node, value)
1. .AddAfter(node, value)
1. .Remove(value)

### 3.1 Stack Initialization

In order to create a new linked list, it's very similar to a stack, at least in its syntax: 

```csharp
LinkedList<string> newList = new LinkedList<string>();
```

This syntax initializes a new linked list called "newList". After this is done, you can start to play around with the previously mentioned methods to start adding nodes and values into the list wherever you'd like, as it's all the same time complexity.

Complexity: O(1)

### 3.2 Using .AddLast() and .AddFirst()
Linked lists are very intuitive in that you are able to quickly add onto the top and bottom respectively with these built in methods:

```csharp
//This will add a node onto the end of the linked list
newList.Addlast("Billy");
//This will add a node onto the beginning of the linked list
newList.AddFirst("Bob");
```

This is much quicker than an array, as when you add a new node, instead of having to copy the whole list, resize it, then put the value you want back in, the program just shifts around the pointers. I will add a diagram that helps visualize this. 

Complexity: O(1)

### 3.3 Using .AddBefore(node, value) and .AddAfter(node, value)

These methods takes two paramters. The first one allows it to find where exactly you want to put the new value, and after you specified which node it should go before or after, it then reorganizes the pointers of the previous node, and current node to continue the linked list. This is how that would look:

```csharp
    newList.AddBefore(LinkedListNode<string> "Billy", "Joe");
    newList.AddAfter(LinkedListNode<string> "Billy", "Jill");
```

With these methods, you are able to remove and add values between other nodes in order to get the oredered list that you need for your program. 
Complexity: O(1)

### 3.4 Using .Remove(value)

This method removes the first occurence of the given value. In order to do this, you specify a value, and the method looks for that value inside each node until it's found. This is the syntax for this:

```csharp
newList.Remove("Jill");
```

Now, because the method has to look through every node, this is not an O(1) time complexity, which means it's slower than the others, but it is one of the only ways of removing a specific node, unless you shift it to the end, and just pop it off. 
O(n)

### 3.7 Overview

| Method                  | Description                                                        | Time Complexity |
|-------------------------|--------------------------------------------------------------------| --------------- |
| .AddLast()              | Adds a node with the specified value to the end of the linked list | O(1)            |
| .AddLast()              | Adds a node to the beginning of a linked list                      | O(1)            |
| .AddBefore(node, value) | Adds a node preceeding a specified node within the list            | O(1)            |
| .AddAfter(node, value)  | Adds a node after a specified node within the list                 | O(1)            |
| .Remove(value)          | Removes the first occurence of the given value from the list       | O(n)            |

## 4.0 Problem to solve: Undo Redo Simulation

Problem to solve: [To-do list example](../To-do List Example/To_do_list_example.cs)

See the solution: [To-do list solution](../To-do List Solution/To_do_list_solution.cs)

[Back to welcome page](0-welcome.md)

## Sources

- [Brilliant.org](https://brilliant.org/wiki/linked-lists/)
- [geeksforgeeks.org](https://www.geeksforgeeks.org/linked-list-data-structure/?ref=gcse_outind)
