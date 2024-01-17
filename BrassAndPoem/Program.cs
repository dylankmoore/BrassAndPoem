
string greeting = @"Welcome to Brass & Poem! We sell a unique selection of poetry and brass musical instruments.";

List<Product> product = new()
{
    new Product()
    {
        Name = "French Horn",
        Price = 4200.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Milk & Honey",
        Price = 30.00M,
        ProductTypeId =2
    },
    new Product()
    {
        Name = "Tuba",
        Price = 1500.00M,
        ProductTypeId =1
    },
    new Product()
    {
        Name = "Shakespeare's Sonnets",
        Price = 30.00M,
        ProductTypeId =2
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 800.00M,
        ProductTypeId = 1
    }
};

List<ProductType> productTypes = new()
{
    new ProductType()
    {
        Title = "Brass Instruments",
        Id = 1,

    },
    new ProductType()
    {
        Title = "Poetry",
        Id = 2

    },
};

Console.WriteLine(greeting);
Console.WriteLine("\n");

string choice = null;
while (choice !="5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine(@"A list of all of our plants:");
            DisplayAllProducts(product, productTypes);
            break;
        case "2":
            Console.WriteLine(@"Add a plant to inventory!");
            DeleteProduct(product, productTypes);
            break;
        case "3":
            Console.WriteLine(@"Adopt a plant!");
            AddProduct(product, productTypes);
            break;
        case "4":
            Console.WriteLine(@"Delist a plant");
            UpdateProduct(product, productTypes);
            break;
        case "5":
            Console.WriteLine(@"Thank you, Goodbye!");
            break;
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"Choose from the main menu:
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }