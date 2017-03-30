Public Class Hardcase
    'robot specific stats
    Public Property intHealth As Integer = 1100
    Public Property intPower As Integer = 900
    Public Property intShields As Integer = 500
    Public Property intMissiles As Integer = 12
    Public Property intPowerUps As Integer = 3
    Public Property intCharge As Integer = 100
    Public Property intChargeAmmount As Integer = 10
    'this robot cannot dodge attacks - locked on false
    Const blnDodge As Boolean = False
    'this robot cannot multi attack - locked at 1
    Const intChance = 1
    'boolean check for critical hits
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

    'determine if the attack is a multi attack
    Public Function MultiAttack()
        Return intChance
    End Function

    'Determine if attack is dodged
    Public Function Dodge()
        Return blnDodge
    End Function

    'Determine if the attack is a critical hit (double damage)
    Public Function Critical()

        Dim intRan As New Random
        Dim intChance As Integer

        'radomly generate a number between 1 and 4 (25% chance)
        intChance = intRan.Next(1, 5)
        'if number = 2 then the attack is a critical hit
        If intChance = 2 Then
            _blnCrit = True
            'any other number is not a critical hit
        Else
            _blnCrit = False
        End If
        Return _blnCrit

    End Function

    'shield power up - adds 250 max of 750
    Public Function ShieldPowerUp(Shields)
        'if shields are at 500 or more set them to 750
        If Shields >= 500 Then
            Shields = 750
        Else
            'else add 250 to current ammount
            Shields = Shields + 250
        End If
        Return Shields

    End Function


End Class



