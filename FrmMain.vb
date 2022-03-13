' Charlotte Childers
' CPT-206 | Visual Basic, Exercise 14 (Chapter 7)
' 2/27/2022

Option Strict On
Option Explicit On
Option Infer Off
Public Class FrmMain


    Dim strEmpID As String 'Cooresponds to TxtID
    Dim intNumSold As Integer = 0 'Cooresponds to TxtNumSold
    Dim intFullTime As Integer = 0 'Cooresponds to TxtSoldByFullTime
    Dim intPartTime As Integer = 0 'Cooresponds to TxtSoldByPartTime
    Dim intNewCar As Integer = 0 'Cooresponds to TxtSoldByNewCar
    Dim intUsedCar As Integer = 0 'Cooresponds to TxtSoldByUsedCar

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim blnIsFullTime As Boolean = False
        Dim blnSellsNew As Boolean = False
        strEmpID = TxtID.Text 'Cooresponds to strEmpID / TxtID is the textbox for the Employee ID 
        Dim blnNumTest As Boolean ' = IsNumeric(txtNumSold.Text)

        blnNumTest = Integer.TryParse(TxtNumSold.Text, intNumSold)
        If blnNumTest <> True Then
            MessageBox.Show("Please enter the correct values! (i.e., Integer Value for Numbers Sold)")
            'Clear textboxes following an error
            TxtID.Clear()
            TxtNumSold.Clear()
        Else

            If strEmpID Like "###[Nn|Uu][Ff|Pp]" Then

                'Will look for a string beginning with three integers
                'Followed "N(new car), U(used car), F(fulltime), P(parttime)
                'Combination will be: [Three Integers]->(Car Type)->(Fulltime || Parttime)

                If strEmpID(3) = "N" Or strEmpID(3) = "n" Then
                    blnSellsNew = True
                End If
                If strEmpID(4) = "F" Or strEmpID(4) = "f" Then
                    blnIsFullTime = True
                End If

                If blnSellsNew Then
                    intNewCar += intNumSold
                Else
                    intUsedCar += intNumSold
                End If
                If blnIsFullTime Then
                    intFullTime += intNumSold
                Else
                    intPartTime += intNumSold
                End If

            Else
                MessageBox.Show("Enter a valid Employee ID to continue!")
                'Clear textboxes following an error
                TxtID.Clear()
                TxtNumSold.Clear()
            End If
            'Convert everything
            TxtSoldByPartTime.Text = intPartTime.ToString
            TxtSoldByFullTime.Text = intFullTime.ToString
            TxtSoldByUsedCar.Text = intUsedCar.ToString
            TxtSoldByNewCar.Text = intNewCar.ToString
            'Clear textboxes following conversions / calculations
            TxtID.Clear()
            TxtNumSold.Clear()

        End If



    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        'These Form Closing events both work the same way, regardless if it is the 'BtnExit' button or the 'X' on the form. 
        'This is an *intended function.*
    End Sub


    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit?", "Woah!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'These Form Closing events both work the same way, regardless if it is the 'BtnExit' button or the 'X' on the form. 
            'This is an *intended function.*
            SplashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DECOY.Text = DateTime.Now.ToString("F")
    End Sub


End Class
