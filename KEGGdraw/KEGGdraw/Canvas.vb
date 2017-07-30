﻿Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Imaging
Imports Microsoft.VisualBasic.Imaging.Drawing2D
Imports Microsoft.VisualBasic.Imaging.Drawing2D.Vector.Shapes
Imports Microsoft.VisualBasic.Imaging.Driver
Imports Microsoft.VisualBasic.MIME.Markup.HTML.CSS
Imports Microsoft.VisualBasic.Scripting.Runtime

Public Module Canvas

    ''' <summary>
    ''' Draw the 2D chemical structure
    ''' </summary>
    ''' <param name="kcf"></param>
    ''' <param name="size$"></param>
    ''' <param name="padding$"></param>
    ''' <param name="bg$"></param>
    ''' <param name="font$"></param>
    ''' <returns></returns>
    <Extension>
    Public Function Draw(kcf As KCF,
                         Optional size$ = "800,800",
                         Optional padding$ = g.DefaultPadding,
                         Optional bg$ = "white",
                         Optional font$ = CSSFont.Win7Normal) As GraphicsData

        Dim atomFont As Font = CSSFont.TryParse(font).GDIObject
        Dim dot = Brushes.Gray
        Dim atoms As (pt As PointF, atom$, index%)() =
            kcf _
            .Atoms _
            .Select(Function(a)
                        With a.Atom2D_coordinates
                            Dim pt As New PointF(.X, .Y * -1)
                            Return (pt:=pt, Atom:=a.KEGGAtom, Index:=a.Index)
                        End With
                    End Function) _
            .ToArray Or die("No atom elements to plot!", Function(l) DirectCast(l, Array).Length = 0)

        Dim plotInternal =
            Sub(ByRef g As IGraphics, region As GraphicsRegion)
                Dim bounds = atoms.Select(Function(a) a.pt).GetBounds
                Dim scale As New SizeF With {
                    .Width = region.Size.Width / bounds.Width,
                    .Height = region.Size.Height / bounds.Height
                }

                atoms = atoms _
                    .Select(Function(a)
                                Dim pt As New PointF(a.pt.X * scale.Width, a.pt.Y * scale.Height)
                                Return (pt, a.atom, a.index)
                            End Function) _
                    .ToArray

                Dim centra As PointF = atoms _
                    .Select(Function(a) a.pt) _
                    .CentralOffset(region.Size)

                For Each atom In atoms
                    Dim pt = atom.pt.OffSet2D(centra)
                    Call g.FillPie(dot, pt.X, pt.Y, 5, 5, 0, 360)
                    Call g.DrawString($"[{atom.index}] " & atom.atom, atomFont, Brushes.Black, pt)
                Next

                For Each bound As Bound In kcf.Bounds
                    Dim a = atoms(bound.from - 1).pt.OffSet2D(centra)
                    Dim b = atoms(bound.to - 1).pt.OffSet2D(centra)
                    Dim line As New Line(a, b)

                    For i As Integer = 1 To bound.bounds
                        Call line.Draw(g)
                        line = line.ParallelShift(10)
                    Next
                Next
            End Sub

        Return g.GraphicsPlots(size.SizeParser, padding, bg, plotInternal)
    End Function


End Module
