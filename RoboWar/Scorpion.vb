Public Class Scorpion
    Public Property intHealth As Integer = 1200
    Public Property intPower As Integer = 3000
    Public Property intShields As Integer = 750
    Public Property intMissiles As Integer = 0
    Public Property intPowerups As Integer = 0
    Public Property intCharge = 0
    Public Property intChargeAmmount = 0
    Public Property blnDodge As Boolean = False
    Public Property blnCrit As Boolean = False

    Public Function ShieldCheck(Attack, Shields)
        If Shields > 0 Then
            If Shields >= (Attack / 2) Then
                Shields = Shields - (Attack / 2)
                Attack = Attack - (Attack / 2)
            Else
                Shields = 0
                Attack = Attack / 2
            End If
        Else
            Attack = Attack

        End If
        Return Shields

    End Function
    Public Function ShieldAttack(Attack, Shields)
        If Shields > 0 Then
            If Shields >= (Attack / 2) Then
                Shields = Shields - (Attack / 2)
                Attack = Attack - (Attack / 2)
            Else
                Shields = 0
                Attack = Attack / 2
            End If
        Else
            Attack = Attack

        End If
        Return Attack


    End Function

    Public Function Dodge()
        Return blnDodge
    End Function

    Public Function Critical()
        Return blnCrit

    End Function

    Public Function TaserAttack()
        Dim intRan As New Random
        Dim intTotalHits As Integer

        intTotalHits = intRan.Next(1, 6)
        Return intTotalHits

    End Function

    Public Function DrainAttack()
        Dim intRan As New Random
        Dim intX As New Integer
        Dim intAttackTotal As Integer

        intX = intRan.Next(1, 6)
        If intX = 1 Then
            intAttackTotal = 50
        ElseIf intX = 2 Then
            intAttackTotal = 75
        ElseIf intX = 3 Then
            intAttackTotal = 100
        ElseIf intX = 4 Then
            intAttackTotal = 125
        ElseIf intX = 5 Then
            intAttackTotal = 150
        End If
        Return intAttackTotal
    End Function


End Class
