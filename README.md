# [`Riverside.DeconstructableInterfaces`](https://nuget.org/packages/Riverside.DeconstructableInterfaces)

> Exposes the IDeconstructable interface and its source generator to allow "deconstructing" classes into their fields.

---

This library exposes an `IDeconstructable` interface that lets you 'deconstruct' classes into their fields.

For example:
```cs
public partial class MyClass : IDeconstructable<Field1, Field2>
{
    public MyClass()
    {
        Field1 = string.Empty;
        Field2 = "Hello World";
    }
    public string Field1;
    public string Field2;
}
```

This will then source generate a method in `MyClass`:
```cs
/// <auto-generated/>
public partial class MyClass : IDeconstructable<Field1, Field2>
{
    public (string, string) Deconstruct()
        => (Field1, Field2)
}
```

This has many use cases, including:
- JSON serialisation so containing serialisation types can be split
  - This might be useful when moving from reflection-based serialisation with anonymous types to source-generated serialisation
- Reducing dependency on class references or 'saving' a class's volatile data into a constant variable

..and just for fun! This project is a learning experience for making simple incremental source generators.
I came up with the idea for this when migrating [Taskie](https://github.com/shef3r/Taskie) to modern UWP with .NET 9 (on Native AOT).
