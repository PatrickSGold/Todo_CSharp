Imports Todo.Data.Services

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private ReadOnly db As ITodoData
    Public Sub New()
        Me.db = New InMemoryData()
    End Sub

    Public ReadOnly Property Db1 As ITodoData
        Get
            Return db
        End Get
    End Property

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
