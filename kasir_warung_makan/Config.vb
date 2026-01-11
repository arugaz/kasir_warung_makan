Module Config
    ' ===== User Auth =====
    Friend Const DefaultUsername As String = "kasir"
    Friend Const DefaultPassword As String = "1234"

    ' ===== Menu Items =====
    Friend Class MenuItem
        Public Property Code As String
        Public Property Name As String
        Public Property Price As Integer
    End Class

    Friend ReadOnly MenuItems As New List(Of MenuItem) From {
        New MenuItem With {.Code = "M001", .Name = "Nasi Goreng", .Price = 15000},
        New MenuItem With {.Code = "M002", .Name = "Mie Goreng", .Price = 12000},
        New MenuItem With {.Code = "M003", .Name = "Ayam Bakar", .Price = 20000},
        New MenuItem With {.Code = "M004", .Name = "Es Teh", .Price = 5000}
    }

    Friend Class CartItem
        Public Property Menu As MenuItem
        Public Property Qty As Integer
        Public ReadOnly Property Total As Integer
            Get
                Return Menu.Price * Qty
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return $"{Menu.Name} x{Qty} = Rp{Total:N0}"
        End Function
    End Class


    ' ===== Discount Rules =====
    Friend Class DiscountRule
        Public MinSubtotal As Integer
        Public Percent As Integer
    End Class

    Friend ReadOnly DiscountRules As New List(Of DiscountRule) From {
        New DiscountRule With {.MinSubtotal = 100000, .Percent = 15},
        New DiscountRule With {.MinSubtotal = 50000, .Percent = 10}
    }

    Friend Function CalculateDiscount(subtotal As Integer) As Integer
        Dim rule = DiscountRules _
            .Where(Function(r) subtotal >= r.MinSubtotal) _
            .OrderByDescending(Function(r) r.MinSubtotal) _
            .FirstOrDefault()

        If rule Is Nothing Then Return 0
        Return subtotal * rule.Percent / 100.0
    End Function

End Module
