Imports Client
Imports Server
Imports NUnit.Framework
Public Class UnitTestSOA
    Private testclient As Client.WebForm1
    Private testserver As Server.Service
    <SetUp()> _
    Public Sub Initialize()
        testclient = New Client.WebForm1
        testserver = New Server.Service
    End Sub
    <TearDown()> _
    Public Sub CleanUp()
        testclient = Nothing
        testserver = Nothing
    End Sub
    <Test()> _
    Public Sub GetResult()
        Assert.AreEqual("2 + 3 = 4", testclient.GetResult(2, 3, 0))
    End Sub

    <Test()> _
    Public Sub Add()
        Assert.AreEqual(5, testserver.Add(2, 3))
    End Sub

End Class
