'window used for 3 main robot types
Public Class frmMainFight
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
    Private strProfileLiteP2 As String
    Private strProfileMidP2 As String
    Private strProfileHeavyp2 As String
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


    'on load define all robot stats and images
    Private Sub frmMainFight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        'player 1 name was sent from previous forms - display on form
        lblP1Name.Text = _strP1Name
        'set variable for profile image locations
        strProfileLiteP1 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_ripper_blue.gif"
        strProfileMidP1 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_static_blue.gif"
        strProfileHeavyp1 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_hardcase_blue.gif"
        strProfileLiteP2 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_ripper_red.gif"
        strProfileMidP2 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_static_red.gif"
        strProfileHeavyp2 = AppDomain.CurrentDomain.BaseDirectory + "/images/p_hardcase_red.gif"
        'conditional check - check which robot was selected for player 1 - create new instance of associated class - set lose picture
        If _blnP1Lite Then
            pBoxP1.ImageLocation = strProfileLiteP1
            Player1 = New Ripper
            strPlayer2Win = AppDomain.CurrentDomain.BaseDirectory + "/images/R_lose.gif"
        ElseIf _blnP1Mid Then
            pBoxP1.ImageLocation = strProfileMidP1
            Player1 = New Statik
            strPlayer2Win = AppDomain.CurrentDomain.BaseDirectory + "/images/S_lose.gif"
        ElseIf _blnP1Heavy = True Then
            pBoxP1.ImageLocation = strProfileHeavyp1
            Player1 = New Hardcase
            strPlayer2Win = AppDomain.CurrentDomain.BaseDirectory + "/images/H_Lose.gif"

        End If
        'conditional check - check which robot was selected for player 2 - create new instance of associated class -set name on form - set lose picture
        If _blnP2Lite Then
            pBoxP2.ImageLocation = strProfileLiteP2
            Player2 = New Ripper
            strP2Name = "Ripper"
            strPlayer1Win = AppDomain.CurrentDomain.BaseDirectory + "/images/R_win.gif"
        ElseIf _blnP2Mid Then
            pBoxP2.ImageLocation = strProfileMidP2
            Player2 = New Statik
            strP2Name = "Static"
            strPlayer1Win = AppDomain.CurrentDomain.BaseDirectory + "/images/S_win.gif"
        ElseIf _blnP2Heavy Then
            pBoxP2.ImageLocation = strProfileHeavyp2
            Player2 = New Hardcase
            strP2Name = "Hardcase"
            strPlayer1Win = AppDomain.CurrentDomain.BaseDirectory + "/images/H_win.gif"
        End If
        'set player 1 stat variables = to what is defined in class
        intP1Health = Player1.intHealth
        intp1Power = Player1.intPower
        intP1Shields = Player1.intShields
        intP1Missiles = Player1.intMissiles
        intP1Powerups = Player1.intPowerups
        intP1Charge = Player1.intCharge
        intP1ChargeAmmount = Player1.intChargeAmmount
        'set player 2 stat variables = to what is defined in class
        intP2Health = Player2.intHealth
        intp2Power = Player2.intPower
        intP2Shields = Player2.intShields
        intP2Missiles = Player2.intMissiles
        intP2Powerups = Player2.intPowerups
        intP2Charge = Player2.intCharge
        intP2ChargeAmmount = Player2.intChargeAmmount
        'set player 1 stat labels to variable values
        lblP1Health.Text = Player1.intHealth
        lblP1Power.Text = Player1.intPower
        lblP1Shields.Text = Player1.intShields
        lblP1Powerups.Text = Player1.intPowerups
        lblP1Missiles.Text = Player1.intMissiles
        lblp1Charge.Text = Player1.intCharge
        'set player 2 stat labels to variable values
        lblP2Health.Text = Player2.intHealth
        lblP2Power.Text = Player2.intPower
        lblP2Shields.Text = Player2.intShields
        lblP2Powerups.Text = Player2.intPowerups
        lblP2Missiles.Text = Player2.intMissiles
        lblP2Charge.Text = Player2.intCharge
        lblP2Name.Text = strP2Name
        'determine who attacks first
        Dim WinFlip As New CoinFlip
        WinFlip.ShowDialog()
        _blnP1Turn = WinFlip.blnPlayer1Turn
        If _blnP1Turn Then
            P1Turn()
        Else
            P2Turn()
            Player2Attack()
        End If

    End Sub

    'player 1 turn enable all player 1 buttons and disable all player 2 buttons
    Private Sub P1Turn()
        btnCannonP1.Enabled = True
        btnGunP1.Enabled = True
        btnPowerP1.Enabled = True
        btnMissileP1.Enabled = True

        btnCannonP2.Enabled = False
        btnGunP2.Enabled = False
        btnPowerP2.Enabled = False
        btnMissileP2.Enabled = False


    End Sub

    'player 2 turn enable all player 2 buttons and disable all player 1 buttons
    Private Sub P2Turn()
        btnCannonP2.Enabled = True
        btnGunP2.Enabled = True
        btnPowerP2.Enabled = True
        btnMissileP2.Enabled = True

        btnCannonP1.Enabled = False
        btnGunP1.Enabled = False
        btnPowerP1.Enabled = False
        btnMissileP1.Enabled = False
    End Sub

    'update all stat labels with current variable values - both players
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
        txtRecap.AppendText(_strP1Name + " riddled " + strP2Name + " " + intAttackChance.ToString + " times for " + intTotalDamage.ToString + " damage!" & Environment.NewLine)

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
            If intP1Missiles >= 1 Then
                intP1Missiles = intP1Missiles - 1
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
        txtRecap.AppendText(_strP1Name + " bombarded " + strP2Name + " with " + intMissilesUsed.ToString + " missiles for " + intTotalDamage.ToString + " damage" & Environment.NewLine)

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
        txtRecap.AppendText(_strP1Name + " scorched " + strP2Name + " for " + intAttack.ToString + " damage" & Environment.NewLine)
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
            txtRecap.AppendText(_strP1Name + " received 10 missiles" & Environment.NewLine)
        ElseIf intPowerUp = 2 Then
            'player launched dron strike hitting opponent for 200 damage and ignoring shields
            Dim WinForm = New frmDroneP1
            WinForm.ShowDialog()
            intP2Health = intP2Health - 200
            txtRecap.AppendText(_strP1Name + " launched a drone attack against" + strP2Name + " for 200 damage" & Environment.NewLine)
        ElseIf intPowerUp = 3 Then
            'player gets full power
            Dim winForm As New P1FullPower
            winForm.ShowDialog()
            intp1Power = 1000
            txtRecap.AppendText(_strP1Name + " now has full power" & Environment.NewLine)

        ElseIf intPowerUp = 4 Then
            'player gets 250 points added to shield up to their maximum alloted ammount
            Dim winForm As New P1Sheilds
            winForm.ShowDialog()
            intP1Shields = Player1.ShieldPowerUp(intP1Shields)
            txtRecap.AppendText(_strP1Name + " has had their shields recharged" & Environment.NewLine)
        ElseIf intPowerUp = 5 Then
            'player gets full health
            intP1Health = Player1.intHealth
            Dim winForm As New P1Health
            winForm.ShowDialog()
            txtRecap.AppendText(_strP1Name + " is now at full health" & Environment.NewLine)
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
        intp2AttackChoice = ranP2Attack.Next(1, 5)
        If intp2AttackChoice = 1 Then
            Player2MachineGun()
        ElseIf intp2AttackChoice = 2 And intP2Missiles >= 0 Then
            Player2MissileLauncher()
        ElseIf intp2AttackChoice = 3 And intP2Charge = 100 Then
            Player2TeslaCannon()
        ElseIf intp2AttackChoice = 4 And intP2Powerups > 0 Then
            Player2PowerUp()
        Else
            Player2MachineGun()
        End If
        GameEndCheck()
        If blnGameOver = False Then
            P1Turn()
            AvailableP1()
        End If

    End Sub

    'check stats and enable/disable buttons accordingly
    Private Sub AvailableP2()
        If intp2Power < intTeslaPowerCost Then
            btnPowerP2.Enabled = False
            btnCannonP2.Enabled = False
        End If
        If intp2Power < intMissilePowerCost Then
            btnMissileP2.Enabled = False
        End If

        If intP2Missiles = 0 Then
            btnMissileP2.Enabled = False
            btnMissileP2.Text = "Out of Missiles"
        Else
            btnMissileP2.Text = "Missile Launcher"
        End If

        If intP2Powerups = 0 Then
            btnPowerP2.Enabled = False
            btnPowerP2.Text = "Out of Powerups"
        End If
        'display charge ammount on button
        If intP2Charge < 100 Then
            btnCannonP2.Enabled = False
            btnCannonP2.Text = "Recharging " + "(" + intP2Charge.ToString + "%" + ")"
        ElseIf intP2Charge = 100 Then
            btnCannonP2.Text = "Tesla Cannon"
            btnCannonP2.Enabled = True

        End If
    End Sub

    'machine gun attack
    Private Sub Player2MachineGun()
        'check availibilty
        AvailableP2()
        'variable for multi attack chance
        Dim intAttackChance As Integer
        'variable for total damage delt
        Dim intTotalDamage As Integer = 0
        'call sub from player 2 object to see if attack was dodged
        'if dodge was sucessfull display message and go to end of turn
        If Player1.Dodge() Then
            MessageBox.Show("Your dodged the attack")
            txtRecap.AppendText(_strP1Name + " dodged an attack!" & Environment.NewLine)
        Else
            'if no dodge - continue with attack
            'create new random object and variables
            Dim ranAttack As New Random
            Dim intAttack As Integer
            Dim intAttackTotal As Integer
            Dim intShieldDamage As Integer

            'create new attack alert window
            Dim win As New frmMGunP2
            'check for multi attack
            intAttackChance = Player2.MultiAttack()
            'loop from 1 to returned multiattack number (minimum of 1)
            For intCounter = 1 To intAttackChance
                'for each itteration generate a random number between 10 and 40 this is damage
                intAttack = ranAttack.Next(10, 41)
                'check if critical hit, if so double the damage
                If Player2.Critical() Then
                    intAttack = intAttack * 2
                    blnCrit = True
                Else
                    intAttack = intAttack
                    blnCrit = False
                End If
                'check if shields are present
                intAttackTotal = Player1.ShieldAttack(intAttack, intP1Shields)
                intTotalDamage = intTotalDamage + intAttack
                intShieldDamage = Player1.ShieldCheck(intAttack, intP1Shields)
                'adjust health and shields
                intP1Health = intP1Health - intAttackTotal
                intP1Shields = intP1Shields - intShieldDamage
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
        If intP2Charge < 100 Then
            intP2Charge = intP2Charge + intP2ChargeAmmount
            If intP2Charge > 100 Then
                intP2Charge = 100
            Else
                intP2Charge = intP2Charge
            End If
        End If
        'subtract power cost 
        intp2Power = intp2Power - intGunPowerCost
        'add details to recap window
        txtRecap.AppendText(strP2Name + " riddled " + _strP1Name + " " + intAttackChance.ToString + " times for " + intTotalDamage.ToString + " damage!" & Environment.NewLine)
        'update all stats - check if anyone won - player 1 turn
        UpdateStats()
        AvailableP2()



    End Sub

    'sub for missile attack
    Private Sub Player2MissileLauncher()
        'set variables
        Dim intTotalDamage As Integer = 0
        Dim intMissilesUsed As Integer = 0
        Dim intShieldDamage As Integer = 0
        'check if attack was dodged
        If Player1.Dodge() Then
            'if dodged - show dodge window - add to recap window - subtract 1 missile
            MessageBox.Show("You dodged the attack")
            If intP2Missiles >= 1 Then
                intP2Missiles = intP2Missiles - 1
            Else
                intP2Missiles = 0
            End If

            txtRecap.AppendText(_strP1Name + " dodged an attack!" & Environment.NewLine)

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
            Dim win As New P2Missile
            'generate random number between 1 and the ammount of missiles the player has - this will be the missiles launched
            intAttackChance = ranNum.Next(1, intP2Missiles + 1)
            intMissilesUsed = intAttackChance
            'loop for as many missiles are being used
            For intCounter = 1 To intAttackChance
                'new random number between 20 and 60 - this is missile damage
                intAttack = ranNum.Next(20, 61)
                If Player2.Critical() Then
                    'if critical hit - double damage
                    intAttack = intAttack * 2
                    blnCrit = True
                Else
                    intAttack = intAttack
                    blnCrit = False
                End If
                'check shields and determine damage
                intAttackTotal = Player1.ShieldAttack(intAttack, intP1Shields)
                intTotalDamage = intTotalDamage + intAttack
                intShieldDamage = Player1.ShieldCheck(intAttack, intP1Shields)
                'adjust stats
                intP1Health = intP1Health - intAttackTotal
                intP1Shields = intP1Shields - intShieldDamage
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
        If intP2Charge < 100 Then
            intP2Charge = intP2Charge + intP2ChargeAmmount
            If intP2Charge >= 100 Then
                intP2Charge = 100
            Else
                intP2Charge = intP2Charge
            End If
        End If
        'subtract power cost
        intp2Power = intp2Power - intMissilePowerCost
        'subtract missiles used
        intP2Missiles = intP2Missiles - intMissilesUsed
        'add attack details to recap window
        txtRecap.AppendText(strP2Name + " bombarded " + _strP1Name + " with " + intMissilesUsed.ToString + " missiles for " + intTotalDamage.ToString + " damage" & Environment.NewLine)

        'update all stats - check if anyone won - player 1 turn
        UpdateStats()
        AvailableP2()

    End Sub

    'sub for tesla cannon attack
    Private Sub Player2TeslaCannon()
        'create new random object
        Dim ranNum As New Random
        'create new variables for attack damage
        Dim intAttack As Integer
        Dim intAttackTotal As Integer
        Dim intShieldDamage As Integer = 0
        Dim intSplashDamage As Integer
        Dim win As New P2Tesla
        'generate new random number between 100 and 150 - this is damage to opponent
        intAttack = ranNum.Next(100, 151)
        'divide damage by 4 - this is splash damage to instigating player
        intSplashDamage = intAttack / 4
        'check shields and determine damage
        intAttackTotal = Player1.ShieldAttack(intAttack, intP1Shields)
        intShieldDamage = Player1.ShieldCheck(intAttack, intP1Shields)
        'adjust stats
        intP1Health = intP1Health - intAttackTotal
        intP1Shields = intP1Shields - intShieldDamage
        'show tesla attack window with damage and splash damage
        win.intDamage = intAttack
        win.intSpash = intSplashDamage
        win.ShowDialog()
        'hit instigating player with splash damage
        intP2Health = intP2Health - intSplashDamage
        'set players tesla cannon charge ammount to 0
        intP2Charge = 0
        'subtract power cost
        intp2Power = intp2Power - intTeslaPowerCost
        'add details to recap window
        txtRecap.AppendText(strP2Name + " scorched " + _strP1Name + " for " + intAttack.ToString + " damage" & Environment.NewLine)
        txtRecap.AppendText(strP2Name + " was caught in the blast for " + intSplashDamage.ToString + " damage" & Environment.NewLine)


        'update stats - check if anyone won -player 1 turn
        UpdateStats()
        AvailableP2()

    End Sub

    'sub for powerups
    Private Sub Player2PowerUp()
        'create new random object
        Dim intRan As New Random
        Dim intPowerUp As Integer
        'generate new random number between 1 and 6 - this is the powerup used
        intPowerUp = intRan.Next(1, 7)
        'powerups 1 = missiles, 2 = drone strike, 3 = full power, 4 = shields, 5 = full health, 6 = full tesla cannon charge
        If intPowerUp = 1 Then
            'player gets 10 extra missiles
            Dim winForm = New P2MissilePowerUp
            winForm.ShowDialog()
            intP2Missiles = intP2Missiles + 10
            txtRecap.AppendText(strP2Name + " received 10 missiles" & Environment.NewLine)

        ElseIf intPowerUp = 2 Then
            'player launched dron strike hitting opponent for 200 damage and ignoring shields
            Dim WinForm = New P2DroneStrike
            WinForm.ShowDialog()
            intP1Health = intP1Health - 200
            txtRecap.AppendText(strP2Name + " launched a drone attack against" + _strP1Name + " for 200 damage" & Environment.NewLine)

        ElseIf intPowerUp = 3 Then
            'player gets full power
            Dim winForm As New P2FullPower
            winForm.ShowDialog()
            intp2Power = 1000
            txtRecap.AppendText(strP2Name + " now has full power" & Environment.NewLine)

        ElseIf intPowerUp = 4 Then
            'player gets 250 points added to shield up to their maximum alloted ammount
            Dim winForm As New P2Sheilds
            winForm.ShowDialog()
            intP2Shields = Player1.ShieldPowerUp(intP2Shields)
            txtRecap.AppendText(strP2Name + " has had their shields recharged" & Environment.NewLine)

        ElseIf intPowerUp = 5 Then
            'player gets full health
            intP2Health = Player2.intHealth
            Dim winForm As New P2Health
            winForm.ShowDialog()
            txtRecap.AppendText(strP2Name + " is now at full health" & Environment.NewLine)

        ElseIf intPowerUp = 6 Then
            'players tesla cannon is fully recharged
            intP2Charge = 100
            Dim WinForm As New P2TeslaPowerUp
            WinForm.ShowDialog()
            txtRecap.AppendText(strP2Name + "'s Tesla Cannon has been fully recharged" & Environment.NewLine)

        End If
        'remove one powerup
        intP2Powerups = intP2Powerups - 1
        'subtract power cost
        intp2Power = intp2Power - intPowerUpPowerCost
        'update stats - check if anyone won -player 2 turn
        UpdateStats()
        AvailableP2()

    End Sub

    'check to see if anyone won
    Private Sub GameEndCheck()
        'create new form for win/loss window
        Dim WinForm As New EndGame
        'pass player 1 name to form for future use
        WinForm.strP1Name = _strP1Name
        If intP1Health <= 0 Or intp1Power <= 0 Then
            blnGameOver = True
            'if player 1 health or power is 0 or less they lose
            WinForm.Picture = strPlayer2Win
            WinForm.ShowDialog()
            Me.Close()
        ElseIf intP2Health <= 0 Or intp2Power <= 0 Then
            blnGameOver = True
            'if player 2 health or power is 0 or less they lose
            'check which robot was fought and set boolean to true for tracking purposes
            If blnP2Lite Then
                _blnBeatLite = True
            ElseIf blnP2Mid Then
                _blnBeatMid = True
            ElseIf blnP2Heavy Then
                _blnBeatHeavy = True
            End If
            'pass current player 1 robot type
            WinForm.blnP1Lite = _blnP1Lite
            WinForm.blnP1Mid = _blnP1Mid
            WinForm.blnP1Heavy = _blnP1Heavy
            'let the form know player 1 won
            WinForm.blnP1Win = True
            'pass the booleans
            WinForm.blnBeatLite = _blnBeatLite
            WinForm.blnBeatMid = _blnBeatMid
            WinForm.blnBeatHeavy = _blnBeatHeavy
            'set the win/loss picture
            WinForm.Picture = strPlayer1Win
            'show window
            WinForm.ShowDialog()
            'close current window
            Me.Close()
        End If
    End Sub

    Private Sub btnP1Choices_Click(sender As Object, e As EventArgs) Handles btnP1Choices.Click
        Dim WinForm As New StandardChoicesP1
        WinForm.Show()

    End Sub

    Private Sub btnP2Choices_Click(sender As Object, e As EventArgs) Handles btnP2Choices.Click
        Dim WinForm As New StandardChoicesP2
        WinForm.Show()
    End Sub
End Class
