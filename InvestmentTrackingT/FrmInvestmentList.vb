Public Class FrmInvestmentList
    Private Sub FrmInvestmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InvestTrackDbDataSet.Investments' Puede moverla o quitarla según sea necesario.

        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDbDataSet.Investments)

    End Sub
End Class