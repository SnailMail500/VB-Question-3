Imports System

Module Program
    Sub Main(args As String())
	    Dim a As Integer = 0
	    Dim c As Integer = 0
	    Dim d As Integer = 0
	    Dim s As Integer = 0
	    Dim t As Integer = 0
	    Dim N1 As Integer = 0
	    Dim N2 As Integer = 0
	    Dim random As Random = New Random
		While c < 3 And d < 3
			t = t + 1
			N1 = random.Next(1, 7)
			N2 = random.Next(1, 7)
			Console.WriteLine(N1 & N2)
		    s = s + N1 + N2
		    If N1 = 6 or N2 = 6 Then
			    c = c + 1
		    End If
		    If N1 = N2 Then
			    d = d + 1
		    End If
	    End While
	    a = s \ (T * 2)
	    Console.WriteLine(c & d & a)
    End Sub
End Module
