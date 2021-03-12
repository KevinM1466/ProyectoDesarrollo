﻿Public Class CLIENTES

    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)
    End Sub

    Private currentChildForm As Form

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'dgClientes.Rows.Add(1, "Kevin Daniel", "Hernandez Martinez", 95183510, "Colonia Montecarlo, Choluteca Honduras", "Toyota"
        SurroundingSub()
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)
    End Sub

    Private Sub SurroundingSub()
        Dim nuevo As FrmNuevoCliente = New FrmNuevoCliente()
        nuevo.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (dgClientes.SelectedRows.Count > 0) Then
            Dim frm As New FrmEditarCliente
            frm.txtid.Text = dgClientes.CurrentRow.Cells(0).Value.ToString()
            frm.txtnombre.Text = dgClientes.CurrentRow.Cells(2).Value.ToString()
            frm.txtapellido.Text = dgClientes.CurrentRow.Cells(3).Value.ToString()
            frm.txttelefono.Text = dgClientes.CurrentRow.Cells(4).Value.ToString()
            frm.txtdireccion.Text = dgClientes.CurrentRow.Cells(5).Value.ToString()
            frm.ShowDialog()
        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim NumeroDeFilaSeleccionada As Integer

        If dgClientes.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgClientes.CurrentRow.Cells(0).Value

            Me.ClientesTableAdapter.DeleteQuery(NumeroDeFilaSeleccionada)
            Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class