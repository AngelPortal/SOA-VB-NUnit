Public Partial Class WebForm1
    Inherits System.Web.UI.Page

    Public Function GetResult(ByVal firstNumber As String, ByVal secondNumber As String, ByVal operacao As Integer) As String

        Dim client As New ServiceReference.CalculatorWebService
        Dim a, b As Integer
        Dim result As String = Nothing

        Try
            a = CInt(firstNumber)
            b = CInt(secondNumber)
            Select Case operacao
                Case 0
                    result = firstNumber + " + " + secondNumber + " = " + client.Add(a, b).ToString
                Case 1
                    result = firstNumber + " - " + secondNumber + " = " + client.Subtract(a, b).ToString
                Case 2
                    result = firstNumber + " * " + secondNumber + " = " + client.Multiply(a, b).ToString
                Case 3
                    result = firstNumber + " / " + secondNumber + " = " + client.Division(a, b).ToString
                Case Else
                    result = "Not between 0 and 3, inclusive"
            End Select
        Catch ex As Exception
            LabelResult.ForeColor = System.Drawing.Color.Red
            result = "Cannot Divide by Zero or Invalid Data Imput"
        End Try
        GetResult = result
    End Function

    Protected Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button.Click
        LabelResult.ForeColor = System.Drawing.Color.Black
        LabelResult.Text = GetResult(TextBoxFirstNumber.Text, TextBoxSecondNumber.Text, DropDownList.SelectedIndex)
    End Sub

End Class