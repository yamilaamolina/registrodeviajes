﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __CustomerCustomerDemoItem = LightSwitchApplication.CustomerCustomerDemoItem

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No hay ninguna descripción modelada
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
    Public NotInheritable Partial Class CustomerCustomerDemoItem
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Inicializa una nueva instancia de la entidad CustomerCustomerDemoItem.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __CustomerCustomerDemoItem))
            MyBase.New(entitySet)
            
            __CustomerCustomerDemoItem.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerCustomerDemoItem_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerCustomerDemoItem_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Obtiene el objeto Application para esta aplicación. El objeto Application proporciona acceso a pantallas activas, métodos para abrir pantallas y acceso al usuario actual.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return TryCast(Global.LightSwitchApplication.Application.Current, Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace))
            End Get
        End Property
        
        ''' <summary>
        ''' Obtiene el área de trabajo de datos contenedora. Dicha área proporciona acceso a todos los orígenes de datos de la aplicación.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No hay ninguna descripción modelada
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property CustomerID As String
            Get
                Return __CustomerCustomerDemoItem.DetailsClass.GetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerID)
            End Get
            Set
                __CustomerCustomerDemoItem.DetailsClass.SetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerID, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerID_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerID_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerID_Changed()
        End Sub

        ''' <summary>
        ''' No hay ninguna descripción modelada
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property CustomerTypeID As String
            Get
                Return __CustomerCustomerDemoItem.DetailsClass.GetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerTypeID)
            End Get
            Set
                __CustomerCustomerDemoItem.DetailsClass.SetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerTypeID, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerTypeID_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerTypeID_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerTypeID_Changed()
        End Sub

        ''' <summary>
        ''' No hay ninguna descripción modelada
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property CustomerDemographicsItem As Global.LightSwitchApplication.CustomerDemographicsItem
            Get
                Return __CustomerCustomerDemoItem.DetailsClass.GetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerDemographicsItem)
            End Get
            Set
                __CustomerCustomerDemoItem.DetailsClass.SetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerDemographicsItem, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerDemographicsItem_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerDemographicsItem_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomerDemographicsItem_Changed()
        End Sub

        ''' <summary>
        ''' No hay ninguna descripción modelada
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property CustomersItem As Global.LightSwitchApplication.CustomersItem
            Get
                Return __CustomerCustomerDemoItem.DetailsClass.GetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomersItem)
            End Get
            Set
                __CustomerCustomerDemoItem.DetailsClass.SetValue(Me, __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomersItem, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomersItem_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomersItem_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub CustomersItem_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __CustomerCustomerDemoItem, _
                __CustomerCustomerDemoItem.DetailsClass, _
                __CustomerCustomerDemoItem.DetailsClass.IImplementation, _
                __CustomerCustomerDemoItem.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerID
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __CustomerCustomerDemoItemEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass).Entry( _
                    AddressOf __CustomerCustomerDemoItem.DetailsClass.__CustomerCustomerDemoItem_CreateNew, _
                    AddressOf __CustomerCustomerDemoItem.DetailsClass.__CustomerCustomerDemoItem_Created, _
                    AddressOf __CustomerCustomerDemoItem.DetailsClass.__CustomerCustomerDemoItem_AllowSaveWithErrors)
            Private Shared Function __CustomerCustomerDemoItem_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __CustomerCustomerDemoItem)) As __CustomerCustomerDemoItem
                Return New __CustomerCustomerDemoItem(es)
            End Function
            Private Shared Sub __CustomerCustomerDemoItem_Created(e As __CustomerCustomerDemoItem)
                e.CustomerCustomerDemoItem_Created()
            End Sub
            Private Shared Function __CustomerCustomerDemoItem_AllowSaveWithErrors(e As __CustomerCustomerDemoItem) As Boolean
                Dim result As Boolean = False
                e.CustomerCustomerDemoItem_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __CustomerCustomerDemoItem.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property CustomerID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerID),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property CustomerTypeID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerTypeID),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property CustomerDemographicsItem As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomerDemographicsItem)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerDemographicsItem),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomerDemographicsItem))
                    End Get
                End Property
                
                Public ReadOnly Property CustomersItem As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomersItem)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomersItem),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomersItem))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property CustomerID As String
                Shadows Property CustomerTypeID As String
                Shadows Property CustomerDemographicsItem As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                Shadows Property CustomersItem As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly CustomerID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Entry( _
                        "CustomerID", _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerID_Stub, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerID_ComputeIsReadOnly, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerID_Validate, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerID_GetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerID_SetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerID_OnValueChanged)
                Private Shared Sub _CustomerID_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __CustomerCustomerDemoItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Data), d As __CustomerCustomerDemoItem.DetailsClass, sf As Object)
                    c(d, d._CustomerID, sf)
                End Sub
                Private Shared Function _CustomerID_ComputeIsReadOnly(e As __CustomerCustomerDemoItem) As Boolean
                    Dim result As Boolean = False
                    e.CustomerID_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _CustomerID_Validate(e As __CustomerCustomerDemoItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.CustomerID_Validate(r)
                End Sub
                Private Shared Function _CustomerID_GetImplementationValue(d As __CustomerCustomerDemoItem.DetailsClass) As String
                    Return d.ImplementationEntity.CustomerID
                End Function
                Private Shared Sub _CustomerID_SetImplementationValue(d As __CustomerCustomerDemoItem.DetailsClass, v As String)
                    d.ImplementationEntity.CustomerID = v
                End Sub
                Private Shared Sub _CustomerID_OnValueChanged(e As __CustomerCustomerDemoItem)
                    e.CustomerID_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly CustomerTypeID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Entry( _
                        "CustomerTypeID", _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerTypeID_Stub, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerTypeID_ComputeIsReadOnly, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerTypeID_Validate, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerTypeID_GetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerTypeID_SetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerTypeID_OnValueChanged)
                Private Shared Sub _CustomerTypeID_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __CustomerCustomerDemoItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Data), d As __CustomerCustomerDemoItem.DetailsClass, sf As Object)
                    c(d, d._CustomerTypeID, sf)
                End Sub
                Private Shared Function _CustomerTypeID_ComputeIsReadOnly(e As __CustomerCustomerDemoItem) As Boolean
                    Dim result As Boolean = False
                    e.CustomerTypeID_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _CustomerTypeID_Validate(e As __CustomerCustomerDemoItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.CustomerTypeID_Validate(r)
                End Sub
                Private Shared Function _CustomerTypeID_GetImplementationValue(d As __CustomerCustomerDemoItem.DetailsClass) As String
                    Return d.ImplementationEntity.CustomerTypeID
                End Function
                Private Shared Sub _CustomerTypeID_SetImplementationValue(d As __CustomerCustomerDemoItem.DetailsClass, v As String)
                    d.ImplementationEntity.CustomerTypeID = v
                End Sub
                Private Shared Sub _CustomerTypeID_OnValueChanged(e As __CustomerCustomerDemoItem)
                    e.CustomerTypeID_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly CustomerDemographicsItem As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomerDemographicsItem).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomerDemographicsItem).Entry( _
                        "CustomerDemographicsItem", _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_Stub, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_ComputeIsReadOnly, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_Validate, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_GetCoreImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_GetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_SetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_Refresh, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomerDemographicsItem_OnValueChanged)
                Private Shared Sub _CustomerDemographicsItem_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __CustomerCustomerDemoItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomerDemographicsItem).Data), d As __CustomerCustomerDemoItem.DetailsClass, sf As Object)
                    c(d, d._CustomerDemographicsItem, sf)
                End Sub
                Private Shared Function _CustomerDemographicsItem_ComputeIsReadOnly(e As __CustomerCustomerDemoItem) As Boolean
                    Dim result As Boolean = False
                    e.CustomerDemographicsItem_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _CustomerDemographicsItem_Validate(e As __CustomerCustomerDemoItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.CustomerDemographicsItem_Validate(r)
                End Sub
                Private Shared Function _CustomerDemographicsItem_GetCoreImplementationValue(d as __CustomerCustomerDemoItem.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.CustomerDemographicsItem
                End Function
                Private Shared Function _CustomerDemographicsItem_GetImplementationValue(d as __CustomerCustomerDemoItem.DetailsClass) As Global.LightSwitchApplication.CustomerDemographicsItem
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.CustomerDemographicsItem, Global.LightSwitchApplication.CustomerDemographicsItem.DetailsClass)(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerDemographicsItem, d._CustomerDemographicsItem)
                End Function
                Private Shared Sub _CustomerDemographicsItem_SetImplementationValue(d As __CustomerCustomerDemoItem.DetailsClass, v As Global.LightSwitchApplication.CustomerDemographicsItem)
                    d.SetImplementationValue(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerDemographicsItem, d._CustomerDemographicsItem, Sub(i, ev) i.CustomerDemographicsItem = ev, v)
                End Sub
                Private Shared Sub _CustomerDemographicsItem_Refresh(d As __CustomerCustomerDemoItem.DetailsClass)
                    d.RefreshNavigationProperty(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomerDemographicsItem, d._CustomerDemographicsItem)
                End Sub
                Private Shared Sub _CustomerDemographicsItem_OnValueChanged(e As __CustomerCustomerDemoItem)
                    e.CustomerDemographicsItem_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly CustomersItem As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomersItem).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomersItem).Entry( _
                        "CustomersItem", _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_Stub, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_ComputeIsReadOnly, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_Validate, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_GetCoreImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_GetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_SetImplementationValue, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_Refresh, _
                        AddressOf __CustomerCustomerDemoItem.DetailsClass.PropertySetProperties._CustomersItem_OnValueChanged)
                Private Shared Sub _CustomersItem_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __CustomerCustomerDemoItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomersItem).Data), d As __CustomerCustomerDemoItem.DetailsClass, sf As Object)
                    c(d, d._CustomersItem, sf)
                End Sub
                Private Shared Function _CustomersItem_ComputeIsReadOnly(e As __CustomerCustomerDemoItem) As Boolean
                    Dim result As Boolean = False
                    e.CustomersItem_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _CustomersItem_Validate(e As __CustomerCustomerDemoItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.CustomersItem_Validate(r)
                End Sub
                Private Shared Function _CustomersItem_GetCoreImplementationValue(d as __CustomerCustomerDemoItem.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.CustomersItem
                End Function
                Private Shared Function _CustomersItem_GetImplementationValue(d as __CustomerCustomerDemoItem.DetailsClass) As Global.LightSwitchApplication.CustomersItem
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.CustomersItem, Global.LightSwitchApplication.CustomersItem.DetailsClass)(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomersItem, d._CustomersItem)
                End Function
                Private Shared Sub _CustomersItem_SetImplementationValue(d As __CustomerCustomerDemoItem.DetailsClass, v As Global.LightSwitchApplication.CustomersItem)
                    d.SetImplementationValue(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomersItem, d._CustomersItem, Sub(i, ev) i.CustomersItem = ev, v)
                End Sub
                Private Shared Sub _CustomersItem_Refresh(d As __CustomerCustomerDemoItem.DetailsClass)
                    d.RefreshNavigationProperty(__CustomerCustomerDemoItem.DetailsClass.PropertySetProperties.CustomersItem, d._CustomersItem)
                End Sub
                Private Shared Sub _CustomersItem_OnValueChanged(e As __CustomerCustomerDemoItem)
                    e.CustomersItem_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _CustomerID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _CustomerTypeID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _CustomerDemographicsItem As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomerDemographicsItem).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _CustomersItem As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __CustomerCustomerDemoItem, __CustomerCustomerDemoItem.DetailsClass, Global.LightSwitchApplication.CustomersItem).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
