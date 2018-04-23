Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm.DataAnnotations

Namespace pgrid_attribute
    Public Class EmployeesViewModel
        Private privateData As EmployeesData
        Public Overridable Property Data() As EmployeesData
            Get
                Return privateData
            End Get
            Protected Set(ByVal value As EmployeesData)
                privateData = value
            End Set
        End Property
        Public Sub New()
            Data = New EmployeesData() With {.FirstName = "Anita", .LastName = "Benson", .Group = "Inventory Management", .HireDate = New Date(2002, 2, 2), .Salary = 65000D, .Phone = "7138638137", .Email = "Anita_Benson@example.com", .AddressLine1 = "9602 South Main", .AddressLine2 = "Seattle, 77025, USA", .BirthDate = New Date(1985, 3, 18)}
        End Sub
    End Class
    Public Class EmployeesData
        Private Const JobGroup As String = "Job"
        Private Const ContactGroup As String = "Contact"
        Private Const AddressGroup As String = "Address"
        Private Const Personal As String = "Personal"
        Private Const NameGroup As String = "Name"

        <Display(GroupName := NameGroup, Name := "First name")> _
        Public Property FirstName() As String
        <Display(GroupName := NameGroup, Name := "Last name")> _
        Public Property LastName() As String

        <Display(GroupName := JobGroup)> _
        Public Property Group() As String
        <DisplayFormat(NullDisplayText := "Title not set"), Display(GroupName := JobGroup)> _
        Public Property Title() As String
        <Display(GroupName := JobGroup, Name := "Hire date")> _
        Public Property HireDate() As Date
        <Display(GroupName := JobGroup), DataType(DataType.Currency)> _
        Public Property Salary() As Decimal

        <Display(GroupName := JobGroup, Name := "Clients"), InstanceInitializer(GetType(Clients), "New Client")> _
        Public Property Clients() As Object

        <Display(GroupName := ContactGroup), DataType(DataType.PhoneNumber)> _
        Public Property Phone() As String
        <Display(GroupName := ContactGroup), DataType(DataType.EmailAddress)> _
        Public Property Email() As String

        <Display(GroupName := Personal, Name := "Birth date"), DisplayFormat(DataFormatString := "m", ApplyFormatInEditMode := True)> _
        Public Property BirthDate() As Date

        <Display(GroupName := AddressGroup, Name := "Address line 1")> _
        Public Property AddressLine1() As String
        <Display(GroupName := AddressGroup, Name := "Address line 2")> _
        Public Property AddressLine2() As String
    End Class
    Public Class Client
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Phone() As String
    End Class
    Public Class Clients
        Inherits List(Of Client)

    End Class
End Namespace