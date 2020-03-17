Public Class Form1

    Dim CtrlClicked As Boolean = False
    Dim AltClicked As Boolean = False
    Dim WinClicked As Boolean = False
    Dim ShiftClicked As Boolean = False
    Dim Fndropclicked As Boolean = False
    Dim BackClicked As Boolean = False
    Dim EntClicked As Boolean = False
    Dim Letclicked As Boolean = False
    Dim Cmdcicked As Boolean = False
    Dim ccmd As String = ""




    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        Timer1.Start()
        BunifuTileButton6.color = Color.DarkGreen



    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        BunifuTileButton7.color = Color.DarkRed
        Timer1.Stop()
        Timer1.Dispose()

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BunifuThinButton1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim b = BunifuMaterialTextbox1.Text



        If (CtrlClicked.Equals(True)) Then
            SendKeys.Send("^(" + b + ")")

        ElseIf (ShiftClicked.Equals(True)) Then
            SendKeys.Send("+(" + b + ")")

        ElseIf (AltClicked.Equals(True)) Then
            SendKeys.Send("%(" + b + ")")

        ElseIf (WinClicked.Equals(True)) Then
            SendKeys.Send("^{ESC}")

        ElseIf (EntClicked.Equals(True)) Then
            SendKeys.Send("{ENTER}")

        ElseIf (BackClicked.Equals(True)) Then
            SendKeys.Send("{BS}")

        ElseIf (Letclicked.Equals(True)) Then
            SendKeys.Send(BunifuMaterialTextbox3.Text)

        ElseIf (Cmdcicked.Equals(True)) Then
            ccmd = BunifuMaterialTextbox4.Text
            Shell("CMD.EXE /k" & ccmd)


        ElseIf (Fndropclicked.Equals(True)) Then

            If (BunifuDropdown2.selectedIndex.Equals(0)) Then
                SendKeys.Send("{F1}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(1)) Then
                SendKeys.Send("{F2}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(2)) Then
                SendKeys.Send("{F3}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(3)) Then
                SendKeys.Send("{F4}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(4)) Then
                SendKeys.Send("{F5}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(5)) Then
                SendKeys.Send("{F6}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(6)) Then
                SendKeys.Send("{F7}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(7)) Then
                SendKeys.Send("{F8}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(8)) Then
                SendKeys.Send("{F9}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(9)) Then
                SendKeys.Send("{F10}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(10)) Then
                SendKeys.Send("{F11}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(11)) Then
                SendKeys.Send("{F12}")

            End If




        End If




    End Sub

    Public Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        CtrlClicked = True
        BunifuTileButton1.color = Color.DarkSlateBlue






    End Sub

    Public Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        AltClicked = True
        BunifuTileButton3.color = Color.DarkSlateBlue

    End Sub

    Public Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        ShiftClicked = True
        BunifuTileButton2.color = Color.DarkSlateBlue

    End Sub

    Public Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        WinClicked = True
        BunifuTileButton4.color = Color.DarkSlateBlue

    End Sub



    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs)
        Dim A = Convert.ToInt32(BunifuMaterialTextbox2.Text)



        If (BunifuDropdown1.selectedIndex.Equals(0)) Then
            'Timer1.Interval
            Timer1.Interval = A

        ElseIf (BunifuDropdown1.selectedIndex.Equals(1)) Then
            Timer1.Interval = A * 1000

        ElseIf (BunifuDropdown1.selectedIndex.Equals(2)) Then
            Timer1.Interval = A * 1000 * 60

        Else
            Timer1.Interval = A * 1000 * 60 * 60



        End If
    End Sub

    Public Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs)
        Fndropclicked = True

    End Sub

    Private Sub BunifuDropdown2_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown2.onItemSelected
        Fndropclicked = True
    End Sub

    Private Sub BunifuTileButton9_Click(sender As Object, e As EventArgs) Handles BunifuTileButton9.Click
        Dim b = BunifuMaterialTextbox1.Text



        If (CtrlClicked.Equals(True)) Then
            SendKeys.Send("^(" + b + ")")

        ElseIf (ShiftClicked.Equals(True)) Then
            SendKeys.Send("+(" + b + ")")

        ElseIf (AltClicked.Equals(True)) Then
            SendKeys.Send("%(" + b + ")")

        ElseIf (WinClicked.Equals(True)) Then
            SendKeys.Send("^{ESC}")

        ElseIf (EntClicked.Equals(True)) Then
            SendKeys.Send("{ENTER}")

        ElseIf (BackClicked.Equals(True)) Then
            SendKeys.Send("{BS}")

        ElseIf (Letclicked.Equals(True)) Then
            SendKeys.Send(BunifuMaterialTextbox3.Text)

        ElseIf (Cmdcicked.Equals(True)) Then
            ccmd = BunifuMaterialTextbox4.Text
            Shell("CMD.EXE /k" & ccmd)


        ElseIf (Fndropclicked.Equals(True)) Then

            If (BunifuDropdown2.selectedIndex.Equals(0)) Then
                SendKeys.Send("{F1}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(1)) Then
                SendKeys.Send("{F2}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(2)) Then
                SendKeys.Send("{F3}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(3)) Then
                SendKeys.Send("{F4}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(4)) Then
                SendKeys.Send("{F5}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(5)) Then
                SendKeys.Send("{F6}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(6)) Then
                SendKeys.Send("{F7}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(7)) Then
                SendKeys.Send("{F8}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(8)) Then
                SendKeys.Send("{F9}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(9)) Then
                SendKeys.Send("{F10}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(10)) Then
                SendKeys.Send("{F11}")
            ElseIf (BunifuDropdown2.selectedIndex.Equals(11)) Then
                SendKeys.Send("{F12}")

            End If




        End If
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        BackClicked = True
        BunifuTileButton5.color = Color.DarkSlateBlue
    End Sub

    Private Sub BunifuTileButton8_Click(sender As Object, e As EventArgs) Handles BunifuTileButton8.Click
        EntClicked = True
        BunifuTileButton8.color = Color.DarkSlateBlue
    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged
        Letclicked = True
    End Sub

    Private Sub BunifuMaterialTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox4.OnValueChanged
        Cmdcicked = True


    End Sub

    Private Sub BunifuMaterialTextbox3_Leave(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.Leave
        Letclicked = True
    End Sub

    Private Sub BunifuTileButton10_Click(sender As Object, e As EventArgs) Handles BunifuTileButton10.Click

        Application.Restart()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim A = Convert.ToInt32(BunifuMaterialTextbox2.Text)



        If (BunifuDropdown1.selectedIndex.Equals(0)) Then
            'Timer1.Interval
            Timer1.Interval = A

        ElseIf (BunifuDropdown1.selectedIndex.Equals(1)) Then
            Timer1.Interval = A * 1000

        ElseIf (BunifuDropdown1.selectedIndex.Equals(2)) Then
            Timer1.Interval = A * 1000 * 60

        Else
            Timer1.Interval = A * 1000 * 60 * 60



        End If
    End Sub
End Class
