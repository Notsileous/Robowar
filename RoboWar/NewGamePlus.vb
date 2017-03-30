'window just for use when fighting the final hidden robot
Public Class NewGamePlus
    'booleans for win/loss passed between all forms
    Public Property blnBeatLite As Boolean
    Public Property blnBeatMid As Boolean
    Public Property blnBeatHeavy As Boolean
    'booleans for which robot type was selected by player 1
    Public Property blnP1Lite As Boolean
    Public Property blnP1Mid As Boolean
    Public Property blnP1Heavy As Boolean
    'booleans for which robot type was selected for player 2
    Public Property blnP2Lite As Boolean
    Public Property blnP2Mid As Boolean
    Public Property blnP2Heavy As Boolean
    'string variables for player names
    Public Property strP1Name As String
    Private strP2Name As String
    'string variables to hold paths for profile pictures
    Private strProfileLiteP1 As String
    Private strProfileMidP1 As String
    Private strProfileHeavyp1 As String
    Private strProfileP2 As String
    'string variables to hold win/lose pictures
    Private strPlayer1Win As String
    Private strPlayer2Win As String
    'variables for player 1 stats
    Private intP1Health As Integer
    Private intp1Power As Integer
    Private intP1Shields As Integer
    Private intP1Missiles As Integer
    Private intP1Powerups As Integer
    Private intP1Charge As Integer
    Private intP1ChargeAmmount As Integer
    'variables for player 2 stats
    Private intP2Health As Integer
    Private intp2Power As Integer
    Private intP2Shields As Integer
    Private intP2Missiles As Integer
    Private intP2Powerups As Integer
    Private intP2Charge As Integer
    Private intP2ChargeAmmount As Integer
    'variable used for multi attacks, used by each player
    Private intMultiAttack As Integer
    'boolean for critical hit check - used by both players
    Private blnCrit As Boolean
    'boolean to keep track of whose turn it is
    Public Property blnP1Turn As Boolean = True
    'constant variables for weapon power cost
    Const intGunPowerCost As Integer = 25
    Const intMissilePowerCost As Integer = 50
    Const intTeslaPowerCost As Integer = 100
    Const intPowerUpPowerCost As Integer = 100
    'object variables to be used for instances of robot classes
    Private Player1 As Object
    Private Player2 As Object
    'boolean for game end
    Private blnGameOver As Boolean = False


    Private Sub NewGamePlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblP1Name.Text = strP1Name


        strProfileLiteP1 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_ripper_blue.gif"
        strProfileMidP1 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_static_blue.gif"
        strProfileHeavyp1 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_hardcase_blue.gif"
        strProfileP2 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_scorpion.gif"


        If blnP1Lite Then
            pBoxP1.ImageLocation = strProfileLiteP1
            Player1 = New Ripper

        ElseIf blnP1Mid Then
            pBoxP1.ImageLocation = strProfileMidP1
            Player1 = New Statik

        ElseIf blnP1Heavy Then
            pBoxP1.ImageLocation = strProfileHeavyp1
            Player1 = New Hardcase


        End If
        Player2 = New Scorpion
        pBoxP2.ImageLocation = strProfileP2
        strP2Name = "Scorpion"
        lblP2Name.Text = strP2Name



        lblP1Health.Text = Player1.intHealth
        lblP1Power.Text = Player1.intPower
        lblP1Shields.Text = Player1.intShields
        lblP1Powerups.Text = Player1.intPowerups
        lblP1Missiles.Text = Player1.intMissiles
        lblp1Charge.Text = Player1.intCharge

        lblP2Health.Text = Player2.intHealth
        lblP2Power.Text = Player2.intPower
        lblP2Shields.Text = Player2.intShields
        lblP2Powerups.Text = Player2.intPowerups
        lblP2Missiles.Text = Player2.intMissiles
        lblP2Charge.Text = Player2.intCharge
        lblP2Name.Text = strP2Name

        intP1Health = Player1.intHealth
        intp1Power = Player1.intPower
        intP1Shields = Player1.intShields
        intP1Missiles = Player1.intMissiles
        intP1Powerups = Player1.intPowerups
        intP1Charge = Player1.intCharge
        intP1ChargeAmmount = Player1.intChargeAmmount


        intP2Health = Player2.intHealth
        intp2Power = Player2.intPower
        intP2Shields = Player2.intShields
        intP2Missiles = Player2.intMissiles
        intP2Powerups = Player2.intPowerups
        intP2Charge = Player2.intCharge
        intP2ChargeAmmount = Player2.intChargeAmmount

        'determine who attacks first
        Dim WinFlip As New CoinFlip
        WinFlip.ShowDialog()
        blnP1Turn = WinFlip.blnPlayer1Turn
        If blnP1Turn Then
            P1Turn()
        Else
            P2Turn()
            Player2Attack()
        End If

    End Sub
    'player 1 turn - enable p1 buttons - disable p2 buttons
    Private Sub P1Turn()
        btnCannonP1.Enabled = True
        btnGunP1.Enabled = True
        btnPowerP1.Enabled = True
        btnMissileP1.Enabled = True

        btnEMP.Enabled = False
        btnTaserP2.Enabled = False
        btnPowerDrain.Enabled = False


    End Sub
    'player 2 turn - enable p2 buttons - disable p2 buttons
    Private Sub P2Turn()
        btnEMP.Enabled = True
        btnTaserP2.Enabled = True
        btnPowerDrain.Enabled = True

        btnCannonP1.Enabled = False
        btnGunP1.Enabled = False
        btnPowerP1.Enabled = False
        btnMissileP1.Enabled = False
    End Sub
    'update all stats text to reflect changes
    Private Sub UpdateStats()
        lblP1Health.Text = intP1Health
        lblP1Power.Text = intp1Power
        lblP1Shields.Text = intP1Shields
        lblP1Powerups.Text = intP1Powerups
        lblP1Missiles.Text = intP1Missiles
        lblp1Charge.Text = intP1Charge

        lblP2Health.Text = intP2Health
        lblP2Power.Text = intp2Power
        lblP2Shields.Text = intP2Shields
        lblP2Powerups.Text = intP2Powerups
        lblP2Missiles.Text = intP2Missiles
        lblP2Charge.Text = intP2Charge
    End Sub
    'check stats and enable/disable buttons accordingly
    Private Sub AvailableP1()
        If intp1Power < intTeslaPowerCost Then
            btnPowerP1.Enabled = False
            btnCannonP1.Enabled = False
        End If
        If intp1Power < intMissilePowerCost Then
            btnMissileP1.Enabled = False
        End If

        If intP1Missiles = 0 Then
            btnMissileP1.Enabled = False
            btnMissileP1.Text = "Out of Missiles"
        Else
            btnMissileP1.Text = "Missile Launcher"
        End If

        If intP1Powerups = 0 Then
            btnPowerP1.Enabled = False
            btnPowerP1.Text = "Out of Powerups"
        End If
        'display charge ammount on button
        If intP1Charge < 100 Then
            btnCannonP1.Enabled = False
            btnCannonP1.Text = "Recharging " + "(" + intP1Charge.ToString + "%" + ")"
        ElseIf intP1Charge = 100 Then
            btnCannonP1.Text = "Tesla Cannon"
            btnCannonP1.Enabled = True

        End If
    End Sub

    'machine gun attack
    Private Sub btnGunP1_Click(sender As Object, e As EventArgs) Handles btnGunP1.Click
        'check availibilty
        AvailableP1()
        'variable for multi attack chance
        Dim intAttackChance As Integer
        'variable for total damage delt
        Dim intTotalDamage As Integer = 0
        'call sub from player 2 object to see if attack was dodged
        'if dodge was sucessfull display message and go to end of turn
        If Player2.Dodge() Then
            MessageBox.Show("Your opponent dodged your attack")
            txtRecap.AppendText(strP2Name + " dodged an attack!" & Environment.NewLine)

        Else
            'if no dodge - continue with attack
            'create new random object and variables
            Dim ranAttack As New Random
            Dim intAttack As Integer
            Dim intAttackTotal As Integer
            Dim intShieldDamage As Integer

            'create new attack alert window
            Dim win As New frmMGunP1
            'check for multi attack
            intAttackChance = Player1.MultiAttack()
            'loop from 1 to returned multiattack number (minimum of 1)
            For intCounter = 1 To intAttackChance
                'for each itteration generate a random number between 10 and 40 this is damage
                intAttack = ranAttack.Next(10, 41)
                'check if critical hit, if so double the damage
                If Player1.Critical() Then
                    intAttack = intAttack * 2
                    blnCrit = True
                Else
                    intAttack = intAttack
                    blnCrit = False
                End If
                'check if shields are present
                intAttackTotal = Player2.ShieldAttack(intAttack, intP2Shields)
                intTotalDamage = intTotalDamage + intAttack
                intShieldDamage = Player2.ShieldCheck(intAttack, intP2Shields)
                'adjust health and shields
                intP2Health = intP2Health - intAttackTotal
                intP2Shields = intP2Shields - intShieldDamage
                'display window with damage and attack counts
                win.intMulti = intCounter
                win.intDamage = intTotalDamage
                'if a critical hit, change the window text
                If blnCrit Then
                    win.Text = "Critical Hit!"
                End If
                win.ShowDialog()
            Next intCounter
        End If
        'add robot specific charge ammount to tesla cannon charge ammount if it less than full
        If intP1Charge < 100 Then
            intP1Charge = intP1Charge + intP1ChargeAmmount
            If intP1Charge > 100 Then
                intP1Charge = 100
            Else
                intP1Charge = intP1Charge
            End If
        End If
        'subtract power cost 
        intp1Power = intp1Power - intGunPowerCost
        'add details to recap window
        txtRecap.AppendText(strP1Name + " riddled " + strP2Name + " " + intAttackChance.ToString + " times for " + intTotalDamage.ToString + " damage!" & Environment.NewLine)

        'update all stats - check if anyone won - player 2 turn
        UpdateStats()
        AvailableP1()
        GameEndCheck()
        If blnGameOver = False Then
            P2Turn()
            Player2Attack()
        End If



    End Sub

    'sub for missile attack
    Private Sub btnMissileP1_Click(sender As Object, e As EventArgs) Handles btnMissileP1.Click
        'set variables
        Dim intTotalDamage As Integer = 0
        Dim intMissilesUsed As Integer = 0
        Dim intShieldDamage As Integer = 0
        'check if attack was dodged
        If Player2.Dodge() Then
            'if dodged - show dodge window - add to recap window - subtract 1 missile
            MessageBox.Show("Your opponent dodged your attack")
            If intP2Missiles >= 1 Then
                intP2Missiles = intP2Missiles - 1
            Else
                intP2Missiles = 0
            End If
            txtRecap.AppendText(strP2Name + " dodged an attack!" & Environment.NewLine)

        Else
            'if not dodged proceed with attack
            'create new random object
            Dim ranNum As New Random
            'create variables for damage and missiles used
            Dim intAttack As Integer
            Dim intAttackTotal As Integer
            Dim intAttackChance As Integer
            Dim intCounter As Integer
            'create new window for missile attack notification
            Dim win As New P1Missile
            'generate random number between 1 and the ammount of missiles the player has - this will be the missiles launched
            intAttackChance = ranNum.Next(1, intP1Missiles + 1)
            intMissilesUsed = intAttackChance
            'loop for as many missiles are being used
            For intCounter = 1 To intAttackChance
                'new random number between 20 and 60 - this is missile damage
                intAttack = ranNum.Next(20, 61)
                If Player1.Critical() Then
                    'if critical hit - double damage
                    intAttack = intAttack * 2
                    blnCrit = True
                Else
                    intAttack = intAttack
                    blnCrit = False
                End If
                'check shields and determine damage
                intAttackTotal = Player2.ShieldAttack(intAttack, intP2Shields)
                intTotalDamage = intTotalDamage + intAttack
                intShieldDamage = Player2.ShieldCheck(intAttack, intP2Shields)
                'adjust stats
                intP2Health = intP2Health - intAttackTotal
                intP2Shields = intP2Shields - intShieldDamage
                'display missile attack window with missiles used and damage dealt
                win.intMulti = intCounter
                win.intDamage = intTotalDamage
                'if critical hit  -change window text
                If blnCrit Then
                    win.Text = "Critical Hit!"
                End If
                'show window
                win.ShowDialog()
            Next intCounter
        End If
        'add robot specific charge ammount to tesla cannon charge ammount if it less than full
        If intP1Charge < 100 Then
            intP1Charge = intP1Charge + intP1ChargeAmmount
            If intP1Charge >= 100 Then
                intP1Charge = 100
            Else
                intP1Charge = intP1Charge
            End If
        End If
        'subtract power cost
        intp1Power = intp1Power - intMissilePowerCost
        'subtract missiles used
        intP1Missiles = intP1Missiles - intMissilesUsed
        'add attack details to recap window
        txtRecap.AppendText(strP1Name + " bombarded " + strP2Name + " with " + intMissilesUsed.ToString + " missiles for " + intTotalDamage.ToString + " damage" & Environment.NewLine)

        'update all stats - check if anyone won - player 2 turn
        UpdateStats()
        AvailableP1()
        GameEndCheck()
        If blnGameOver = False Then
            P2Turn()
            Player2Attack()
        End If
    End Sub

    'sub for tesla cannon attack
    Private Sub btnCannonP1_Click(sender As Object, e As EventArgs) Handles btnCannonP1.Click
        'create new random object
        Dim ranNum As New Random
        'create new variables for attack damage
        Dim intAttack As Integer
        Dim intAttackTotal As Integer
        Dim intShieldDamage As Integer = 0
        Dim intSplashDamage As Integer
        Dim win As New P1Tesla
        'generate new random number between 100 and 150 - this is damage to opponent
        intAttack = ranNum.Next(100, 151)
        'divide damage by 4 - this is splash damage to instigating player
        intSplashDamage = intAttack / 4
        'check shields and determine damage
        intAttackTotal = Player2.ShieldAttack(intAttack, intP2Shields)
        intShieldDamage = Player2.ShieldCheck(intAttack, intP2Shields)
        'adjust stats
        intP2Health = intP2Health - intAttackTotal
        intP2Shields = intP2Shields - intShieldDamage
        'show tesla attack window with damage and splash damage
        win.intDamage = intAttack
        win.intSpash = intSplashDamage
        win.ShowDialog()
        'hit instigating player with splash damage
        intP1Health = intP1Health - intSplashDamage
        'set players tesla cannon charge ammount to 0
        intP1Charge = 0
        'subtract power cost
        intp1Power = intp1Power - intTeslaPowerCost
        'add details to recap window
        txtRecap.AppendText(strP1Name + " scorched " + strP2Name + " for " + intAttack.ToString + " damage" & Environment.NewLine)
        txtRecap.AppendText(strP1Name + " was caught in the blast for " + intSplashDamage.ToString + " damage" & Environment.NewLine)

        'update stats - check if anyone won -player 2 turn
        UpdateStats()
        AvailableP1()
        GameEndCheck()
        If blnGameOver = False Then
            P2Turn()
            Player2Attack()
        End If
    End Sub

    'sub for powerups
    Private Sub btnPowerP1_Click(sender As Object, e As EventArgs) Handles btnPowerP1.Click
        'create new random object
        Dim intRan As New Random
        Dim intPowerUp As Integer
        'generate new random number between 1 and 6 - this is the powerup used
        intPowerUp = intRan.Next(1, 7)
        'powerups 1 = missiles, 2 = drone strike, 3 = full power, 4 = shields, 5 = full health, 6 = full tesla cannon charge
        If intPowerUp = 1 Then
            'player gets 10 extra missiles
            Dim winForm = New P1MissilePowerUp
            winForm.ShowDialog()
            intP1Missiles = intP1Missiles + 10
            txtRecap.AppendText(strP1Name + " received 10 missiles" & Environment.NewLine)

        ElseIf intPowerUp = 2 Then
            'player launched dron strike hitting opponent for 200 damage and ignoring shields
            Dim WinForm = New frmDroneP1
            WinForm.ShowDialog()
            intP2Health = intP2Health - 200
            txtRecap.AppendText(strP1Name + " launched a drone attack against" + strP2Name + " for 200 damage" & Environment.NewLine)

        ElseIf intPowerUp = 3 Then
            'player gets full power
            Dim winForm As New P1FullPower
            winForm.ShowDialog()
            intp1Power = 1000
            txtRecap.AppendText(strP1Name + " now has full power" & Environment.NewLine)
        ElseIf intPowerUp = 4 Then
            'player gets 250 points added to shield up to their maximum alloted ammount
            Dim winForm As New P1Sheilds
            winForm.ShowDialog()
            intP1Shields = Player1.ShieldPowerUp(intP1Shields)
            txtRecap.AppendText(strP1Name + " has had their shields recharged" & Environment.NewLine)
        ElseIf intPowerUp = 5 Then
            'player gets full health
            intP1Health = Player1.intHealth
            Dim winForm As New P1Health
            winForm.ShowDialog()
            txtRecap.AppendText(strP1Name + " is now at full health" & Environment.NewLine)

        ElseIf intPowerUp = 6 Then
            'players tesla cannon is fully recharged
            intP1Charge = 100
            Dim WinForm As New P1TeslaPowerUp
            WinForm.ShowDialog()
            txtRecap.AppendText(strP1Name + "'s Tesla Cannon has been fully recharged" & Environment.NewLine)
        End If
        'remove one powerup
        intP1Powerups = intP1Powerups - 1
        'subtract power cost
        intp1Power = intp1Power - intPowerUpPowerCost
        'update stats - check if anyone won -player 2 turn
        UpdateStats()
        AvailableP1()
        GameEndCheck()
        If blnGameOver = False Then
            P2Turn()
            Player2Attack()
        End If
    End Sub

    'player 2 attacks begin here

    Private Sub Player2Attack()
        Dim ranP2Attack As New Random
        Dim intp2AttackChoice As Integer
        'generate new random number between 1 and 3
        intp2AttackChoice = ranP2Attack.Next(1, 4)

        If intp2AttackChoice = 1 Then
            TaserAttack()
        ElseIf intp2AttackChoice = 2 Then
            DrainAttack()
        ElseIf intp2AttackChoice = 3 Then
            EMP()

        End If
        'all attacks cost the same ammount
        intp2Power = intp2Power - 100


        'check for game ending conditions
        GameEndCheck()
        If blnGameOver = False Then
            P1Turn()
            AvailableP1()
        End If

    End Sub
    'taser attack hits for for 25 damage and can hit from 1 to 5 times per turn
    Private Sub TaserAttack()
        Dim IntAttackAmount As Integer = 25
        Dim intAttackTimes As Integer
        Dim winForm As New frmTaser
        Dim intDmgCounter As Integer = 0
        'check to see how many times attack will hit
        intAttackTimes = Player2.TaserAttack()
        'loop from 1 to above ammount
        For intCounter = 1 To intAttackTimes
            'for each itteration - calculate damage - display attack window and adjust stats
            winForm.intDamage = IntAttackAmount
            winForm.intTimes = intCounter
            winForm.ShowDialog()
            intP1Health = intP1Health - IntAttackAmount
            intDmgCounter = intDmgCounter + IntAttackAmount

        Next intCounter
        'add to recap window
        txtRecap.AppendText(strP2Name + " tasered " + strP1Name + intAttackTimes.ToString + " times for " + intDmgCounter.ToString + " times" & Environment.NewLine)


        UpdateStats()

    End Sub
    'drain attack pulls from shields, power, or health and adds to scorpions total
    Private Sub DrainAttack()
        Dim intAttackTotal As Integer
        Dim strTypeDmg As String = "null"
        Dim intRan As New Random
        Dim intType As Integer
        Dim WinForm As New Drain
        'get damage ammount
        intAttackTotal = Player2.DrainAttack()
        'shields check, if no shields present limit the choices to power and health
        If intP1Shields < 0 Then
            intType = intRan.Next(1, 4)
        Else
            intType = intRan.Next(1, 3)
        End If

        If intType = 1 Then
            'drains from player 1 power and gives same ammount to player 2 power
            strTypeDmg = "power"
            WinForm.strDmgType = strTypeDmg
            WinForm.intDmg = intAttackTotal
            WinForm.ShowDialog()
            intp1Power = intp1Power - intAttackTotal
            intp2Power = intp2Power + intAttackTotal
        ElseIf intType = 2 Then
            'drains from player 1 health and gives same ammount to player 2 health
            strTypeDmg = "health"
            WinForm.strDmgType = strTypeDmg
            WinForm.intDmg = intAttackTotal
            WinForm.ShowDialog()
            intP1Health = intP1Health - intAttackTotal
            intP2Health = intP2Health + intAttackTotal
        ElseIf intType = 3 Then
            strTypeDmg = "shields"
            'drains from player 1 shields and gives same ammount to player 2 shields

            If intP1Shields >= intAttackTotal Then
                intP1Shields = intP1Shields - intAttackTotal
                intP2Shields = intP2Shields + intAttackTotal
                WinForm.strDmgType = strTypeDmg
                WinForm.intDmg = intAttackTotal
                WinForm.ShowDialog()
            Else
                intP2Shields = intP2Shields + intP1Shields
                WinForm.strDmgType = strTypeDmg
                WinForm.intDmg = intP1Shields
                WinForm.ShowDialog()
                intP1Shields = 0
            End If
        End If
        'add to recap window
        txtRecap.AppendText(strP2Name + " drained the " + strTypeDmg + " of " + strP1Name + " by " + intAttackTotal.ToString & Environment.NewLine)
        txtRecap.AppendText(strP2Name + " added " + intAttackTotal.ToString + " to their own " + strTypeDmg & Environment.NewLine)


        UpdateStats()

    End Sub
    'emp drains a fixed ammount of health, power, and shields and  tesla charge
    Private Sub EMP()
        Dim winForm = New EMP
        winForm.ShowDialog()
        'reduce all 3 stats
        intP1Health = intP1Health - 25
        If intP1Shields >= 25 Then
            intP1Shields = intP1Shields - 25
        Else
            intP1Shields = 0
        End If

        intp1Power = intp1Power - 25
        'if tesla has charge reduce it by 10
        If intP1Charge >= 25 Then
            intP1Charge = intP1Charge - 25
        Else
            intP1Charge = 0
        End If
        'add to recap
        txtRecap.AppendText(strP2Name + " detonated an eltromagnetic pulse, draining the health, shields, and power and Tesla cannon charge of " + strP1Name + " by 25" & Environment.NewLine)

        UpdateStats()

    End Sub

    Private Sub GameEndCheck()
        Dim WinForm As New EndGame
        WinForm.strP1Name = strP1Name
        'if player 1 health or power reaches 0 they lose
        If intP1Health <= 0 Or intp1Power <= 0 Then
            blnGameOver = True
            'display scorpion wins image
            WinForm.Picture = AppDomain.CurrentDomain.BaseDirectory + "/images/scorp_win.gif"
            WinForm.Show()
            Me.Close()
            'if player 2 health or power drops to 0 they lose
        ElseIf intP2Health <= 0 Or intp2Power <= 0 Then
            blnGameOver = True
            WinForm.blnP1Win = True
            WinForm.Picture = AppDomain.CurrentDomain.BaseDirectory + "/images/scorp_lose.gif"
            WinForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAttackChoiceP2_Click(sender As Object, e As EventArgs) Handles btnAttackChoiceP2.Click
        Dim WinForm As New AdvancedChoices
        WinForm.Show()

    End Sub
End Class