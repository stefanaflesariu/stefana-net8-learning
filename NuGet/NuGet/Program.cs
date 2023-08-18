using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using NuGet;

void Method()
{
    Product product = new Product
    {
        ProductName = "Notebook",
        ProductPrice = 10
    };

    var json = JsonConvert.SerializeObject(product, new JsonSerializerSettings
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new KebabCaseNamingStrategy()
        }
    });

    Console.WriteLine(json);
}
Method();

// 4. I have only one error. Can't find KebabCaseNamingStrategy()
// 5. I have no more errors and  the product is displayed
// The 2nd 4th :)  The product is displayed
