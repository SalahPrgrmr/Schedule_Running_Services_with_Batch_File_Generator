Imports Microsoft.Management.Infrastructure
Imports System.Management
Imports System.Net
Imports System.Linq
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Net.NetworkInformation

Public Class Form1

    Dim X As String = ""
    Dim Y As Int64 = 0
    Dim Z As Int64 = 0
    Dim K As Integer = 0
    Dim OddXEven As Integer = 1


    Dim psBattery As PowerStatus = SystemInformation.PowerStatus
    Dim perFull As Single = psBattery.BatteryLifePercent
    Dim status As PowerStatus = SystemInformation.PowerStatus

    Dim xindex As Integer
    Dim xstring As String

    Sub Ping_test()


        Try
            Dim myPing As Ping = New Ping()
            Dim PLOC As String
            Dim PNET As String
            Dim reply As PingReply = myPing.Send(TPLOC.Text, 1000)
            Dim replyNet As PingReply = myPing.Send(TPNET.Text, 1000)
            LPLOC.Text = "LStatus :  " & reply.Status.ToString & "  Time : " & reply.RoundtripTime.ToString & "  Address : " & reply.Address.ToString
            LPNET.Text = "NStatus :  " & replyNet.Status.ToString & "  Time : " & replyNet.RoundtripTime.ToString & "  Address : " & replyNet.Address.ToString
        Catch ex As Exception

        End Try


    End Sub

    Sub Test()
        Try


            Dim speeds As Double() = New Double(4) {}
            For i As Integer = 0 To 4
                Dim jQueryFileSize As Integer = 261
                'Size of File in KB.
                Dim client As New WebClient()
                Dim startTime As DateTime = DateTime.Now
                client.DownloadFile("https://intern.hethoutsemeer.nl/index2.php?option=com_webservices&controller=csv&method=hours.board.fetch&key=F2mKaXYGzbjMA4V&element=departments", "intern.hethoutsemeer.nl.1505213278-Departments.csv")
                'client.DownloadFile("http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.js", Server.MapPath("~/jQuery.js"))
                Dim endTime As DateTime = DateTime.Now
                speeds(i) = Math.Round((jQueryFileSize / (endTime - startTime).TotalSeconds))
            Next
            NST.Text = String.Format("Download Speed: {0}KB/s", speeds.Average())
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bat_Data()
        L1.SelectedIndex = 0
        B0.Text = 0
        B1.Text = 0
        B2.Text = 0
        TIMEBEFORE1UC.Text = 0
        MinFromStart.Text = 0



        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - 230)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - 195)
        'Timer1.Enabled = True

    End Sub

    Sub MeOnTop()
        If OnTopToolStripMenuItem.CheckState = CheckState.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
    Sub Bat_Data()
        L1.Items.Clear()
        L2.Items.Clear()
        OddXEven = 0
        Y = 0

        For i As Integer = 0 To 99
            L1.Items.Add(i + 1)
            L2.Items.Add(0).ToString()
        Next
    End Sub



    Sub Bat_FullyCharge_calc()
        Try


            TIMENOW.Text = Now.ToString

            If ((CInt(L1.SelectedItem) <> 100) Or (CInt(L1.SelectedItem) <> 0)) And (status.PowerLineStatus.ToString() = "Online") Then
                TIMEBEFORE1UC.Text = OddXEven
                MinFromStart.Text = Y

                xindex = status.BatteryLifePercent.ToString("P0").IndexOf("%")
                xstring = status.BatteryLifePercent.ToString("P0").Substring(0, xindex)
                B0.Text = xstring
                L1.SelectedIndex = CInt(xstring) - 1
                L2.SelectedIndex = CInt(xstring) - 1

                If CInt(xstring) Mod 2 = 0 Then
                    OddXEven = 0
                    Y += 1
                    L2.Items.Item(CInt(xstring) - 1) = Y

                Else
                    Y = 0
                    OddXEven += 1
                    L2.Items.Item(CInt(xstring) - 1) = OddXEven

                End If

                Dim Xcnt As Integer = 0
                Dim XFCR As Integer = 0

                For j As Integer = 0 To 99



                    If L2.Items.Item(j) >= 60 Then
                        Xcnt += 1
                        XFCR = XFCR + L2.Items.Item(j)
                    End If
                    If Xcnt > 1 Then

                        B1.Text = CInt((((XFCR / Xcnt) * (100 - CInt(xstring))) / 60) / 2)
                    Else
                        B1.Text = 0
                    End If

                Next


                B2.Text = Xcnt

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub ShowBatInfo()
        If perFull * 100 > 100 Then
            ProgressBar1.Value = 100
        ElseIf perFull * 100 < 100 Then
            ProgressBar1.Value = perFull * 100
        End If

        txtChargeStatus.Text = "Charge Status : " & status.BatteryChargeStatus.ToString()
        txtFullLifetime.Text = "Fully Time : " & B1.Text & " Min" 'If(status.BatteryFullLifetime = -1, "Unknown", CInt(status.BatteryFullLifetime.ToString()) / 60)
        txtBatteryPercent.Text = "Battery Percent : " & status.BatteryLifePercent.ToString("P0")
        txtLifeRemaining.Text = "Life Remaining : " & If(status.BatteryLifeRemaining = -1, "Unknown", CInt(status.BatteryLifeRemaining.ToString() / 60)) & " Min"
        txtPowerLineStatus.Text = "Power Line Status : " & status.PowerLineStatus.ToString()
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MeOnTop()
        Try


            Bat_FullyCharge_calc()
            ShowBatInfo()
            Test()
            Ping_test()

        Catch ex As Exception

        End Try










    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub OnTopToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs) Handles OnTopToolStripMenuItem.CheckStateChanged
        MeOnTop()
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        MsgBox(X)
    End Sub

    Private Sub txtPowerLineStatus_TextChanged(sender As Object, e As EventArgs) Handles txtPowerLineStatus.TextChanged
        Bat_Data()
    End Sub






End Class



'Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'    Dim status As PowerStatus = SystemInformation.PowerStatus
'    txtChargeStatus.Text = "ChargeStatus : " & status.BatteryChargeStatus.ToString()
'    txtFullLifetime.Text = "FullLifetime : " & If(status.BatteryFullLifetime = -1, "Unknown", status.BatteryFullLifetime.ToString())
'    txtBatteryPercent.Text = "BatteryPercent : " & status.BatteryLifePercent.ToString("P0")
'    txtLifeRemaining.Text = "LifeRemaining : " & If(status.BatteryLifeRemaining = -1, "Unknown", status.BatteryLifeRemaining.ToString())
'    txtPowerLineStatus.Text = "PowerLineStatus : " & status.PowerLineStatus.ToString()
'End Sub
'Dim i As Integer = 0
'If psBattery.PowerLineStatus = PowerLineStatus.Online Then
'    ' Me.Text = "Battinfo - " & perFull * 100 & "%" & " charging!"
'    Label1.Text = "Battinfo - " & perFull * 100 & "%" & " charging!"
'ElseIf psBattery.PowerLineStatus = PowerLineStatus.Offline Then
'    ' Me.Text = "Battinfo - " & perFull * 100 & "%" & " don´t charging"
'    Label1.Text = "Battinfo - " & perFull * 100 & "%" & " don´t charging"
'End If
'Timer1.Interval = 10000



'If CInt(xstring) Mod 2 = 0 Then
'    Y += 1
'Else
'    OddXEven += 1
'End If

'B0.Text = status.BatteryLifePercent.ToString("0")
'Y += 1
' K += 1
'OddXEven += 1
