namespace Task5
{
    public partial class MainPage : ContentPage
    {
        private List<Product> products;

        public MainPage()
        {
            InitializeComponent();

            products = new List<Product>
        {
            new FoodProduct
            {
                Price = 100,
                CountryOfOrigin = "Ukraine",
                Name = "Milk",
                PackagingDate = DateTime.Now.AddDays(-5),
                Description = "Fresh milk",
                ExpirationDate = DateTime.Now.AddDays(5),
                Quantity = 1,
                UnitOfMeasure = "liter"
            },
            new Book
            {
                Price = 200,
                CountryOfOrigin = "Ukraine",
                Name = "Ukrainian Classic",
                PackagingDate = DateTime.Now.AddDays(-10),
                Description = "Classic literature",
                PageCount = 300,
                Publisher = "ABC Publishing",
                Authors = new List<string> { "Author 1", "Author 2" }
            }
        };

            UpdateGrid();
        }

        private void AddProductClicked(object sender, EventArgs e)
        {
            var newProduct = new FoodProduct
            {
                Price = 50,
                CountryOfOrigin = "Poland",
                Name = "Cheese",
                PackagingDate = DateTime.Now,
                Description = "Soft cheese",
                ExpirationDate = DateTime.Now.AddDays(7),
                Quantity = 1,
                UnitOfMeasure = "kg"
            };

            products.Add(newProduct);
            UpdateGrid();
        }

        private void RemoveProductClicked(object sender, EventArgs e)
        {
            if (products.Any())
            {
                products.RemoveAt(products.Count - 1);
                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            ProductsGrid.Children.Clear();
            ProductsGrid.RowDefinitions.Clear();

            ProductsGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            ProductsGrid.Add(new Label { Text = "Name", FontAttributes = FontAttributes.Bold }, 0, 0);
            ProductsGrid.Add(new Label { Text = "Price", FontAttributes = FontAttributes.Bold }, 1, 0);
            ProductsGrid.Add(new Label { Text = "Description", FontAttributes = FontAttributes.Bold }, 2, 0);

            int row = 1;
            foreach (var product in products)
            {
                ProductsGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                ProductsGrid.Add(new Label { Text = product.Name }, 0, row);
                ProductsGrid.Add(new Label { Text = product.Price.ToString() + " грн" }, 1, row);
                ProductsGrid.Add(new Label { Text = product.Description }, 2, row);
                row++;
            }
        }
    }
}
