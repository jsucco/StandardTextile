﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class AprManager_Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AprManager_Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property EmailMasters() As DbSet(Of EmailMaster)
    Public Overridable Property LinkedServerMasters() As DbSet(Of LinkedServerMaster)
    Public Overridable Property LocationMasters() As DbSet(Of LocationMaster)
    Public Overridable Property OPCMasters() As DbSet(Of OPCMaster)
    Public Overridable Property SPC_ApplicationLog() As DbSet(Of SPC_ApplicationLog)
    Public Overridable Property UserActivityLogs() As DbSet(Of UserActivityLog)
    Public Overridable Property UserCrudActivityLogs() As DbSet(Of UserCrudActivityLog)

    Public Overridable Function EmailTest1(returnmsg As ObjectParameter, emailAddress As String, subject As String, body As String) As Integer
        Dim emailAddressParameter As ObjectParameter = If(emailAddress IsNot Nothing, New ObjectParameter("EmailAddress", emailAddress), New ObjectParameter("EmailAddress", GetType(String)))

        Dim subjectParameter As ObjectParameter = If(subject IsNot Nothing, New ObjectParameter("Subject", subject), New ObjectParameter("Subject", GetType(String)))

        Dim bodyParameter As ObjectParameter = If(body IsNot Nothing, New ObjectParameter("Body", body), New ObjectParameter("Body", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("EmailTest1", returnmsg, emailAddressParameter, subjectParameter, bodyParameter)
    End Function

    Public Overridable Function Get400Locations(rETSTRG As ObjectParameter) As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("Get400Locations", rETSTRG)
    End Function

    Public Overridable Function SearchAllTables(searchStr As String) As ObjectResult(Of SearchAllTables_Result)
        Dim searchStrParameter As ObjectParameter = If(searchStr IsNot Nothing, New ObjectParameter("SearchStr", searchStr), New ObjectParameter("SearchStr", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SearchAllTables_Result)("SearchAllTables", searchStrParameter)
    End Function

    Public Overridable Function SP_ApplicationLogInsert(type As String, target As String, message As String, numRowAff As ObjectParameter) As Integer
        Dim typeParameter As ObjectParameter = If(type IsNot Nothing, New ObjectParameter("type", type), New ObjectParameter("type", GetType(String)))

        Dim targetParameter As ObjectParameter = If(target IsNot Nothing, New ObjectParameter("target", target), New ObjectParameter("target", GetType(String)))

        Dim messageParameter As ObjectParameter = If(message IsNot Nothing, New ObjectParameter("message", message), New ObjectParameter("message", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("SP_ApplicationLogInsert", typeParameter, targetParameter, messageParameter, numRowAff)
    End Function

    Public Overridable Function SP_ApplicationLogInsert_1(type As String, target As String, message As String, userPK As Nullable(Of Integer), numRowAff As ObjectParameter) As Integer
        Dim typeParameter As ObjectParameter = If(type IsNot Nothing, New ObjectParameter("type", type), New ObjectParameter("type", GetType(String)))

        Dim targetParameter As ObjectParameter = If(target IsNot Nothing, New ObjectParameter("target", target), New ObjectParameter("target", GetType(String)))

        Dim messageParameter As ObjectParameter = If(message IsNot Nothing, New ObjectParameter("message", message), New ObjectParameter("message", GetType(String)))

        Dim userPKParameter As ObjectParameter = If(userPK.HasValue, New ObjectParameter("UserPK", userPK), New ObjectParameter("UserPK", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("SP_ApplicationLogInsert_1", typeParameter, targetParameter, messageParameter, userPKParameter, numRowAff)
    End Function

    Public Overridable Function SP_SPC_GetTemplateLocationStatus(templateId As Nullable(Of Integer)) As ObjectResult(Of SP_SPC_GetTemplateLocationStatus_Result)
        Dim templateIdParameter As ObjectParameter = If(templateId.HasValue, New ObjectParameter("TemplateId", templateId), New ObjectParameter("TemplateId", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SP_SPC_GetTemplateLocationStatus_Result)("SP_SPC_GetTemplateLocationStatus", templateIdParameter)
    End Function

    Public Overridable Function usp_InsertErrorToLog(type As String, target As String) As Integer
        Dim typeParameter As ObjectParameter = If(type IsNot Nothing, New ObjectParameter("type", type), New ObjectParameter("type", GetType(String)))

        Dim targetParameter As ObjectParameter = If(target IsNot Nothing, New ObjectParameter("target", target), New ObjectParameter("target", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("usp_InsertErrorToLog", typeParameter, targetParameter)
    End Function

End Class
