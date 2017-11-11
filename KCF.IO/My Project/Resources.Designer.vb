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
    
    '這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    '類別透過 ResGen 或 Visual Studio 這類工具。
    '若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    '(利用 /str 選項)，或重建您的 VS 專案。
    '''<summary>
    '''  用於查詢當地語系化字串等的強類型資源類別。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  傳回這個類別使用的快取的 ResourceManager 執行個體。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SMRUCC.Chemistry.Model.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查詢類似 #NO,Symbol,Name,Atomic Weight,Notes
        '''1,H,Hydrogen,1.008,&quot;3, 5&quot;
        '''2,He,Helium,4.002 602(2),&quot;1, 2&quot;
        '''3,Li,Lithium,6.94,&quot;3, 5&quot;
        '''4,Be,Beryllium,9.012 1831(5),
        '''5,B,Boron,10.81,&quot;3, 5&quot;
        '''6,C,Carbon,12.011,5
        '''7,N,Nitrogen,14.007,5
        '''8,O,Oxygen,15.999,5
        '''9,F,Fluorine,18.998 403 163(6),
        '''10,Ne,Neon,20.1797(6),&quot;1, 3&quot;
        '''11,Na,Sodium,22.989 769 28(2),
        '''12,Mg,Magnesium,24.305,5
        '''13,Al,Aluminium,26.981 5385(7),
        '''14,Si,Silicon,28.085,5
        '''15,P,Phosphorus,30.973 761 998(5),
        '''16,S,Sulfur,32.06,5
        '''17,Cl,Chlorine,35.45,&quot;3, 5&quot;
        '''18,Ar [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        '''</summary>
        Friend ReadOnly Property AtomicWeights() As String
            Get
                Return ResourceManager.GetString("AtomicWeights", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查詢類似 +   Carbon atoms
        '''C1a R-CH3 / methyl
        '''C1b R-CH2-R / methylene
        '''C1c R-CH(-R)-R / tertiary carbon
        '''C1d R-C(-R)2-R / quaternary carbon
        '''C1x ring-CH2-ring / methylene in ring
        '''C1y ring-CH(-R)-ring / tertiary carbon in ring
        '''C1z ring-C(-R)2-ring / quaternary carbon in ring
        '''C2a R=CH2 / alkenyl terminus carbon
        '''C2b R=CH-R / alkenyl secondary carbon
        '''C2c R=C(-R)2 / alkenyl tertiary carbon
        '''C2x ring-CH=ring / alkenyl secondary carbon in ring
        '''C2y ring-C(-R)=ring / alkenyl tertiary carbon in ring
        '''C2y ring-C(=R)-rin [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        '''</summary>
        Friend ReadOnly Property KEGGAtomTypes() As String
            Get
                Return ResourceManager.GetString("KEGGAtomTypes", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
