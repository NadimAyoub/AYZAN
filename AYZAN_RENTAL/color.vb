Public Class color
    Private Sub ColorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ColorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)

    End Sub

    Private Sub color_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AyzanDataSet.Color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.AyzanDataSet.Color)
        Color_idTextBox.Clear()
        Color_idTextBox.Enabled = False
        Colore_nameTextBox.Clear()
        Colore_nameTextBox.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True

    End Sub

    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        Me.ColorBindingSource.AddNew()
        Color_idTextBox.Enabled = True
        Colore_nameTextBox.Enabled = True

        Button1.Enabled = False
        Button2.Enabled = False
        Color_idTextBox.Focus()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Me.ColorBindingSource.RemoveCurrent()
        Color_idTextBox.Enabled = True
        Colore_nameTextBox.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        If Color_idTextBox IsNot
        vbNullString Then
            Me.Validate()
            Me.ColorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)
            Color_idTextBox.Clear()
            Colore_nameTextBox.Clear()

        End If

        If Color_idTextBox.ToString Is vbNullString Then

            Color_idTextBox.Focus()
        End If
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ColorBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ColorBindingSource.MoveNext()
    End Sub
End Class