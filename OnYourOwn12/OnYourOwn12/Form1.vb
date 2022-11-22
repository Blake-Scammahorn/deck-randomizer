'So this took longer to make than anticipated.
'My friends wanted a program that could pull a random deck from a list of decks and since I was
'on this chapter I'd give it a shot as a submission, but it turns out it isn't as
'easy or clear as I thought it would be to turn an Excel spreadsheet and turn it into a
'SQL table.
'Turns out it isn't that hard if the amount of data is low, but there isn't a website out there
'that used the same method I ended up on.  Most want you to use a special SQL software,
'but for some reason the software did not recognize the db I was using for school work.
'There is also a tutorial for doing it through Visual Studio, but that didnt work for the same reason.
'I also tried to just create a new table, and eventually that worked, but I was unclear
'on exactly how to make it work since all the tutorials were coming at it from a SQL focus and
'not the coding side, which has different tools.
'
'The process I ended up doing was as follows:
'
'0. I reccomend inserting an ID column to your spreadsheet before adding to SQL.  You can 
'   make an auto-numbered SQL column, but its easier if this data isnt going to be edited
'   often to just add it in the spreadsheet.
'1. Save the spreadsheet as a .csv file
'2. go to https://www.convertcsv.com/csv-to-sql.htm
'   This is a tool that can take the data from a spreadsheet and create a query based on it.
'   This is your chance to make sure all the data is named correctly for SQL.  Under Step 3
'   you can edit the column names and data types.  Once you're happy with that click "CSV To SQL Insert"
'   under Step 4 and it will generate a query for you.  Turns out also query is the word used to not 
'   just find stuff in a table, but also to create and edit them.
'3. Create a new database.  I believe this is covered in ch 11.  
'4. Add a new table to the dataset.  The way we will be doing it is in the Server Explorer.  If you
'   don't have it open, you can open it in VS by selecting it in the View menu.  Under your new
'   database, there should be a Tables folder.  Right click and choose 'add new table'.  This will open
'   a window with a text portion at the bottom where you can enter your query.  We won't be using the full
'   query here though.
'5. Copy just the first portion of the query you generated on convertcsv.  That is, copy from CREATE to
'   the close parenthesis right before the first INSERT statement.  Then, paste this to the table designer
'   in VS.  Next, click "Update".  You have now created a table!  It is empty though, so now we need to
'   add the data.
'6. right click the newly created table in the server explorer and choose "New query".  Copy the rest of the
'   generated query statements (starting from that first INSERT statement) and paste it in VS.  Then click
'   the green run button. This will load all the data into your table.
'
'   From that point, everything is covered in the book.  It took me 4 or so days to figure all this out, so
'   I'm glad thats done with.
'
' As for what this program specifically is doing, it randomly displays information from the table, excluding
'any information matched to the user.  So if I select my name, it has a chance of showing anyone's
'information except mine, for example.
'<Blake S> on <12/29/2020>

Public Class frmMain
    Private Sub btnRand_Click(sender As Object, e As EventArgs) Handles btnRand.Click
        Dim strName As String

        Select Case True
            Case radBlake.Checked
                strName = "Dosha"
            Case radTim.Checked
                strName = "Tim"
            Case radNate.Checked
                strName = "Nate"
            Case radMichael.Checked
                strName = "Michael"
            Case radNepsWife.Checked
                strName = "Nep's Wife"
        End Select

        Dim randKey As Random = New Random()

        Do
            DecksTableAdapter.FillByID(CardsDataSet.decks, randKey.Next(0, 47))
        Loop While lblOwner.Text.Trim Like strName

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CardsDataSet.decks' table. You can move, or remove it, as needed.
        'Me.DecksTableAdapter.Fill(Me.CardsDataSet.decks)

    End Sub

    Private Sub linkDecklist_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDecklist.LinkClicked
        System.Diagnostics.Process.Start(linkDecklist.Text.Trim)
    End Sub

    Private Sub clearData(sender As Object, e As EventArgs) Handles radBlake.CheckedChanged, radMichael.CheckedChanged,
    radNate.CheckedChanged, radNepsWife.CheckedChanged, radTim.CheckedChanged

        lblCmdr.ResetText()
        lblColors.ResetText()
        lblDeckName.ResetText()
        lblOwner.ResetText()
        linkDecklist.ResetText()

    End Sub
End Class
