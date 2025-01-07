# C# NullReferenceException Example

This repository demonstrates a common coding error in C#: a `NullReferenceException` that can occur when accessing properties of objects that might be null.  The example shows how this can happen and how to fix it with a simple null check.

## Bug Description

The `ExampleClass` has a property `MyProperty`. The constructor initializes it. However, if an instance of `ExampleClass` is created without using the constructor (e.g., using reflection, deserialization) or if the property is not initialized explicitly, accessing `MyProperty` will result in a `NullReferenceException`.

## Solution

The solution involves adding a null check before accessing the property to ensure it's not null before performing any operations on it.  This makes the code more robust and prevents unexpected crashes.