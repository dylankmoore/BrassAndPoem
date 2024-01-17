
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

List<ProductType> producttypes = new()
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

string choice = null;
while (choice !="0")
{
    Console.WriteLine(@"Choose from the main menu:
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit
");
}

void DisplayMenu()
{
    throw new NotImplementedException();
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