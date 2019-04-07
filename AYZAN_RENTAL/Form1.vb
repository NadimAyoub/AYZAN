Public Class client
    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AyzanDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.AyzanDataSet.Client)
        Client_idTextBox.Clear()
        Client_idTextBox.Enabled = False
        Client_nameTextBox.Clear()
        Client_nameTextBox.Enabled = False
        Client_addressTextBox.Clear()
        Client_addressTextBox.Enabled = False
        Cleint_telTextBox.Clear()
        Cleint_telTextBox.Enabled = False
        Client_emailTextBox.Clear()
        Client_emailTextBox.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True


    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Me.ClientBindingSource.AddNew()
        Client_idTextBox.Enabled = True
        Client_nameTextBox.Enabled = True
        Client_addressTextBox.Enabled = True
        Cleint_telTextBox.Enabled = True
        Client_emailTextBox.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        Client_idTextBox.Focus()



    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        If Client_idTextBox IsNot
        vbNullString Then
            Me.Validate()
            Me.ClientBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)
            Client_idTextBox.Clear()
            Client_nameTextBox.Clear()
            Client_addressTextBox.Clear()
            Cleint_telTextBox.Clear()
            Client_emailTextBox.Clear()
        End If

        If Client_idTextBox.ToString Is vbNullString Then

            Client_idTextBox.Focus()
        End If
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Me.ClientBindingSource.RemoveCurrent()
        Client_idTextBox.Enabled = True
        Client_nameTextBox.Enabled = True
        Client_addressTextBox.Enabled = True
        Cleint_telTextBox.Enabled = True
        Client_emailTextBox.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True

    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientBindingSource.MoveNext()

    End Sub
End Class
