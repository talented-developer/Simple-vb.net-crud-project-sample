Public Class UserForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim user = DataStore.CreateUser(txtName.Text, txtEmail.Text)
        LoadUsers()
        MessageBox.Show($"User Created: ID = {user.Id}, Name = {user.Name}, Email = {user.Email}")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dataGridViewUsers.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dataGridViewUsers.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

            If DataStore.UpdateUser(id, txtName.Text, txtEmail.Text) Then
                LoadUsers()
                MessageBox.Show("User Updated Successfully.")
            Else
                MessageBox.Show("User Not Found.")
            End If
        Else
            MessageBox.Show("Please select a user to update.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dataGridViewUsers.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dataGridViewUsers.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

            If DataStore.DeleteUser(id) Then
                LoadUsers()
                MessageBox.Show("User Deleted Successfully.")
            Else
                MessageBox.Show("User Not Found.")
            End If
        Else
            MessageBox.Show("Please select a user to delete.")
        End If
    End Sub

    Private Sub LoadUsers()
        dataGridViewUsers.DataSource = Nothing
        If DataStore.CountUser > 0 Then
            dataGridViewUsers.DataSource = DataStore.ReadUsers()
            txtName.Clear()
            txtEmail.Clear()
        End If
    End Sub

    Private Sub dataGridViewUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridViewUsers.SelectionChanged
        If dataGridViewUsers.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dataGridViewUsers.SelectedRows(0)
            txtName.Text = Convert.ToString(selectedRow.Cells("Name").Value)
            txtEmail.Text = Convert.ToString(selectedRow.Cells("Email").Value)
        End If
    End Sub
End Class