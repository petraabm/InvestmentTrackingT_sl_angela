<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvestmentList
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InvestTrackDbDataSet = New InvestmentTrackingT.InvestTrackDbDataSet()
        Me.InvestmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentsTableAdapter = New InvestmentTrackingT.InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TickerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvestmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceShareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumshareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TickerDataGridViewTextBoxColumn, Me.InvestmentTypeDataGridViewTextBoxColumn, Me.PriceShareDataGridViewTextBoxColumn, Me.PurchaseDateDataGridViewTextBoxColumn, Me.NumshareDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvestmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 173)
        Me.DataGridView1.TabIndex = 0
        '
        'InvestTrackDbDataSet
        '
        Me.InvestTrackDbDataSet.DataSetName = "InvestTrackDbDataSet"
        Me.InvestTrackDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TickerDataGridViewTextBoxColumn
        '
        Me.TickerDataGridViewTextBoxColumn.DataPropertyName = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.HeaderText = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.Name = "TickerDataGridViewTextBoxColumn"
        '
        'InvestmentTypeDataGridViewTextBoxColumn
        '
        Me.InvestmentTypeDataGridViewTextBoxColumn.DataPropertyName = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.HeaderText = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.Name = "InvestmentTypeDataGridViewTextBoxColumn"
        '
        'PriceShareDataGridViewTextBoxColumn
        '
        Me.PriceShareDataGridViewTextBoxColumn.DataPropertyName = "PriceShare"
        Me.PriceShareDataGridViewTextBoxColumn.HeaderText = "PriceShare"
        Me.PriceShareDataGridViewTextBoxColumn.Name = "PriceShareDataGridViewTextBoxColumn"
        '
        'PurchaseDateDataGridViewTextBoxColumn
        '
        Me.PurchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.Name = "PurchaseDateDataGridViewTextBoxColumn"
        '
        'NumshareDataGridViewTextBoxColumn
        '
        Me.NumshareDataGridViewTextBoxColumn.DataPropertyName = "Numshare"
        Me.NumshareDataGridViewTextBoxColumn.HeaderText = "Numshare"
        Me.NumshareDataGridViewTextBoxColumn.Name = "NumshareDataGridViewTextBoxColumn"
        '
        'FrmInvestmentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmInvestmentList"
        Me.Text = "InvestmentList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InvestTrackDbDataSet As InvestTrackDbDataSet
    Friend WithEvents InvestmentsBindingSource As BindingSource
    Friend WithEvents InvestmentsTableAdapter As InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TickerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvestmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceShareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumshareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
