Public Class Form1
    Dim HoursDecimal, PayRateDecimal, GrossPayDecimal, FederalTaxDecimal As Decimal

    'Tax rate constants
    Const TAX_RATE_08_DECIMAL As Decimal = 0.08D
    Const TAX_RATE_18_DECIMAL As Decimal = 0.18D
    Const TAX_RATE_28_DECIMAL As Decimal = 0.28D
    Const TAX_LEVEL_08_DECIMAL As Decimal = 985D
    Const TAX_LEVEL_18_DECIMAL As Decimal = 2450D

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim ExitMessage As String = "Are you sure you want to exit?"
        If MessageBox.Show(ExitMessage, "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles DepartmentLabel.Click

    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click




        If HoursDecimal <= 40 Then
            GrossPayDecimal = Decimal.Round(HoursDecimal * PayrateDecimal, 2)
        Else
            GrossPayDecimal = Decimal.Round((40 * PayrateDecimal) + (HoursDecimal - 40) * (PayrateDecimal * 1.5D), 2)
        End If
        HoursDecimal = Decimal.Parse(HoursWorkedTextBox.Text, Globalization.NumberStyles.Number)
        PayrateDecimal = Decimal.Parse(PayRateTextBox.Text, Globalization.NumberStyles.Currency)

        GrossPayTextBox.Text = GrossPayDecimal.ToString("C2")
        Try
        Catch ex As Exception
            MessageBox.Show("Check to ensure no data values are missing." & ControlChars.NewLine & ex.Message, "Compute Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If GrossPayDecimal <= TAX_LEVEL_08_DECIMAL Then  '8% tax bracket
            FederalTaxDecimal = Decimal.Round(TAX_RATE_08_DECIMAL * GrossPayDecimal, 2)
        ElseIf GrossPayDecimal <= TAX_LEVEL_18_DECIMAL Then  '18% tax bracket
            FederalTaxDecimal = Decimal.Round(TAX_RATE_18_DECIMAL * GrossPayDecimal, 2)
        Else  '28% tax bracket
            FederalTaxDecimal = Decimal.Round(TAX_RATE_28_DECIMAL * GrossPayDecimal, 2)
        End If
        FederalTaxTextBox.Text = FederalTaxDecimal.ToString("N")


    End Sub
End Class
