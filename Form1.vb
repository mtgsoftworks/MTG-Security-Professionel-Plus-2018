Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form6.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form7.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form10.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MsgBox("Bilgisayarınız Hızlandırılıyor")
        Shell("cmd /c" + "Rundll32.exe(advapi32.dll")
        Shell("cmd /c" + "ProcessldleTasks()")
        Shell("cmd /c" + "attrib -H -R -A C:\WINDOWS\Prefetch\*.*")
        Shell("cmd /c" + "attrib -H -R -A C:\WINDOWS\Temp\*.*")
        Shell("cmd /c" + "attrib -H -R -A %userprofile%\local settings\temporary internet files\*.*")
        Shell("cmd /c" + "attrib -H -R -A %userprofile%\local settings\temporary internet files\*.*")
        Shell("cmd /c" + "attrib -H -R -A %userprofile%\Cookies\*.*")
        Shell("cmd /c" + "del(C:\WINDOWS\Prefetch\*.*")
        Shell("cmd /c" + "del(C:\WINDOWS\Temp\*.*")
        Shell("cmd /c" + "del(%userprofile%\local settings\temporary internet files\*.*")
        Shell("cmd /c" + "del(%userprofile%\local settings\temporary internet files\*.*")
        MsgBox("Bilgisyarınız Hızlandırıldı")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        MsgBox("İnternet Geçmişi Siliniyor")
        Shell("cmd /c" + "Net config server /hidden:yes")
        Shell("cmd /c" + "ipconfig /registerdns")
        Shell("cmd /c" + "RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 32")
        Shell("cmd /c" + "RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 1")
        Shell("cmd /c" + "RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")
        MsgBox("İnternet Geçmişi Silindi")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        MsgBox("İnternetiniz Hızlandırılıyor")
        Shell("cmd /c" + "netsh int tcp show global")

        Shell("cmd /c" + "netsh int tcp set global chimney=enabled")

        Shell("cmd /c" + "netsh int tcp set global autotuninglevel=normal")

        Shell("cmd /c" + "netsh int tcp set global congestionprovider=ctcp")

        Shell("cmd /c" + "netsh int tcp show global")
        MsgBox("İnternetiniz Hızlandırıldı")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MsgBox("Bu Program Mesut Taha Güven Tarafından Yazılmıştır")
        MsgBox("2018 MTG Software")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MsgBox("Ip Adresiniz Değiştiriliyor")
        Shell("cmd /c" + "ipconfig /release")
        Shell("cmd /c" + "ipconfig /renew")
        MsgBox("Ip Adresiniz Değitirildi")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        MsgBox("Otomatik Virüs Temizleme İşlemi Başlatıldı")
        Shell("cmd /c" + "nret=geekside.Run(cmd /C taskkill /f /im amvo.exe", 0, True)
        Shell("cmd /c" + "For Each objDrive in colDrives")
        Shell("cmd /c" + "If objDrive.IsReady = True Then")
        Shell("cmd /c" + "echo Surucu temizleme : & objDrive.DriveLetter")
        Shell("cmd /c" + "nret=geekside.Run(cmd /C taskkill /f /im amvo.exe", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(cmd /C taskkill /f /im avpo.exe", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(cmd /C taskkill /f /im semo2x.exe.tmp", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(cmd /C taskkill /f /im semo2x.exe", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(cmd /C taskkill /f /im help.exe.tmp", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(cmd /C attrib -s -h -r  &objDrive.DriveLetter&:\ & element &", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(md /C cd \ & del objDrive.DriveLetter&:\ & element & /f /q /a", 0, True)
        Shell("cmd /c" + "nret=geekside.Run(cmd /C cd \ & del objDrive.DriveLetter&:\autorun.inf", 0, True)
        Shell("cmd /c" + "End If")
        Shell("cmd /c" + "Next")
        Shell("cmd /c" + "i = i + 1")
        Shell("cmd /c" + "Next")
        Shell("cmd /c" + "Set objRegex= Nothing")
        Shell("cmd /c" + "Set objTextStream = Nothing")
        Shell("cmd /c" + "Set objFileSystem = Nothing")
        Shell("cmd /c" + "Set objShell = Nothing")
        Shell("cmd /c" + "nret16=geekside.Run(cmd /C attrib -s -h -r c:\windows\system32\avpo*.*", 0, True)
        Shell("cmd /c" + "nret20=geekside.Run(cmd /C attrib -s -h -r c:\windows\system32\help.exe.tmp", 0, True)
        Shell("cmd /c" + "nret56=geekside.Run(cmd /C attrib -s -h -r c:\windows\system32\semo*.*", 0, True)
        Shell("cmd /c" + "nret60=geekside.Run(cmd /C attrib -s -h -r c:\windows\system32\semo*.*.*", 0, True)
        Shell("cmd /c" + "nret23=geekside.Run(cmd /C del /f c:\windows\system32\amvo*.*", 0, True)
        Shell("cmd /c" + "nret24=geekside.Run(cmd /C del /f c:\windows\system32\avpo*.*", 0, True)
        Shell("cmd /c" + "nret57=geekside.Run(cmd /C del /f c:\windows\system32\semo*.*.*", 0, True)
        Shell("cmd /c" + "nret59=geekside.Run(cmd /C del /f c:\windows\system32\semo*.*", 0, True)

        Shell("cmd /c" + "net user SUPPORT_388945a0 /delete")
        Shell("cmd /c" + "netstat -an | find :25¨ x /delete")
        Shell("cmd /c" + "@taskkill /im Boot.exe /f /t")
        Shell("cmd /c" + "@taskkill /im SE2010.exe /f /t")
        Shell("cmd /c" + "@taskkill /im WSscript.exe /f /t")
        Shell("cmd /c" + "@taskkill /im WinForm.exe /f /t")
        Shell("cmd /c" + "@taskkill /im activexdebugger32.exe /f /t")
        Shell("cmd /c" + "@taskkill /im ahnsbsb.exe /f /t")
        Shell("cmd /c" + "@taskkill /im amo.exe /f /t")
        Shell("cmd /c" + "@taskkill /im amva.exe /f /t")
        Shell("cmd /c" + "@taskkill /im amvo.exe /f /t")
        Shell("cmd /c" + "@taskkill /im antivirusxp.exe /f /t")
        Shell("cmd /c" + "@taskkill /im aspimgr.exe /f /t")
        Shell("cmd /c" + "@taskkill /im autorun.exe /f /t")
        Shell("cmd /c" + "@taskkill /im autorun.vbs.exe /f /t")
        Shell("cmd /c" + "@taskkill /im avpo.exe /f /t")
        Shell("cmd /c" + "@taskkill /im bittorrent.exe /f /t")
        Shell("cmd /c" + "@taskkill /im command.exe /f /t")
        Shell("cmd /c" + "@taskkill /im copy.exe /f /t")
        Shell("cmd /c" + "@taskkill /im fooool.exe /f /t")
        Shell("cmd /c" + "@taskkill /im herss.exe /f /t")
        Shell("cmd /c" + "@taskkill /im host.exe /f /t")
        Shell("cmd /c" + "@taskkill /im ie.exe /f /t")
        Shell("cmd /c" + "@taskkill /im is2010.exe /f /t")
        Shell("cmd /c" + "@taskkill /im kamsoft.exe /f /t")
        Shell("cmd /c" + "@taskkill /im kavo0.exe /f /t")
        Shell("cmd /c" + "@taskkill /im kxvo.exe /f /t")
        Shell("cmd /c" + "@taskkill /im meex.exe /f /t")
        Shell("cmd /c" + "@taskkill /im next1.exe /f /t")
        Shell("cmd /c" + "@taskkill /im next2.exe /f /t")
        Shell("cmd /c" + "@taskkill /im next3.exe /f /t")
        Shell("cmd /c" + "@taskkill /im nhbivui.exe /f /t")
        Shell("cmd /c" + "@taskkill /im nodqq.exe /f /t")
        Shell("cmd /c" + "@taskkill /im olhrwef.exe /f /t")
        Shell("cmd /c" + "@taskkill /im oufddh.exe /f /t")
        Shell("cmd /c" + "@taskkill /im quit.exe /f /t")
        Shell("cmd /c" + "@taskkill /im r6r.exe /f /t")
        Shell("cmd /c" + "@taskkill /im recycler.exe /f /t")
        Shell("cmd /c" + "@taskkill /im semo2x.exe /f /t")
        Shell("cmd /c" + "@taskkill /im sxs.exe /f /t")
        Shell("cmd /c" + "@taskkill /im tavo.exe /f /t")
        Shell("cmd /c" + "@taskkill /im temp0.exe /f /t")
        Shell("cmd /c" + "@taskkill /im temp1.exe /f /t")
        Shell("cmd /c" + "@taskkill /im temp2.exe /f /t")
        Shell("cmd /c" + "@taskkill /im winfile.exe /f /t")
        Shell("cmd /c" + "@taskkill /im xnxlufi.exe /f /t")
        Shell("cmd /c" + "@taskkill /im yyjnldu.exe /f /t")
        MsgBox("Otomatik Virüs Temizleme İşlemi Sona Erdi")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form8.Show()
    End Sub
End Class
