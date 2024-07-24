Imports System.IO

Public Class Form1
    Public isEditing As Boolean = False
    Public activeFile As String = "%USERPROFILE%\Documents\events.gml"
    Private Sub finishMessageEventButton_Click(sender As Object, e As EventArgs) Handles finishMessageEventButton.Click
        If (messageSpeakerNameBox.Text IsNot Nothing) Then
            eventOutputBox.Items.Add("    npcname(""" + messageSpeakerNameBox.Text + """),")
            eventOutputBox.Items.Add("    msgbox(" + """" + messageEntryBox.Text + """" + "),")
            eventOutputBox.Items.Add("    npcname(""""),")
        Else
            eventOutputBox.Items.Add("    msgbox(" + """" + messageEntryBox.Text + """" + "),")
        End If
        messageEntryBox.Text = ""
        messageSpeakerNameBox.Text = ""
        msgGroupBox.Visible = False
        isEditing = False
    End Sub

    Private Sub newEventCreateButton_Click(sender As Object, e As EventArgs) Handles newEventCreateButton.Click
        If (eventOutputBox.Items.Count > 0) Then
            Dim Msg, Style, Title, Response
            Msg = "There's already an event in the output box. Delete and start a new Event?"    ' Define message.
            Style = vbYesNo Or vbCritical Or vbDefaultButton2    ' Define buttons.
            Title = "Overwrite event?"    ' Define title.
            ' Display message.
            Response = MsgBox(Msg, Style, Title)
            If Response = vbYes Then    ' User chose Yes.
                eventOutputBox.Items.Clear()
                createEventGroupBox.Visible = False
                eventOutputBox.Items.Add("global.topics[$ """ + newEventNameBox.Text + """] = [")
                eventButtonsGroupBox.Visible = True
                finishEventButton.Visible = True
            End If
        Else
            eventOutputBox.Items.Clear()
            createEventGroupBox.Visible = False
            eventOutputBox.Items.Add("global.topics[$ """ + newEventNameBox.Text + """] = [")
            eventButtonsGroupBox.Visible = True
            finishEventButton.Visible = True
        End If
    End Sub

    Private Sub newEventStartButton_Click(sender As Object, e As EventArgs) Handles newEventStartButton.Click
        createEventGroupBox.Visible = True
    End Sub

    Private Sub finishEventButton_Click(sender As Object, e As EventArgs) Handles finishEventButton.Click
        eventOutputBox.Items.Add("];")
        eventButtonsGroupBox.Visible = False
        finishEventButton.Visible = False
        exportGroupBox.Visible = True
    End Sub


    Private Sub gotoEventButton_Click(sender As Object, e As EventArgs)
        If isEditing = False Then
            gotoEventGroupBox.Visible = True
            isEditing = True
        End If
    End Sub

    Private Sub messageButton_Click(sender As Object, e As EventArgs) Handles messageButton.Click
        If isEditing = False Then
            msgGroupBox.Visible = True
            isEditing = True
        End If
    End Sub

    Private Sub gotoEventButton_Click_1(sender As Object, e As EventArgs) Handles gotoEventButton.Click
        If isEditing = False Then
            gotoEventGroupBox.Visible = True
            isEditing = True
        End If
    End Sub

    Private Sub finishGotoEventButton_Click(sender As Object, e As EventArgs) Handles finishGotoEventButton.Click
        eventOutputBox.Items.Add("    goto(" + gotoEventTextbox.Text + ")," + Environment.NewLine)
        gotoEventGroupBox.Visible = False
        eventButtonsGroupBox.Visible = False
        isEditing = False
    End Sub

    Private Sub finishGotoIfEventButton_Click(sender As Object, e As EventArgs) Handles finishGotoIfEventButton.Click
        eventOutputBox.Items.Add("    goto_if_equals(" + gotoIfEventVarBox.Text + ", " + gotoIfEventValueBox.Text + ", " + gotoIfEventBox.Text + "),")
        gotoEventGroupBox.Visible = False
        eventButtonsGroupBox.Visible = False
        gotoEventIfGroupBox.Visible = False
        isEditing = False
    End Sub

    Private Sub gotoEventIfButton_Click(sender As Object, e As EventArgs) Handles gotoEventIfButton.Click
        If isEditing = False Then
            gotoEventIfGroupBox.Visible = True
            isEditing = True
        End If
    End Sub

    Private Sub SetQuestStageButton_Click(sender As Object, e As EventArgs) Handles SetQuestStageButton.Click
        If isEditing = False Then
            setQuestStageGroupBox.Visible = True
            isEditing = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eventOutputBox.Items.Add("    setvar(" + setQuestStageVarBox.Text + ", " + setQuestStageTextbox.Text + "),")
        setQuestStageGroupBox.Visible = False
        isEditing = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        setQuestStageTextbox.Text = ""
        setQuestStageVarBox.Text = ""
        isEditing = False
        setQuestStageGroupBox.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case movementSelectionBox.SelectedIndex
            Case 0 'North 1 tile
                eventOutputBox.Items.Add("    applymovement(" + movementNPCIdBox.Text + ", CommonMovement_North),")
            Case 1 'South 1 tile
                eventOutputBox.Items.Add("    applymovement(" + movementNPCIdBox.Text + ", CommonMovement_South),")
            Case 2 'East 1 tile
                eventOutputBox.Items.Add("    applymovement(" + movementNPCIdBox.Text + ", CommonMovement_East),")
            Case 3 'West 1 tile
                eventOutputBox.Items.Add("    applymovement(" + movementNPCIdBox.Text + ", CommonMovement_West),")
        End Select

    End Sub

    Private Sub movementButton_Click(sender As Object, e As EventArgs) Handles movementButton.Click
        If isEditing = False Then
            movementGroupBox.Visible = True
            isEditing = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        movementGroupBox.Visible = False
        isEditing = False
    End Sub

    Private Sub eventOutputBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventOutputBox.SelectedIndexChanged
        If isEditing = False Then
            changeEventBox.Visible = True
            isEditing = True
            modifyEventBox.Text = eventOutputBox.SelectedItem
            eventOutputBox.Enabled = False
        End If
    End Sub

    Private Sub modifyEventFinishButton_Click(sender As Object, e As EventArgs) Handles modifyEventFinishButton.Click
        eventOutputBox.Items(eventOutputBox.SelectedIndex) = modifyEventBox.Text
        changeEventBox.Visible = False
        eventOutputBox.Enabled = True
        isEditing = False
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Select Case colorSelectionBox.SelectedIndex
            Case 0
                messageEntryBox.SelectedText = "[f_mc][c_mc]"
            Case 1
                messageEntryBox.SelectedText = "[f_ally][c_ally]"
            Case 2
                messageEntryBox.SelectedText = "[f_ally_rel][c_ally_rel]"
            Case 3
                messageEntryBox.SelectedText = "[f_standard][c_standard]"
            Case 4
                messageEntryBox.SelectedText = "[f_quest][c_quest]"
            Case 5
                messageEntryBox.SelectedText = "[f_location][c_location]"
            Case 6
                messageEntryBox.SelectedText = "[f_system][c_system]"
            Case 7
                messageEntryBox.SelectedText = "[f_narrate][c_narrate]"
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        eventOutputBox.Items.Remove(eventOutputBox.SelectedItem)
        changeEventBox.Visible = False
        eventOutputBox.Enabled = True
        isEditing = False
    End Sub

    Private Sub copyToClipboardButton_Click(sender As Object, e As EventArgs) Handles copyToClipboardButton.Click
        Dim str As String = ""
        For i As Integer = 0 To (eventOutputBox.Items.Count - 1)
            str = (str + eventOutputBox.Items(i).ToString + Environment.NewLine)
        Next
        My.Computer.Clipboard.SetText(str)
        exportGroupBox.Visible = False
        MessageBox.Show("Copied to Clipboard!", "Export", MessageBoxButtons.OK)
        eventOutputBox.Items.Clear()
    End Sub

    Private Sub openFileButton_Click(sender As Object, e As EventArgs) Handles openFileButton.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.CheckFileExists = True Then
            activeFile = OpenFileDialog1.FileName
            MessageBox.Show("File successfully opened.", "Open file", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub startNewFileButton_Click(sender As Object, e As EventArgs) Handles startNewFileButton.Click
        SaveFileDialog1.ShowDialog()
        activeFile = SaveFileDialog1.FileName
        If eventOutputBox.Items.Count > 0 Then
            For i As Integer = 0 To eventOutputBox.Items.Count - 1
                Dim sw1 As System.IO.StreamWriter
                sw1 = My.Computer.FileSystem.OpenTextFileWriter(activeFile, True)
                sw1.WriteLine(eventOutputBox.Items(i).ToString)
                sw1.Close()
            Next
            Dim sw2 As System.IO.StreamWriter
            sw2 = My.Computer.FileSystem.OpenTextFileWriter(activeFile, True)
            sw2.WriteLine(Environment.NewLine)
            sw2.Close()
            eventOutputBox.Items.Clear()
            MessageBox.Show("Wrote Topic to a new file.", "Success", MessageBoxButtons.OK)
            eventOutputBox.Items.Clear()
            OpenFileDialog1.FileName = SaveFileDialog1.FileName
        Else
            MessageBox.Show("Event log was empty. Nothing Written.", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub writeExitingTextButton_Click(sender As Object, e As EventArgs) Handles writeExitingTextButton.Click
        If OpenFileDialog1.CheckFileExists = True Then
            activeFile = OpenFileDialog1.FileName
            If eventOutputBox.Items.Count > 0 Then
                For i As Integer = 0 To eventOutputBox.Items.Count - 1
                    Dim sw3 As System.IO.StreamWriter
                    sw3 = My.Computer.FileSystem.OpenTextFileWriter(activeFile, True)
                    sw3.WriteLine(eventOutputBox.Items(i).ToString)
                    sw3.Close()
                Next
                Dim sw4 As System.IO.StreamWriter
                sw4 = My.Computer.FileSystem.OpenTextFileWriter(activeFile, True)
                sw4.WriteLine(Environment.NewLine)
                sw4.Close()
                eventOutputBox.Items.Clear()
                MessageBox.Show("Wrote event to a new file.", "Success", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Event log was empty. Nothing Written.", "Error", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("File isn't valid, present, or writeable.", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        eventOutputBox.Items.Add("    lock(),")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        eventOutputBox.Items.Add("    unlock(),")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (isEditing = False) Then
            turnObjectGroupBox.visible = True
            isEditing = True
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        eventOutputBox.Items.Add("    turnobject(" + turnObjectIDEntry.Text + ", " + turnObjectDirSelection.SelectedIndex.ToString + "),")
        turnObjectGroupBox.Visible = False
        isEditing = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        eventOutputBox.Items.Add("    msgbox(" + """" + messageEntryBox.Text + """" + "),")
        messageEntryBox.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        setflagGroup.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        eventOutputBox.Items.Add("    setflag(" + setflaginput.Text + ", " + setflagValues.SelectedIndex.ToString + "),")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        setflagGroup.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        checkFlagGroup.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        eventOutputBox.Items.Add("    checkflag(" + checkFlagInput.Text + ", " + checkFlagValues.SelectedIndex.ToString + ", " + checkFlagFunction.Text)
        checkFlagGroup.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        checkFlagGroup.Visible = False
    End Sub
End Class
