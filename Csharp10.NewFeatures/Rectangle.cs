namespace Csharp10.NewFeatures;
internal record Rectangle(int Height, int Width)
{
    public sealed override string ToString()
    {
        return $"Rectangle({Width},{Height})";
    }
}

// ToString can be sealed now so you won't be able to override it, yeah, but why :-)?

internal record Square(int Side) : Rectangle(Side, Side)
{
    //public override string ToString()
    //{
    //    return $"Square({Side})";
    //}
}