Public Class frmMainForm


    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InvestTrackDbDataSet.Investments' Puede moverla o quitarla según sea necesario.
        'Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDbDataSet.Investments)
        dtpPurchaDate.Value = Today
        Investment.LoadPrices()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim invest As New Investment
        If cboInvestmentType.SelectedIndex = -1 Or txtShares.Text = "" Then
            MessageBox.Show("Ingrese un dato correcto")
        End If
        With invest
            .Type = CType(cboInvestmentType.SelectedIndex, Investment.InvestmentType)
            .PurchaseDate = dtpPurchaDate.Value.Date
            .Ticker = txtTicker.Text
            .PricePerShare = CDbl(lblPricePerShare.Text)
            .NumOfShares = CInt(txtShares.Text)
        End With
        lblTotal.Text = invest.PurchaseAmount.ToString("c")
        Investment.Insert(invest)
    End Sub

    Private Sub txtTicker_TextChanged(sender As Object, e As EventArgs) Handles txtTicker.TextChanged
        Dim price As Double = Investment.GetCurrentPrince(txtTicker.Text)
        If price > 0 Then
            lblPricePerShare.Text = price.ToString("n")
        Else
            lblPricePerShare.Text = String.Empty
        End If
    End Sub

    Private Sub txtShares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShares.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FrmInvestmentList.showdialog()
    End Sub




End Class