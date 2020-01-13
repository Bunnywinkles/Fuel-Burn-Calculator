Public Class Form1
    Public Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim ACCap, FHour, FMinute As Integer
        Dim FuelCost, PaxCost, YCost, JCost, FCost, CrewCosts, DestSlotFees, OriginSlotFees, Landing, APFees As Double

        ACCap = AircraftCapacity.Value
        FHour = FlightHours.Value
        FMinute = FlightMinutes.Value

        FMinute = (FHour * 60) + FMinute

        funPaxCost(ACCap, FMinute, PaxCost, FuelCost)
        funCrewCosts(YCost, JCost, FCost, CrewCosts, FMinute)
        funAirportFees(ACCap, DestSlotFees, Landing, OriginSlotFees, APFees)

        lblFuelCosts.Text = "Total Fuel Cost:" & vbCrLf & FormatCurrency(FuelCost, 2) & vbCrLf & vbCrLf &
            "Cost per Passanger:" & vbCrLf & FormatCurrency(PaxCost, 2)
        lblCrewCosts.Text = "Total Crew Costs:" & vbCrLf & FormatCurrency(CrewCosts, 2) & vbCrLf & vbCrLf &
             "Economy:" & vbCrLf & FormatCurrency(YCost, 2) & vbCrLf & vbCrLf & "Business:" & vbCrLf & FormatCurrency(JCost, 2) _
             & vbCrLf & vbCrLf & "First:" & vbCrLf & FormatCurrency(FCost, 2)
        lblAPFees.Text = "Origin Fees: " & FormatCurrency(OriginSlotFees, 2) & " Dest Fees: " & FormatCurrency(DestSlotFees, 2) & " Landing\Takeoff Fees: " & FormatCurrency(Landing, 2) _
            & vbCrLf & "Total Fees: " & FormatCurrency(APFees, 2)


    End Sub

    Function funPaxCost(ACCap, FMinute, ByRef PaxCost, ByRef FuelCost)

        Dim Ascent, ACFB As Integer

        ACFB = AircraftFuelBurn.Value

        If FMinute < 90 Then
            Ascent = FMinute / 2
            FuelCost = (ACFB * 10 * Ascent + ACFB * Ascent) * 0.08 * 1
        Else
            FuelCost = ((ACFB * 10 * 45 + ACFB * (FMinute - 30)) * 0.08 * 1) * (0.7 + 0.3 * 1)
        End If

        PaxCost = FuelCost / ACCap

    End Function

    Function funCrewCosts(ByRef YCost, ByRef JCost, ByRef FCost, ByRef CrewCosts, FMinute)

        Dim EcoSeats, BusSeats, FCSeats As Integer

        EcoSeats = YSeats.Value
        BusSeats = JSeats.Value
        FCSeats = FSeats.Value

        YCost = (1 * EcoSeats * FMinute / 60 * 12)
        JCost = (2 * BusSeats * FMinute / 60 * 12)
        FCost = (3 * FCSeats * FMinute / 60 * 12)

        CrewCosts = YCost + JCost + FCost

    End Function

    Function funAirportFees(ACCap, ByRef DestSlotFees, ByRef Landing, ByRef OriginSlotFees, ByRef APFees)

        Dim ACSize As String
        Dim DestAPSize, OriginAPSize, ACSizeint As Integer

        ACSize = cbACSize.Text
        DestAPSize = CInt(cbDestSize.Text)
        OriginAPSize = CInt(cbOriginSize.Text)

        Select Case DestAPSize
            Case 1
                DestSlotFees = 50
            Case 2
                DestSlotFees = 50
            Case 3
                DestSlotFees = 80
            Case 4
                DestSlotFees = 150
            Case 5
                DestSlotFees = 250
            Case = 6
                DestSlotFees = 350
            Case > 6
                DestSlotFees = 500
        End Select

        Select Case OriginAPSize
            Case 1
                OriginSlotFees = 50
            Case 2
                OriginSlotFees = 50
            Case 3
                OriginSlotFees = 80
            Case 4
                OriginSlotFees = 150
            Case 5
                OriginSlotFees = 250
            Case = 6
                OriginSlotFees = 350
            Case > 6
                OriginSlotFees = 500
        End Select

        Select Case ACSize
            Case "Light"
                ACSizeint = 1
            Case "Regional"
                ACSizeint = 1
            Case "Small"
                ACSizeint = 3
            Case "Medium"
                ACSizeint = 8
            Case "Large"
                ACSizeint = 12
            Case "X-Large"
                ACSizeint = 15
            Case "Jumbo"
                ACSizeint = 18
        End Select

        If ACSizeint <= 3 Then
            Landing = (3 * ACCap) * 2
        Else
            Landing = (ACSizeint * ACCap) * 2
        End If

        APFees = Landing + OriginSlotFees + DestSlotFees

    End Function


End Class
