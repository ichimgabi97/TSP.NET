Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class Product
    Inherits DbContext

    ' Your context has been configured to use a 'Model1' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'ModelSelfReferences.Model1' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'Model1' 
    ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=Product")
    End Sub

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)

    Public Class Product
{
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.None)]
Public int SKU { Get; Set; }
Public String Description { Get; Set; }
Public Decimal Price { Get; Set; }
Public String ImageURL { Get; Set; }
}


    Public Class EF6RecipesContext :  DbContext
{
Public DbSet<Product> Products { Get; Set; }
Public ProductContext() :  base("name=ProductContext")
{}
Protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
base.OnModelCreating(modelBuilder);
modelBuilder.Entity<Product>()
.Map(m >=
{
m.Properties(p >= New {p.SKU, p.Description, p.Price});
m.ToTable("Product", "BazaDeDate");
})
.Map(m >=
{
m.Properties(p >= New {p.SKU, p.ImageURL});
m.ToTable("ProductWebInfo", "BazaDeDate");
});
}
}

End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class
