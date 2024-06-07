Public Class Form1
    'to count every tick of timer1
    Dim runRoblox As Integer
    Dim canRunRoblox
    Dim canEnd As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Add 1 to runRoblox
        runRoblox = runRoblox + 1
        If runRoblox = 50 Then
            'If its 50 then change the labels
            Label1.Text = "   Almost ready..."
            Label2.Text = "          Wait a litle bit more!"
            'I don`t know how to change the location of the labels so i'll just ad spaces to the text
        End If
        'If runRoblox is 100 set canRunRoblox to true then open roblox and stop the timer for less cpu usage
        If runRoblox = 100 Then
            canRunRoblox = True 'sets canRunRoblox to true
            Button1.Visible = True 'to run roblox bro
            ProgressBar1.Visible = False 'make ui more beautiful
            Label1.Text = "       All ready!"
            Label2.Text = "Press the green button to run roblox!"
            Timer1.Stop() 'stops the timer

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DON'T DELETE THIS UNDER ANY CIRCUMSTANCES OR THE APP WILL NOT WORK
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'credits
        MessageBox.Show("Developed by 1hyzh in 2024", "RobloxPlayerLauncher", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If canRunRoblox = True Then 'you can run roblox
            Process.Start("cmd.exe", "/c start %localappdata%\Roblox\Versions\version-d6abc3b106a04c5c\RobloxPlayerBeta.exe && exit")
            'this version of roblox, to change the version just change the "version-something" to the one that you want
            'Roblox it's executed via cmd
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        canEnd = canEnd + 1
        If canEnd > 25 Then 'to wait a litle bit until roblox is opened
            Timer2.Stop()
            End
        End If
    End Sub
End Class
