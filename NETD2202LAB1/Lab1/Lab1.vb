'Project: Lab1
'Name: Alec Armstrong 100617553
'Date: 2020-01-16
'Desc: Will take an input for each day in the week numbered from 1 to 7. Input data will then be validated and 
'displayed to the user. Once the number of units has been entered for the final day a calculation for average will 
'be done and displayed to the user. After the 7th day will not allow the user to access the enter key or input any
'more data until the form is reset. The user will be allowed to exit at any time.

Option Strict On

Public Class frmAverageUnitsShipped

    'Constant
    'Days in the week
    Const DAYS_IN_WEEK As Integer = 7

    'Variables
    'Day counter to keep track of day in week
    Dim DayCounter As Integer = 1
    'Average, double
    Dim AverageUnitsShipped As Double = 0.0
    'Tester used to check if number is a whole number, integer
    Dim TryParseTesterInteger As Integer = 0
    'Tester used to check if number is a real number, double
    Dim TryParseTesterDouble As Double = 0.0

    'Array
    'Set to contain unit entries for each day, using days in the week constant, integers
    Dim UnitsShipped(DAYS_IN_WEEK - 1) As Integer

    'Initialize variables, array and day display on form load
    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Reset variables
        'Day counter to keep track of day in week
        DayCounter = 1
        'Average
        AverageUnitsShipped = 0.0
        'Testers
        TryParseTesterInteger = 0
        TryParseTesterDouble = 0.0

        'Array
        'Set to contain unit entries for each day, using days in the week constant, integers
        ReDim UnitsShipped(DAYS_IN_WEEK - 1)

        'Day display
        lblDay.Text = "Day: " & CType(DayCounter, String)

    End Sub

    'Exit button
    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click

        'Close the form
        Me.Close()

    End Sub

    'Reset button
    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click

        'Clear all fields 
        txtGetUnits.Clear()
        lblShowAverage.Text = ""
        txtShowPrevUnits.Clear()

        'Clear contents of array and variables
        ReDim UnitsShipped(DAYS_IN_WEEK - 1)
        AverageUnitsShipped = 0.0
        TryParseTesterInteger = 0
        TryParseTesterDouble = 0.0
        DayCounter = 1

        'Set focus on the input field and reset all tools
        lblDay.Text = "Day: " & CType(DayCounter, String)
        btnEnterUseable.Enabled = True
        btnEnterUseable.BackColor = Color.White
        txtGetUnits.ReadOnly = False
        txtGetUnits.BackColor = Color.White
        txtGetUnits.Focus()

    End Sub

    'Enter button
    Private Sub btnEnterUseable_Click(sender As Object, e As EventArgs) Handles btnEnterUseable.Click

        'Validate that input is an integer and in range
        If Integer.TryParse(txtGetUnits.Text, TryParseTesterInteger) = True And TryParseTesterInteger >= 0 And TryParseTesterInteger <= 5000 Then

            'Check what day of the week it is
            If DayCounter <= 6 Then

                'If days 1-6 store units in day array and display in the PrevUnits text box, reset integer tester
                UnitsShipped(DayCounter - 1) = TryParseTesterInteger
                txtShowPrevUnits.Text = txtShowPrevUnits.Text + CType(UnitsShipped(DayCounter - 1), String) + vbNewLine
                txtGetUnits.Clear()
                TryParseTesterInteger = 0

                'Update day counter and display
                DayCounter = DayCounter + 1
                lblDay.Text = "Day: " & CType(DayCounter, String)

            ElseIf DayCounter = 7 Then

                'If day 7 store units in day array, display in the PrevUnits text box 
                'Also make the enter button hidden and get units field and show the unuseable enter button and unusable units label
                'Update day counter
                UnitsShipped(DayCounter - 1) = TryParseTesterInteger
                txtShowPrevUnits.Text = txtShowPrevUnits.Text + CType(UnitsShipped(DayCounter - 1), String)
                txtGetUnits.Clear()
                TryParseTesterInteger = 0
                DayCounter = DayCounter + 1
                btnEnterUseable.Enabled = False
                btnEnterUseable.BackColor = Color.LightGray
                txtGetUnits.ReadOnly = True
                txtGetUnits.BackColor = Color.LightGray

                'Calculate the average of all the days in the array
                For AverageCounter As Integer = 1 To DAYS_IN_WEEK

                    AverageUnitsShipped = AverageUnitsShipped + UnitsShipped(AverageCounter - 1)

                Next

                'Display the average of all the days
                AverageUnitsShipped = AverageUnitsShipped / DAYS_IN_WEEK
                lblShowAverage.Text = "Average Per Day: " & CType(Math.Round(AverageUnitsShipped, 2), String)

            Else

                'Do nothing until reset button is used

            End If

        Else

            If Double.TryParse(txtGetUnits.Text, TryParseTesterDouble) = False Then

                'Display must be a number error
                MessageBox.Show("Please enter a numeric value.")
                txtGetUnits.Clear()
                txtGetUnits.Focus()

            Else

                If TryParseTesterDouble < 0 Or TryParseTesterDouble > 5000 Then

                    'Display must be in range number error
                    MessageBox.Show("Please enter a numeric value between 0 and 5000.")
                    txtGetUnits.Clear()
                    txtGetUnits.Focus()

                Else

                    'Display must be a integer error
                    MessageBox.Show("Please enter a whole numeric value.")
                    txtGetUnits.Clear()
                    txtGetUnits.Focus()

                End If

            End If

        End If

    End Sub

End Class
