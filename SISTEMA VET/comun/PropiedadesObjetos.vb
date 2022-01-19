Public Class PropiedadesObjetos

    'Funcion para aplicar formato a los datagridview del sistema
    Public Sub Grid(ByVal dgv As DataGridView)
        Try
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                .DefaultCellStyle.BackColor = Color.Aquamarine
                .BackgroundColor = Color.White
                .Font = New Font("Tahoma", 9)
                .ForeColor = Color.Black
                .Anchor = AnchorStyles.Top
                .Anchor = AnchorStyles.Bottom
                .Anchor = AnchorStyles.Left
                .Anchor = AnchorStyles.Right
                .BackColor = Color.White

            End With
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ExportarExcel(ByVal dgv As DataGridView)

        Dim SAVE As New SaveFileDialog
        Dim ruta As String
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim pth As String = ""
        'crearemos una nueva hoja de calculo
        Dim xlwb As Object = xlApp.WorkBooks.add
        Dim xlws As Object = xlwb.WorkSheets(1)
        Try
            'exportaremos los caracteres de las columnas
            For c As Integer = 0 To dgv.Columns.Count - 1
                xlws.cells(1, c + 1).value = dgv.Columns(c).HeaderText
            Next
            'exportaremos las cabeceras de las calumnas
            For r As Integer = 0 To dgv.RowCount - 1
                For c As Integer = 0 To dgv.Columns.Count - 1
                    xlws.cells(r + 2, c + 1).value = Convert.ToString(dgv.Item(c, r).Value)
                Next
            Next
            'guardamos la hoja de excel en la ruta especifica
            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog1.Filter = "Archivo Excel| *.xlsx"
            SaveFileDialog1.FilterIndex = 2
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                ruta = SaveFileDialog1.FileName
                xlwb.saveas(ruta)
                xlws = Nothing
                xlwb = Nothing
                xlApp.quit()
                MsgBox("Exportado Correctamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try

    End Sub

End Class
