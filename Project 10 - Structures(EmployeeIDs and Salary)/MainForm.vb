Public Class MainForm

    '/*******************************
    ' 
    '  Program: Converting Distances
    '
    '  Author: Chris D.
    '  Description: Using structures and files to display data.
    ' 
    ' *****************************


    'declare structure
    Structure Employees
        'structure variables to use for each employee
        Public strId As String  ' Employee has an ID
        Public dblSalary As Double ' Employee has a salary
    End Structure

    ' declare array of structure variables - structure array variable is an object now
    Private employeeList(4) As Employees 'The items in the array are Employees 1 through 4. 
    ' EmployeeList is an object



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declarations
        Dim fileTxtString As String = String.Empty
        Dim i As Integer = 0

        'Declare object first
        Dim inputFile As IO.StreamReader ' taking a class and placing it as a variable/object


        ' Check so see file exists
        If IO.File.Exists("Employees.txt") Then
            ' Initialize object next
            inputFile = IO.File.OpenText("Employees.txt")

            'Read lines from text file until end of file or when the employeeList array is full
            Do Until inputFile.Peek = -1

                ' take that line from text file, and store in a variable 
                fileTxtString = inputFile.ReadLine

                ' move that variable into the employeelist array
                employeeList(i).strId = fileTxtString.Substring(0, 5) ' grab each character starting from 0 position and span to 5 characters from string variable

                ' grab salary from current line and store in array
                Double.TryParse(fileTxtString.Substring(6), employeeList(i).dblSalary) ' grab characters from position 6 to rest of string.

                'add the id from structure array to listbox
                listIds.Items.Add(employeeList(i).strId)

                'increment to next Employeelist item
                i += 1

            Loop

            'close file
            inputFile.Close()
        Else ' Doesn't exist
            MessageBox.Show("Can't find the file",
                            "Game Show Contestants",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub listIds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listIds.SelectedIndexChanged
        ' When any listbox items are selected, the output-label control for salary will grab 
        ' from the structure array - the "salary" stucture variable
        ' it does this by selecting the position of the array based on what the user clicked from
        ' the listbox control - top of listbox is index 0, bottom is index 4

        ' Once index is chosen, it picks the 'salary' variable and converts it to string in currency format

        outputSalary.Text = employeeList(listIds.SelectedIndex).dblSalary.ToString("c0")

    End Sub
End Class
