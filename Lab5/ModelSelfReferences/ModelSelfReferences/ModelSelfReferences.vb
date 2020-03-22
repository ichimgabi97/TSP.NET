Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class ModelSelfReferences
    Inherits DbContext

    ' Your context has been configured to use a 'Model1' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'ModelSelfReferences.Model1' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'Model1' 
    ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=ModelSelfReferences")
    End Sub

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)

    Using System;
 Using System.Data.Entity;
 Using System.Linq;
 Using System.Collections.Generic;
 Using System.ComponentModel.DataAnnotations;
 Using System.ComponentModel.DataAnnotations.Schema;
 Public Class ModelSelfRefrences :  DbContext
 {
 Public ModelSelfRefrences()
  base("name=ModelSelfRefrences")
 {
 }
 Public virtual DbSet<SelfReference> SelfReferences { Get; Set; }
 Protected override void OnModelCreating(DbModelBuilder modelBuilder)
 {
 base.OnModelCreating(modelBuilder);
 modelBuilder.Entity<SelfReference>()
 .HasMany(m >= m.References)
        .WithOptional(m >= m.ParentSelfReference);
 }
 }

        Public Class SelfReference
 {
 [Key]
 [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
 Public int SelfReferenceId { Get; Private Set; }
 Public String Name { Get; Set; }
 Public int? ParentSelfReferenceId { Get; Private Set; }
 [ForeignKey("ParentSelfReferenceId")]
 Public SelfReference ParentSelfReference { Get; Set; }
 Public virtual ICollection<SelfReference> References { Get; Set; }
 Public SelfReference()
 {
 References = New HashSet<SelfReference>();
 }
 }


End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class

