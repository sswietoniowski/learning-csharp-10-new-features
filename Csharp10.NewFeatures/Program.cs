// extended property patterns

using Csharp10.NewFeatures;

var rectangleInside = new Rectangle(0, 0);
var rectangleOutside = new Rectangle(100, 100, rectangleInside);

// old syntax
//if (rectangleOutside is { rectangle: { Height: > 100} })
// new syntax
if (rectangleOutside is { rectangle.Height: > 100 })
{
    // do something with that...
}