Imports System
Imports System.DirectoryServices
Imports System.ServiceModel

''' <summary>
''' CADS WCF Client
''' </summary>
''' <remarks>V1.0 D. Robinson</remarks>
''' 
Public Class WCF
    Implements iCADSComms

    Public Function Authenticate(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal EncryptedPassword As String, ByVal Result As String) As Integer Implements iCADSComms.Authenticate

    End Function

    Public Function CheckLicense(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Computername As String, ByVal Result As Boolean) As Integer Implements iCADSComms.CheckLicense

    End Function

    Public Function GetLicense(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Computername As String) As Integer Implements iCADSComms.GetLicense

    End Function

    Public Function GetOUCount(ByVal Server As String, ByVal Port As Short, ByVal Scope As System.DirectoryServices.SearchScope, ByVal OUPath As String, ByVal Count As Integer) As Integer Implements iCADSComms.GetOUCount

    End Function

    Public Function GetOUList(ByVal Server As String, ByVal Port As Short, ByVal Scope As System.DirectoryServices.SearchScope, ByVal OUPath As String, ByVal OUList As String) As Integer Implements iCADSComms.GetOUList

    End Function

    Public Function GetUserCount(ByVal Server As String, ByVal Port As Short, ByVal Scope As System.DirectoryServices.SearchScope, ByVal OUPath As String, ByVal Count As Integer) As Integer Implements iCADSComms.GetUserCount

    End Function

    Public Function GetUserList(ByVal Server As String, ByVal Port As Short, ByVal Scope As System.DirectoryServices.SearchScope, ByVal OUPath As String, ByVal UserList As String) As Integer Implements iCADSComms.GetUserList

    End Function

    Public Function ReadConfig(ByVal Server As String, ByVal Port As Short, ByVal Setting As String, ByVal Value As String) As Integer Implements iCADSComms.ReadConfig

    End Function

    Public Function ReadMessage(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Messagename As String, ByVal Message As String) As Integer Implements iCADSComms.ReadMessage

    End Function

    Public Function ReadProcedure(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Procedurename As String, ByVal Procedure As String) As Integer Implements iCADSComms.ReadProcedure

    End Function

    Public Function ReleaseLicense(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Computername As String) As Integer Implements iCADSComms.ReleaseLicense

    End Function

    Public Function WriteConfig(ByVal Server As String, ByVal Port As Short, ByVal Setting As String, ByVal Value As String) As Integer Implements iCADSComms.WriteConfig

    End Function

    Public Function WriteMessage(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Messagename As String, ByVal Message As String) As Integer Implements iCADSComms.WriteMessage

    End Function

    Public Function WriteProcedure(ByVal Server As String, ByVal Port As Short, ByVal Username As String, ByVal Procedurename As String, ByVal Procedure As String) As Integer Implements iCADSComms.WriteProcedure

    End Function
End Class
