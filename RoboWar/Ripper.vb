Public Class Ripper
    'robot specific stats
    Public Property intHealth As Integer = 900
    Public Property intPower As Integer = 1000
    Public Property intShields As Integer = 0
    Public Property intMissiles As Integer = 8
    Public Property intPowerups As Integer = 4
    Public Property intCharge = 100
    Public Property intChargeAmmount = 20
    Public Property blnDodge As Boolean
    'this robot cannot perform critical hits - locked to false
    Const blnCrit As Boolean = False



    'check if opponent has shieilds and determine damage to shields
    Public Function ShieldCheck(Attack, Shields)
        Dim intShieldDamage As Integer
        'if shields are present damage is halved and split between shields and health
        'if shield ammount is less than damage ammount set shields to 0
        If Shields > 0 Then
            If Shields >= (Attack / 2) Then
                intShieldDamage = Attack / 2
            Else
                intShieldDamage = Shields
            End If

        End If
        Return intShieldDamage

    End Function

    'check if opponent has shieilds and determine damage to health
    Public Function ShieldAttack(Attack, Shields)
        'if shields are present damage is halved and split between shields and health
        If Shields > 0 Then
            Attack = Attack / 2
        Else
            'if shields are not present health takes all damage
            Attack = Attack
        End If
        Return Attack

    End Function

    Public Function MultiAttack()
        'create new random object
        Dim intRan As New Random
        Dim intChance As Integer
        'generate new number between 1 and 4 (25%) chance
        intChance = intRan.Next(1, 5)
        'if number = 3 than multi attack is performed
        If intChance = 3 Then
            'generate new number between 2 and 3 - this is number of attacks to be performed
            intChance = intRan.Next(2, 4)
        Else
            'if no multiattck - attack chance is 1
            intChance = 1
        End If
        Return intChance

    End Function

    'dodge check
    Public Function Dodge()
        Dim intRan As New Random
        Dim intChance As Integer
        'generate new number between 1 and 4 (25% chance)
        intChance = intRan.Next(1, 5)
        'if 2 then dodge was sucessfull
        If intChance = 2 Then
            blnDodge = True
        Else
            'otherwise no dodge
            blnDodge = False
        End If
        Return blnDodge
    End Function

    'critical hit check
    Public Function Critical()
        Return blnCrit
    End Function

    'shields powerup
    Public Function ShieldPowerUp(Shields)
        'because max shields is 250 - set to 250
        Shields = 250
        Return Shields
    End Function
End Class
