﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboInvestmentType = New System.Windows.Forms.ComboBox()
        Me.InvestmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestTrackDbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestTrackDbDataSet = New InvestmentTrackingT.InvestTrackDbDataSet()
        Me.txtTicker = New System.Windows.Forms.TextBox()
        Me.txtShares = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dtpPurchaDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPricePerShare = New System.Windows.Forms.Label()
        Me.InvestmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentsTableAdapter = New InvestmentTrackingT.InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter()
        Me.InvestmentsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.InvestmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Investment Purchase Information"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Inversion:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ticker Symbol:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio por accion"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de la compra:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numero de Acciones:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(332, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Importe Total:"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(80, 352)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "Mostrar"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(193, 352)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(311, 352)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboInvestmentType
        '
        Me.cboInvestmentType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvestmentsBindingSource1, "InvestmentType", True))
        Me.cboInvestmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvestmentType.FormattingEnabled = True
        Me.cboInvestmentType.Location = New System.Drawing.Point(193, 94)
        Me.cboInvestmentType.Name = "cboInvestmentType"
        Me.cboInvestmentType.Size = New System.Drawing.Size(193, 24)
        Me.cboInvestmentType.TabIndex = 10
        '
        'InvestmentsBindingSource1
        '
        Me.InvestmentsBindingSource1.DataMember = "Investments"
        Me.InvestmentsBindingSource1.DataSource = Me.InvestTrackDbDataSetBindingSource
        '
        'InvestTrackDbDataSetBindingSource
        '
        Me.InvestTrackDbDataSetBindingSource.DataSource = Me.InvestTrackDbDataSet
        Me.InvestTrackDbDataSetBindingSource.Position = 0
        '
        'InvestTrackDbDataSet
        '
        Me.InvestTrackDbDataSet.DataSetName = "InvestTrackDbDataSet"
        Me.InvestTrackDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTicker
        '
        Me.txtTicker.Location = New System.Drawing.Point(193, 130)
        Me.txtTicker.Name = "txtTicker"
        Me.txtTicker.Size = New System.Drawing.Size(133, 23)
        Me.txtTicker.TabIndex = 11
        '
        'txtShares
        '
        Me.txtShares.Location = New System.Drawing.Point(193, 256)
        Me.txtShares.Name = "txtShares"
        Me.txtShares.Size = New System.Drawing.Size(96, 23)
        Me.txtShares.TabIndex = 12
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(467, 252)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(111, 27)
        Me.lblTotal.TabIndex = 13
        '
        'dtpPurchaDate
        '
        Me.dtpPurchaDate.Location = New System.Drawing.Point(195, 187)
        Me.dtpPurchaDate.Name = "dtpPurchaDate"
        Me.dtpPurchaDate.Size = New System.Drawing.Size(225, 23)
        Me.dtpPurchaDate.TabIndex = 14
        '
        'lblPricePerShare
        '
        Me.lblPricePerShare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPricePerShare.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerShare.Location = New System.Drawing.Point(467, 130)
        Me.lblPricePerShare.Name = "lblPricePerShare"
        Me.lblPricePerShare.Size = New System.Drawing.Size(111, 27)
        Me.lblPricePerShare.TabIndex = 15
        '
        'InvestmentsBindingSource
        '
        Me.InvestmentsBindingSource.DataMember = "Investments"
        Me.InvestmentsBindingSource.DataSource = Me.InvestTrackDbDataSet
        '
        'InvestmentsTableAdapter
        '
        Me.InvestmentsTableAdapter.ClearBeforeFill = True
        '
        'InvestmentsBindingSource2
        '
        Me.InvestmentsBindingSource2.DataMember = "Investments"
        Me.InvestmentsBindingSource2.DataSource = Me.InvestTrackDbDataSetBindingSource
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(616, 418)
        Me.Controls.Add(Me.lblPricePerShare)
        Me.Controls.Add(Me.dtpPurchaDate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtShares)
        Me.Controls.Add(Me.txtTicker)
        Me.Controls.Add(Me.cboInvestmentType)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investment Tracking"
        CType(Me.InvestmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cboInvestmentType As ComboBox
    Friend WithEvents txtTicker As TextBox
    Friend WithEvents txtShares As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents dtpPurchaDate As DateTimePicker
    Friend WithEvents lblPricePerShare As Label
    Friend WithEvents InvestTrackDbDataSet As InvestTrackDbDataSet
    Friend WithEvents InvestmentsBindingSource As BindingSource
    Friend WithEvents InvestmentsTableAdapter As InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter
    Friend WithEvents InvestmentsBindingSource1 As BindingSource
    Friend WithEvents InvestTrackDbDataSetBindingSource As BindingSource
    Friend WithEvents InvestmentsBindingSource2 As BindingSource
End Class
