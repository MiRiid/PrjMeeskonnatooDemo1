Public Class CDistantsiTeisendaja
    Implements IDistantsiTeisendaja

    Private Function KilometersToMiles(ByVal km As Double) As Double
        Return (km * 1.6)
    End Function
    Private Function MilesToKilometers(ByVal mi As Double) As Double
        Return (mi / 1.6)
    End Function

End Class
