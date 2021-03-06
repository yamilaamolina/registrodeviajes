﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __ChoferSetListDetail = LightSwitchApplication.ChoferSetListDetail

Namespace LightSwitchApplication

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
    Partial Public NotInheritable Class ChoferSetListDetail
        Inherits Global.Microsoft.LightSwitch.Framework.Client.ScreenObject(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass)

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private Sub New()
            MyBase.New("LightSwitchApplication.RegistroDeViajes.DesktopClient:ChoferSetListDetail")
            __ChoferSetListDetail.DetailsClass.Initialize(Me)
        End Sub

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        Public Shared Function CreateInstance() As ChoferSetListDetail
            Return New __ChoferSetListDetail( _
            )
        End Function

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_Activated()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_Saving(ByRef handled As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_Saved()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_Closing(ByRef cancel As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSetListDetail_SaveError(ByVal exception As Global.System.Exception, ByRef handled As Boolean)
        End Sub
     
        #Region "Private Properties"
        
        ''' <summary>
        ''' Obtiene el objeto Application para esta aplicación. El objeto Application proporciona acceso a pantallas activas, métodos para abrir pantallas y acceso al usuario actual.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.LightSwitchApplication.Application
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Obtiene el área de trabajo de datos contenedora. Dicha área proporciona acceso a todos los orígenes de datos de la aplicación.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(DirectCast(Me.Details, Global.Microsoft.LightSwitch.Details.Client.IScreenDetails).DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
 
        Partial Private Sub ChoferSet_SelectionChanged()
        End Sub

        Partial Private Sub ChoferSet_Changed(ByVal e As Global.System.Collections.Specialized.NotifyCollectionChangedEventArgs)
        End Sub

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSet_Loaded(ByVal succeeded As Boolean)
        End Sub

        Partial Private Sub ViajeCollection_SelectionChanged()
        End Sub

        Partial Private Sub ViajeCollection_Changed(ByVal e As Global.System.Collections.Specialized.NotifyCollectionChangedEventArgs)
        End Sub

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ViajeCollection_Loaded(ByVal succeeded As Boolean)
        End Sub

        ''' <summary>
        ''' Obtiene la colección visual ChoferSet. La colección contiene todos los registros que se muestran actualmente en el control de cuadrícula o lista respectivo.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property ChoferSet As Global.Microsoft.LightSwitch.Framework.Client.VisualCollection(Of Global.LightSwitchApplication.Chofer)
            Get
                Return __ChoferSetListDetail.DetailsClass.GetValue(Me, __ChoferSetListDetail.DetailsClass.PropertySetProperties.ChoferSet)
            End Get
        End Property
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ChoferSet_Validate(ByVal results As Global.Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder)
        End Sub
 
        ''' <summary>
        ''' Obtiene la colección visual ViajeCollection. La colección contiene todos los registros que se muestran actualmente en el control de cuadrícula o lista respectivo.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property ViajeCollection As Global.Microsoft.LightSwitch.Framework.Client.VisualCollection(Of Global.LightSwitchApplication.Viaje)
            Get
                Return __ChoferSetListDetail.DetailsClass.GetValue(Me, __ChoferSetListDetail.DetailsClass.PropertySetProperties.ViajeCollection)
            End Get
        End Property
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ViajeCollection_Validate(ByVal results As Global.Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder)
        End Sub
 
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, __ChoferSetListDetail.DetailsClass.PropertySet, __ChoferSetListDetail.DetailsClass.CommandSet, __ChoferSetListDetail.DetailsClass.MethodSet)

            Shared Sub New()
                Dim initializePropertyEntry = __ChoferSetListDetail.DetailsClass.PropertySetProperties.ChoferSet
            End Sub

            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __ChoferSetListDetailEntry As Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass).Entry( _
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeInitializeDataWorkspace,
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeSavingEvent,
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeSavedEvent,
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeClosingEvent,
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeCreated,
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeActivated,
                    AddressOf __ChoferSetListDetail.DetailsClass.__ChoferSetListDetail_InvokeSaveErrorEvent)
            Private Shared Sub __ChoferSetListDetail_InvokeInitializeDataWorkspace(s As __ChoferSetListDetail, saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
                s.ChoferSetListDetail_InitializeDataWorkspace(saveChangesTo)
            End Sub
            Private Shared Function __ChoferSetListDetail_InvokeSavingEvent(s As __ChoferSetListDetail) As Boolean
                Dim handled = False
                s.ChoferSetListDetail_Saving(handled)
                Return handled
            End Function
            Private Shared Sub __ChoferSetListDetail_InvokeSavedEvent(s As __ChoferSetListDetail)
                s.ChoferSetListDetail_Saved()
            End Sub
            Private Shared Function __ChoferSetListDetail_InvokeClosingEvent(s As __ChoferSetListDetail) As Boolean
                Dim cancel = False
                s.ChoferSetListDetail_Closing(cancel)
                Return cancel
            End Function
            Private Shared Sub __ChoferSetListDetail_InvokeCreated(s As __ChoferSetListDetail)
                s.ChoferSetListDetail_Created()
            End Sub
            Private Shared Sub __ChoferSetListDetail_InvokeActivated(s As __ChoferSetListDetail)
                s.ChoferSetListDetail_Activated()
            End Sub
            Private Shared Function __ChoferSetListDetail_InvokeSaveErrorEvent(s As __ChoferSetListDetail, ex As Global.System.Exception) As Boolean
                Dim handled = False
                s.ChoferSetListDetail_SaveError(ex, handled)
                Return handled
            End Function

            Public Sub New()
                MyBase.New()
            End Sub

            Public Shadows ReadOnly Property Properties As __ChoferSetListDetail.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property

            Public Shadows ReadOnly Property Commands As __ChoferSetListDetail.DetailsClass.CommandSet
                Get
                    Return MyBase.Commands
                End Get
            End Property

            Public Shadows ReadOnly Property Methods As __ChoferSetListDetail.DetailsClass.MethodSet
                Get
                    Return MyBase.Methods
                End Get
            End Property

            Private Function ChoferSetQuery() As Global.Microsoft.LightSwitch.IDataServiceQueryable
                Return Me.Screen.DataWorkspace.ApplicationData.ChoferSet
            End Function

            Private Function ViajeCollectionQuery() As Global.Microsoft.LightSwitch.IDataServiceQueryable
                If Me.Screen.ChoferSet.SelectedItem Is Nothing Then
                    Return Nothing
                End If

                Dim loader As Global.Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Viaje) = _
                    DirectCast(DirectCast(Me.Screen.ChoferSet.SelectedItem.Details.Properties.ViajeCollection, Global.Microsoft.LightSwitch.Details.ILoadableProperty).Loader, Global.Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Viaje))
                If loader Is Nothing Then
                    Return Nothing
                End If

                Return loader
            End Function

            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)>
            Private _ChoferSet As Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Chofer).Data

            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)>
            Private _ViajeCollection As Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Viaje).Data

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenPropertySet(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass)

                Public ReadOnly Property ChoferSet As Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Chofer)
                    Get
                        Return DirectCast(MyBase.GetItem(__ChoferSetListDetail.DetailsClass.PropertySetProperties.ChoferSet), Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Chofer))
                    End Get
                End Property

                Public ReadOnly Property ViajeCollection As Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Viaje)
                    Get
                        Return DirectCast(MyBase.GetItem(__ChoferSetListDetail.DetailsClass.PropertySetProperties.ViajeCollection), Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Viaje))
                    End Get
                End Property

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class CommandSet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCommandSet(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass)
            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class MethodSet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenMethodSet(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass)
            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class PropertySetProperties

                Public Shared ReadOnly ChoferSet As New Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Chofer).Entry( _
                    "ChoferSet",
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ChoferSet_Stub,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ChoferSet_Validate,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ChoferSet_CreateQuery,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ChoferSet_SelectionChanged,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ChoferSet_OnCollectionChanged,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ChoferSet_OnLoaded)
                Private Shared Sub _ChoferSet_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __ChoferSetListDetail.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Chofer).Data), d As __ChoferSetListDetail.DetailsClass, sf As Object)
                    c(d, d._ChoferSet, sf)
                End Sub
                Private Shared Sub _ChoferSet_Validate(s As __ChoferSetListDetail, r As Global.Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder)
                    s.ChoferSet_Validate(r)
                End Sub
                Private Shared Function _ChoferSet_CreateQuery(d As __ChoferSetListDetail.DetailsClass, args As Object()) As Global.Microsoft.LightSwitch.IDataServiceQueryable
                    Return d.ChoferSetQuery()
                End Function
                Private Shared Sub _ChoferSet_SelectionChanged(s As __ChoferSetListDetail)
                    s.ChoferSet_SelectionChanged()
                End Sub
                Private Shared Sub _ChoferSet_OnCollectionChanged(s As __ChoferSetListDetail, e As Global.System.Collections.Specialized.NotifyCollectionChangedEventArgs)
                    s.ChoferSet_Changed(e)
                End Sub
                Private Shared Sub _ChoferSet_OnLoaded(s As __ChoferSetListDetail, succeeded As Boolean)
                    s.ChoferSet_Loaded(succeeded)
                End Sub

                Public Shared ReadOnly ViajeCollection As New Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Viaje).Entry( _
                    "ViajeCollection",
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ViajeCollection_Stub,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ViajeCollection_Validate,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ViajeCollection_CreateQuery,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ViajeCollection_SelectionChanged,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ViajeCollection_OnCollectionChanged,
                    AddressOf __ChoferSetListDetail.DetailsClass.PropertySetProperties._ViajeCollection_OnLoaded)
                Private Shared Sub _ViajeCollection_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __ChoferSetListDetail.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty(Of __ChoferSetListDetail, __ChoferSetListDetail.DetailsClass, Global.LightSwitchApplication.Viaje).Data), d As __ChoferSetListDetail.DetailsClass, sf As Object)
                    c(d, d._ViajeCollection, sf)
                End Sub
                Private Shared Sub _ViajeCollection_Validate(s As __ChoferSetListDetail, r As Global.Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder)
                    s.ViajeCollection_Validate(r)
                End Sub
                Private Shared Function _ViajeCollection_CreateQuery(d As __ChoferSetListDetail.DetailsClass, args As Object()) As Global.Microsoft.LightSwitch.IDataServiceQueryable
                    Return d.ViajeCollectionQuery()
                End Function
                Private Shared Sub _ViajeCollection_SelectionChanged(s As __ChoferSetListDetail)
                    s.ViajeCollection_SelectionChanged()
                End Sub
                Private Shared Sub _ViajeCollection_OnCollectionChanged(s As __ChoferSetListDetail, e As Global.System.Collections.Specialized.NotifyCollectionChangedEventArgs)
                    s.ViajeCollection_Changed(e)
                End Sub
                Private Shared Sub _ViajeCollection_OnLoaded(s As __ChoferSetListDetail, succeeded As Boolean)
                    s.ViajeCollection_Loaded(succeeded)
                End Sub

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class CommandSetProperties
            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class MethodSetProperties
            End Class

        End Class

    End Class

End Namespace
