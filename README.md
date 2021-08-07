# CollectionsExercises
## Instructions

## Squared Randoms Exercise
1. Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.

    ```csharp
    Random random = new Random();
    // Create a list
    // Populate the list
    ```

2. With the resulting List, populate a new List that contains each number squared. For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
3. Then remove any number that is odd from the list of squared numbers.

----
## Planets ans Spaceships Exercise
In the `Main` method, place the following code

```
List<string> planetList = new List<string>(){"Mercury", "Mars"};
```

1. `Add()` Jupiter and Saturn at the end of the list.
2. Create another `List` that contains that last two planet of our solar system.
3. Combine the two lists by using `AddRange()`.
4. Use `Insert()` to add Earth, and Venus in the correct order.
5. Use `Add()` again to add Pluto to the end of the list.
6. Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.

## Iterating over planets

> Ref: [List of Solar System probes](https://en.wikipedia.org/wiki/List_of_Solar_System_probes)

1. Create a dictionary that will hold the name of a spacecraft
that we have launched, and a list of names of the planets that it has
visited. Remember that `List` is a Type just like native types (such as `string`, `int`, & `bool`) and your custom types (such as `Movie`, `Dog`, and `Food`). These types can be passed to anything, like a dictionary.
2. Iterate over your list of planets from above, and inside that loop,
iterate over the dictionary. Write to the console, for each planet,
which satellites have visited which planet.

```
Mars: Viking, Opportunity, Curiosity
Venus: Mariner, Venera
etc...
```

----
## Family Dictionary Exercise
1. Define a Dictionary that contains information about several members of your family. Use the following example as a template.

    ```csharp
    Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
    myFamily.Add("sister", new Dictionary<string, string>(){ {"name", "Krista"}, {"age", "42"}});
    ```

2. Next, iterate over each item in `myFamily` and produce the following output.

    ```
    Krista is my sister and is 42 years old
    ```
----
## Stock Purchase Dictionary Exercise

A block of publicly traded stock has a variety of attributes, we'll
look at a few of them. A stock has a ticker symbol and a company name.
Create a simple dictionary with ticker symbols and company names in the `Main` method.

### Example

```csharp
Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
// Add a few more of your favorite stocks
```

To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.

```csharp
string GM = stocks["GM"]; <--- "General Motors"
```

Create list of ValueTuples that represents stock purchases. Properties will be `ticker`, `shares`, `price`.

```csharp
List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
```

### Example

```csharp
purchases.Add((ticker: "GE", shares: 150, price: 23.21));
purchases.Add((ticker: "GE", shares: 32, price: 17.87));
purchases.Add((ticker: "GE", shares: 80, price: 19.02));
// Add more for each stock you added to the stocks dictionary

//Create a total ownership report that computes the total value of each stock that you have purchased.
//This is the basic relational database join algorithm between two tables.

/*
 * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
 * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
*/
// Iterate over the purchases and update the valuation for each stock
foreach ((string ticker, int shares, double price) purchase in purchases)
{
	// Does the company name key already exist in the report dictionary?
	// If it does, update the total valuation
	// If not, add the new key and set its value
}
```


