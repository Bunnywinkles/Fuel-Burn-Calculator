Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim ACCap As Integer
        Dim ACFB As Integer
        Dim FHour As Integer
        Dim FMinute As Integer
        Dim Ascent As Integer
        Dim FuelCost As Double
        Dim PaxCost As Double

        ACCap = AircraftCapacity.Value
        ACFB = AircraftFuelBurn.Value
        FHour = FlightHours.Value
        FMinute = FlightMinutes.Value

        FMinute = (FHour * 60) + FMinute

        If FMinute < 90 Then
            Ascent = FMinute / 2
            FuelCost = (ACFB * 10 * Ascent + ACFB * Ascent) * 0.08 * 1
        Else
            FuelCost = ((ACFB * 10 * 45 + ACFB * (FMinute - 30)) * 0.08 * 1) * (0.7 + 0.3 * 1)
        End If

        PaxCost = FuelCost / ACCap

        lblResult.Text = "Total Fuel Cost:" & vbCrLf & FormatCurrency(FuelCost, 2) & vbCrLf & vbCrLf & "Cost per Passanger:" & vbCrLf & FormatCurrency(PaxCost, 2)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
