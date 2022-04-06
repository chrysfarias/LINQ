

        //Data Source // list

        var productList = new List<Product>()
        { 
            new Product { Id = 1, CategoryId = 3, Name = "Fan", Status = true, Value = 120 },
            new Product { Id = 2, CategoryId = 2, Name = "Television", Status = true, Value = 400 },
            new Product { Id = 3, CategoryId = 3, Name = "T-shirt", Status = true, Value = 90 },
            new Product { Id = 4, CategoryId = 3, Name = "Shose", Status = true, Value = 200 },
            new Product { Id = 5, CategoryId = 1, Name = "Table", Status = true, Value = 120 },
            new Product { Id = 6, CategoryId = 3, Name = "Stove", Status = true, Value = 300 },
            new Product { Id = 7, CategoryId = 3, Name = "Computer", Status = true, Value = 1200 },
            new Product { Id = 8, CategoryId = 2, Name = "Ball", Status = true, Value = 40 },
            new Product { Id = 9, CategoryId = 1, Name = "Cellphone", Status = true, Value = 420 }
        };


        var categoryLists = new List<Category>()
        {
            new Category{ Id = 1, Name = "Eletronics", Status = true },
            new Category{ Id = 2, Name = "Others", Status = true },
   
        };

        // linq query

        var result = from product in productList
             where product.Value > 400
             select product;


        foreach (var product in result)
        {
            Console.WriteLine($"{product.Id}|{product.Name}|{product.Status}|{product.Value}|");
        
        }


        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Status { get; set; }
            public decimal Value { get; set; }
            public int CategoryId { get; set; }

        }

        class Category
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public bool Status { get; set; }

        }
