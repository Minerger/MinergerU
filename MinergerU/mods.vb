
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net
Imports AutoUpdaterDotNET
Public Class mods1

    Dim cn As MySqlConnection
    Private Sub mods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---- Connexion à la BDD et récupération des données
        If GunaCheckBox1.Checked = False Then

            TB_chemin_dossier.Text = "C:\Users\" & Environment.UserName & "\AppData\Roaming\.minecraft\mods"
        Else
        End If

        cn = New MySqlConnection("SERVER=54.37.177.16; PORT=3306; DATABASE=computer; UID=" & GunaLinkLabel20.Text & "; PWD=" & GunaLinkLabel19.Text & ";")

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()

            End If
        Catch ex As Exception
            MsgBox("Erreur : impossible de se connecter à la base de données, veuillez contacter le développeur")
            Me.Close()
        End Try

        If cn.State = ConnectionState.Open Then
            ListView1.Items.Clear()
            Dim cmd1 As New MySqlCommand("SELECT * FROM AddMods", cn)
            Using l As MySqlDataReader = cmd1.ExecuteReader
                While l.Read
                    Dim ID As String = l("ID")
                    Dim Image As String = l("Image")
                    Dim NomMod As String = l("NomMod")
                    Dim Description As String = l("Description")
                    Dim Author As String = l("Author")
                    Dim Lien As String = l("Lien")
                    Dim File As String = l("File")
                    Dim Dependances As String = l("Dependances")
                    Dim Titredep As String = l("Titredep")
                    Dim Liendep As String = l("Liendep")
                    Dim Filedep As String = l("Filedep")

                    ListView1.Items.Add(New ListViewItem(New String() {ID, Image, NomMod, Description, Author, Lien, File, Dependances, Titredep, Liendep, Filedep}))

                End While
            End Using
        End If

        If cn.State = ConnectionState.Open Then
            ListView2.Items.Clear()
            Dim cmd1 As New MySqlCommand("SELECT * FROM DesktopName", cn)
            Using l As MySqlDataReader = cmd1.ExecuteReader
                While l.Read
                    Dim ID As String = l("ID")
                    Dim DeskName As String = l("NameDesk")


                    ListView2.Items.Add(New ListViewItem(New String() {ID, DeskName}))

                End While
            End Using
        End If
        Form1.Timer1.Stop()

        '---- Récupération des items de la listviews pour les noms, description etc de mods (si plusieurs = différentes catégories)

        GunaLinkLabel3.Text = ListView1.Items(0).SubItems(2).Text
        GunaLinkLabel12.Text = ListView1.Items(0).SubItems(2).Text

        Label2.Text = ListView1.Items(0).SubItems(3).Text 'description du mod
        Label17.Text = ListView1.Items(0).SubItems(3).Text 'description du mod

        GunaCirclePictureBox1.Load(ListView1.Items(0).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox8.Load(ListView1.Items(0).SubItems(1).Text) 'image du mod

        '----

        GunaLinkLabel4.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod
        GunaLinkLabel11.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod
        GunaLinkLabel13.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod
        GunaLinkLabel14.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod

        Label3.Text = ListView1.Items(1).SubItems(3).Text 'description du mod
        Label16.Text = ListView1.Items(1).SubItems(3).Text 'description du mod
        Label18.Text = ListView1.Items(1).SubItems(3).Text 'description du mod
        Label19.Text = ListView1.Items(1).SubItems(3).Text 'description du mod


        GunaCirclePictureBox2.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox7.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox9.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox10.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod

        '----

        GunaLinkLabel6.Text = ListView1.Items(2).SubItems(2).Text 'nom du mod
        GunaLinkLabel15.Text = ListView1.Items(2).SubItems(2).Text 'nom du mod
        GunaLinkLabel16.Text = ListView1.Items(2).SubItems(2).Text 'nom du mod

        Label5.Text = ListView1.Items(2).SubItems(3).Text 'description du mod
        Label20.Text = ListView1.Items(2).SubItems(3).Text 'description du mod
        Label21.Text = ListView1.Items(2).SubItems(3).Text 'description du mod

        GunaCirclePictureBox4.Load(ListView1.Items(2).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox11.Load(ListView1.Items(2).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox12.Load(ListView1.Items(2).SubItems(1).Text) 'image du mod

        '----

        GunaLinkLabel5.Text = ListView1.Items(3).SubItems(2).Text 'nom du mod
        GunaLinkLabel17.Text = ListView1.Items(3).SubItems(2).Text 'nom du mod
        GunaLinkLabel18.Text = ListView1.Items(3).SubItems(2).Text 'nom du mod

        Label4.Text = ListView1.Items(3).SubItems(3).Text 'description du mod
        Label22.Text = ListView1.Items(3).SubItems(3).Text 'description du mod
        Label23.Text = ListView1.Items(3).SubItems(3).Text 'description du mod

        GunaCirclePictureBox3.Load(ListView1.Items(3).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox13.Load(ListView1.Items(3).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox14.Load(ListView1.Items(3).SubItems(1).Text) 'image du mod

        '----
        GunaLinkLabel8.Text = ListView1.Items(4).SubItems(2).Text 'nom du mod
        Label6.Text = ListView1.Items(4).SubItems(3).Text 'description du mod
        GunaCirclePictureBox5.Load(ListView1.Items(4).SubItems(1).Text) 'image du mod

        GunaLinkLabel24.Text = ListView1.Items(4).SubItems(2).Text 'nom du mod
        Label27.Text = ListView1.Items(4).SubItems(3).Text 'description du mod
        GunaCirclePictureBox15.Load(ListView1.Items(4).SubItems(1).Text) 'image du mod
        '----
        GunaLinkLabel10.Text = ListView1.Items(5).SubItems(2).Text 'nom du mod
        Label15.Text = ListView1.Items(5).SubItems(3).Text 'description du mod
        GunaCirclePictureBox6.Load(ListView1.Items(5).SubItems(1).Text) 'image du mod

        GunaLinkLabel25.Text = ListView1.Items(5).SubItems(2).Text 'nom du mod
        Label28.Text = ListView1.Items(5).SubItems(3).Text 'description du mod
        GunaCirclePictureBox16.Load(ListView1.Items(5).SubItems(1).Text) 'image du mod
        '----
        GunaLinkLabel27.Text = ListView1.Items(6).SubItems(2).Text 'nom du mod
        Label30.Text = ListView1.Items(6).SubItems(3).Text 'description du mod
        GunaCirclePictureBox18.Load(ListView1.Items(6).SubItems(1).Text) 'image du mod
        '----
        GunaLinkLabel26.Text = ListView1.Items(7).SubItems(2).Text 'nom du mod
        Label29.Text = ListView1.Items(7).SubItems(3).Text 'description du mod
        GunaCirclePictureBox17.Load(ListView1.Items(7).SubItems(1).Text) 'image du mod
        '---- Mode sombre
        If GunaCheckBox4.Checked = True Then

            TabPage1.BackColor = Color.FromArgb(54, 77, 99)

            Panel2.BackColor = Color.FromArgb(44, 62, 80)
            Panel3.BackColor = Color.FromArgb(52, 73, 94)
            Panel4.BackColor = Color.FromArgb(44, 62, 80)

            GunaProgressBar1.BackColor = Color.FromArgb(44, 62, 80)
            GunaProgressBar1.IdleColor = Color.FromArgb(44, 62, 80)
            GunaProgressBar1.ProgressMinColor = Color.FromArgb(52, 73, 94)
            GunaProgressBar1.ProgressMaxColor = Color.FromArgb(52, 73, 94)

            '----
            GunaAdvenceButton3.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnHoverBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnHoverBorderColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnHoverLineColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnPressedColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaAdvenceButton1.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnHoverBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnHoverBorderColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnHoverLineColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnPressedColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaAdvenceButton2.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnHoverBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnHoverBorderColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnHoverLineColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnPressedColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaGroupBox2.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox3.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox4.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox7.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox8.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox10.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox12.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox15.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox17.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox11.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox13.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox14.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox16.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox18.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox20.BorderColor = Color.FromArgb(44, 62, 80)
            '----
            GunaGroupBox2.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox3.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox4.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox7.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox8.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox10.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox12.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox15.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox17.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox11.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox13.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox14.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox16.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox18.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox20.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaGroupBox2.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox3.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox4.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox7.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox8.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox10.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox12.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox15.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox17.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox11.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox13.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox14.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox16.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox18.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox20.BaseColor = Color.FromArgb(36, 51, 66)
            '----

            '----
            GunaAdvenceButton4.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton4.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton4.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaAdvenceButton7.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton7.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton7.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaAdvenceButton5.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton5.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton5.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaAdvenceButton6.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton6.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton6.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaLinkLabel8.LinkColor = Color.White
            GunaLinkLabel6.LinkColor = Color.White
            GunaLinkLabel5.LinkColor = Color.White
            GunaLinkLabel4.LinkColor = Color.White
            GunaLinkLabel3.LinkColor = Color.White
            GunaLinkLabel10.LinkColor = Color.White
            GunaLinkLabel11.LinkColor = Color.White
            GunaLinkLabel13.LinkColor = Color.White
            GunaLinkLabel16.LinkColor = Color.White
            GunaLinkLabel18.LinkColor = Color.White
            GunaLinkLabel12.LinkColor = Color.White
            GunaLinkLabel14.LinkColor = Color.White
            GunaLinkLabel15.LinkColor = Color.White
            GunaLinkLabel17.LinkColor = Color.White
            GunaLinkLabel24.LinkColor = Color.White

            TabPage12.BackColor = Color.FromArgb(54, 77, 99)
            TabPage11.BackColor = Color.FromArgb(54, 77, 99)
            TabPage10.BackColor = Color.FromArgb(54, 77, 99)
            TabPage9.BackColor = Color.FromArgb(54, 77, 99)
            TabPage8.BackColor = Color.FromArgb(54, 77, 99)
            TabPage6.BackColor = Color.FromArgb(54, 77, 99)
            TabPage5.BackColor = Color.FromArgb(54, 77, 99)
            TabPage3.BackColor = Color.FromArgb(54, 77, 99)
            TabPage2.BackColor = Color.FromArgb(54, 77, 99)

            GunaGroupBox5.BaseColor = Color.FromArgb(36, 51, 66)

            GunaCheckBox1.ForeColor = Color.White
            GunaCheckBox2.ForeColor = Color.White
            GunaCheckBox3.ForeColor = Color.White
            GunaCheckBox4.ForeColor = Color.White
            GunaGroupBox5.LineColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox5.BorderColor = Color.FromArgb(52, 73, 94)

            GunaGroupBox9.LineColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox9.BorderColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox9.BaseColor = Color.FromArgb(36, 51, 66)

            GunaGroupBox6.BaseColor = Color.FromArgb(36, 51, 66)

            GunaGroupBox6.LineColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox6.BorderColor = Color.FromArgb(52, 73, 94)
            GunaCheckBox5.ForeColor = Color.White
            GunaCheckBox6.ForeColor = Color.White

            Label12.ForeColor = Color.White
            Label13.ForeColor = Color.White
            Label14.ForeColor = Color.White
            GunaCheckBox7.ForeColor = Color.White

        Else


            TabPage1.BackColor = Color.White
            '  Me.BackColor = Color.FromArgb(127, 140, 141)
            Panel3.BackColor = Color.FromArgb(41, 128, 185)
            GunaProgressBar1.BackColor = Color.FromArgb(52, 152, 219)
            GunaProgressBar1.IdleColor = Color.FromArgb(52, 152, 219)
            GunaProgressBar1.ProgressMinColor = Color.FromArgb(41, 128, 185)
            GunaProgressBar1.ProgressMaxColor = Color.FromArgb(41, 128, 185)
            Panel2.BackColor = Color.FromArgb(52, 152, 219)
            Panel4.BackColor = Color.FromArgb(41, 128, 185)
            '----
            GunaAdvenceButton3.BaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.CheckedBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton1.BaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.CheckedBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton2.BaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.CheckedBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaGroupBox2.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox3.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox4.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox7.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox8.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox2.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox3.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox4.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox7.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox8.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox9.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox9.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox9.BaseColor = Color.White
            '----
            GunaGroupBox10.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox10.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox10.BaseColor = Color.White
            '----

            GunaGroupBox12.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox12.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox12.BaseColor = Color.White
            '----
            GunaGroupBox15.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox15.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox15.BaseColor = Color.White
            '----
            GunaGroupBox17.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox17.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox17.BaseColor = Color.White
            '----
            GunaGroupBox11.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox11.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox11.BaseColor = Color.White
            '----
            GunaGroupBox13.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox13.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox13.BaseColor = Color.White
            '----
            GunaGroupBox14.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox14.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox14.BaseColor = Color.White
            '----
            GunaGroupBox16.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox16.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox16.BaseColor = Color.White
            '----
            GunaGroupBox18.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox18.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox18.BaseColor = Color.White
            '----
            GunaGroupBox20.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox20.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox20.BaseColor = Color.White
            '----
            GunaGroupBox2.BaseColor = Color.White
            GunaGroupBox3.BaseColor = Color.White
            GunaGroupBox4.BaseColor = Color.White
            GunaGroupBox7.BaseColor = Color.White
            GunaGroupBox8.BaseColor = Color.White
            GunaGroupBox10.BaseColor = Color.White
            GunaGroupBox12.BaseColor = Color.White
            GunaGroupBox15.BaseColor = Color.White
            GunaGroupBox17.BaseColor = Color.White
            GunaGroupBox11.BaseColor = Color.White
            GunaGroupBox13.BaseColor = Color.White
            GunaGroupBox14.BaseColor = Color.White
            GunaGroupBox16.BaseColor = Color.White
            GunaGroupBox18.BaseColor = Color.White
            GunaGroupBox20.BaseColor = Color.White
            '----
            GunaAdvenceButton4.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton4.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton4.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton4.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton4.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton4.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton4.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton7.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton7.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton7.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton7.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton7.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton7.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton7.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton5.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton5.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton5.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton5.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton5.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton5.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton5.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton6.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton6.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton6.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton6.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton6.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton6.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton6.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaLinkLabel8.LinkColor = Color.Black
            GunaLinkLabel6.LinkColor = Color.Black
            GunaLinkLabel5.LinkColor = Color.Black
            GunaLinkLabel4.LinkColor = Color.Black
            GunaLinkLabel3.LinkColor = Color.Black
            GunaLinkLabel10.LinkColor = Color.Black
            GunaLinkLabel11.LinkColor = Color.Black
            GunaLinkLabel13.LinkColor = Color.Black
            GunaLinkLabel16.LinkColor = Color.Black
            GunaLinkLabel18.LinkColor = Color.Black
            GunaLinkLabel12.LinkColor = Color.Black
            GunaLinkLabel14.LinkColor = Color.Black
            GunaLinkLabel16.LinkColor = Color.Black
            GunaLinkLabel17.LinkColor = Color.Black
            GunaLinkLabel15.LinkColor = Color.Black
            GunaLinkLabel18.LinkColor = Color.Black
            GunaLinkLabel25.LinkColor = Color.Black

            TabPage12.BackColor = Color.White
            TabPage11.BackColor = Color.White
            TabPage10.BackColor = Color.White
            TabPage9.BackColor = Color.White
            TabPage8.BackColor = Color.White
            TabPage6.BackColor = Color.White
            TabPage5.BackColor = Color.White
            TabPage3.BackColor = Color.White
            TabPage2.BackColor = Color.White

            GunaGroupBox5.BaseColor = Color.White
            GunaCheckBox1.ForeColor = Color.Black
            GunaCheckBox2.ForeColor = Color.Black
            GunaCheckBox3.ForeColor = Color.Black
            GunaCheckBox4.ForeColor = Color.Black
            GunaGroupBox5.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox5.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox6.BaseColor = Color.White

            GunaGroupBox6.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox6.BorderColor = Color.FromArgb(52, 152, 219)
            GunaCheckBox5.ForeColor = Color.Black
            GunaCheckBox6.ForeColor = Color.Black

            Label12.ForeColor = Color.Black
            Label13.ForeColor = Color.Black
            Label14.ForeColor = Color.Black
            GunaCheckBox7.ForeColor = Color.Black
        End If



        '---- Couleurs des boutons


        If ComboBox2.Text = "Vert" Then
            Panel1.BackColor = Color.FromArgb(46, 204, 113)
            GunaButton13.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton13.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(46, 204, 113)
        End If
        If ComboBox2.Text = "Normal" Then
            Panel1.BackColor = Color.FromArgb(52, 152, 219)
            GunaButton13.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton13.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
        End If
        If ComboBox2.Text = "Violet" Then
            Panel1.BackColor = Color.FromArgb(142, 68, 173)
            GunaButton13.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton13.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(142, 68, 173)
        End If
        If ComboBox2.Text = "Sombre" Then
            Panel1.BackColor = Color.FromArgb(52, 73, 94)
            GunaButton13.BaseColor = Color.FromArgb(52, 73, 94)
            GunaButton13.BorderColor = Color.FromArgb(52, 73, 94)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
        End If



        If ComboBox1.Text = "Vert" Then
            GunaButton3.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton3.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton3.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton3.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton6.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton6.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton6.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton6.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton8.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton8.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton8.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton8.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton10.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton10.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton10.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton10.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton12.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton12.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton12.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton12.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton15.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton15.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton15.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton15.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton17.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton17.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton17.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton17.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton21.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton21.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton21.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton21.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton27.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton27.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton27.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton27.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton31.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton31.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton31.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton31.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton29.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton29.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton29.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton29.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton19.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton19.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton19.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton19.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton23.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton23.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton23.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton23.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton25.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton25.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton25.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton25.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton41.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton41.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton41.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton41.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton39.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton39.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton39.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton39.OnHoverBorderColor = Color.FromArgb(46, 204, 113)
        End If
        If ComboBox1.Text = "Bleu" Then
            GunaButton3.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton3.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton3.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton3.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton6.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton6.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton6.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton6.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton8.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton8.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton8.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton8.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton10.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton10.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton10.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton10.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton12.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton12.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton12.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton12.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton15.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton15.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton15.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton15.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton17.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton17.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton17.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton17.OnHoverBorderColor = Color.FromArgb(52, 152, 219)


            GunaButton21.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton21.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton21.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton21.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton27.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton27.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton27.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton27.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton31.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton31.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton31.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton31.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton29.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton29.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton29.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton29.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton19.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton19.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton19.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton19.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton23.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton23.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton23.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton23.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton25.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton25.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton25.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton25.OnHoverBorderColor = Color.FromArgb(52, 152, 219)


            GunaButton41.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton41.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton41.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton41.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton39.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton39.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton39.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton39.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
        End If

        If ComboBox1.Text = "Violet" Then
            GunaButton3.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton3.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton3.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton3.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton6.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton6.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton6.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton6.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton8.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton8.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton8.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton8.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton10.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton10.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton10.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton10.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton12.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton12.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton12.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton12.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton15.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton15.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton15.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton15.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton17.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton17.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton17.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton17.OnHoverBorderColor = Color.FromArgb(142, 68, 173)


            GunaButton21.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton21.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton21.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton21.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton27.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton27.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton27.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton27.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton31.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton31.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton31.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton31.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton29.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton29.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton29.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton29.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton19.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton19.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton19.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton19.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton23.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton23.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton23.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton23.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton25.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton25.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton25.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton25.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton41.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton41.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton41.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton41.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton39.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton39.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton39.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton39.OnHoverBorderColor = Color.FromArgb(142, 68, 173)


        End If
    End Sub





    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

        GunaAdvenceButton4.PerformClick()
        TabControl1.SelectTab(0)
        GunaAdvenceButton4.Show()
        GunaAdvenceButton5.Show()
        GunaAdvenceButton6.Show()
        GunaAdvenceButton7.Show()

        Panel4.Show()
        GunaLinkLabel1.Text = "Liste des mods"
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        TabControl1.SelectTab(1)
        GunaAdvenceButton4.Hide()
        GunaAdvenceButton5.Hide()
        GunaAdvenceButton6.Hide()
        GunaAdvenceButton7.Hide()

        GunaLinkLabel1.Text = "Paramètres"
        GunaLinkLabel1.TextAlign = ContentAlignment.MiddleCenter


    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        TabControl1.SelectTab(4)
        GunaAdvenceButton4.Hide()
        GunaAdvenceButton5.Hide()
        GunaAdvenceButton6.Hide()
        GunaAdvenceButton7.Hide()

        GunaLinkLabel1.Text = "Infos et Outils"
        GunaLinkLabel1.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        If GunaCheckBox1.Checked = True Then
            TB_chemin_dossier.Enabled = True
        Else
            TB_chemin_dossier.Enabled = False
        End If
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        TabPage4.AutoScroll = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TB_chemin_dossier.TextChanged

    End Sub
    Dim Client As WebClient = New WebClient
    Dim Client1 As WebClient = New WebClient


    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        dep1 = "mods1"
        If ListView1.Items(0).SubItems(7).Text = "test" Then
            dep.Show()


            AddHandler Client1.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
            AddHandler Client1.DownloadFileCompleted, AddressOf client_DownloadCompleted



            Client1.DownloadFileAsync(New Uri(ListView1.Items(0).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(0).SubItems(6).Text)

            popup1.Show()

        Else

            AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged

            AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted

            Client.DownloadFileAsync(New Uri(ListView1.Items(0).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(0).SubItems(6).Text)


            popup1.Show()

        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
2:
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
3:
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
4:
        Dim percentage As Double = bytesIn / totalBytes * 100
5:

6:
        popup1.GunaProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())


    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
2:
        popup2.Show()
3:      popup1.Close()
    End Sub


    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        dep1 = "mods2"
        If ListView1.Items(1).SubItems(7).Text = "test" Then
            dep.Show()

            AddHandler Client1.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
            AddHandler Client1.DownloadFileCompleted, AddressOf client_DownloadCompleted


            Client1.DownloadFileAsync(New Uri(ListView1.Items(1).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(1).SubItems(6).Text)
            popup1.Show()
        Else
            AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged

            AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted

            Client.DownloadFileAsync(New Uri(ListView1.Items(1).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(1).SubItems(6).Text)
            popup1.Show()

        End If
    End Sub

    Private Sub GunaLinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel3.LinkClicked
        Process.Start(ListView1.Items(0).SubItems(4).Text)
    End Sub

    Private Sub GunaCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox4.CheckedChanged
        If GunaCheckBox4.Checked = True Then

            TabPage1.BackColor = Color.FromArgb(54, 77, 99)

            Panel2.BackColor = Color.FromArgb(44, 62, 80)
            Panel3.BackColor = Color.FromArgb(52, 73, 94)
            Panel4.BackColor = Color.FromArgb(44, 62, 80)

            GunaProgressBar1.BackColor = Color.FromArgb(44, 62, 80)
            GunaProgressBar1.IdleColor = Color.FromArgb(44, 62, 80)
            GunaProgressBar1.ProgressMinColor = Color.FromArgb(52, 73, 94)
            GunaProgressBar1.ProgressMaxColor = Color.FromArgb(52, 73, 94)

            '----
            GunaAdvenceButton3.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnHoverBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnHoverBorderColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnHoverLineColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.OnPressedColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton3.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaAdvenceButton1.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnHoverBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnHoverBorderColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnHoverLineColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.OnPressedColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton1.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaAdvenceButton2.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnHoverBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnHoverBorderColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnHoverLineColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.OnPressedColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton2.LineColor = Color.FromArgb(44, 62, 80)
            '----
            GunaGroupBox2.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox3.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox4.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox7.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox8.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox10.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox12.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox15.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox17.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox11.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox13.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox14.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox16.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox18.BorderColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox20.BorderColor = Color.FromArgb(44, 62, 80)
            '----
            GunaGroupBox2.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox3.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox4.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox7.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox8.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox10.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox12.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox15.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox17.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox11.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox13.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox14.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox16.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox18.LineColor = Color.FromArgb(44, 62, 80)
            GunaGroupBox20.LineColor = Color.FromArgb(44, 62, 80)

            '----
            GunaGroupBox2.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox3.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox4.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox7.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox8.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox10.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox12.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox15.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox17.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox11.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox13.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox14.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox16.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox18.BaseColor = Color.FromArgb(36, 51, 66)
            GunaGroupBox20.BaseColor = Color.FromArgb(36, 51, 66)
            '----

            '----
            GunaAdvenceButton4.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton4.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton4.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton4.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaAdvenceButton7.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton7.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton7.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton7.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaAdvenceButton5.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton5.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton5.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton5.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaAdvenceButton6.BaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton6.CheckedBaseColor = Color.FromArgb(44, 62, 80)
            GunaAdvenceButton6.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.OnHoverLineColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.OnPressedColor = Color.FromArgb(52, 73, 94)
            GunaAdvenceButton6.LineColor = Color.FromArgb(52, 73, 94)
            '----
            GunaLinkLabel8.LinkColor = Color.White
            GunaLinkLabel6.LinkColor = Color.White
            GunaLinkLabel5.LinkColor = Color.White
            GunaLinkLabel4.LinkColor = Color.White
            GunaLinkLabel3.LinkColor = Color.White
            GunaLinkLabel10.LinkColor = Color.White
            GunaLinkLabel11.LinkColor = Color.White
            GunaLinkLabel13.LinkColor = Color.White
            GunaLinkLabel16.LinkColor = Color.White
            GunaLinkLabel18.LinkColor = Color.White
            GunaLinkLabel12.LinkColor = Color.White
            GunaLinkLabel14.LinkColor = Color.White
            GunaLinkLabel15.LinkColor = Color.White
            GunaLinkLabel17.LinkColor = Color.White
            GunaLinkLabel24.LinkColor = Color.White
            GunaLinkLabel25.LinkColor = Color.White

            TabPage12.BackColor = Color.FromArgb(54, 77, 99)
            TabPage11.BackColor = Color.FromArgb(54, 77, 99)
            TabPage10.BackColor = Color.FromArgb(54, 77, 99)
            TabPage9.BackColor = Color.FromArgb(54, 77, 99)
            TabPage8.BackColor = Color.FromArgb(54, 77, 99)
            TabPage6.BackColor = Color.FromArgb(54, 77, 99)
            TabPage5.BackColor = Color.FromArgb(54, 77, 99)
            TabPage3.BackColor = Color.FromArgb(54, 77, 99)
            TabPage2.BackColor = Color.FromArgb(54, 77, 99)

            GunaGroupBox5.BaseColor = Color.FromArgb(36, 51, 66)

            GunaCheckBox1.ForeColor = Color.White
            GunaCheckBox2.ForeColor = Color.White
            GunaCheckBox3.ForeColor = Color.White
            GunaCheckBox4.ForeColor = Color.White
            GunaGroupBox5.LineColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox5.BorderColor = Color.FromArgb(52, 73, 94)

            GunaGroupBox9.LineColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox9.BorderColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox9.BaseColor = Color.FromArgb(36, 51, 66)

            GunaGroupBox6.BaseColor = Color.FromArgb(36, 51, 66)

            GunaGroupBox6.LineColor = Color.FromArgb(52, 73, 94)
            GunaGroupBox6.BorderColor = Color.FromArgb(52, 73, 94)
            GunaCheckBox5.ForeColor = Color.White
            GunaCheckBox6.ForeColor = Color.White

            Label12.ForeColor = Color.White
            Label13.ForeColor = Color.White
            Label14.ForeColor = Color.White
            GunaCheckBox7.ForeColor = Color.White

        Else


            TabPage1.BackColor = Color.White
            '  Me.BackColor = Color.FromArgb(127, 140, 141)
            Panel3.BackColor = Color.FromArgb(41, 128, 185)
            GunaProgressBar1.BackColor = Color.FromArgb(52, 152, 219)
            GunaProgressBar1.IdleColor = Color.FromArgb(52, 152, 219)
            GunaProgressBar1.ProgressMinColor = Color.FromArgb(41, 128, 185)
            GunaProgressBar1.ProgressMaxColor = Color.FromArgb(41, 128, 185)
            Panel2.BackColor = Color.FromArgb(52, 152, 219)
            Panel4.BackColor = Color.FromArgb(41, 128, 185)
            '----
            GunaAdvenceButton3.BaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.CheckedBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton3.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton1.BaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.CheckedBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton1.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton2.BaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.CheckedBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton2.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaGroupBox2.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox3.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox4.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox7.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox8.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox2.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox3.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox4.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox7.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox8.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox9.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox9.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox9.BaseColor = Color.White
            '----
            GunaGroupBox10.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox10.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox10.BaseColor = Color.White
            '----

            GunaGroupBox12.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox12.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox12.BaseColor = Color.White
            '----
            GunaGroupBox15.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox15.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox15.BaseColor = Color.White
            '----
            GunaGroupBox17.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox17.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox17.BaseColor = Color.White
            '----
            GunaGroupBox11.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox11.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox11.BaseColor = Color.White
            '----
            GunaGroupBox13.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox13.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox13.BaseColor = Color.White
            '----
            GunaGroupBox14.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox14.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox14.BaseColor = Color.White
            '----
            GunaGroupBox16.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox16.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox16.BaseColor = Color.White
            '----
            GunaGroupBox18.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox18.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox18.BaseColor = Color.White
            '----
            GunaGroupBox20.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox20.BorderColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox20.BaseColor = Color.White
            '----

            GunaGroupBox2.BaseColor = Color.White
            GunaGroupBox3.BaseColor = Color.White
            GunaGroupBox4.BaseColor = Color.White
            GunaGroupBox7.BaseColor = Color.White
            GunaGroupBox8.BaseColor = Color.White
            GunaGroupBox10.BaseColor = Color.White
            GunaGroupBox12.BaseColor = Color.White
            GunaGroupBox15.BaseColor = Color.White
            GunaGroupBox17.BaseColor = Color.White
            GunaGroupBox11.BaseColor = Color.White
            GunaGroupBox13.BaseColor = Color.White
            GunaGroupBox14.BaseColor = Color.White
            GunaGroupBox16.BaseColor = Color.White
            GunaGroupBox18.BaseColor = Color.White
            GunaGroupBox20.BaseColor = Color.White
            '----
            GunaAdvenceButton4.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton4.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton4.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton4.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton4.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton4.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton4.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton7.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton7.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton7.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton7.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton7.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton7.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton7.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton5.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton5.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton5.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton5.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton5.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton5.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton5.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaAdvenceButton6.BaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton6.CheckedBaseColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton6.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton6.OnHoverBorderColor = Color.FromArgb(41, 128, 185)
            GunaAdvenceButton6.OnHoverLineColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton6.OnPressedColor = Color.FromArgb(52, 152, 219)
            GunaAdvenceButton6.LineColor = Color.FromArgb(52, 152, 219)
            '----
            GunaLinkLabel8.LinkColor = Color.Black
            GunaLinkLabel6.LinkColor = Color.Black
            GunaLinkLabel5.LinkColor = Color.Black
            GunaLinkLabel4.LinkColor = Color.Black
            GunaLinkLabel3.LinkColor = Color.Black
            GunaLinkLabel10.LinkColor = Color.Black
            GunaLinkLabel11.LinkColor = Color.Black
            GunaLinkLabel13.LinkColor = Color.Black
            GunaLinkLabel16.LinkColor = Color.Black
            GunaLinkLabel18.LinkColor = Color.Black
            GunaLinkLabel12.LinkColor = Color.Black
            GunaLinkLabel14.LinkColor = Color.Black
            GunaLinkLabel16.LinkColor = Color.Black
            GunaLinkLabel17.LinkColor = Color.Black
            GunaLinkLabel25.LinkColor = Color.Black

            TabPage12.BackColor = Color.White
            TabPage11.BackColor = Color.White
            TabPage10.BackColor = Color.White
            TabPage9.BackColor = Color.White
            TabPage8.BackColor = Color.White
            TabPage6.BackColor = Color.White
            TabPage5.BackColor = Color.White
            TabPage3.BackColor = Color.White
            TabPage2.BackColor = Color.White

            GunaGroupBox5.BaseColor = Color.White
            GunaCheckBox1.ForeColor = Color.Black
            GunaCheckBox2.ForeColor = Color.Black
            GunaCheckBox3.ForeColor = Color.Black
            GunaCheckBox4.ForeColor = Color.Black
            GunaGroupBox5.LineColor = Color.FromArgb(52, 152, 219)
            GunaGroupBox5.BorderColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox6.BaseColor = Color.White

            GunaGroupBox6.LineColor = Color.FromArgb(52, 152, 219)

            GunaGroupBox6.BorderColor = Color.FromArgb(52, 152, 219)
            GunaCheckBox5.ForeColor = Color.Black
            GunaCheckBox6.ForeColor = Color.Black

            Label12.ForeColor = Color.Black
            Label13.ForeColor = Color.Black
            Label14.ForeColor = Color.Black
            GunaCheckBox7.ForeColor = Color.Black
        End If


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cn.State = ConnectionState.Open Then
            ListView1.Items.Clear()
            Dim cmd1 As New MySqlCommand("SELECT * FROM AddMods", cn)
            Using l As MySqlDataReader = cmd1.ExecuteReader
                While l.Read
                    Dim ID As String = l("ID")
                    Dim Image As String = l("Image")
                    Dim NomMod As String = l("NomMod")
                    Dim Description As String = l("Description")
                    Dim Author As String = l("Author")
                    Dim Lien As String = l("Lien")
                    Dim File As String = l("File")
                    Dim Dependances As String = l("Dependances")
                    Dim Titredep As String = l("Titredep")
                    Dim Liendep As String = l("Liendep")
                    Dim Filedep As String = l("Filedep")

                    ListView1.Items.Add(New ListViewItem(New String() {ID, Image, NomMod, Description, Author, Lien, File, Dependances, Titredep, Liendep, Filedep}))

                End While
            End Using
        End If

        If cn.State = ConnectionState.Open Then
            ListView2.Items.Clear()
            Dim cmd1 As New MySqlCommand("SELECT * FROM DesktopName", cn)
            Using l As MySqlDataReader = cmd1.ExecuteReader
                While l.Read
                    Dim ID As String = l("ID")
                    Dim DeskName As String = l("NameDesk")


                    ListView2.Items.Add(New ListViewItem(New String() {ID, DeskName}))

                End While
            End Using
        End If

        '---- 

        GunaLinkLabel3.Text = ListView1.Items(0).SubItems(2).Text
        GunaLinkLabel12.Text = ListView1.Items(0).SubItems(2).Text


        Label2.Text = ListView1.Items(0).SubItems(3).Text 'description du mod
        Label17.Text = ListView1.Items(0).SubItems(3).Text 'description du mod

        GunaCirclePictureBox1.Load(ListView1.Items(0).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox8.Load(ListView1.Items(0).SubItems(1).Text) 'image du mod

        '----

        GunaLinkLabel4.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod
        GunaLinkLabel11.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod
        GunaLinkLabel13.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod
        GunaLinkLabel14.Text = ListView1.Items(1).SubItems(2).Text 'nom du mod

        Label3.Text = ListView1.Items(1).SubItems(3).Text 'description du mod
        Label16.Text = ListView1.Items(1).SubItems(3).Text 'description du mod
        Label18.Text = ListView1.Items(1).SubItems(3).Text 'description du mod
        Label19.Text = ListView1.Items(1).SubItems(3).Text 'description du mod


        GunaCirclePictureBox2.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox7.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox9.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox10.Load(ListView1.Items(1).SubItems(1).Text) 'image du mod

        '----

        GunaLinkLabel6.Text = ListView1.Items(2).SubItems(2).Text 'nom du mod
        GunaLinkLabel15.Text = ListView1.Items(2).SubItems(2).Text 'nom du mod
        GunaLinkLabel16.Text = ListView1.Items(2).SubItems(2).Text 'nom du mod

        Label5.Text = ListView1.Items(2).SubItems(3).Text 'description du mod
        Label20.Text = ListView1.Items(2).SubItems(3).Text 'description du mod
        Label21.Text = ListView1.Items(2).SubItems(3).Text 'description du mod

        GunaCirclePictureBox4.Load(ListView1.Items(2).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox11.Load(ListView1.Items(2).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox12.Load(ListView1.Items(2).SubItems(1).Text) 'image du mod

        '----

        GunaLinkLabel5.Text = ListView1.Items(3).SubItems(2).Text 'nom du mod
        GunaLinkLabel17.Text = ListView1.Items(3).SubItems(2).Text 'nom du mod
        GunaLinkLabel18.Text = ListView1.Items(3).SubItems(2).Text 'nom du mod

        Label4.Text = ListView1.Items(3).SubItems(3).Text 'description du mod
        Label22.Text = ListView1.Items(3).SubItems(3).Text 'description du mod
        Label23.Text = ListView1.Items(3).SubItems(3).Text 'description du mod

        GunaCirclePictureBox3.Load(ListView1.Items(3).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox13.Load(ListView1.Items(3).SubItems(1).Text) 'image du mod
        GunaCirclePictureBox14.Load(ListView1.Items(3).SubItems(1).Text) 'image du mod

        '----
        GunaLinkLabel8.Text = ListView1.Items(4).SubItems(2).Text 'nom du mod
        Label6.Text = ListView1.Items(4).SubItems(3).Text 'description du mod
        GunaCirclePictureBox5.Load(ListView1.Items(4).SubItems(1).Text) 'image du mod

        GunaLinkLabel24.Text = ListView1.Items(4).SubItems(2).Text 'nom du mod
        Label27.Text = ListView1.Items(4).SubItems(3).Text 'description du mod
        GunaCirclePictureBox15.Load(ListView1.Items(4).SubItems(1).Text) 'image du mod
        '----
        GunaLinkLabel10.Text = ListView1.Items(5).SubItems(2).Text 'nom du mod
        Label15.Text = ListView1.Items(5).SubItems(3).Text 'description du mod
        GunaCirclePictureBox6.Load(ListView1.Items(5).SubItems(1).Text) 'image du mod
        '----
        GunaLinkLabel25.Text = ListView1.Items(5).SubItems(2).Text 'nom du mod
        Label28.Text = ListView1.Items(5).SubItems(3).Text 'description du mod
        GunaCirclePictureBox16.Load(ListView1.Items(5).SubItems(1).Text) 'image du mod



    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If cn.State = ConnectionState.Open Then
            ListView1.Items.Clear()
            Dim cmd1 As New MySqlCommand("SELECT * FROM AddMods", cn)
            Using l As MySqlDataReader = cmd1.ExecuteReader
                While l.Read
                    Dim ID As String = l("ID")
                    Dim Image As String = l("Image")
                    Dim NomMod As String = l("NomMod")
                    Dim Description As String = l("Description")
                    Dim Author As String = l("Author")
                    Dim Lien As String = l("Lien")
                    Dim File As String = l("File")
                    Dim Dependances As String = l("Dependances")
                    Dim Titredep As String = l("Titredep")
                    Dim Liendep As String = l("Liendep")
                    Dim Filedep As String = l("Filedep")

                    ListView1.Items.Add(New ListViewItem(New String() {ID, Image, NomMod, Description, Author, Lien, File, Dependances, Titredep, Liendep, Filedep}))

                End While
            End Using
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cn.State = ConnectionState.Open And ListView1.SelectedItems.Count > 0 Then
            Dim element As ListViewItem = ListView1.SelectedItems(0)
            Dim ID As String = element.SubItems(0).Text
            Dim cmd As New MySqlCommand("UPDATE AddMods SET Lien=@Link,NomMod=@Name,Description=@Description,File=@File WHERE ID=@ID", cn)
            cmd.Parameters.AddWithValue("@Link", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Description", TextBox4.Text)
            cmd.Parameters.AddWithValue("@File", TextBox2.Text)
            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.ExecuteNonQuery()

            MsgBox("Modifié !")

        End If
    End Sub

    Private Sub GunaButton13_Click(sender As Object, e As EventArgs) Handles GunaButton13.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim element As ListViewItem = ListView1.SelectedItems(0)
            TextBox1.Text = element.SubItems(2).Text
            TextBox4.Text = element.SubItems(3).Text
            TextBox3.Text = element.SubItems(5).Text
            TextBox2.Text = element.SubItems(6).Text
        End If
    End Sub

    Private Sub GunaLinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel4.LinkClicked
        Process.Start(ListView1.Items(1).SubItems(4).Text)
    End Sub

    Private Sub GunaLinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel6.LinkClicked
        Process.Start(ListView1.Items(2).SubItems(4).Text)
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        dep1 = "mods3"
        If ListView1.Items(2).SubItems(7).Text = "test" Then
            dep.Show()


            AddHandler Client1.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
            AddHandler Client1.DownloadFileCompleted, AddressOf client_DownloadCompleted

            Client1.DownloadFileAsync(New Uri(ListView1.Items(2).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(2).SubItems(6).Text)



            popup1.Show()

        Else

            AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged

            AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted

            Client.DownloadFileAsync(New Uri(ListView1.Items(2).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(2).SubItems(6).Text)


            popup1.Show()

        End If
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(3).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(3).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) Handles GunaButton12.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(4).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(4).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaLinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel5.LinkClicked
        Process.Start(ListView1.Items(3).SubItems(4).Text)
    End Sub

    Private Sub GunaLinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel8.LinkClicked
        Process.Start(ListView1.Items(4).SubItems(4).Text)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Vert" Then
            GunaButton3.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton3.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton3.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton3.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton6.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton6.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton6.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton6.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton8.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton8.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton8.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton8.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton10.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton10.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton10.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton10.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton12.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton12.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton12.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton12.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton15.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton15.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton15.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton15.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton17.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton17.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton17.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton17.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton21.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton21.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton21.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton21.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton27.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton27.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton27.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton27.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton31.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton31.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton31.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton31.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton29.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton29.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton29.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton29.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton19.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton19.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton19.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton19.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton23.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton23.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton23.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton23.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton25.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton25.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton25.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton25.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton41.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton41.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton41.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton41.OnHoverBorderColor = Color.FromArgb(46, 204, 113)

            GunaButton39.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton39.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton39.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton39.OnHoverBorderColor = Color.FromArgb(46, 204, 113)
        End If
        If ComboBox1.Text = "Bleu" Then
            GunaButton3.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton3.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton3.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton3.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton6.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton6.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton6.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton6.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton8.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton8.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton8.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton8.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton10.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton10.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton10.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton10.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton12.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton12.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton12.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton12.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton15.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton15.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton15.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton15.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton17.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton17.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton17.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton17.OnHoverBorderColor = Color.FromArgb(52, 152, 219)


            GunaButton21.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton21.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton21.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton21.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton27.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton27.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton27.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton27.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton31.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton31.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton31.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton31.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton29.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton29.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton29.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton29.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton19.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton19.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton19.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton19.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton23.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton23.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton23.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton23.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton25.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton25.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton25.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton25.OnHoverBorderColor = Color.FromArgb(52, 152, 219)


            GunaButton41.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton41.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton41.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton41.OnHoverBorderColor = Color.FromArgb(52, 152, 219)

            GunaButton39.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton39.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton39.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton39.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
        End If

        If ComboBox1.Text = "Violet" Then
            GunaButton3.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton3.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton3.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton3.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton6.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton6.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton6.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton6.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton8.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton8.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton8.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton8.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton10.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton10.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton10.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton10.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton12.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton12.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton12.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton12.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton15.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton15.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton15.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton15.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton17.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton17.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton17.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton17.OnHoverBorderColor = Color.FromArgb(142, 68, 173)


            GunaButton21.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton21.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton21.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton21.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton27.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton27.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton27.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton27.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton31.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton31.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton31.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton31.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton29.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton29.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton29.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton29.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton19.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton19.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton19.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton19.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton23.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton23.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton23.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton23.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton25.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton25.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton25.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton25.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton41.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton41.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton41.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton41.OnHoverBorderColor = Color.FromArgb(142, 68, 173)

            GunaButton39.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton39.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton39.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton39.OnHoverBorderColor = Color.FromArgb(142, 68, 173)
        End If
    End Sub

    Private Sub GunaCheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox5.CheckedChanged
        If GunaCheckBox5.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Vert" Then
            Panel1.BackColor = Color.FromArgb(46, 204, 113)
            GunaButton13.BaseColor = Color.FromArgb(46, 204, 113)
            GunaButton13.BorderColor = Color.FromArgb(46, 204, 113)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(46, 204, 113)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(46, 204, 113)
        End If
        If ComboBox2.Text = "Normal" Then
            Panel1.BackColor = Color.FromArgb(52, 152, 219)
            GunaButton13.BaseColor = Color.FromArgb(52, 152, 219)
            GunaButton13.BorderColor = Color.FromArgb(52, 152, 219)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(52, 152, 219)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(52, 152, 219)
        End If
        If ComboBox2.Text = "Violet" Then
            Panel1.BackColor = Color.FromArgb(142, 68, 173)
            GunaButton13.BaseColor = Color.FromArgb(142, 68, 173)
            GunaButton13.BorderColor = Color.FromArgb(142, 68, 173)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(142, 68, 173)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(142, 68, 173)
        End If
        If ComboBox2.Text = "Sombre" Then
            Panel1.BackColor = Color.FromArgb(52, 73, 94)
            GunaButton13.BaseColor = Color.FromArgb(52, 73, 94)
            GunaButton13.BorderColor = Color.FromArgb(52, 73, 94)
            GunaButton13.OnHoverBaseColor = Color.FromArgb(52, 73, 94)
            GunaButton13.OnHoverBorderColor = Color.FromArgb(52, 73, 94)
        End If
    End Sub

    Private Sub GunaCheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox6.CheckedChanged

    End Sub

    Private Sub GunaButton15_Click(sender As Object, e As EventArgs) Handles GunaButton15.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(5).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(5).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaLinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel10.LinkClicked
        Process.Start(ListView1.Items(5).SubItems(4).Text)
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click

        If GunaAdvenceButton7.Text = "Magie & Tech" Then
            TabControl1.SelectTab(8)
        Else
            TabControl1.SelectTab(5)
        End If

    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click


        If GunaAdvenceButton7.Text = "Magie & Tech" Then
            GunaAdvenceButton5.Text = "Armes & Armures"
            GunaAdvenceButton7.Text = "Créatures & Mobs"
            GunaAdvenceButton4.Text = "Tous les mods"
        Else
            GunaAdvenceButton5.Text = "Biomes & Blocs"
            GunaAdvenceButton7.Text = "Magie & Tech"
            GunaAdvenceButton4.Text = "Outils & Gadgets"
        End If
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click

        If GunaAdvenceButton4.Text = "Outils & Gadgets" Then
            TabControl1.SelectTab(9)
        Else
            TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub GunaLinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel12.LinkClicked
        Process.Start(ListView1.Items(0).SubItems(4).Text)
    End Sub

    Private Sub GunaLinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel11.LinkClicked
        Process.Start(ListView1.Items(1).SubItems(4).Text)
    End Sub

    Private Sub GunaLinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel13.LinkClicked
        Process.Start(ListView1.Items(1).SubItems(4).Text)
    End Sub

    Private Sub GunaLinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel14.LinkClicked
        Process.Start(ListView1.Items(1).SubItems(4).Text)
    End Sub

    Private Sub GunaButton19_Click(sender As Object, e As EventArgs) Handles GunaButton19.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(0).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(0).SubItems(6).Text)
        popup1.Show()



    End Sub

    Private Sub GunaButton17_Click(sender As Object, e As EventArgs) Handles GunaButton17.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(1).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(1).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton21_Click(sender As Object, e As EventArgs) Handles GunaButton21.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(1).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(1).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton23_Click(sender As Object, e As EventArgs) Handles GunaButton23.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(1).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(1).SubItems(6).Text)
        popup1.Show()

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click

        If GunaAdvenceButton5.Text = "Biomes & Blocs" Then
            TabControl1.SelectTab(7)
        Else
            TabControl1.SelectTab(6)
        End If
    End Sub

    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        If Environment.MachineName = ListView2.Items(0).SubItems(1).Text Or Environment.MachineName = ListView2.Items(1).SubItems(1).Text Then
            TabControl1.SelectTab(3)
        Else

            TabControl1.SelectTab(2)
        End If

        GunaAdvenceButton4.Hide()
        GunaAdvenceButton5.Hide()
        GunaAdvenceButton6.Hide()
        GunaAdvenceButton7.Hide()


        GunaLinkLabel1.Text = "Panel Staff"
        GunaLinkLabel1.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub GunaButton27_Click(sender As Object, e As EventArgs) Handles GunaButton27.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(2).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(2).SubItems(6).Text)

        popup1.Show()
    End Sub

    Private Sub GunaButton31_Click(sender As Object, e As EventArgs) Handles GunaButton31.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(3).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(3).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton29_Click(sender As Object, e As EventArgs) Handles GunaButton29.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(3).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(3).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton25_Click(sender As Object, e As EventArgs) Handles GunaButton25.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(2).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(2).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton18_Click(sender As Object, e As EventArgs) Handles GunaButton18.Click

    End Sub

    Private Sub GunaGroupBox13_Click(sender As Object, e As EventArgs) Handles GunaGroupBox13.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TabPage8_Click(sender As Object, e As EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub GunaButton39_Click(sender As Object, e As EventArgs) Handles GunaButton39.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(4).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(4).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton41_Click(sender As Object, e As EventArgs) Handles GunaButton41.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(5).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(5).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton45_Click(sender As Object, e As EventArgs) Handles GunaButton45.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(6).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(6).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton43_Click(sender As Object, e As EventArgs) Handles GunaButton43.Click
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
4:
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted


        Client.DownloadFileAsync(New Uri(ListView1.Items(7).SubItems(5).Text), TB_chemin_dossier.Text & "\" + ListView1.Items(7).SubItems(6).Text)
        popup1.Show()
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click

    End Sub
End Class