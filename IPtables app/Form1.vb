Public Class IPTables
    ' Declarations
    Dim DestinationIP As String
    Dim Proto As String
    Dim GenTable As String
    Dim PortArray() As String
    Dim PortString As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub Output_TextChanged(sender As Object, e As EventArgs) Handles OutputBox.TextChanged


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Dest.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PortBox.TextChanged
        PortString = PortBox.Text
    End Sub

    Public Sub IPadd_TextChanged(sender As Object, e As EventArgs) Handles DestBox.TextChanged
        DestinationIP = DestBox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        'OutputBox.Text = DestBox.Text & " " & ProtocolBox.Text & " "
        For index = 0 To UBound(PortArray)
            PortArray(index) = Replace(PortArray(index), "-", ":")
        Next

        For index = 0 To UBound(PortArray)
            OutputBox.AppendText(Environment.NewLine + ("-A PREROUTING -i eth0 -p " & ProtocolBox.Text & " --dport " & PortArray(index) & " -j DNAT --to-destination " & DestBox.Text))
        Next
        Array.Clear(PortArray, 0, PortArray.Length)
    End Sub

    Public Sub ProtocolBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocolBox.TextChanged
        PortArray = Split(PortString, ",")
    End Sub
End Class
