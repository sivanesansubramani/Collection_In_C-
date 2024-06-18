Collections in C#
Collections in C# are containers that hold multiple objects together. They are essential for organizing and managing groups of related data in your programs. Think of them as boxes where you can store various items (objects) and easily retrieve them later. C# provides several types of collections that offer different ways to store and manipulate data.

Key Features of Collections
Store: Collections can hold multiple objects of the same or different types.
Access: You can retrieve objects from collections by index, key, or iterator.
Manipulate: Collections allow dynamic addition, removal, and modification of elements.
Iterate: You can traverse through collection elements sequentially or based on specific conditions.
Common Types of Collections in C#
Lists (List<T>)
Lists are ordered collections where elements can be accessed by index. They are versatile and support dynamic resizing.

Dictionaries (Dictionary<TKey, TValue>)
Dictionaries store key-value pairs, enabling fast lookup of values based on keys. They are efficient for scenarios requiring quick access to data by a unique identifier.

Queues (Queue<T>)
Queues follow the FIFO (First-In-First-Out) principle, meaning the first element added is the first to be removed. They are useful for implementing scenarios like task scheduling or processing.

Stacks (Stack<T>)
Stacks adhere to the LIFO (Last-In-First-Out) principle, where the last element added is the first to be removed. They are ideal for scenarios such as undo operations or recursive function calls.

Sets (HashSet<T>)
Sets store unique elements, ensuring no duplicates. They provide efficient methods for checking membership and performing set operations like union, intersection, and difference.

Choosing the Right Collection
List: Use when you need an ordered collection and frequent access by index.
Dictionary: Opt for key-value pairs when you require fast lookup by unique keys.
Queue: Choose for implementing FIFO scenarios such as task processing.
Stack: Select for LIFO scenarios like managing undo operations.
HashSet: Use when you need a collection of unique items without duplicates.
