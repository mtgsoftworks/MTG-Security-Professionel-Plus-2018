Imports System.Security.Cryptography

Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' değişkenler tanımlanıyor
        Dim password As String
        Dim passwordHASH As String

        password = StrReverse(txtSifre.Text) ' şifre alınıp ters çevriliyor ve password değişkenine aktarılıyor

        ' ilk olarak MD5 ile şifreleniyor
        MD5(password)
        password = StrReverse(password) ' MD5 ile şifrelenmiş olan şifreyi tekrar ters çevirdik

        Call passwordEncryptSHA(password) ' SHA1 şifreleme function u çağırılıyor

        passwordHASH = passwordEncryptSHA(password) ' SHA1 ile şifrelenmiş şifre passwordSHA değişkenine aktarılıyor
        passwordHASH = StrReverse(passwordHASH) ' SHA1 ile şifrelenmiş olan şifreyi tekrar ters çevirdik

        ' şifrenin en son hali yazdırılıyor ve bitiyor.
        txtSifrelenmisHali.Text = passwordHASH
    End Sub

    Public Function passwordEncryptSHA(ByVal password As String) As String
        Dim sha As New SHA1CryptoServiceProvider ' yeni bir SHA1CryptoServiceProvider nesnesi oluşturuluyor
        Dim bytesToHash() As Byte

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(password) ' şifre ASCII ye dönüştürülüyor

        bytesToHash = sha.ComputeHash(bytesToHash) ' SHA1 şifreleme başlıyor

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword ' ve sonunda SHA1 ile şifrelendi ve ana programa döndürüldü

    End Function

    Public Function MD5(ByVal yazi As String) As String

        ' MD5 şifrelemeyi açıklamakla uğraşmak istemiyorum
        ' MD5 şifreleme her yerde var zaten araştırırsanız bilgi edinirsiniz

        Try
            Dim MD5şifreleyici As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim baytlar As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(yazi)
            Dim hash As Byte() = MD5şifreleyici.ComputeHash(baytlar)
            Dim kapasite As Integer = (hash.Length * 2 + (hash.Length / 8))
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(kapasite)
            Dim I As Integer
            For I = 0 To hash.Length - 1
                sb.Append(BitConverter.ToString(hash, I, 1))
            Next I
            Return sb.ToString().TrimEnd(New Char() {" "c})
        Catch ex As Exception
            Return "0"
        End Try
    End Function

End Class

