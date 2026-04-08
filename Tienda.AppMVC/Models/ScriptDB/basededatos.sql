CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE()
);

CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(18, 2) NOT NULL CHECK (Precio >= 0),
    Stock INT NOT NULL DEFAULT 0,
    CategoriaID INT, -- Esta es nuestra Llave Foránea
    FechaIngreso DATETIME DEFAULT GETDATE(),
    
    CONSTRAINT FK_Categoria_Producto FOREIGN KEY (CategoriaID) 
    REFERENCES Categorias(CategoriaID)
    ON DELETE SET NULL);
GO
