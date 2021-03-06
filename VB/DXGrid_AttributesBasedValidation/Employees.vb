﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Public Class Employee
    Public Property ID() As Integer
    Public Property ParentID() As Integer
    <Required(AllowEmptyStrings := False, ErrorMessage := "The Name cannot be empty. Please correct.")> _
    Public Property Name() As String
    <StringLength(20)> _
    Public Property Position() As String
    <Required(AllowEmptyStrings := False, ErrorMessage := "The Department cannot be empty. Please correct.")> _
    Public Property Department() As String
End Class

Public NotInheritable Class Stuff

    Private Sub New()
    End Sub

    Public Shared Function GetStuff() As List(Of Employee)

        Dim stuff_Renamed As New List(Of Employee)()
        stuff_Renamed.Add(New Employee() With {.ID = 1, .ParentID = 0, .Name = "Gregory S. Price", .Department = "", .Position = "President"})
        stuff_Renamed.Add(New Employee() With {.ID = 2, .ParentID = 1, .Name = String.Empty, .Department = "Marketing", .Position = "Vice President"})
        stuff_Renamed.Add(New Employee() With {.ID = 3, .ParentID = 1, .Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"})
        stuff_Renamed.Add(New Employee() With {.ID = 4, .ParentID = 1, .Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"})
        stuff_Renamed.Add(New Employee() With {.ID = 5, .ParentID = 1, .Name = String.Empty, .Department = "Finance", .Position = "Vice President"})

        stuff_Renamed.Add(New Employee() With {.ID = 6, .ParentID = 2, .Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 7, .ParentID = 2, .Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 8, .ParentID = 2, .Name = "", .Department = "Marketing", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 9, .ParentID = 2, .Name = "", .Department = "Marketing", .Position = "Manager"})

        stuff_Renamed.Add(New Employee() With {.ID = 10, .ParentID = 3, .Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 11, .ParentID = 3, .Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 12, .ParentID = 3, .Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 13, .ParentID = 3, .Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"})

        stuff_Renamed.Add(New Employee() With {.ID = 14, .ParentID = 4, .Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 15, .ParentID = 4, .Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 16, .ParentID = 4, .Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"})

        stuff_Renamed.Add(New Employee() With {.ID = 17, .ParentID = 5, .Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"})
        stuff_Renamed.Add(New Employee() With {.ID = 18, .ParentID = 5, .Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"})
        Return stuff_Renamed
    End Function
End Class
