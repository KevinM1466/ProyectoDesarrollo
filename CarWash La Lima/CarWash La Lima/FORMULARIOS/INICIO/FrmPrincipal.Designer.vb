﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMaximize = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.mzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.iconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.pnlSubMenu = New System.Windows.Forms.Panel()
        Me.btnMarcas = New FontAwesome.Sharp.IconButton()
        Me.btnTipoV = New FontAwesome.Sharp.IconButton()
        Me.btnModelos = New FontAwesome.Sharp.IconButton()
        Me.btnColor = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnOpciones = New FontAwesome.Sharp.IconButton()
        Me.btnHistorial = New FontAwesome.Sharp.IconButton()
        Me.btnEmpleados = New FontAwesome.Sharp.IconButton()
        Me.btnVehiculos = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnFacturar = New FontAwesome.Sharp.IconButton()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        Me.pnlSubMenu.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(74, 27)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(56, 18)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "INICIO"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.btnMinimize)
        Me.panelTitleBar.Controls.Add(Me.btnMaximize)
        Me.panelTitleBar.Controls.Add(Me.btnSalir)
        Me.panelTitleBar.Controls.Add(Me.label5)
        Me.panelTitleBar.Controls.Add(Me.label4)
        Me.panelTitleBar.Controls.Add(Me.label3)
        Me.panelTitleBar.Controls.Add(Me.pictureBox7)
        Me.panelTitleBar.Controls.Add(Me.mzButtonWindows2)
        Me.panelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.panelTitleBar.Controls.Add(Me.iconCurrentForm)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(223, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(1077, 76)
        Me.panelTitleBar.TabIndex = 2
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.ForeColor = System.Drawing.Color.DimGray
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.DimGray
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 26
        Me.btnMinimize.Location = New System.Drawing.Point(968, 17)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 26)
        Me.btnMinimize.TabIndex = 24
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.ForeColor = System.Drawing.Color.DimGray
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.Color.DimGray
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 26
        Me.btnMaximize.Location = New System.Drawing.Point(1000, 17)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(32, 26)
        Me.btnMaximize.TabIndex = 23
        Me.btnMaximize.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.ForeColor = System.Drawing.Color.Red
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnSalir.IconColor = System.Drawing.Color.Red
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.IconSize = 26
        Me.btnSalir.Location = New System.Drawing.Point(1033, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 26)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.TabStop = False
        '
        'label5
        '
        Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.LightGray
        Me.label5.Location = New System.Drawing.Point(841, 45)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(45, 16)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Cargo"
        '
        'label4
        '
        Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.LightGray
        Me.label4.Location = New System.Drawing.Point(841, 27)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(97, 16)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Apellidos User"
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.LightGray
        Me.label3.Location = New System.Drawing.Point(841, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 16)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Nombres "
        '
        'pictureBox7
        '
        Me.pictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox7.Location = New System.Drawing.Point(770, 5)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(65, 65)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox7.TabIndex = 18
        Me.pictureBox7.TabStop = False
        '
        'mzButtonWindows2
        '
        Me.mzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mzButtonWindows2.BackgroundImage = CType(resources.GetObject("mzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.mzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.mzButtonWindows2.Location = New System.Drawing.Point(1257, 0)
        Me.mzButtonWindows2.Name = "mzButtonWindows2"
        Me.mzButtonWindows2.ParentControl = Me
        Me.mzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.mzButtonWindows2.TabIndex = 0
        Me.mzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null
        '
        'iconCurrentForm
        '
        Me.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.iconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.iconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconCurrentForm.Location = New System.Drawing.Point(36, 21)
        Me.iconCurrentForm.Name = "iconCurrentForm"
        Me.iconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.iconCurrentForm.TabIndex = 0
        Me.iconCurrentForm.TabStop = False
        '
        'panelMenu
        '
        Me.panelMenu.AutoScroll = True
        Me.panelMenu.AutoScrollMinSize = New System.Drawing.Size(50, 50)
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.pnlSubMenu)
        Me.panelMenu.Controls.Add(Me.btnOpciones)
        Me.panelMenu.Controls.Add(Me.btnHistorial)
        Me.panelMenu.Controls.Add(Me.btnEmpleados)
        Me.panelMenu.Controls.Add(Me.btnVehiculos)
        Me.panelMenu.Controls.Add(Me.btnClientes)
        Me.panelMenu.Controls.Add(Me.btnFacturar)
        Me.panelMenu.Controls.Add(Me.imgHome)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(223, 788)
        Me.panelMenu.TabIndex = 1
        '
        'pnlSubMenu
        '
        Me.pnlSubMenu.Controls.Add(Me.btnMarcas)
        Me.pnlSubMenu.Controls.Add(Me.btnTipoV)
        Me.pnlSubMenu.Controls.Add(Me.btnModelos)
        Me.pnlSubMenu.Controls.Add(Me.btnColor)
        Me.pnlSubMenu.Controls.Add(Me.btnUsuarios)
        Me.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSubMenu.Location = New System.Drawing.Point(0, 529)
        Me.pnlSubMenu.Name = "pnlSubMenu"
        Me.pnlSubMenu.Size = New System.Drawing.Size(223, 259)
        Me.pnlSubMenu.TabIndex = 24
        '
        'btnMarcas
        '
        Me.btnMarcas.FlatAppearance.BorderSize = 0
        Me.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMarcas.IconChar = FontAwesome.Sharp.IconChar.Copyright
        Me.btnMarcas.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMarcas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMarcas.IconSize = 32
        Me.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarcas.Location = New System.Drawing.Point(3, 195)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.Padding = New System.Windows.Forms.Padding(35, 0, 20, 0)
        Me.btnMarcas.Size = New System.Drawing.Size(220, 42)
        Me.btnMarcas.TabIndex = 23
        Me.btnMarcas.Text = "MARCAS"
        Me.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMarcas.UseVisualStyleBackColor = True
        '
        'btnTipoV
        '
        Me.btnTipoV.FlatAppearance.BorderSize = 0
        Me.btnTipoV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoV.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTipoV.IconChar = FontAwesome.Sharp.IconChar.CarAlt
        Me.btnTipoV.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTipoV.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTipoV.IconSize = 32
        Me.btnTipoV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipoV.Location = New System.Drawing.Point(3, 147)
        Me.btnTipoV.Name = "btnTipoV"
        Me.btnTipoV.Padding = New System.Windows.Forms.Padding(35, 0, 20, 0)
        Me.btnTipoV.Size = New System.Drawing.Size(220, 42)
        Me.btnTipoV.TabIndex = 22
        Me.btnTipoV.Text = "TIPO DE VEHICULOS"
        Me.btnTipoV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipoV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTipoV.UseVisualStyleBackColor = True
        '
        'btnModelos
        '
        Me.btnModelos.FlatAppearance.BorderSize = 0
        Me.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModelos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnModelos.IconChar = FontAwesome.Sharp.IconChar.TruckPickup
        Me.btnModelos.IconColor = System.Drawing.Color.Gainsboro
        Me.btnModelos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModelos.IconSize = 32
        Me.btnModelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModelos.Location = New System.Drawing.Point(3, 51)
        Me.btnModelos.Name = "btnModelos"
        Me.btnModelos.Padding = New System.Windows.Forms.Padding(35, 0, 20, 0)
        Me.btnModelos.Size = New System.Drawing.Size(220, 42)
        Me.btnModelos.TabIndex = 21
        Me.btnModelos.Text = "MODELOS"
        Me.btnModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModelos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModelos.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.FlatAppearance.BorderSize = 0
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnColor.IconChar = FontAwesome.Sharp.IconChar.Tint
        Me.btnColor.IconColor = System.Drawing.Color.Gainsboro
        Me.btnColor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnColor.IconSize = 32
        Me.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor.Location = New System.Drawing.Point(3, 99)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Padding = New System.Windows.Forms.Padding(35, 0, 20, 0)
        Me.btnColor.Size = New System.Drawing.Size(220, 42)
        Me.btnColor.TabIndex = 20
        Me.btnColor.Text = "COLORES VEHICULOS"
        Me.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnUsuarios.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsuarios.IconSize = 32
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(35, 0, 20, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(220, 42)
        Me.btnUsuarios.TabIndex = 19
        Me.btnUsuarios.Text = "USUARIOS"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnOpciones
        '
        Me.btnOpciones.FlatAppearance.BorderSize = 0
        Me.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpciones.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnOpciones.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.btnOpciones.IconColor = System.Drawing.Color.Gainsboro
        Me.btnOpciones.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOpciones.IconSize = 32
        Me.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpciones.Location = New System.Drawing.Point(3, 486)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Padding = New System.Windows.Forms.Padding(10, 0, 18, 0)
        Me.btnOpciones.Size = New System.Drawing.Size(220, 42)
        Me.btnOpciones.TabIndex = 23
        Me.btnOpciones.Text = "OTRAS OPCIONES"
        Me.btnOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpciones.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnHistorial.IconColor = System.Drawing.Color.Gainsboro
        Me.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHistorial.IconSize = 32
        Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.Location = New System.Drawing.Point(3, 420)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnHistorial.Size = New System.Drawing.Size(220, 60)
        Me.btnHistorial.TabIndex = 22
        Me.btnHistorial.Text = "HISTORIAL"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.btnEmpleados.IconColor = System.Drawing.Color.Gainsboro
        Me.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmpleados.IconSize = 32
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(3, 354)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnEmpleados.Size = New System.Drawing.Size(220, 60)
        Me.btnEmpleados.TabIndex = 21
        Me.btnEmpleados.Text = "EMPLEADOS"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnVehiculos
        '
        Me.btnVehiculos.FlatAppearance.BorderSize = 0
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVehiculos.IconChar = FontAwesome.Sharp.IconChar.CarSide
        Me.btnVehiculos.IconColor = System.Drawing.Color.Gainsboro
        Me.btnVehiculos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVehiculos.IconSize = 32
        Me.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.Location = New System.Drawing.Point(3, 288)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnVehiculos.Size = New System.Drawing.Size(220, 60)
        Me.btnVehiculos.TabIndex = 20
        Me.btnVehiculos.Text = "VEHICULOS"
        Me.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnClientes.IconColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClientes.IconSize = 32
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(3, 222)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnClientes.Size = New System.Drawing.Size(220, 60)
        Me.btnClientes.TabIndex = 19
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.FlatAppearance.BorderSize = 0
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt
        Me.btnFacturar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFacturar.IconSize = 32
        Me.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturar.Location = New System.Drawing.Point(3, 156)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnFacturar.Size = New System.Drawing.Size(220, 60)
        Me.btnFacturar.TabIndex = 18
        Me.btnFacturar.Text = "FACTURAR"
        Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'imgHome
        '
        Me.imgHome.Image = Global.CarWash_La_Lima.My.Resources.Resources._23667483
        Me.imgHome.Location = New System.Drawing.Point(12, 27)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(176, 104)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 6
        Me.imgHome.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.pictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(223, 76)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1077, 712)
        Me.PanelDesktop.TabIndex = 3
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox2.Image = Global.CarWash_La_Lima.My.Resources.Resources._23667483
        Me.pictureBox2.Location = New System.Drawing.Point(333, 215)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(438, 231)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 8
        Me.pictureBox2.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 788)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.pnlSubMenu.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents iconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Private WithEvents lblFormTitle As Label
    Private WithEvents mzButtonWindows2 As BWCMM.MZButtonWindows
    Private WithEvents panelTitleBar As Panel
    Private WithEvents panelMenu As Panel
    Private WithEvents imgHome As PictureBox
    Friend WithEvents btnHistorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVehiculos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFacturar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Private WithEvents btnMaximize As FontAwesome.Sharp.IconPictureBox
    Private WithEvents btnMinimize As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlSubMenu As Panel
    Friend WithEvents btnTipoV As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModelos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnColor As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOpciones As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarcas As FontAwesome.Sharp.IconButton
End Class
