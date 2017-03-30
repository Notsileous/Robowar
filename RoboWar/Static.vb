Public Class Statik
    'robot specific variables
    Public Property intHealth As Integer = 1000
    Public Property intPower As Integer = 1000
    Public Property intShields As Integer = 250
    Public Property intMissiles As Integer = 10
    Public Property intPowerUps As Integer = 4
    Public Property intCharge As Integer = 100
    Public Property intChargeAmmount As Integer = 15
    'robot can both dodge and critcal hit
    Public Property blnDodge As Boolean
    Public Property blnCrit As Boolean

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

    'check for multi attack
    Public Function MultiAttack()
        Dim intRan As New Random
        Dim intChance As Integer
        'generate new random number between 1 and 10 (10% chance)
        intChance = intRan.Next(1, 11)
        'if number = 5 then multi attack is good
        If intChance = 5 Then
            'this robot can only multi attack for 2
            intChance = 2
        Else
            intChance = 1
        End If
        Return intChance
    End Function

    'dodge check
    Public Function Dodge()
        Dim intRan As New Random
        Dim intChance As Integer
        'generate new random number between 1 and 10 (10% chance)
        intChance = intRan.Next(1, 11)
        'if number = 6 then dodge successful
        If intChance = 6 Then
            blnDodge = True
        Else
            blnDodge = False
        End If
        Return blnDodge
    End Function

    'critical hit check
    Public Function Critical()
        Dim intRan As New Random
        Dim intChance As Integer
        'generate new random number between 1 and 10 (10% chance)
        intChance = intRan.Next(1, 11)
        'if number = 4 than critical hit check successful
        If intChance = 4 Then
            blnCrit = True
        Else
            blnCrit = False
        End If
        Return blnCrit
    End Function

    'shield powerup
    Public Function ShieldPowerUp(Shields)
        'if current ammpunt is 250 or greater - set to maximum (500)
        If Shields >= 250 Then
            Shields = 500
        Else
            'otherwise add 250
            Shields = Shields + 250
        End If
        Return Shields
    End Function


End Class
