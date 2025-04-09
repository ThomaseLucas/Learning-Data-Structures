# Trees
A tree is a non-linear data structure, meaning that it can go more than one direction. Trees consist of nodes that are linked to eachother by what is called an edge. It begins with a single node called the root, and the root has two "Child" nodes. It is then possible for each child to have child nodes, and so on and so forth. Just like a tree. Think of it like an updside down tree.

Here is a good visual to help understand the concept better:
>        Root
>       /    \
>     Child1  Child2
>     /
>     Child1.1

Each child consists of a value, and two pointers, pointing to the left, and one pointing to the right.

## 1.0 The purpose of a Tree
There are many reasons that trees are used, and are the one of the most effective ways to store data, because of how efficient it is to search and retrieve items if it's organized correctly. It can also be used to represent relationships between elements (much like a parent and child class does). 

When a tree is organized correctly, it is called a balanced tree. That is very important to remember, because if you are working with an unbalanced tree, it likely would not be possible to use algorithms that utilize the tree.


### 1.1 Why would I use a tree?

### 1.2 Where would I use a tree?

## 2.0 Pros and Cons of trees


### 2.1 Advantages

- **Speed of searching/inserting/deleting**: When the tree is balanced, there are certain algorithms that help utilize the tree in an O(log(n)) complexity.

- **Recursive focused**: Within trees, you are able to navigate the data much easier with recursive logic. This is because all of the nodes are structured the same, but by moving downwards along the tree, you are able to reach every node.

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
