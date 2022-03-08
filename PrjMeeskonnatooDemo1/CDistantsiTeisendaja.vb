Public Class CDistantsiTeisendaja
    Implements IDistantsiTeisendaja
    Private Function IDistantsiTeisendaja_KilometersToMiles(km As Double) As Double Implements IDistantsiTeisendaja.KilometersToMiles
        Return (km * 1.6)
    End Function

    Private Function IDistantsiTeisendaja_MilesToKilometers(mi As Double) As Double Implements IDistantsiTeisendaja.MilesToKilometers
        Return (mi / 1.6)
    End Function
End Class
