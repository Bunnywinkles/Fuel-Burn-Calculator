Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim ACCap, ACFB, FHour, FMinute, Ascent, EcoSeats, BusSeats, FCSeats As Integer
        Dim FuelCost, PaxCost, YCost, JCost, FCost, CrewCosts As Double

        ACCap = AircraftCapacity.Value
        ACFB = AircraftFuelBurn.Value
        FHour = FlightHours.Value
        FMinute = FlightMinutes.Value
        EcoSeats = YSeats.Value
        BusSeats = JSeats.Value
        FCSeats = FSeats.Value

        FMinute = (FHour * 60) + FMinute

        If FMinute < 90 Then
            Ascent = FMinute / 2
            FuelCost = (ACFB * 10 * Ascent + ACFB * Ascent) * 0.08 * 1
        Else
            FuelCost = ((ACFB * 10 * 45 + ACFB * (FMinute - 30)) * 0.08 * 1) * (0.7 + 0.3 * 1)
        End If

        PaxCost = FuelCost / ACCap

        YCost = (1 * EcoSeats * FMinute / 60 * 12)
        JCost = (2 * BusSeats * FMinute / 60 * 12)
        FCost = (3 * FCSeats * FMinute / 60 * 12)

        CrewCosts = YCost + JCost + FCost


        lblResult.Text = "Total Fuel Cost:" & vbCrLf & FormatCurrency(FuelCost, 2) & vbCrLf & vbCrLf & "Cost per Passanger:" & vbCrLf & FormatCurrency(PaxCost, 2) & vbCrLf & vbCrLf & "Crew Costs" & vbCrLf & FormatCurrency(CrewCosts, 2)

    End Sub
End Class
