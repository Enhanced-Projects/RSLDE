<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        newEventStartButton = New Button()
        Panel1 = New Panel()
        checkFlagGroup = New GroupBox()
        Button19 = New Button()
        Button18 = New Button()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        checkFlagFunction = New TextBox()
        checkFlagValues = New ComboBox()
        checkFlagInput = New TextBox()
        setflagGroup = New GroupBox()
        Button16 = New Button()
        Button15 = New Button()
        Label23 = New Label()
        Label22 = New Label()
        setflagValues = New ComboBox()
        Label18 = New Label()
        setflaginput = New TextBox()
        msgGroupBox = New GroupBox()
        Button13 = New Button()
        Button9 = New Button()
        colorSelectionBox = New ComboBox()
        Button3 = New Button()
        Label10 = New Label()
        messageSpeakerNameBox = New TextBox()
        Label2 = New Label()
        finishMessageEventButton = New Button()
        messageEntryBox = New TextBox()
        eventOutputBox = New ListBox()
        movementGroupBox = New GroupBox()
        movementNPCIdBox = New MaskedTextBox()
        Label14 = New Label()
        Button6 = New Button()
        movementSelectionBox = New ComboBox()
        Button4 = New Button()
        Label15 = New Label()
        Button5 = New Button()
        turnObjectGroupBox = New GroupBox()
        turnObjectDirSelection = New ComboBox()
        turnObjectIDEntry = New MaskedTextBox()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Button12 = New Button()
        gotoEventIfGroupBox = New GroupBox()
        gotoIfEventValueBox = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        gotoIfEventVarBox = New TextBox()
        Label1 = New Label()
        gotoIfEventBox = New TextBox()
        Label7 = New Label()
        finishGotoIfEventButton = New Button()
        changeEventBox = New GroupBox()
        Button8 = New Button()
        Label16 = New Label()
        modifyEventBox = New TextBox()
        Label17 = New Label()
        modifyEventFinishButton = New Button()
        gotoEventGroupBox = New GroupBox()
        Label4 = New Label()
        gotoEventTextbox = New TextBox()
        Label3 = New Label()
        finishGotoEventButton = New Button()
        createEventGroupBox = New GroupBox()
        Label5 = New Label()
        newEventNameBox = New TextBox()
        Label6 = New Label()
        newEventCreateButton = New Button()
        setQuestStageGroupBox = New GroupBox()
        Button2 = New Button()
        setQuestStageVarBox = New MaskedTextBox()
        Label13 = New Label()
        setQuestStageTextbox = New TextBox()
        Label11 = New Label()
        Button1 = New Button()
        Label12 = New Label()
        finishEventButton = New Button()
        eventButtonsGroupBox = New GroupBox()
        Button17 = New Button()
        Button14 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Button7 = New Button()
        SetQuestStageButton = New Button()
        gotoEventIfButton = New Button()
        movementButton = New Button()
        gotoEventButton = New Button()
        messageButton = New Button()
        ToolTip1 = New ToolTip(components)
        copyToClipboardButton = New Button()
        writeExitingTextButton = New Button()
        startNewFileButton = New Button()
        openFileButton = New Button()
        colorPickerBox = New ColorDialog()
        exportGroupBox = New GroupBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1.SuspendLayout()
        checkFlagGroup.SuspendLayout()
        setflagGroup.SuspendLayout()
        msgGroupBox.SuspendLayout()
        movementGroupBox.SuspendLayout()
        turnObjectGroupBox.SuspendLayout()
        gotoEventIfGroupBox.SuspendLayout()
        changeEventBox.SuspendLayout()
        gotoEventGroupBox.SuspendLayout()
        createEventGroupBox.SuspendLayout()
        setQuestStageGroupBox.SuspendLayout()
        eventButtonsGroupBox.SuspendLayout()
        exportGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' newEventStartButton
        ' 
        newEventStartButton.ForeColor = SystemColors.ActiveCaptionText
        newEventStartButton.Location = New Point(12, 9)
        newEventStartButton.Name = "newEventStartButton"
        newEventStartButton.Size = New Size(88, 31)
        newEventStartButton.TabIndex = 0
        newEventStartButton.Text = "New Topic"
        newEventStartButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(checkFlagGroup)
        Panel1.Controls.Add(setflagGroup)
        Panel1.Controls.Add(msgGroupBox)
        Panel1.Controls.Add(eventOutputBox)
        Panel1.Controls.Add(movementGroupBox)
        Panel1.Controls.Add(turnObjectGroupBox)
        Panel1.Controls.Add(gotoEventIfGroupBox)
        Panel1.Controls.Add(changeEventBox)
        Panel1.Controls.Add(gotoEventGroupBox)
        Panel1.Controls.Add(createEventGroupBox)
        Panel1.Controls.Add(setQuestStageGroupBox)
        Panel1.Location = New Point(263, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(624, 568)
        Panel1.TabIndex = 1
        ' 
        ' checkFlagGroup
        ' 
        checkFlagGroup.Controls.Add(Button19)
        checkFlagGroup.Controls.Add(Button18)
        checkFlagGroup.Controls.Add(Label27)
        checkFlagGroup.Controls.Add(Label26)
        checkFlagGroup.Controls.Add(Label25)
        checkFlagGroup.Controls.Add(Label24)
        checkFlagGroup.Controls.Add(checkFlagFunction)
        checkFlagGroup.Controls.Add(checkFlagValues)
        checkFlagGroup.Controls.Add(checkFlagInput)
        checkFlagGroup.Location = New Point(115, 27)
        checkFlagGroup.Name = "checkFlagGroup"
        checkFlagGroup.Size = New Size(373, 325)
        checkFlagGroup.TabIndex = 22
        checkFlagGroup.TabStop = False
        checkFlagGroup.Text = "Check Flag"
        checkFlagGroup.Visible = False
        ' 
        ' Button19
        ' 
        Button19.ForeColor = SystemColors.ActiveCaptionText
        Button19.Location = New Point(280, 129)
        Button19.Name = "Button19"
        Button19.Size = New Size(76, 28)
        Button19.TabIndex = 8
        Button19.Text = "Cancel"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.ForeColor = SystemColors.ActiveCaptionText
        Button18.Location = New Point(192, 129)
        Button18.Name = "Button18"
        Button18.Size = New Size(78, 29)
        Button18.TabIndex = 7
        Button18.Text = "Insert"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Label27
        ' 
        Label27.Location = New Point(11, 225)
        Label27.Name = "Label27"
        Label27.Size = New Size(350, 95)
        Label27.TabIndex = 6
        Label27.Text = "This function checks a given flag for a given value, and then goes to the given function if the value is the one you're checking."
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(12, 164)
        Label26.Name = "Label26"
        Label26.Size = New Size(105, 20)
        Label26.TabIndex = 5
        Label26.Text = "Function to go"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(13, 108)
        Label25.Name = "Label25"
        Label25.Size = New Size(45, 20)
        Label25.TabIndex = 4
        Label25.Text = "Value"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(12, 51)
        Label24.Name = "Label24"
        Label24.Size = New Size(96, 20)
        Label24.TabIndex = 3
        Label24.Text = "Flag to check"
        ' 
        ' checkFlagFunction
        ' 
        checkFlagFunction.Location = New Point(9, 187)
        checkFlagFunction.Name = "checkFlagFunction"
        checkFlagFunction.Size = New Size(347, 27)
        checkFlagFunction.TabIndex = 2
        ' 
        ' checkFlagValues
        ' 
        checkFlagValues.FormattingEnabled = True
        checkFlagValues.Items.AddRange(New Object() {"Enabled", "Disabled", "Permanently Disabled"})
        checkFlagValues.Location = New Point(10, 130)
        checkFlagValues.Name = "checkFlagValues"
        checkFlagValues.Size = New Size(173, 28)
        checkFlagValues.TabIndex = 1
        ' 
        ' checkFlagInput
        ' 
        checkFlagInput.Location = New Point(9, 74)
        checkFlagInput.Name = "checkFlagInput"
        checkFlagInput.Size = New Size(347, 27)
        checkFlagInput.TabIndex = 0
        ' 
        ' setflagGroup
        ' 
        setflagGroup.Controls.Add(Button16)
        setflagGroup.Controls.Add(Button15)
        setflagGroup.Controls.Add(Label23)
        setflagGroup.Controls.Add(Label22)
        setflagGroup.Controls.Add(setflagValues)
        setflagGroup.Controls.Add(Label18)
        setflagGroup.Controls.Add(setflaginput)
        setflagGroup.ForeColor = Color.WhiteSmoke
        setflagGroup.Location = New Point(100, 27)
        setflagGroup.Name = "setflagGroup"
        setflagGroup.Size = New Size(405, 325)
        setflagGroup.TabIndex = 15
        setflagGroup.TabStop = False
        setflagGroup.Text = "Set Flag"
        setflagGroup.Visible = False
        ' 
        ' Button16
        ' 
        Button16.ForeColor = Color.Black
        Button16.Location = New Point(147, 102)
        Button16.Name = "Button16"
        Button16.Size = New Size(94, 28)
        Button16.TabIndex = 6
        Button16.Text = "Cancel"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.ForeColor = Color.Black
        Button15.Location = New Point(147, 63)
        Button15.Name = "Button15"
        Button15.Size = New Size(96, 30)
        Button15.TabIndex = 5
        Button15.Text = "Insert"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(252, 41)
        Label23.Name = "Label23"
        Label23.Size = New Size(86, 20)
        Label23.TabIndex = 4
        Label23.Text = "Value to set"
        ' 
        ' Label22
        ' 
        Label22.Location = New Point(31, 167)
        Label22.Name = "Label22"
        Label22.Size = New Size(342, 135)
        Label22.TabIndex = 3
        Label22.Text = resources.GetString("Label22.Text")
        ' 
        ' setflagValues
        ' 
        setflagValues.FormattingEnabled = True
        setflagValues.Items.AddRange(New Object() {"Enabled", "Disabled", "Permanently Disabled"})
        setflagValues.Location = New Point(252, 65)
        setflagValues.Name = "setflagValues"
        setflagValues.Size = New Size(121, 28)
        setflagValues.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(31, 41)
        Label18.Name = "Label18"
        Label18.Size = New Size(78, 20)
        Label18.TabIndex = 1
        Label18.Text = "Flag to set"
        ' 
        ' setflaginput
        ' 
        setflaginput.Location = New Point(31, 65)
        setflaginput.Name = "setflaginput"
        setflaginput.Size = New Size(100, 27)
        setflaginput.TabIndex = 0
        setflaginput.Text = "unusedFlag0"
        ' 
        ' msgGroupBox
        ' 
        msgGroupBox.BackColor = SystemColors.ActiveCaptionText
        msgGroupBox.Controls.Add(Button13)
        msgGroupBox.Controls.Add(Button9)
        msgGroupBox.Controls.Add(colorSelectionBox)
        msgGroupBox.Controls.Add(Button3)
        msgGroupBox.Controls.Add(Label10)
        msgGroupBox.Controls.Add(messageSpeakerNameBox)
        msgGroupBox.Controls.Add(Label2)
        msgGroupBox.Controls.Add(finishMessageEventButton)
        msgGroupBox.Controls.Add(messageEntryBox)
        msgGroupBox.ForeColor = Color.White
        msgGroupBox.Location = New Point(24, 27)
        msgGroupBox.Name = "msgGroupBox"
        msgGroupBox.Size = New Size(579, 323)
        msgGroupBox.TabIndex = 11
        msgGroupBox.TabStop = False
        msgGroupBox.Text = "Message"
        msgGroupBox.Visible = False
        ' 
        ' Button13
        ' 
        Button13.ForeColor = SystemColors.ControlText
        Button13.Location = New Point(438, 85)
        Button13.Name = "Button13"
        Button13.Size = New Size(126, 30)
        Button13.TabIndex = 21
        Button13.Text = "New Paragraph"
        ToolTip1.SetToolTip(Button13, "Click to add the color change command from the menu to the text below. You can also  manually type these if you want. You can use other colors like [c_orange] after the fDialogue text.")
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.ForeColor = SystemColors.ControlText
        Button9.Location = New Point(283, 85)
        Button9.Name = "Button9"
        Button9.Size = New Size(102, 30)
        Button9.TabIndex = 20
        Button9.Text = "Insert"
        ToolTip1.SetToolTip(Button9, "Click to add the color change command from the menu to the text below. You can also  manually type these if you want. You can use other colors like [c_orange] after the fDialogue text.")
        Button9.UseVisualStyleBackColor = True
        ' 
        ' colorSelectionBox
        ' 
        colorSelectionBox.FormattingEnabled = True
        colorSelectionBox.Items.AddRange(New Object() {"MC (blue)", "Ally (teal)", "Companion (pink)", "Standard (white)", "Quest (gold)", "Location (green)", "System (pale red)", "Narrate(gray)"})
        colorSelectionBox.Location = New Point(131, 87)
        colorSelectionBox.Name = "colorSelectionBox"
        colorSelectionBox.Size = New Size(133, 28)
        colorSelectionBox.TabIndex = 19
        colorSelectionBox.Text = "Color:"
        ToolTip1.SetToolTip(colorSelectionBox, "Choose a font")
        ' 
        ' Button3
        ' 
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(7, 26)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 30)
        Button3.TabIndex = 17
        Button3.Text = "Cancel"
        ToolTip1.SetToolTip(Button3, "Cancel this event and clear boxes.")
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 65)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 20)
        Label10.TabIndex = 16
        Label10.Text = "NPC Name:"
        ' 
        ' messageSpeakerNameBox
        ' 
        messageSpeakerNameBox.Location = New Point(8, 88)
        messageSpeakerNameBox.Name = "messageSpeakerNameBox"
        messageSpeakerNameBox.Size = New Size(100, 27)
        messageSpeakerNameBox.TabIndex = 15
        ToolTip1.SetToolTip(messageSpeakerNameBox, "Enter the name of the talking NPC")
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(8, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(556, 88)
        Label2.TabIndex = 14
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' finishMessageEventButton
        ' 
        finishMessageEventButton.ForeColor = SystemColors.ControlText
        finishMessageEventButton.Location = New Point(471, 26)
        finishMessageEventButton.Name = "finishMessageEventButton"
        finishMessageEventButton.Size = New Size(102, 30)
        finishMessageEventButton.TabIndex = 13
        finishMessageEventButton.Text = "Finish"
        ToolTip1.SetToolTip(finishMessageEventButton, "Finalize this Event and add it to the output.")
        finishMessageEventButton.UseVisualStyleBackColor = True
        ' 
        ' messageEntryBox
        ' 
        messageEntryBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        messageEntryBox.Location = New Point(7, 125)
        messageEntryBox.Multiline = True
        messageEntryBox.Name = "messageEntryBox"
        messageEntryBox.Size = New Size(557, 98)
        messageEntryBox.TabIndex = 0
        messageEntryBox.Text = "Type your message content here."
        ToolTip1.SetToolTip(messageEntryBox, "Enter the message content.")
        ' 
        ' eventOutputBox
        ' 
        eventOutputBox.BackColor = SystemColors.ActiveCaptionText
        eventOutputBox.ForeColor = SystemColors.AppWorkspace
        eventOutputBox.FormattingEnabled = True
        eventOutputBox.ItemHeight = 20
        eventOutputBox.Location = New Point(24, 354)
        eventOutputBox.Name = "eventOutputBox"
        eventOutputBox.Size = New Size(579, 204)
        eventOutputBox.TabIndex = 2
        ToolTip1.SetToolTip(eventOutputBox, "You can select an event line here to modify or remove it.")
        ' 
        ' movementGroupBox
        ' 
        movementGroupBox.BackColor = SystemColors.ActiveCaptionText
        movementGroupBox.Controls.Add(movementNPCIdBox)
        movementGroupBox.Controls.Add(Label14)
        movementGroupBox.Controls.Add(Button6)
        movementGroupBox.Controls.Add(movementSelectionBox)
        movementGroupBox.Controls.Add(Button4)
        movementGroupBox.Controls.Add(Label15)
        movementGroupBox.Controls.Add(Button5)
        movementGroupBox.ForeColor = Color.White
        movementGroupBox.Location = New Point(24, 53)
        movementGroupBox.Name = "movementGroupBox"
        movementGroupBox.Size = New Size(579, 299)
        movementGroupBox.TabIndex = 18
        movementGroupBox.TabStop = False
        movementGroupBox.Text = "Movement"
        movementGroupBox.Visible = False
        ' 
        ' movementNPCIdBox
        ' 
        movementNPCIdBox.Location = New Point(536, 85)
        movementNPCIdBox.Mask = "00"
        movementNPCIdBox.Name = "movementNPCIdBox"
        movementNPCIdBox.Size = New Size(28, 27)
        movementNPCIdBox.TabIndex = 21
        movementNPCIdBox.Text = "0"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(438, 92)
        Label14.Name = "Label14"
        Label14.Size = New Size(92, 20)
        Label14.TabIndex = 20
        Label14.Text = "NPC number"
        ' 
        ' Button6
        ' 
        Button6.ForeColor = SystemColors.ControlText
        Button6.Location = New Point(218, 80)
        Button6.Name = "Button6"
        Button6.Size = New Size(102, 30)
        Button6.TabIndex = 19
        Button6.Text = "Add"
        ToolTip1.SetToolTip(Button6, "Finalize this Event and add it to the output.")
        Button6.UseVisualStyleBackColor = True
        ' 
        ' movementSelectionBox
        ' 
        movementSelectionBox.FormattingEnabled = True
        movementSelectionBox.Items.AddRange(New Object() {"North 1 tile", "South 1 tile", "East 1 tile", "West 1 tile", "Face North", "Face South", "Face East", "Face West"})
        movementSelectionBox.Location = New Point(8, 82)
        movementSelectionBox.Name = "movementSelectionBox"
        movementSelectionBox.Size = New Size(204, 28)
        movementSelectionBox.TabIndex = 18
        movementSelectionBox.Text = "Select a Movement action."
        ' 
        ' Button4
        ' 
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(7, 26)
        Button4.Name = "Button4"
        Button4.Size = New Size(102, 30)
        Button4.TabIndex = 17
        Button4.Text = "Cancel"
        ToolTip1.SetToolTip(Button4, "Cancel this event and clear boxes.")
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(8, 180)
        Label15.Name = "Label15"
        Label15.Size = New Size(565, 111)
        Label15.TabIndex = 14
        Label15.Text = resources.GetString("Label15.Text")
        ' 
        ' Button5
        ' 
        Button5.ForeColor = SystemColors.ControlText
        Button5.Location = New Point(471, 26)
        Button5.Name = "Button5"
        Button5.Size = New Size(102, 30)
        Button5.TabIndex = 13
        Button5.Text = "Finish"
        ToolTip1.SetToolTip(Button5, "Finalize this Event and add it to the output.")
        Button5.UseVisualStyleBackColor = True
        ' 
        ' turnObjectGroupBox
        ' 
        turnObjectGroupBox.BackColor = SystemColors.ActiveCaptionText
        turnObjectGroupBox.Controls.Add(turnObjectDirSelection)
        turnObjectGroupBox.Controls.Add(turnObjectIDEntry)
        turnObjectGroupBox.Controls.Add(Label19)
        turnObjectGroupBox.Controls.Add(Label20)
        turnObjectGroupBox.Controls.Add(Label21)
        turnObjectGroupBox.Controls.Add(Button12)
        turnObjectGroupBox.ForeColor = Color.White
        turnObjectGroupBox.Location = New Point(125, 60)
        turnObjectGroupBox.Name = "turnObjectGroupBox"
        turnObjectGroupBox.RightToLeft = RightToLeft.No
        turnObjectGroupBox.Size = New Size(400, 166)
        turnObjectGroupBox.TabIndex = 20
        turnObjectGroupBox.TabStop = False
        turnObjectGroupBox.Text = "Turn Object"
        turnObjectGroupBox.Visible = False
        ' 
        ' turnObjectDirSelection
        ' 
        turnObjectDirSelection.FormattingEnabled = True
        turnObjectDirSelection.Items.AddRange(New Object() {"East", "North", "West", "South"})
        turnObjectDirSelection.Location = New Point(113, 82)
        turnObjectDirSelection.Name = "turnObjectDirSelection"
        turnObjectDirSelection.Size = New Size(121, 28)
        turnObjectDirSelection.TabIndex = 22
        turnObjectDirSelection.Text = "Select Dir"
        ' 
        ' turnObjectIDEntry
        ' 
        turnObjectIDEntry.Location = New Point(13, 82)
        turnObjectIDEntry.Mask = "0000"
        turnObjectIDEntry.Name = "turnObjectIDEntry"
        turnObjectIDEntry.Size = New Size(67, 27)
        turnObjectIDEntry.TabIndex = 21
        turnObjectIDEntry.Text = "0"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(113, 55)
        Label19.Name = "Label19"
        Label19.Size = New Size(124, 20)
        Label19.TabIndex = 19
        Label19.Text = "Direction to Face:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(7, 59)
        Label20.Name = "Label20"
        Label20.Size = New Size(72, 20)
        Label20.TabIndex = 16
        Label20.Text = "Object ID"
        ' 
        ' Label21
        ' 
        Label21.Location = New Point(7, 114)
        Label21.Name = "Label21"
        Label21.Size = New Size(386, 85)
        Label21.TabIndex = 14
        Label21.Text = "Make any object(or NPC) face a specific direction. Select a Direction then click Finish."
        ' 
        ' Button12
        ' 
        Button12.ForeColor = SystemColors.ControlText
        Button12.Location = New Point(291, 25)
        Button12.Name = "Button12"
        Button12.Size = New Size(102, 30)
        Button12.TabIndex = 13
        Button12.Text = "Finish"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' gotoEventIfGroupBox
        ' 
        gotoEventIfGroupBox.BackColor = SystemColors.ActiveCaptionText
        gotoEventIfGroupBox.Controls.Add(gotoIfEventValueBox)
        gotoEventIfGroupBox.Controls.Add(Label9)
        gotoEventIfGroupBox.Controls.Add(Label8)
        gotoEventIfGroupBox.Controls.Add(gotoIfEventVarBox)
        gotoEventIfGroupBox.Controls.Add(Label1)
        gotoEventIfGroupBox.Controls.Add(gotoIfEventBox)
        gotoEventIfGroupBox.Controls.Add(Label7)
        gotoEventIfGroupBox.Controls.Add(finishGotoIfEventButton)
        gotoEventIfGroupBox.ForeColor = Color.White
        gotoEventIfGroupBox.Location = New Point(125, 60)
        gotoEventIfGroupBox.Name = "gotoEventIfGroupBox"
        gotoEventIfGroupBox.RightToLeft = RightToLeft.No
        gotoEventIfGroupBox.Size = New Size(400, 280)
        gotoEventIfGroupBox.TabIndex = 17
        gotoEventIfGroupBox.TabStop = False
        gotoEventIfGroupBox.Text = "Go To Event If"
        gotoEventIfGroupBox.Visible = False
        ' 
        ' gotoIfEventValueBox
        ' 
        gotoIfEventValueBox.Location = New Point(283, 146)
        gotoIfEventValueBox.Mask = "000000000"
        gotoIfEventValueBox.Name = "gotoIfEventValueBox"
        gotoIfEventValueBox.Size = New Size(67, 27)
        gotoIfEventValueBox.TabIndex = 21
        gotoIfEventValueBox.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(256, 123)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 20)
        Label9.TabIndex = 20
        Label9.Text = "Value to check for:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(50, 119)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 20)
        Label8.TabIndex = 19
        Label8.Text = "Variable Name:"
        ' 
        ' gotoIfEventVarBox
        ' 
        gotoIfEventVarBox.Location = New Point(22, 145)
        gotoIfEventVarBox.Name = "gotoIfEventVarBox"
        gotoIfEventVarBox.Size = New Size(153, 27)
        gotoIfEventVarBox.TabIndex = 17
        gotoIfEventVarBox.Text = "introQuestVar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 20)
        Label1.TabIndex = 16
        Label1.Text = "Name of Topic to go to:"
        ' 
        ' gotoIfEventBox
        ' 
        gotoIfEventBox.Location = New Point(11, 88)
        gotoIfEventBox.Name = "gotoIfEventBox"
        gotoIfEventBox.Size = New Size(386, 27)
        gotoIfEventBox.TabIndex = 15
        gotoIfEventBox.Text = "SomeOtherEventNameHere"
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(7, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(386, 85)
        Label7.TabIndex = 14
        Label7.Text = "Similar to Go To Event, except it only goes to the chosen Topic if the variable name in here has the value you put in here. Great for if you will have multiple different interactions with an NPC."
        ' 
        ' finishGotoIfEventButton
        ' 
        finishGotoIfEventButton.ForeColor = SystemColors.ControlText
        finishGotoIfEventButton.Location = New Point(291, 25)
        finishGotoIfEventButton.Name = "finishGotoIfEventButton"
        finishGotoIfEventButton.Size = New Size(102, 30)
        finishGotoIfEventButton.TabIndex = 13
        finishGotoIfEventButton.Text = "Finish"
        finishGotoIfEventButton.UseVisualStyleBackColor = True
        ' 
        ' changeEventBox
        ' 
        changeEventBox.BackColor = SystemColors.ActiveCaptionText
        changeEventBox.Controls.Add(Button8)
        changeEventBox.Controls.Add(Label16)
        changeEventBox.Controls.Add(modifyEventBox)
        changeEventBox.Controls.Add(Label17)
        changeEventBox.Controls.Add(modifyEventFinishButton)
        changeEventBox.ForeColor = Color.White
        changeEventBox.Location = New Point(24, 60)
        changeEventBox.Name = "changeEventBox"
        changeEventBox.RightToLeft = RightToLeft.No
        changeEventBox.Size = New Size(579, 280)
        changeEventBox.TabIndex = 19
        changeEventBox.TabStop = False
        changeEventBox.Text = "Modify or Remove event"
        changeEventBox.Visible = False
        ' 
        ' Button8
        ' 
        Button8.ForeColor = SystemColors.ControlText
        Button8.Location = New Point(11, 25)
        Button8.Name = "Button8"
        Button8.Size = New Size(126, 30)
        Button8.TabIndex = 17
        Button8.Text = "Remove Event"
        ToolTip1.SetToolTip(Button8, "Delete this event from the output.")
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(7, 59)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 20)
        Label16.TabIndex = 16
        Label16.Text = "Event:"
        ' 
        ' modifyEventBox
        ' 
        modifyEventBox.Location = New Point(7, 91)
        modifyEventBox.Name = "modifyEventBox"
        modifyEventBox.Size = New Size(566, 27)
        modifyEventBox.TabIndex = 15
        ToolTip1.SetToolTip(modifyEventBox, "The currently active output line.")
        ' 
        ' Label17
        ' 
        Label17.Location = New Point(7, 192)
        Label17.Name = "Label17"
        Label17.Size = New Size(566, 72)
        Label17.TabIndex = 14
        Label17.Text = "You can modify the raw contents of an event line in this box. Use for the purposes of fixing a typo or changing a value."
        ' 
        ' modifyEventFinishButton
        ' 
        modifyEventFinishButton.ForeColor = SystemColors.ControlText
        modifyEventFinishButton.Location = New Point(471, 19)
        modifyEventFinishButton.Name = "modifyEventFinishButton"
        modifyEventFinishButton.Size = New Size(102, 30)
        modifyEventFinishButton.TabIndex = 13
        modifyEventFinishButton.Text = "Finish"
        ToolTip1.SetToolTip(modifyEventFinishButton, "commit the changes to the line to the output.")
        modifyEventFinishButton.UseVisualStyleBackColor = True
        ' 
        ' gotoEventGroupBox
        ' 
        gotoEventGroupBox.BackColor = SystemColors.ActiveCaptionText
        gotoEventGroupBox.Controls.Add(Label4)
        gotoEventGroupBox.Controls.Add(gotoEventTextbox)
        gotoEventGroupBox.Controls.Add(Label3)
        gotoEventGroupBox.Controls.Add(finishGotoEventButton)
        gotoEventGroupBox.ForeColor = Color.White
        gotoEventGroupBox.Location = New Point(125, 60)
        gotoEventGroupBox.Name = "gotoEventGroupBox"
        gotoEventGroupBox.RightToLeft = RightToLeft.No
        gotoEventGroupBox.Size = New Size(400, 280)
        gotoEventGroupBox.TabIndex = 15
        gotoEventGroupBox.TabStop = False
        gotoEventGroupBox.Text = "Go To Event"
        gotoEventGroupBox.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 20)
        Label4.TabIndex = 16
        Label4.Text = "Name of Topic to go to:"
        ' 
        ' gotoEventTextbox
        ' 
        gotoEventTextbox.Location = New Point(7, 91)
        gotoEventTextbox.Name = "gotoEventTextbox"
        gotoEventTextbox.Size = New Size(386, 27)
        gotoEventTextbox.TabIndex = 15
        gotoEventTextbox.Text = "SomeOtherEventNameHere"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(7, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(386, 72)
        Label3.TabIndex = 14
        Label3.Text = "This function goes to the Topic you enter in the box. You generally don't want to put anything after this event, because anything below it is ignored anyway."
        ' 
        ' finishGotoEventButton
        ' 
        finishGotoEventButton.ForeColor = SystemColors.ControlText
        finishGotoEventButton.Location = New Point(291, 25)
        finishGotoEventButton.Name = "finishGotoEventButton"
        finishGotoEventButton.Size = New Size(102, 30)
        finishGotoEventButton.TabIndex = 13
        finishGotoEventButton.Text = "Finish"
        finishGotoEventButton.UseVisualStyleBackColor = True
        ' 
        ' createEventGroupBox
        ' 
        createEventGroupBox.BackColor = SystemColors.ActiveCaptionText
        createEventGroupBox.Controls.Add(Label5)
        createEventGroupBox.Controls.Add(newEventNameBox)
        createEventGroupBox.Controls.Add(Label6)
        createEventGroupBox.Controls.Add(newEventCreateButton)
        createEventGroupBox.ForeColor = Color.White
        createEventGroupBox.Location = New Point(125, 60)
        createEventGroupBox.Name = "createEventGroupBox"
        createEventGroupBox.RightToLeft = RightToLeft.No
        createEventGroupBox.Size = New Size(400, 280)
        createEventGroupBox.TabIndex = 17
        createEventGroupBox.TabStop = False
        createEventGroupBox.Text = "Create New Event"
        createEventGroupBox.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 20)
        Label5.TabIndex = 16
        Label5.Text = "Name of the new Event:"
        ' 
        ' newEventNameBox
        ' 
        newEventNameBox.Location = New Point(7, 91)
        newEventNameBox.Name = "newEventNameBox"
        newEventNameBox.Size = New Size(386, 27)
        newEventNameBox.TabIndex = 15
        newEventNameBox.Text = "SomeTown_npcName_desc"
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(7, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(386, 72)
        Label6.TabIndex = 14
        Label6.Text = "This function goes to the Topic you enter in the box."
        ' 
        ' newEventCreateButton
        ' 
        newEventCreateButton.ForeColor = SystemColors.ControlText
        newEventCreateButton.Location = New Point(283, 53)
        newEventCreateButton.Name = "newEventCreateButton"
        newEventCreateButton.Size = New Size(102, 30)
        newEventCreateButton.TabIndex = 13
        newEventCreateButton.Text = "Create"
        newEventCreateButton.UseVisualStyleBackColor = True
        ' 
        ' setQuestStageGroupBox
        ' 
        setQuestStageGroupBox.BackColor = SystemColors.ActiveCaptionText
        setQuestStageGroupBox.Controls.Add(Button2)
        setQuestStageGroupBox.Controls.Add(setQuestStageVarBox)
        setQuestStageGroupBox.Controls.Add(Label13)
        setQuestStageGroupBox.Controls.Add(setQuestStageTextbox)
        setQuestStageGroupBox.Controls.Add(Label11)
        setQuestStageGroupBox.Controls.Add(Button1)
        setQuestStageGroupBox.Controls.Add(Label12)
        setQuestStageGroupBox.ForeColor = Color.White
        setQuestStageGroupBox.Location = New Point(125, 60)
        setQuestStageGroupBox.Name = "setQuestStageGroupBox"
        setQuestStageGroupBox.Size = New Size(400, 290)
        setQuestStageGroupBox.TabIndex = 17
        setQuestStageGroupBox.TabStop = False
        setQuestStageGroupBox.Text = "Set Quest Stage"
        setQuestStageGroupBox.Visible = False
        ' 
        ' Button2
        ' 
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(11, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 30)
        Button2.TabIndex = 20
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' setQuestStageVarBox
        ' 
        setQuestStageVarBox.Location = New Point(235, 124)
        setQuestStageVarBox.Mask = "000000000"
        setQuestStageVarBox.Name = "setQuestStageVarBox"
        setQuestStageVarBox.Size = New Size(100, 27)
        setQuestStageVarBox.TabIndex = 19
        setQuestStageVarBox.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(37, 94)
        Label13.Name = "Label13"
        Label13.Size = New Size(152, 20)
        Label13.TabIndex = 18
        Label13.Text = "Quest Variable Name:"
        ' 
        ' setQuestStageTextbox
        ' 
        setQuestStageTextbox.Location = New Point(60, 121)
        setQuestStageTextbox.Name = "setQuestStageTextbox"
        setQuestStageTextbox.Size = New Size(100, 27)
        setQuestStageTextbox.TabIndex = 17
        setQuestStageTextbox.Text = "introQuestVar"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(238, 98)
        Label11.Name = "Label11"
        Label11.Size = New Size(93, 20)
        Label11.TabIndex = 16
        Label11.Text = "Stage to Set:"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(291, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 30)
        Button1.TabIndex = 13
        Button1.Text = "Finish"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.Location = New Point(7, 173)
        Label12.Name = "Label12"
        Label12.Size = New Size(386, 114)
        Label12.TabIndex = 14
        Label12.Text = resources.GetString("Label12.Text")
        ' 
        ' finishEventButton
        ' 
        finishEventButton.ForeColor = SystemColors.ActiveCaptionText
        finishEventButton.Location = New Point(12, 386)
        finishEventButton.Name = "finishEventButton"
        finishEventButton.Size = New Size(200, 31)
        finishEventButton.TabIndex = 11
        finishEventButton.Text = "Finish Topic"
        finishEventButton.UseVisualStyleBackColor = True
        finishEventButton.Visible = False
        ' 
        ' eventButtonsGroupBox
        ' 
        eventButtonsGroupBox.Controls.Add(Button17)
        eventButtonsGroupBox.Controls.Add(Button14)
        eventButtonsGroupBox.Controls.Add(Button11)
        eventButtonsGroupBox.Controls.Add(Button10)
        eventButtonsGroupBox.Controls.Add(Button7)
        eventButtonsGroupBox.Controls.Add(SetQuestStageButton)
        eventButtonsGroupBox.Controls.Add(gotoEventIfButton)
        eventButtonsGroupBox.Controls.Add(movementButton)
        eventButtonsGroupBox.Controls.Add(gotoEventButton)
        eventButtonsGroupBox.Controls.Add(messageButton)
        eventButtonsGroupBox.ForeColor = SystemColors.Control
        eventButtonsGroupBox.Location = New Point(12, 46)
        eventButtonsGroupBox.Name = "eventButtonsGroupBox"
        eventButtonsGroupBox.Size = New Size(248, 334)
        eventButtonsGroupBox.TabIndex = 12
        eventButtonsGroupBox.TabStop = False
        eventButtonsGroupBox.Text = "Events"
        eventButtonsGroupBox.Visible = False
        ' 
        ' Button17
        ' 
        Button17.ForeColor = SystemColors.ActiveCaptionText
        Button17.Location = New Point(153, 159)
        Button17.Name = "Button17"
        Button17.Size = New Size(89, 33)
        Button17.TabIndex = 21
        Button17.Text = "Check Flag"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.ForeColor = SystemColors.ActiveCaptionText
        Button14.Location = New Point(161, 124)
        Button14.Name = "Button14"
        Button14.Size = New Size(81, 33)
        Button14.TabIndex = 20
        Button14.Text = "Set Flag"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.ForeColor = SystemColors.ControlText
        Button11.Location = New Point(6, 55)
        Button11.Name = "Button11"
        Button11.Size = New Size(101, 30)
        Button11.TabIndex = 19
        Button11.Text = "Turn Object"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.ForeColor = SystemColors.ControlText
        Button10.Location = New Point(167, 91)
        Button10.Name = "Button10"
        Button10.Size = New Size(75, 30)
        Button10.TabIndex = 18
        Button10.Text = "Release"
        ToolTip1.SetToolTip(Button10, "Unlocks all objects frozen in place with Lock.")
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.ForeColor = SystemColors.ControlText
        Button7.Location = New Point(167, 19)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 30)
        Button7.TabIndex = 17
        Button7.Text = "Lock"
        ToolTip1.SetToolTip(Button7, resources.GetString("Button7.ToolTip"))
        Button7.UseVisualStyleBackColor = True
        ' 
        ' SetQuestStageButton
        ' 
        SetQuestStageButton.ForeColor = SystemColors.ControlText
        SetQuestStageButton.Location = New Point(3, 163)
        SetQuestStageButton.Name = "SetQuestStageButton"
        SetQuestStageButton.Size = New Size(128, 30)
        SetQuestStageButton.TabIndex = 13
        SetQuestStageButton.Text = "Set Quest Stage"
        SetQuestStageButton.UseVisualStyleBackColor = True
        ' 
        ' gotoEventIfButton
        ' 
        gotoEventIfButton.ForeColor = SystemColors.ControlText
        gotoEventIfButton.Location = New Point(6, 127)
        gotoEventIfButton.Name = "gotoEventIfButton"
        gotoEventIfButton.Size = New Size(111, 30)
        gotoEventIfButton.TabIndex = 16
        gotoEventIfButton.Text = "Go to Event If"
        gotoEventIfButton.UseVisualStyleBackColor = True
        ' 
        ' movementButton
        ' 
        movementButton.ForeColor = SystemColors.ControlText
        movementButton.Location = New Point(6, 19)
        movementButton.Name = "movementButton"
        movementButton.Size = New Size(90, 30)
        movementButton.TabIndex = 12
        movementButton.Text = "Movement"
        movementButton.UseVisualStyleBackColor = True
        ' 
        ' gotoEventButton
        ' 
        gotoEventButton.ForeColor = SystemColors.ControlText
        gotoEventButton.Location = New Point(6, 91)
        gotoEventButton.Name = "gotoEventButton"
        gotoEventButton.Size = New Size(95, 30)
        gotoEventButton.TabIndex = 15
        gotoEventButton.Text = "Go to event"
        gotoEventButton.UseVisualStyleBackColor = True
        ' 
        ' messageButton
        ' 
        messageButton.ForeColor = SystemColors.ControlText
        messageButton.Location = New Point(167, 55)
        messageButton.Name = "messageButton"
        messageButton.Size = New Size(75, 30)
        messageButton.TabIndex = 11
        messageButton.Text = "Message"
        messageButton.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Tutorial"
        ' 
        ' copyToClipboardButton
        ' 
        copyToClipboardButton.ForeColor = SystemColors.ActiveCaptionText
        copyToClipboardButton.Location = New Point(6, 26)
        copyToClipboardButton.Name = "copyToClipboardButton"
        copyToClipboardButton.Size = New Size(188, 31)
        copyToClipboardButton.TabIndex = 14
        copyToClipboardButton.Text = "Copy to Clipboard"
        ToolTip1.SetToolTip(copyToClipboardButton, "Copies the whole Topic to your clipboard so it can be pasted somewhere.")
        copyToClipboardButton.UseVisualStyleBackColor = True
        ' 
        ' writeExitingTextButton
        ' 
        writeExitingTextButton.Enabled = False
        writeExitingTextButton.ForeColor = SystemColors.ActiveCaptionText
        writeExitingTextButton.Location = New Point(6, 63)
        writeExitingTextButton.Name = "writeExitingTextButton"
        writeExitingTextButton.Size = New Size(188, 31)
        writeExitingTextButton.TabIndex = 15
        writeExitingTextButton.Text = "Add to loaded file"
        ToolTip1.SetToolTip(writeExitingTextButton, "If you have a file loaded, this will append the created event to the end of the loaded file.")
        writeExitingTextButton.UseVisualStyleBackColor = True
        ' 
        ' startNewFileButton
        ' 
        startNewFileButton.ForeColor = SystemColors.ActiveCaptionText
        startNewFileButton.Location = New Point(6, 100)
        startNewFileButton.Name = "startNewFileButton"
        startNewFileButton.Size = New Size(188, 31)
        startNewFileButton.TabIndex = 16
        startNewFileButton.Text = "Start New File"
        ToolTip1.SetToolTip(startNewFileButton, "Start a new text file to export these Topics to.")
        startNewFileButton.UseVisualStyleBackColor = True
        ' 
        ' openFileButton
        ' 
        openFileButton.ForeColor = SystemColors.ActiveCaptionText
        openFileButton.Location = New Point(124, 9)
        openFileButton.Name = "openFileButton"
        openFileButton.Size = New Size(88, 31)
        openFileButton.TabIndex = 14
        openFileButton.Text = "Open File"
        ToolTip1.SetToolTip(openFileButton, "Open an existing topics.gml file.")
        openFileButton.UseVisualStyleBackColor = True
        ' 
        ' colorPickerBox
        ' 
        colorPickerBox.AnyColor = True
        ' 
        ' exportGroupBox
        ' 
        exportGroupBox.Controls.Add(startNewFileButton)
        exportGroupBox.Controls.Add(writeExitingTextButton)
        exportGroupBox.Controls.Add(copyToClipboardButton)
        exportGroupBox.ForeColor = Color.White
        exportGroupBox.Location = New Point(12, 423)
        exportGroupBox.Name = "exportGroupBox"
        exportGroupBox.Size = New Size(200, 147)
        exportGroupBox.TabIndex = 13
        exportGroupBox.TabStop = False
        exportGroupBox.Text = "Save/Export"
        exportGroupBox.Visible = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.CheckFileExists = False
        OpenFileDialog1.DefaultExt = "gml"
        OpenFileDialog1.FileName = "events"
        OpenFileDialog1.Filter = "Game Maker Language files|*.gml"
        OpenFileDialog1.InitialDirectory = "%USERPROFILE%"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.DefaultExt = "gml"
        SaveFileDialog1.FileName = "events"
        SaveFileDialog1.Filter = "Game Maker Language files|*.gml"
        SaveFileDialog1.InitialDirectory = "%USERPROFILE%"
        SaveFileDialog1.OkRequiresInteraction = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(900, 592)
        Controls.Add(openFileButton)
        Controls.Add(exportGroupBox)
        Controls.Add(eventButtonsGroupBox)
        Controls.Add(finishEventButton)
        Controls.Add(Panel1)
        Controls.Add(newEventStartButton)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlLight
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Ryu Script Language Event Editor"
        Panel1.ResumeLayout(False)
        checkFlagGroup.ResumeLayout(False)
        checkFlagGroup.PerformLayout()
        setflagGroup.ResumeLayout(False)
        setflagGroup.PerformLayout()
        msgGroupBox.ResumeLayout(False)
        msgGroupBox.PerformLayout()
        movementGroupBox.ResumeLayout(False)
        movementGroupBox.PerformLayout()
        turnObjectGroupBox.ResumeLayout(False)
        turnObjectGroupBox.PerformLayout()
        gotoEventIfGroupBox.ResumeLayout(False)
        gotoEventIfGroupBox.PerformLayout()
        changeEventBox.ResumeLayout(False)
        changeEventBox.PerformLayout()
        gotoEventGroupBox.ResumeLayout(False)
        gotoEventGroupBox.PerformLayout()
        createEventGroupBox.ResumeLayout(False)
        createEventGroupBox.PerformLayout()
        setQuestStageGroupBox.ResumeLayout(False)
        setQuestStageGroupBox.PerformLayout()
        eventButtonsGroupBox.ResumeLayout(False)
        exportGroupBox.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents newEventStartButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents eventOutputBox As ListBox
    Friend WithEvents msgGroupBox As GroupBox
    Friend WithEvents messageEntryBox As TextBox
    Friend WithEvents finishMessageEventButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents gotoEventGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gotoEventTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents finishGotoEventButton As Button
    Friend WithEvents createEventGroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents newEventNameBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents newEventCreateButton As Button
    Friend WithEvents finishEventButton As Button
    Friend WithEvents eventButtonsGroupBox As GroupBox
    Friend WithEvents SetQuestStageButton As Button
    Friend WithEvents gotoEventIfButton As Button
    Friend WithEvents movementButton As Button
    Friend WithEvents gotoEventButton As Button
    Friend WithEvents messageButton As Button
    Friend WithEvents gotoEventIfGroupBox As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gotoIfEventVarBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gotoIfEventBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents finishGotoIfEventButton As Button
    Friend WithEvents gotoIfEventValueBox As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents messageSpeakerNameBox As TextBox
    Friend WithEvents setQuestStageGroupBox As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents setQuestStageTextbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents setQuestStageVarBox As MaskedTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents movementGroupBox As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents movementSelectionBox As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents movementNPCIdBox As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents changeEventBox As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents modifyEventBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents modifyEventFinishButton As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents colorPickerBox As ColorDialog
    Friend WithEvents colorSelectionBox As ComboBox
    Friend WithEvents Button9 As Button
    Friend WithEvents exportGroupBox As GroupBox
    Friend WithEvents copyToClipboardButton As Button
    Friend WithEvents startNewFileButton As Button
    Friend WithEvents writeExitingTextButton As Button
    Friend WithEvents openFileButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button7 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents turnObjectGroupBox As GroupBox
    Friend WithEvents turnObjectIDEntry As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents turnObjectDirSelection As ComboBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents setflagGroup As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents setflagValues As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents setflaginput As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents checkFlagGroup As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents checkFlagFunction As TextBox
    Friend WithEvents checkFlagValues As ComboBox
    Friend WithEvents checkFlagInput As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button

End Class
