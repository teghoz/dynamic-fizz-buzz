# dynamic-fizz-buzz
Just a dynamic way of handling the fizz-buzz-bazz code challenge. All you need to do is add the rules in the configuration below:

```
public class DynamicFizzBuzzRequest
{
    public Dictionary<int, string> Configurations { get; set; }
    public int MaxNumber { get; set; }
}
```

```
var dynamicFizzBuzzRequest = new DynamicFizzBuzzRequest()
{
    MaxNumber = 105,
    Configurations = new Dictionary<int, string> {
        { 3, "Fizz" },
        { 5, "Buzz" },
        { 7, "Bazz" }
    }
};
```