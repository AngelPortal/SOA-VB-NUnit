Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

<WebService(Namespace:="http://tempuri.org/", Description:="A Simple Web Calculator Service", Name:="CalculatorWebService")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function
    <WebMethod()> _
    Public Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x - y
    End Function
    <WebMethod()> _
    Public Function Multiply(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x * y
    End Function
    <WebMethod()> _
    Public Function Division(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x / y
    End Function
End Class