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

Imports __RegionItem = LightSwitchApplication.RegionItem

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No hay ninguna descripción modelada
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
    Public NotInheritable Partial Class RegionItem
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __RegionItem, __RegionItem.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Inicializa una nueva instancia de la entidad RegionItem.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __RegionItem))
            MyBase.New(entitySet)
            
            __RegionItem.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionItem_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionItem_AllowSaveWithErrors(ByRef result As Boolean)
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
        Public Property RegionID As Integer
            Get
                Return __RegionItem.DetailsClass.GetValue(Me, __RegionItem.DetailsClass.PropertySetProperties.RegionID)
            End Get
            Set
                __RegionItem.DetailsClass.SetValue(Me, __RegionItem.DetailsClass.PropertySetProperties.RegionID, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionID_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionID_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionID_Changed()
        End Sub

        ''' <summary>
        ''' No hay ninguna descripción modelada
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RegionDescription As String
            Get
                Return __RegionItem.DetailsClass.GetValue(Me, __RegionItem.DetailsClass.PropertySetProperties.RegionDescription)
            End Get
            Set
                __RegionItem.DetailsClass.SetValue(Me, __RegionItem.DetailsClass.PropertySetProperties.RegionDescription, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionDescription_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionDescription_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RegionDescription_Changed()
        End Sub

        ''' <summary>
        ''' No hay ninguna descripción modelada
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property Territories As Global.Microsoft.LightSwitch.Framework.EntityCollection(Of Global.LightSwitchApplication.TerritoriesItem)
            Get
                Return __RegionItem.DetailsClass.GetValue(Me, __RegionItem.DetailsClass.PropertySetProperties.Territories)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property TerritoriesQuery As Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.TerritoriesItem)
            Get
                Return __RegionItem.DetailsClass.GetQuery(Me, __RegionItem.DetailsClass.PropertySetProperties.Territories)
            End Get
        End Property

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __RegionItem, _
                __RegionItem.DetailsClass, _
                __RegionItem.DetailsClass.IImplementation, _
                __RegionItem.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __RegionItem, __RegionItem.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __RegionItem, __RegionItem.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __RegionItem.DetailsClass.PropertySetProperties.RegionID
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __RegionItemEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __RegionItem, __RegionItem.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __RegionItem, __RegionItem.DetailsClass).Entry( _
                    AddressOf __RegionItem.DetailsClass.__RegionItem_CreateNew, _
                    AddressOf __RegionItem.DetailsClass.__RegionItem_Created, _
                    AddressOf __RegionItem.DetailsClass.__RegionItem_AllowSaveWithErrors)
            Private Shared Function __RegionItem_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __RegionItem)) As __RegionItem
                Return New __RegionItem(es)
            End Function
            Private Shared Sub __RegionItem_Created(e As __RegionItem)
                e.RegionItem_Created()
            End Sub
            Private Shared Function __RegionItem_AllowSaveWithErrors(e As __RegionItem) As Boolean
                Dim result As Boolean = False
                e.RegionItem_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __RegionItem, __RegionItem.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __RegionItem, __RegionItem.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __RegionItem.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __RegionItem, __RegionItem.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property RegionID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__RegionItem.DetailsClass.PropertySetProperties.RegionID),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RegionDescription As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__RegionItem.DetailsClass.PropertySetProperties.RegionDescription),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Territories As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __RegionItem, __RegionItem.DetailsClass, Global.LightSwitchApplication.TerritoriesItem)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__RegionItem.DetailsClass.PropertySetProperties.Territories),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __RegionItem, __RegionItem.DetailsClass, Global.LightSwitchApplication.TerritoriesItem))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property RegionID As Integer
                Shadows Property RegionDescription As String
                Shadows ReadOnly Property Territories As Global.System.Collections.IEnumerable
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RegionID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, Integer).Entry( _
                        "RegionID", _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionID_Stub, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionID_ComputeIsReadOnly, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionID_Validate, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionID_GetImplementationValue, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionID_SetImplementationValue, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionID_OnValueChanged)
                Private Shared Sub _RegionID_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __RegionItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, Integer).Data), d As __RegionItem.DetailsClass, sf As Object)
                    c(d, d._RegionID, sf)
                End Sub
                Private Shared Function _RegionID_ComputeIsReadOnly(e As __RegionItem) As Boolean
                    Dim result As Boolean = False
                    e.RegionID_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RegionID_Validate(e As __RegionItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RegionID_Validate(r)
                End Sub
                Private Shared Function _RegionID_GetImplementationValue(d As __RegionItem.DetailsClass) As Integer
                    Return d.ImplementationEntity.RegionID
                End Function
                Private Shared Sub _RegionID_SetImplementationValue(d As __RegionItem.DetailsClass, v As Integer)
                    d.ImplementationEntity.RegionID = v
                End Sub
                Private Shared Sub _RegionID_OnValueChanged(e As __RegionItem)
                    e.RegionID_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RegionDescription As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, String).Entry( _
                        "RegionDescription", _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionDescription_Stub, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionDescription_ComputeIsReadOnly, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionDescription_Validate, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionDescription_GetImplementationValue, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionDescription_SetImplementationValue, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._RegionDescription_OnValueChanged)
                Private Shared Sub _RegionDescription_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __RegionItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, String).Data), d As __RegionItem.DetailsClass, sf As Object)
                    c(d, d._RegionDescription, sf)
                End Sub
                Private Shared Function _RegionDescription_ComputeIsReadOnly(e As __RegionItem) As Boolean
                    Dim result As Boolean = False
                    e.RegionDescription_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RegionDescription_Validate(e As __RegionItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RegionDescription_Validate(r)
                End Sub
                Private Shared Function _RegionDescription_GetImplementationValue(d As __RegionItem.DetailsClass) As String
                    Return d.ImplementationEntity.RegionDescription
                End Function
                Private Shared Sub _RegionDescription_SetImplementationValue(d As __RegionItem.DetailsClass, v As String)
                    d.ImplementationEntity.RegionDescription = v
                End Sub
                Private Shared Sub _RegionDescription_OnValueChanged(e As __RegionItem)
                    e.RegionDescription_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Territories As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __RegionItem, __RegionItem.DetailsClass, Global.LightSwitchApplication.TerritoriesItem).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __RegionItem, __RegionItem.DetailsClass, Global.LightSwitchApplication.TerritoriesItem).Entry( _
                        "Territories", _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._Territories_Stub, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._Territories_GetReferencedEntities, _
                        AddressOf __RegionItem.DetailsClass.PropertySetProperties._Territories_GetEntityCollection)
                Private Shared Sub _Territories_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __RegionItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __RegionItem, __RegionItem.DetailsClass, Global.LightSwitchApplication.TerritoriesItem).Data), d As __RegionItem.DetailsClass, sf As Object)
                    c(d, d._Territories, sf)
                End Sub
                Private Shared Function _Territories_GetReferencedEntities(d As __RegionItem.DetailsClass) As Global.System.Collections.Generic.IEnumerable(Of Global.LightSwitchApplication.TerritoriesItem)
                    Return d.GetReferencedEntities(Of Global.LightSwitchApplication.TerritoriesItem, Global.LightSwitchApplication.TerritoriesItem.DetailsClass)(__RegionItem.DetailsClass.PropertySetProperties.Territories, d._Territories)
                End Function
                Private Shared Function _Territories_GetEntityCollection(d As __RegionItem.DetailsClass) As Global.System.Collections.IEnumerable
                    Return d.ImplementationEntity.Territories
                End Function
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RegionID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RegionDescription As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __RegionItem, __RegionItem.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Territories As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __RegionItem, __RegionItem.DetailsClass, Global.LightSwitchApplication.TerritoriesItem).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
