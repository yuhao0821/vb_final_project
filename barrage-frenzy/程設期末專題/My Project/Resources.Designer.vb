﻿'------------------------------------------------------------------------------
' <auto-generated>
'     這段程式碼是由工具產生的。
'     執行階段版本:4.0.30319.42000
'
'     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
'     變更將會遺失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    '類別透過 ResGen 或 Visual Studio 這類工具。
    '若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    '(利用 /str 選項)，或重建您的 VS 專案。
    '''<summary>
    '''  用於查詢當地語系化字串等的強類型資源類別。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  傳回這個類別使用的快取的 ResourceManager 執行個體。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("程設期末專題.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        '''  使用這個強類型資源類別的資源查閱。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查詢類似 System.IO.MemoryStream 的類型 System.IO.UnmanagedMemoryStream 當地語系化資源。
        '''</summary>
        Public ReadOnly Property Bullet_hit() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Bullet_hit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類似 System.IO.MemoryStream 的類型 System.IO.UnmanagedMemoryStream 當地語系化資源。
        '''</summary>
        Public ReadOnly Property die() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("die", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類似 System.IO.MemoryStream 的類型 System.IO.UnmanagedMemoryStream 當地語系化資源。
        '''</summary>
        Public ReadOnly Property GameMusic() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("GameMusic", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類似 System.IO.MemoryStream 的類型 System.IO.UnmanagedMemoryStream 當地語系化資源。
        '''</summary>
        Public ReadOnly Property moving() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("moving", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property questionmark() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("questionmark", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property select_map() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("select_map", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類似 System.IO.MemoryStream 的類型 System.IO.UnmanagedMemoryStream 當地語系化資源。
        '''</summary>
        Public ReadOnly Property shooting() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("shooting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 土地() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("土地", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 地圖1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("地圖1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 柱子() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("柱子", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 玩家提示() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("玩家提示", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 空島1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("空島1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 空島2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("空島2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 空島3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("空島3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 空島4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("空島4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 箱子() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("箱子", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅_bang() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅_bang", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅_拿槍() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅_拿槍", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅_拿槍_翻轉() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅_拿槍_翻轉", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅1bang() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅1bang", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅1dead() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅1dead", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅2bang() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅2bang", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 紅2dead() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("紅2dead", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類似 System.IO.MemoryStream 的類型 System.IO.UnmanagedMemoryStream 當地語系化資源。
        '''</summary>
        Public ReadOnly Property 結算() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("結算", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 背景() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("背景", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍_bang() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍_bang", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍_拿槍() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍_拿槍", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍_拿槍_翻轉() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍_拿槍_翻轉", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍1bang() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍1bang", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍1dead() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍1dead", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍2bang() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍2bang", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        '''</summary>
        Public ReadOnly Property 藍2dead() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("藍2dead", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
