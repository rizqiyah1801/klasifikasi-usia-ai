Public Class Form1

    Private Class AgeRule
        Public Property Min As Decimal
        Public Property Max As Decimal
        Public Property Label As String
        Public Property Description As String
        Public Property TransitionNote As String
    End Class

    ' List aturan (rule base)
    Private AgeRules As New List(Of AgeRule)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitRules()
        LblHasil.Text = "Keterangan: -"
        LblDet.Text = ""
    End Sub

    ' Inisialisasi rule base
    Private Sub InitRules()
        AgeRules.Add(New AgeRule With {
            .Min = 0, .Max = 12.99D,
            .Label = "Anak-anak 👶",
            .Description = "Masa bermain dan belajar.",
            .TransitionNote = "Menuju Remaja"
        })
        AgeRules.Add(New AgeRule With {
            .Min = 13, .Max = 17.99D,
            .Label = "Remaja 🧒",
            .Description = "Masa pubertas dan pencarian jati diri.",
            .TransitionNote = "Menuju Dewasa"
        })
        AgeRules.Add(New AgeRule With {
            .Min = 18, .Max = 120,
            .Label = "Dewasa 🧑",
            .Description = "Masa mandiri dan bertanggung jawab.",
            .TransitionNote = ""
        })
    End Sub

    ' Reasoning logic
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim usia As Decimal

        If Decimal.TryParse(TxtUsia.Text, usia) Then
            If usia < 0 Or usia > 120 Then
                LblHasil.Text = "Usia tidak masuk akal!"
                LblDet.Text = ""
                Return
            End If

            Dim hasil As String = ""
            Dim detail As String = ""

            ' Proses klasifikasi berbasis aturan
            For Each rule In AgeRules
                If usia >= rule.Min And usia <= rule.Max Then
                    hasil = rule.Label
                    If rule.TransitionNote <> "" AndAlso usia >= rule.Max - 1 Then
                        hasil &= $" ({rule.TransitionNote})"
                    End If
                    detail = rule.Description
                    Exit For
                End If
            Next

            LblHasil.Text = "Keterangan: " & hasil
            LblDet.Text = detail
        Else
            LblHasil.Text = "Masukkan usia berupa angka!"
            LblDet.Text = ""
        End If
    End Sub

End Class


