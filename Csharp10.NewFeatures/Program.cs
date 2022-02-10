// there are many improvements conserning lambdas

// this is how we could do that in the old days

Func<string> helloWorld = () => "Hello World!";

// now we could use type inference

var newHelloWorld = () => "New Hello World!";

WriteLine(helloWorld());
WriteLine(newHelloWorld());

var text = string? () => null; // in the past you could not do that (after all null can be anything)
