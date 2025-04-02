# C# Partial Keyword

A quick reference guide for the partial keyword in C#.

## 📋 Index
- [A. Partial Classes/Structs/Interfaces](#a-partial-classesstructsinterfaces)
- [B. Partial Methods](#b-partial-methods)
- [C. Rules for Partial Methods](#c-rules-for-partial-methods)
- [D. Code Example](#d-code-example)
- [Best Practices](#best-practices)

## A. Partial Classes/Structs/Interfaces

- **Purpose:** Allows splitting a class, struct, or interface definition across multiple files
- **Usage:** Applied to class, struct, or interface declarations
- **Syntax:** `partial class ClassName { }`, `partial struct StructName { }`, `partial interface InterfaceName { }`
- **In reality:** All partial declarations are considered as one class/struct/interface

**Example of inheritance with partial classes:**
```csharp
partial class Earth : Planet, IRotate { }
partial class Earth : IRevolve { }
```
These two lines are equivalent to:
```csharp
class Earth : Planet, IRotate, IRevolve { }
```

## B. Partial Methods

- **Purpose:** Allows declaration of a method in one part and implementation in another part
- **Usage:** Used within partial classes/structs to provide optional implementation
- **Components:**
  - **Declaration part:** Represents the signature of the partial method
  - **Definition part:** Represents the implementation of the partial method
- **Behavior:** If no implementation is provided, the compiler removes the declaration and all calls to the method

## C. Rules for Partial Methods

1. **Container requirement:** Only partial classes/structs can have partial methods
2. **Signature matching:** The signatures in both parts of the partial type must be the same
3. **Return type:** Partial methods can only have a void return type
4. **Access level:** Partial methods are implicitly private
5. **Modifiers:**
   - Cannot have access modifiers
   - Cannot be virtual, abstract, or sealed
   - Can be static or generic
6. **Parameters:**
   - Can have ref parameters
   - Cannot have out parameters
7. **Optimization:** If declaration part exists without definition part, the compiler removes the declaration and method calls

## Best Practices 🥇

- Use partial classes to organize large classes into logical sections
- Use partial classes when working with generated code to separate manual code from auto-generated code
- Keep related functionality together in the same partial class file
- Use clear naming conventions for partial class files
- Use partial methods for extensibility points in generated code
- Document dependencies between partial class files
- Avoid creating too many partial files for a single class
- Consider using interfaces or composition instead of large partial classes