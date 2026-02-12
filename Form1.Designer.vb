<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        EmployeeInformationGroupBox = New GroupBox()
        PayRateLabel = New Label()
        HoursWorkedLabel = New Label()
        DepartmentLabel = New Label()
        EmployeeIDLabel = New Label()
        NameLabel = New Label()
        BenefitsGroupBox = New GroupBox()
        GroupBox3 = New GroupBox()
        ComputeButton = New Button()
        ResetButton = New Button()
        ExitButton = New Button()
        GrossPayLabel = New Label()
        FederalTaxLabel = New Label()
        BenefitsLabel = New Label()
        NetPayLabel = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        NoRetirementPlanRadioButton = New RadioButton()
        RetirementStandardRadioButton = New RadioButton()
        Retirement401ARadioButton = New RadioButton()
        MedicalInsureranceCheckBox = New CheckBox()
        LifeInsuranceCheckBox = New CheckBox()
        DentalInsuranceCheckBox = New CheckBox()
        EmployeeInformationGroupBox.SuspendLayout()
        BenefitsGroupBox.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' EmployeeInformationGroupBox
        ' 
        EmployeeInformationGroupBox.Controls.Add(TextBox5)
        EmployeeInformationGroupBox.Controls.Add(TextBox4)
        EmployeeInformationGroupBox.Controls.Add(TextBox3)
        EmployeeInformationGroupBox.Controls.Add(TextBox2)
        EmployeeInformationGroupBox.Controls.Add(TextBox1)
        EmployeeInformationGroupBox.Controls.Add(PayRateLabel)
        EmployeeInformationGroupBox.Controls.Add(HoursWorkedLabel)
        EmployeeInformationGroupBox.Controls.Add(DepartmentLabel)
        EmployeeInformationGroupBox.Controls.Add(EmployeeIDLabel)
        EmployeeInformationGroupBox.Controls.Add(NameLabel)
        EmployeeInformationGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmployeeInformationGroupBox.Location = New Point(39, 12)
        EmployeeInformationGroupBox.Name = "EmployeeInformationGroupBox"
        EmployeeInformationGroupBox.Size = New Size(905, 201)
        EmployeeInformationGroupBox.TabIndex = 0
        EmployeeInformationGroupBox.TabStop = False
        EmployeeInformationGroupBox.Text = "Employee Information"
        ' 
        ' PayRateLabel
        ' 
        PayRateLabel.AutoSize = True
        PayRateLabel.Location = New Point(412, 163)
        PayRateLabel.Name = "PayRateLabel"
        PayRateLabel.Size = New Size(68, 20)
        PayRateLabel.TabIndex = 4
        PayRateLabel.Text = "Pay Rate"
        ' 
        ' HoursWorkedLabel
        ' 
        HoursWorkedLabel.AutoSize = True
        HoursWorkedLabel.Location = New Point(412, 111)
        HoursWorkedLabel.Name = "HoursWorkedLabel"
        HoursWorkedLabel.Size = New Size(108, 20)
        HoursWorkedLabel.TabIndex = 3
        HoursWorkedLabel.Text = "Hours Worked"
        ' 
        ' DepartmentLabel
        ' 
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New Point(39, 164)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New Size(95, 20)
        DepartmentLabel.TabIndex = 2
        DepartmentLabel.Text = "Department:"
        ' 
        ' EmployeeIDLabel
        ' 
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New Point(39, 104)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New Size(95, 20)
        EmployeeIDLabel.TabIndex = 1
        EmployeeIDLabel.Text = "Employee ID"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(39, 42)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(54, 20)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        ' 
        ' BenefitsGroupBox
        ' 
        BenefitsGroupBox.Controls.Add(DentalInsuranceCheckBox)
        BenefitsGroupBox.Controls.Add(LifeInsuranceCheckBox)
        BenefitsGroupBox.Controls.Add(MedicalInsureranceCheckBox)
        BenefitsGroupBox.Controls.Add(Retirement401ARadioButton)
        BenefitsGroupBox.Controls.Add(RetirementStandardRadioButton)
        BenefitsGroupBox.Controls.Add(NoRetirementPlanRadioButton)
        BenefitsGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BenefitsGroupBox.Location = New Point(56, 230)
        BenefitsGroupBox.Name = "BenefitsGroupBox"
        BenefitsGroupBox.Size = New Size(279, 354)
        BenefitsGroupBox.TabIndex = 1
        BenefitsGroupBox.TabStop = False
        BenefitsGroupBox.Text = "Benefits"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox9)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Controls.Add(TextBox7)
        GroupBox3.Controls.Add(TextBox6)
        GroupBox3.Controls.Add(NetPayLabel)
        GroupBox3.Controls.Add(GrossPayLabel)
        GroupBox3.Controls.Add(BenefitsLabel)
        GroupBox3.Controls.Add(FederalTaxLabel)
        GroupBox3.Location = New Point(374, 230)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(375, 241)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComputeButton.Location = New Point(389, 539)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(115, 45)
        ComputeButton.TabIndex = 3
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetButton.Location = New Point(523, 539)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(103, 45)
        ResetButton.TabIndex = 4
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(653, 539)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(134, 45)
        ExitButton.TabIndex = 5
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' GrossPayLabel
        ' 
        GrossPayLabel.AutoSize = True
        GrossPayLabel.Location = New Point(45, 39)
        GrossPayLabel.Name = "GrossPayLabel"
        GrossPayLabel.Size = New Size(71, 20)
        GrossPayLabel.TabIndex = 5
        GrossPayLabel.Text = "Gross Pay"
        ' 
        ' FederalTaxLabel
        ' 
        FederalTaxLabel.AutoSize = True
        FederalTaxLabel.Location = New Point(45, 94)
        FederalTaxLabel.Name = "FederalTaxLabel"
        FederalTaxLabel.Size = New Size(83, 20)
        FederalTaxLabel.TabIndex = 6
        FederalTaxLabel.Text = "Federal Tax"
        ' 
        ' BenefitsLabel
        ' 
        BenefitsLabel.AutoSize = True
        BenefitsLabel.Location = New Point(45, 147)
        BenefitsLabel.Name = "BenefitsLabel"
        BenefitsLabel.Size = New Size(62, 20)
        BenefitsLabel.TabIndex = 7
        BenefitsLabel.Text = "Benefits"
        ' 
        ' NetPayLabel
        ' 
        NetPayLabel.AutoSize = True
        NetPayLabel.Location = New Point(45, 196)
        NetPayLabel.Name = "NetPayLabel"
        NetPayLabel.Size = New Size(59, 20)
        NetPayLabel.TabIndex = 8
        NetPayLabel.Text = "Net Pay"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(171, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(400, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(171, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(171, 163)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(519, 104)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(519, 156)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(184, 39)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 9
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(184, 87)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 10
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(184, 147)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(125, 27)
        TextBox8.TabIndex = 11
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(184, 196)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(125, 27)
        TextBox9.TabIndex = 12
        ' 
        ' NoRetirementPlanRadioButton
        ' 
        NoRetirementPlanRadioButton.AutoSize = True
        NoRetirementPlanRadioButton.Location = New Point(58, 58)
        NoRetirementPlanRadioButton.Name = "NoRetirementPlanRadioButton"
        NoRetirementPlanRadioButton.Size = New Size(164, 24)
        NoRetirementPlanRadioButton.TabIndex = 0
        NoRetirementPlanRadioButton.TabStop = True
        NoRetirementPlanRadioButton.Text = "No Retirement Plan"
        NoRetirementPlanRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RetirementStandardRadioButton
        ' 
        RetirementStandardRadioButton.AutoSize = True
        RetirementStandardRadioButton.Location = New Point(58, 107)
        RetirementStandardRadioButton.Name = "RetirementStandardRadioButton"
        RetirementStandardRadioButton.Size = New Size(181, 24)
        RetirementStandardRadioButton.TabIndex = 1
        RetirementStandardRadioButton.TabStop = True
        RetirementStandardRadioButton.Text = "Retirement - Standard"
        RetirementStandardRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Retirement401ARadioButton
        ' 
        Retirement401ARadioButton.AutoSize = True
        Retirement401ARadioButton.Location = New Point(58, 162)
        Retirement401ARadioButton.Name = "Retirement401ARadioButton"
        Retirement401ARadioButton.Size = New Size(123, 24)
        Retirement401ARadioButton.TabIndex = 2
        Retirement401ARadioButton.TabStop = True
        Retirement401ARadioButton.Text = "RadioButton3"
        Retirement401ARadioButton.UseVisualStyleBackColor = True
        ' 
        ' MedicalInsureranceCheckBox
        ' 
        MedicalInsureranceCheckBox.AutoSize = True
        MedicalInsureranceCheckBox.Location = New Point(58, 228)
        MedicalInsureranceCheckBox.Name = "MedicalInsureranceCheckBox"
        MedicalInsureranceCheckBox.Size = New Size(155, 24)
        MedicalInsureranceCheckBox.TabIndex = 3
        MedicalInsureranceCheckBox.Text = "Medical Insurance"
        MedicalInsureranceCheckBox.UseVisualStyleBackColor = True
        ' 
        ' LifeInsuranceCheckBox
        ' 
        LifeInsuranceCheckBox.AutoSize = True
        LifeInsuranceCheckBox.Location = New Point(58, 273)
        LifeInsuranceCheckBox.Name = "LifeInsuranceCheckBox"
        LifeInsuranceCheckBox.Size = New Size(125, 24)
        LifeInsuranceCheckBox.TabIndex = 4
        LifeInsuranceCheckBox.Text = "Life Insurance"
        LifeInsuranceCheckBox.UseVisualStyleBackColor = True
        ' 
        ' DentalInsuranceCheckBox
        ' 
        DentalInsuranceCheckBox.AutoSize = True
        DentalInsuranceCheckBox.Location = New Point(58, 320)
        DentalInsuranceCheckBox.Name = "DentalInsuranceCheckBox"
        DentalInsuranceCheckBox.Size = New Size(146, 24)
        DentalInsuranceCheckBox.TabIndex = 5
        DentalInsuranceCheckBox.Text = "Dental Insurance"
        DentalInsuranceCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 657)
        Controls.Add(ExitButton)
        Controls.Add(ResetButton)
        Controls.Add(ComputeButton)
        Controls.Add(GroupBox3)
        Controls.Add(BenefitsGroupBox)
        Controls.Add(EmployeeInformationGroupBox)
        Name = "Form1"
        Text = "Form1"
        EmployeeInformationGroupBox.ResumeLayout(False)
        EmployeeInformationGroupBox.PerformLayout()
        BenefitsGroupBox.ResumeLayout(False)
        BenefitsGroupBox.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeeInformationGroupBox As GroupBox
    Friend WithEvents BenefitsGroupBox As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents EmployeeIDLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PayRateLabel As Label
    Friend WithEvents HoursWorkedLabel As Label
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents NetPayLabel As Label
    Friend WithEvents GrossPayLabel As Label
    Friend WithEvents BenefitsLabel As Label
    Friend WithEvents FederalTaxLabel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DentalInsuranceCheckBox As CheckBox
    Friend WithEvents LifeInsuranceCheckBox As CheckBox
    Friend WithEvents MedicalInsureranceCheckBox As CheckBox
    Friend WithEvents Retirement401ARadioButton As RadioButton
    Friend WithEvents RetirementStandardRadioButton As RadioButton
    Friend WithEvents NoRetirementPlanRadioButton As RadioButton
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox

End Class
