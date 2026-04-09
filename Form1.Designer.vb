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
        MaskedTextBox1 = New MaskedTextBox()
        PayRateTextBox = New TextBox()
        HoursWorkedTextBox = New TextBox()
        TextBox3 = New TextBox()
        NameTextBox = New TextBox()
        PayRateLabel = New Label()
        HoursWorkedLabel = New Label()
        DepartmentLabel = New Label()
        EmployeeIDLabel = New Label()
        NameLabel = New Label()
        BenefitsGroupBox = New GroupBox()
        DentalInsuranceCheckBox = New CheckBox()
        LifeInsuranceCheckBox = New CheckBox()
        MedicalInsureranceCheckBox = New CheckBox()
        Retirement401ARadioButton = New RadioButton()
        RetirementStandardRadioButton = New RadioButton()
        NoRetirementPlanRadioButton = New RadioButton()
        PayrollGroupBox = New GroupBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        FederalTaxTextBox = New TextBox()
        GrossPayTextBox = New TextBox()
        NetPayLabel = New Label()
        GrossPayLabel = New Label()
        BenefitsLabel = New Label()
        FederalTaxLabel = New Label()
        ComputeButton = New Button()
        ResetButton = New Button()
        ExitButton = New Button()
        EmployeeInformationGroupBox.SuspendLayout()
        BenefitsGroupBox.SuspendLayout()
        PayrollGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' EmployeeInformationGroupBox
        ' 
        EmployeeInformationGroupBox.BackColor = Color.SandyBrown
        EmployeeInformationGroupBox.Controls.Add(MaskedTextBox1)
        EmployeeInformationGroupBox.Controls.Add(PayRateTextBox)
        EmployeeInformationGroupBox.Controls.Add(HoursWorkedTextBox)
        EmployeeInformationGroupBox.Controls.Add(TextBox3)
        EmployeeInformationGroupBox.Controls.Add(NameTextBox)
        EmployeeInformationGroupBox.Controls.Add(PayRateLabel)
        EmployeeInformationGroupBox.Controls.Add(HoursWorkedLabel)
        EmployeeInformationGroupBox.Controls.Add(DepartmentLabel)
        EmployeeInformationGroupBox.Controls.Add(EmployeeIDLabel)
        EmployeeInformationGroupBox.Controls.Add(NameLabel)
        EmployeeInformationGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmployeeInformationGroupBox.Location = New Point(39, 13)
        EmployeeInformationGroupBox.Name = "EmployeeInformationGroupBox"
        EmployeeInformationGroupBox.Size = New Size(905, 201)
        EmployeeInformationGroupBox.TabIndex = 0
        EmployeeInformationGroupBox.TabStop = False
        EmployeeInformationGroupBox.Text = "Employee Information"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(171, 104)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(125, 27)
        MaskedTextBox1.TabIndex = 10
        ' 
        ' PayRateTextBox
        ' 
        PayRateTextBox.Location = New Point(519, 156)
        PayRateTextBox.Name = "PayRateTextBox"
        PayRateTextBox.Size = New Size(125, 27)
        PayRateTextBox.TabIndex = 9
        ' 
        ' HoursWorkedTextBox
        ' 
        HoursWorkedTextBox.Location = New Point(519, 104)
        HoursWorkedTextBox.Name = "HoursWorkedTextBox"
        HoursWorkedTextBox.Size = New Size(125, 27)
        HoursWorkedTextBox.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(171, 163)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 7
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(171, 42)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(400, 27)
        NameTextBox.TabIndex = 5
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
        BenefitsGroupBox.BackColor = Color.SandyBrown
        BenefitsGroupBox.Controls.Add(DentalInsuranceCheckBox)
        BenefitsGroupBox.Controls.Add(LifeInsuranceCheckBox)
        BenefitsGroupBox.Controls.Add(MedicalInsureranceCheckBox)
        BenefitsGroupBox.Controls.Add(Retirement401ARadioButton)
        BenefitsGroupBox.Controls.Add(RetirementStandardRadioButton)
        BenefitsGroupBox.Controls.Add(NoRetirementPlanRadioButton)
        BenefitsGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BenefitsGroupBox.Location = New Point(39, 230)
        BenefitsGroupBox.Name = "BenefitsGroupBox"
        BenefitsGroupBox.Size = New Size(314, 354)
        BenefitsGroupBox.TabIndex = 1
        BenefitsGroupBox.TabStop = False
        BenefitsGroupBox.Text = "Benefits"
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
        ' Retirement401ARadioButton
        ' 
        Retirement401ARadioButton.AutoSize = True
        Retirement401ARadioButton.Location = New Point(58, 163)
        Retirement401ARadioButton.Name = "Retirement401ARadioButton"
        Retirement401ARadioButton.Size = New Size(152, 24)
        Retirement401ARadioButton.TabIndex = 2
        Retirement401ARadioButton.TabStop = True
        Retirement401ARadioButton.Text = "Retirement - 401A"
        Retirement401ARadioButton.UseVisualStyleBackColor = True
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
        ' PayrollGroupBox
        ' 
        PayrollGroupBox.BackColor = Color.SandyBrown
        PayrollGroupBox.Controls.Add(TextBox9)
        PayrollGroupBox.Controls.Add(TextBox8)
        PayrollGroupBox.Controls.Add(FederalTaxTextBox)
        PayrollGroupBox.Controls.Add(GrossPayTextBox)
        PayrollGroupBox.Controls.Add(NetPayLabel)
        PayrollGroupBox.Controls.Add(GrossPayLabel)
        PayrollGroupBox.Controls.Add(BenefitsLabel)
        PayrollGroupBox.Controls.Add(FederalTaxLabel)
        PayrollGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PayrollGroupBox.Location = New Point(372, 230)
        PayrollGroupBox.Name = "PayrollGroupBox"
        PayrollGroupBox.Size = New Size(377, 270)
        PayrollGroupBox.TabIndex = 2
        PayrollGroupBox.TabStop = False
        PayrollGroupBox.Text = "Payroll Information"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(184, 196)
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(125, 27)
        TextBox9.TabIndex = 12
        TextBox9.TabStop = False
        TextBox9.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(184, 147)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(125, 27)
        TextBox8.TabIndex = 11
        TextBox8.TabStop = False
        TextBox8.TextAlign = HorizontalAlignment.Right
        ' 
        ' FederalTaxTextBox
        ' 
        FederalTaxTextBox.Location = New Point(184, 87)
        FederalTaxTextBox.Name = "FederalTaxTextBox"
        FederalTaxTextBox.ReadOnly = True
        FederalTaxTextBox.Size = New Size(125, 27)
        FederalTaxTextBox.TabIndex = 10
        FederalTaxTextBox.TabStop = False
        FederalTaxTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' GrossPayTextBox
        ' 
        GrossPayTextBox.Location = New Point(184, 39)
        GrossPayTextBox.Name = "GrossPayTextBox"
        GrossPayTextBox.ReadOnly = True
        GrossPayTextBox.Size = New Size(125, 27)
        GrossPayTextBox.TabIndex = 9
        GrossPayTextBox.TabStop = False
        GrossPayTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' NetPayLabel
        ' 
        NetPayLabel.AutoSize = True
        NetPayLabel.Location = New Point(45, 196)
        NetPayLabel.Name = "NetPayLabel"
        NetPayLabel.Size = New Size(63, 20)
        NetPayLabel.TabIndex = 8
        NetPayLabel.Text = "Net Pay"
        ' 
        ' GrossPayLabel
        ' 
        GrossPayLabel.AutoSize = True
        GrossPayLabel.Location = New Point(45, 39)
        GrossPayLabel.Name = "GrossPayLabel"
        GrossPayLabel.Size = New Size(75, 20)
        GrossPayLabel.TabIndex = 5
        GrossPayLabel.Text = "Gross Pay"
        ' 
        ' BenefitsLabel
        ' 
        BenefitsLabel.AutoSize = True
        BenefitsLabel.Location = New Point(45, 147)
        BenefitsLabel.Name = "BenefitsLabel"
        BenefitsLabel.Size = New Size(63, 20)
        BenefitsLabel.TabIndex = 7
        BenefitsLabel.Text = "Benefits"
        ' 
        ' FederalTaxLabel
        ' 
        FederalTaxLabel.AutoSize = True
        FederalTaxLabel.Location = New Point(45, 94)
        FederalTaxLabel.Name = "FederalTaxLabel"
        FederalTaxLabel.Size = New Size(87, 20)
        FederalTaxLabel.TabIndex = 6
        FederalTaxLabel.Text = "Federal Tax"
        ' 
        ' ComputeButton
        ' 
        ComputeButton.BackColor = Color.SandyBrown
        ComputeButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComputeButton.Location = New Point(389, 539)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(115, 45)
        ComputeButton.TabIndex = 3
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = False
        ' 
        ' ResetButton
        ' 
        ResetButton.BackColor = Color.SandyBrown
        ResetButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetButton.Location = New Point(523, 539)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(103, 45)
        ResetButton.TabIndex = 4
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.SandyBrown
        ExitButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(653, 539)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(134, 45)
        ExitButton.TabIndex = 5
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(1014, 657)
        Controls.Add(ExitButton)
        Controls.Add(ResetButton)
        Controls.Add(ComputeButton)
        Controls.Add(PayrollGroupBox)
        Controls.Add(BenefitsGroupBox)
        Controls.Add(EmployeeInformationGroupBox)
        Name = "Form1"
        Text = "Form1"
        EmployeeInformationGroupBox.ResumeLayout(False)
        EmployeeInformationGroupBox.PerformLayout()
        BenefitsGroupBox.ResumeLayout(False)
        BenefitsGroupBox.PerformLayout()
        PayrollGroupBox.ResumeLayout(False)
        PayrollGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeeInformationGroupBox As GroupBox
    Friend WithEvents BenefitsGroupBox As GroupBox
    Friend WithEvents PayrollGroupBox As GroupBox
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
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PayRateTextBox As TextBox
    Friend WithEvents HoursWorkedTextBox As TextBox
    Friend WithEvents DentalInsuranceCheckBox As CheckBox
    Friend WithEvents LifeInsuranceCheckBox As CheckBox
    Friend WithEvents MedicalInsureranceCheckBox As CheckBox
    Friend WithEvents Retirement401ARadioButton As RadioButton
    Friend WithEvents RetirementStandardRadioButton As RadioButton
    Friend WithEvents NoRetirementPlanRadioButton As RadioButton
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents FederalTaxTextBox As TextBox
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox

End Class
