Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm.DataAnnotations

Namespace pgrid_attribute

    Public Class EmployeesViewModel

        Public Overridable Property Data As EmployeesData

        Public Sub New()
            Data = New EmployeesData() With {.FirstName = "Anita", .LastName = "Benson", .Group = "Inventory Management", .HireDate = New DateTime(2002, 2, 2), .Salary = 65000D, .Phone = "7138638137", .Email = "Anita_Benson@example.com", .AddressLine1 = "9602 South Main", .AddressLine2 = "Seattle, 77025, USA", .BirthDate = New DateTime(1985, 3, 18)}
        End Sub
    End Class

    Public Class EmployeesData

        Const JobGroup As String = "Job"

        Const ContactGroup As String = "Contact"

        Const AddressGroup As String = "Address"

        Const Personal As String = "Personal"

        Const NameGroup As String = "Name"

        <Display(GroupName:=NameGroup, Name:="First name")>
        Public Property FirstName As String

        <Display(GroupName:=NameGroup, Name:="Last name")>
        Public Property LastName As String

        <Display(GroupName:=JobGroup)>
        Public Property Group As String

        <DisplayFormat(NullDisplayText:="Title not set"), Display(GroupName:=JobGroup)>
        Public Property Title As String

        <Display(GroupName:=JobGroup, Name:="Hire date")>
        Public Property HireDate As Date

        <Display(GroupName:=JobGroup), DataType(DataType.Currency)>
        Public Property Salary As Decimal

        <Display(GroupName:=JobGroup, Name:="Clients")>
        <InstanceInitializer(GetType(Clients), "New Client")>
        Public Property Clients As Object

        <Display(GroupName:=ContactGroup), DataType(DataType.PhoneNumber)>
        Public Property Phone As String

        <Display(GroupName:=ContactGroup), DataType(DataType.EmailAddress)>
        Public Property Email As String

        <Display(GroupName:=Personal, Name:="Birth date")>
        <DisplayFormat(DataFormatString:="m", ApplyFormatInEditMode:=True)>
        Public Property BirthDate As Date

        <Display(GroupName:=AddressGroup, Name:="Address line 1")>
        Public Property AddressLine1 As String

        <Display(GroupName:=AddressGroup, Name:="Address line 2")>
        Public Property AddressLine2 As String
    End Class

    Public Class Client

        Public Property FirstName As String

        Public Property LastName As String

        Public Property Phone As String
    End Class

    Public Class Clients
        Inherits List(Of Client)

    End Class
End Namespace
