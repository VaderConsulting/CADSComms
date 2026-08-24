Imports System
Imports System.DirectoryServices
Imports System.ServiceModel

<ServiceContract()> _
Public Interface iCADSComms

    ''' <summary>
    ''' Reads the specified configuration setting.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Setting">The setting to read.</param>
    ''' <param name="Value">The value found.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function ReadConfig(ByVal Server As String, ByVal Port As Int16, ByVal Setting As String, ByVal Value As String) As Int32
    ''' <summary>
    ''' Writes the specified configuration setting.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Setting">The name of the setting.</param>
    ''' <param name="Value">The value to write.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function WriteConfig(ByVal Server As String, ByVal Port As Int16, ByVal Setting As String, ByVal Value As String) As Int32
    ''' <summary>
    ''' Reads the specified message.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the user that has the message.</param>
    ''' <param name="Messagename">The name of the message.</param>
    ''' <param name="Message">The message found.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function ReadMessage(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Messagename As String, ByVal Message As String) As Int32
    ''' <summary>
    ''' Writes the specified message.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="Messagename">The name of the message</param>
    ''' <param name="Message">The message to write</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function WriteMessage(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Messagename As String, ByVal Message As String) As Int32
    ''' <summary>
    ''' Reads the specified procedure.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="Procedurename">The name of the procedure.</param>
    ''' <param name="Procedure">The text of the procedure.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function ReadProcedure(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Procedurename As String, ByVal Procedure As String) As Int32
    ''' <summary>
    ''' Writes the specified procedure.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="Procedurename">The name of the procedure.</param>
    ''' <param name="Procedure">The procedure to write.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function WriteProcedure(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Procedurename As String, ByVal Procedure As String) As Int32
    ''' <summary>
    ''' Authenticates to the Server.  Must be performed very early in the WCF conversation.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="EncryptedPassword">The encrypted password of the person making the call.</param>
    ''' <param name="Result">The result of the authentication attempt.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function Authenticate(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal EncryptedPassword As String, ByVal Result As String) As Int32
    ''' <summary>
    ''' Checks if a valid license exists for this user or computer
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="Computername">The computername that the console is running on.</param>
    ''' <param name="Result">The result of the license check.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function CheckLicense(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Computername As String, ByVal Result As Boolean) As Int32
    ''' <summary>
    ''' Assigns a license to this User\Computer
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="Computername">The computername that the console is running on.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function GetLicense(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Computername As String) As Int32
    ''' <summary>
    ''' Releases the license held by the user\computer.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Username">The Username of the person making the call.</param>
    ''' <param name="Computername">The computername that the console is running on.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function ReleaseLicense(ByVal Server As String, ByVal Port As Int16, ByVal Username As String, ByVal Computername As String) As Int32
    ''' <summary>
    ''' Gets the count of OU's within the scope of the enumeration.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Scope">The scope of the enumeration.</param>
    ''' <param name="OUPath">The path of the OU that is the Search Root.</param>
    ''' <param name="Count">The count of OU's found within the search scope.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function GetOUCount(ByVal Server As String, ByVal Port As Int16, ByVal Scope As DirectoryServices.SearchScope, ByVal OUPath As String, ByVal Count As Int32) As Int32
    ''' <summary>
    ''' Gets the count of users within the scope of the enumeration.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param><param name="Port">The port to connect to.</param>
    ''' <param name="Scope">The scope of the enumeration.</param>
    ''' <param name="OUPath">The path of the OU that is the Search Root.</param>
    ''' <param name="Count">The number of users found within the search scope.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function GetUserCount(ByVal Server As String, ByVal Port As Int16, ByVal Scope As DirectoryServices.SearchScope, ByVal OUPath As String, ByVal Count As Int32) As Int32
    ''' <summary>
    ''' Gets the list of OU's within the scope of the enumeration.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Scope">The scope of the enumeration.</param>
    ''' <param name="OUPath">The path of the OU that is the Search Root.</param>
    ''' <param name="OUList">The list of OU's found within the search scope.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function GetOUList(ByVal Server As String, ByVal Port As Int16, ByVal Scope As DirectoryServices.SearchScope, ByVal OUPath As String, ByVal OUList As String) As Int32
    ''' <summary>
    ''' Gets the list of users within the scope of the enumeration.
    ''' </summary>
    ''' <param name="Server">The name of the Server to connect to.</param>
    ''' <param name="Port">The port to connect to.</param>
    ''' <param name="Scope">The scope of the enumeration.</param>
    ''' <param name="OUPath">The path of the OU that is the Search Root.</param>
    ''' <param name="UserList">A list of users found within the search scope.</param>
    ''' <returns>INT32 (CADS_ERRORCODE)</returns>
    ''' <remarks>V1.0 D. Robinson</remarks>
    <OperationContract()> _
    Function GetUserList(ByVal Server As String, ByVal Port As Int16, ByVal Scope As DirectoryServices.SearchScope, ByVal OUPath As String, ByVal UserList As String) As Int32

End Interface

