﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("risersoft.unitcad.iv.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property BrowseForFile() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("BrowseForFile", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit Formula.
        '''</summary>
        Friend ReadOnly Property ContextMenu_EditFormula() As String
            Get
                Return ResourceManager.GetString("ContextMenu_EditFormula", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit Value.
        '''</summary>
        Friend ReadOnly Property ContextMenu_EditValue() As String
            Get
                Return ResourceManager.GetString("ContextMenu_EditValue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Greater than the specified maximum value of {0}.
        '''</summary>
        Friend ReadOnly Property Error_GreaterThanMax() As String
            Get
                Return ResourceManager.GetString("Error_GreaterThanMax", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Less than the specified minimum value of {0}.
        '''</summary>
        Friend ReadOnly Property Error_LessThanMin() As String
            Get
                Return ResourceManager.GetString("Error_LessThanMin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Must be a numeric value.
        '''</summary>
        Friend ReadOnly Property Error_NotNumeric() As String
            Get
                Return ResourceManager.GetString("Error_NotNumeric", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to False.
        '''</summary>
        Friend ReadOnly Property FalseString() As String
            Get
                Return ResourceManager.GetString("FalseString", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Filter2HS() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Filter2HS", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property FormulaModeIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("FormulaModeIcon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property HelpButtonIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("HelpButtonIcon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property Properties_View_Alpha() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Properties_View_Alpha", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property Properties_ViewGrouped() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Properties_ViewGrouped", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Formula: .
        '''</summary>
        Friend ReadOnly Property Rule_FormulaTitle() As String
            Get
                Return ResourceManager.GetString("Rule_FormulaTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unevaluated.
        '''</summary>
        Friend ReadOnly Property Rule_Unevaluated() As String
            Get
                Return ResourceManager.GetString("Rule_Unevaluated", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Value: .
        '''</summary>
        Friend ReadOnly Property Rule_ValueTitle() As String
            Get
                Return ResourceManager.GetString("Rule_ValueTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to True.
        '''</summary>
        Friend ReadOnly Property TrueString() As String
            Get
                Return ResourceManager.GetString("TrueString", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property WarningIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("WarningIcon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
    End Module
End Namespace
