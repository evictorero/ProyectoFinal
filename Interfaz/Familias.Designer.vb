﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Familias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtFecha_baja = New System.Windows.Forms.TextBox()
        Me.txtDescripcion_larga = New System.Windows.Forms.TextBox()
        Me.txtDescripcion_corta = New System.Windows.Forms.TextBox()
        Me.txtId_familia = New System.Windows.Forms.TextBox()
        Me.lblFechaBaja = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvFamiliaPatentes = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFamiliaPatentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(298, 515)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 31)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(166, 515)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(109, 31)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTitulo)
        Me.GroupBox1.Controls.Add(Me.txtFecha_baja)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion_larga)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion_corta)
        Me.GroupBox1.Controls.Add(Me.txtId_familia)
        Me.GroupBox1.Controls.Add(Me.lblFechaBaja)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 260)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(13, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(68, 17)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Mensaje"
        '
        'txtFecha_baja
        '
        Me.txtFecha_baja.Location = New System.Drawing.Point(157, 222)
        Me.txtFecha_baja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha_baja.Name = "txtFecha_baja"
        Me.txtFecha_baja.Size = New System.Drawing.Size(108, 22)
        Me.txtFecha_baja.TabIndex = 10
        '
        'txtDescripcion_larga
        '
        Me.txtDescripcion_larga.Location = New System.Drawing.Point(157, 98)
        Me.txtDescripcion_larga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion_larga.MaxLength = 500
        Me.txtDescripcion_larga.Multiline = True
        Me.txtDescripcion_larga.Name = "txtDescripcion_larga"
        Me.txtDescripcion_larga.Size = New System.Drawing.Size(296, 115)
        Me.txtDescripcion_larga.TabIndex = 8
        '
        'txtDescripcion_corta
        '
        Me.txtDescripcion_corta.Location = New System.Drawing.Point(157, 70)
        Me.txtDescripcion_corta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion_corta.MaxLength = 30
        Me.txtDescripcion_corta.Name = "txtDescripcion_corta"
        Me.txtDescripcion_corta.Size = New System.Drawing.Size(296, 22)
        Me.txtDescripcion_corta.TabIndex = 7
        '
        'txtId_familia
        '
        Me.txtId_familia.Location = New System.Drawing.Point(157, 34)
        Me.txtId_familia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtId_familia.Name = "txtId_familia"
        Me.txtId_familia.ReadOnly = True
        Me.txtId_familia.Size = New System.Drawing.Size(89, 22)
        Me.txtId_familia.TabIndex = 6
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.AutoSize = True
        Me.lblFechaBaja.Location = New System.Drawing.Point(21, 226)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(98, 17)
        Me.lblFechaBaja.TabIndex = 4
        Me.lblFechaBaja.Text = "Fecha de baja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción larga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción corta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.dgvFamiliaPatentes)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 293)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(504, 209)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patentes"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(412, 120)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(84, 31)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(412, 74)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(84, 31)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvFamiliaPatentes
        '
        Me.dgvFamiliaPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFamiliaPatentes.Location = New System.Drawing.Point(12, 29)
        Me.dgvFamiliaPatentes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvFamiliaPatentes.Name = "dgvFamiliaPatentes"
        Me.dgvFamiliaPatentes.RowTemplate.Height = 28
        Me.dgvFamiliaPatentes.Size = New System.Drawing.Size(391, 158)
        Me.dgvFamiliaPatentes.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(563, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Familias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 573)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Familias"
        Me.Text = "Familia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvFamiliaPatentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFecha_baja As TextBox
    Friend WithEvents txtDescripcion_larga As TextBox
    Friend WithEvents txtDescripcion_corta As TextBox
    Friend WithEvents txtId_familia As TextBox
    Friend WithEvents lblFechaBaja As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvFamiliaPatentes As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
