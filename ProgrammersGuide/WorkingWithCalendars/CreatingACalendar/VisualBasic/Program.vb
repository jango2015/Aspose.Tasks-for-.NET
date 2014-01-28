'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks

Namespace CreatingACalendar
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Create a project instance
			Dim prj As New Project()

			'Define Calendar
			Dim cal1 As New Aspose.Tasks.Calendar()
			cal1.Name = "no info"
			Dim cal2 As New Aspose.Tasks.Calendar(1)
			cal2.Name = "no name"
			Dim cal3 As New Aspose.Tasks.Calendar("cal3")
			prj.Calendars.Add(cal1)
			prj.Calendars.Add(cal2)
			prj.Calendars.Add(cal3)

			prj.CalcCalendarUids()

			'Save the Project
			prj.Save(dataDir & "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace