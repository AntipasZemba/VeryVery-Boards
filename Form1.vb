Public Class Form1
    Dim dblDailyTotal As Double
    Dim intDayBoards As Integer
    Dim intDayBoots As Integer
    Dim intDayCust As Integer

    Const dblBoardRate As Single = 20
    Const dblBootRate As Single = 30

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' declaring Variables
        Dim intBoards As Integer
        Dim intBoots As Integer

        Dim dblBoardCharge As Double
        Dim dblBootsCharge As Double
        Dim dblRentalTotal As Double
        Dim dblCustAvg As Double

        ' get my input
        If IsNumeric(txtBoards.Text) Then
            intBoards = txtBoards.Text
            If intBoards < 1 Then
                MessageBox.Show("Number of Snowboards Must Be Greater than 0")
                txtBoards.Focus()
            End If

        Else
            MessageBox.Show("Number of Snowboards Must Exist and Must be Numeric")
            txtBoards.Focus()
        End If

        If IsNumeric(txtBoardBoots.Text) Then
            intBoots = txtBoardBoots.Text
            If intBoards < 1 Then
                MessageBox.Show("Number of Snowboards with Boots Must Be Greater than 0")
                txtBoardBoots.Focus()
            End If

        Else
            MessageBox.Show("Number of Snowboards with Boots Must Exist and Must be Numeric")
            txtBoardBoots.Focus()
        End If
        ' do calculation

        ' Calculate Customer Rental
        dblBoardCharge = intBoards * dblBoardRate
        dblBootsCharge = intBoots * dblBootRate
        dblRentalTotal = dblBoardCharge + dblBootsCharge

        ' Calc. daily summary
        dblDailyTotal += dblRentalTotal

        intDayBoards += intBoards
        intDayBoots += intBoots

        intDayCust += 1

        dblCustAvg = dblDailyTotal / intDayCust


        ' Display Output
        lblBoardCharges.Text = FormatCurrency(dblBoardCharge)
        lblBoardBootsCharges.Text = FormatCurrency(dblBootsCharge)
        lblRentalCharges.Text = FormatCurrency(dblRentalTotal)

        lblDailyTotal.Text = FormatCurrency(dblDailyTotal)
        lblDailyBoards.Text = intDayBoards
        lblDailyBoots.Text = intDayBoots
        lblAvgCust.Text = FormatCurrency(dblCustAvg)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtID.Clear()
        txtBoards.Clear()
        txtBoardBoots.Clear()
        lblBoardCharges.ResetText()
        lblBoardBootsCharges.ResetText()
        lblRentalCharges.ResetText()

        txtName.Focus()

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtName.Clear()
        txtID.Clear()
        txtBoards.Clear()
        txtBoardBoots.Clear()
        lblBoardCharges.ResetText()
        lblBoardBootsCharges.ResetText()
        lblRentalCharges.ResetText()

        lblDailyBoards.ResetText()
        lblDailyBoots.ResetText()
        lblDailyTotal.ResetText()
        lblAvgCust.ResetText()

    End Sub
End Class
