# LeetCodeRunner.Core

Reusable data structures and helpers for solving LeetCode problems.

## Features

### Binary Trees

- TreeNode
- TreeBuilder.FromLevelOrder
- TreeBuilder.ToLevelOrder
- TreeBuilder.Clone
- TreePrinter.Print

### Linked Lists

- ListNode
- LinkedListBuilder.FromArray
- LinkedListBuilder.ToArray
- LinkedListBuilder.Clone
- LinkedListPrinter.Print

## Example

```csharp
var root = TreeBuilder.FromLevelOrder(
    1, 2, 3, null, 4);

TreePrinter.Print(root);
