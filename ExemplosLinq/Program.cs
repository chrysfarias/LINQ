

//fonte de dados // list

var listaProdutos = new List<Produto>()
{ 
    new Produto { Id = 1, CategoriaId = 3, Nome = "Ventilador", Status = true, Valor = 120 },
    new Produto { Id = 2, CategoriaId = 2, Nome = "Televisor", Status = true, Valor = 400 },
    new Produto { Id = 3, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 90 },
    new Produto { Id = 4, CategoriaId = 3, Nome = "Sapato", Status = true, Valor = 200 },
    new Produto { Id = 5, CategoriaId = 1, Nome = "Mesa", Status = true, Valor = 120 },
    new Produto { Id = 6, CategoriaId = 3, Nome = "Fogão", Status = true, Valor = 300 },
    new Produto { Id = 7, CategoriaId = 3, Nome = "Computador", Status = true, Valor = 1200 },
    new Produto { Id = 8, CategoriaId = 2, Nome = "Bola", Status = true, Valor = 40 },
    new Produto { Id = 9, CategoriaId = 1, Nome = "Celular", Status = true, Valor = 420 }
};


var listaCategorias = new List<Categoria>()
{
    new Categoria{ Id = 1, Nome = "Eletrônicos", Status = true },
    new Categoria{ Id = 2, Nome = "Outros", Status = true },
   
};

// consulta linq    


class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }
    public decimal  Valor { get; set; }
    public int CategoriaId { get; set; }

}

class Categoria
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public bool Status { get; set; }

}
