# Linked List

A linked list can seem like a daunting structure to understand at first, but its fairly straightforward once you understand it, and just like a stack, linked lists a very powerful.

A stack is made up of individual objects called nodes that hold data and reference the next node in the list. There are many different implementations of linked lists, the main is a singley linked list (a linked list with the nodes only referencing the next node). The next is a doubly linked list (referencing both the next and previous nodes).

## 1.0 The Purpose of a Linked List

You may ask:

- **"Why would I use a linked list instead of a list? Isn't it the same thing?"**

This is a very important question to answer, because if you don't understand this, it will be hard to use linked lists to their full capacity. The difference between an array and linked list is in the way they store and access elements in memory

**The main advantage of a linked list is its efficiency when inserting and deleting elements.** Unlike arrays, when an element is inserted or deleted, you must shift all the other elements around it, a linked list simply changes the references that are pointing to it. This makes insertion and deletion faster and more flexible.

### 1.1 The Preformance of a Linked List

In regards to deletion and insertion, linked lists have an obvious advantage to dynamic arrays. With a linked list, inserting and element and deleting an element has a constant time complexity of:

    O(1)

However, because you have to look through every node to find data you are looking for in the linked list, a search with a linked list has a linear time complexity of:

    O(n)

## 2.0 The syntax of a stack

With a Linked List, there are different aspects within each structure in it's entirety. The most important thing to note is that there are values denoting the beginning of the list, and the end of the list, usually called the **head** and the **tail**. For consistancy accross this lesson, we will be using doubly linked lists to demonstrate the syntax of this structure:

First, to create a linked list in C-Sharp, this is the syntax you use:

```csharp
LinkedList<string> myList = new LinkedList<string>();
```

Then, you can start adding elements by using built in functions to C-Sharp's data structure. You should always start by adding the top element, or the head:

```csharp
myList.AddLast("Alice");
myList.AddFirst("Bob");
```

After this you can start to manipulate and play around with placing different elements in different spots, namely, before and after specified nodes:

```csharp
void AddAfter(node){
    mylist.AddAfter(node, "Jill");
}

void AddBefore(node){
    myList.AddBefore(node, "Sam");
}

//These obviously don't need to be functions, but seeing as we have no other nodes defined we have to pass in a parameter.
```

And to remove certain elements from a linked list:

```csharp
myList.Remove("Alice");
myList.RemoveFirst();
myList.RemoveLast();
```

You can also manually switch around the pointers to point at different nodes:

```chsarp

```

### 2.2 Simple example solution

Assuming we already have a linked list to work with... Here is code that revereses a list without built-in functions:

```csharp
void
    var current = myNode

    while(current != null){

        var next = current.next
        current.next = previous
        var previous = current
        current = next
    }
```

## 3.0 Pros and Cons of a Linked List

As previously mentioned, linked lists are different from arrays in small ways. They offer a unique strategy for storing and organizing data, but also comes with trade-offs when using them. Because they are stored in nodes, with pointers, it impacts how well we are able insert nodes into the list. An understanding of these pros and cons is essential for being able to know when to use a linked list and when to avoid using one.

### 3.1 Advantages

- **Insert/Delete O(1) Time Complexity**: Because you are only interacting with the pointers of the nodes, that is all you have to change in order to insert or delete something from the list. If you have access to these pointers, you are able to easily shift.

- **No Predetermined Size**: As a linked list is just floating memory with references pointing to one another, you can make it as big or as small as you want with little to no consequences (memory allocation wise).

- **No shifting of Elements**: When an element is inserted into an array, the compiler copies it, then adds your number. With a linked list this doesn't happen, you just reassign the pointers and you have a new node in the list!

- **Simple to understand**: It's as simple as this: to remove an element, you reference the next behind it to it, and the next of the new node to the one after that one. Done! To remove, you just reference the one before the node to be removed to the one after the node. Very simple!

### 3.2 Disadvantages

- **O(n) Search Time**: Unlike an array, searching through a linked list requires the program to search through each node, then follow the pointer to the next node, and make comparisons to each.

- **Large Memory Usage**: Each node allocates ~16 bytes of memory. This is seperated between an int (4 bytes), padding (4 bytes), pointer (8 bytes). If it's doubly linked, then it allocates 24 bytes (2 pointers).

- **No Direct Access to Nodes (No indexing)**: It isn't possible to

## 4.0 Problem to solve: [Remove Duplicates in an unsorted list]()

[Back to welcome page](0-welcome.md)

## Sources

- [Brilliant.org](https://brilliant.org/wiki/linked-lists/)
