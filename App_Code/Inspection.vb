﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ButtonLibrary
    Public Property ButtonId As Integer
    Public Property Name As String
    Public Property Text As String
    Public Property DefectImage As Byte()
    Public Property DefectImage_Desc As String
    Public Property DefectCode As String
    Public Property Hide As Boolean

    Public Overridable Property ButtonTemplates As ICollection(Of ButtonTemplate) = New HashSet(Of ButtonTemplate)

End Class
Partial Public Class ButtonTemplate
    Public Property id As Integer
    Public Property TabTemplateId As Integer
    Public Property ButtonId As Integer
    Public Property DefectType As String
    Public Property Hide As Boolean
    Public Property Timer As Boolean

    Public Overridable Property ButtonLibrary As ButtonLibrary
    Public Overridable Property TabTemplate As TabTemplate
    Public Overridable Property DefectTimers As ICollection(Of DefectTimer) = New HashSet(Of DefectTimer)

End Class
Partial Public Class DefectMaster
    Public Property DefectID As Integer
    Public Property DefectTime As Nullable(Of Date)
    Public Property DefectDesc As String
    Public Property POnumber As String
    Public Property DataNo As String
    Public Property EmployeeNo As String
    Public Property AQL As String
    Public Property ThisPieceNo As String
    Public Property SampleSize As String
    Public Property RejectLimiter As Nullable(Of Integer)
    Public Property TotalLotPieces As String
    Public Property Product As String
    Public Property DefectClass As String
    Public Property MergeDate As Nullable(Of Date)
    Public Property Tablet As String
    Public Property WorkOrder As String
    Public Property LotNo As String
    Public Property Location As String
    Public Property DataType As String
    Public Property Dimensions As String
    Public Property Comment As String
    Public Property LoomNo As String
    Public Property DefectPoints As String
    Public Property GriegeNo As String
    Public Property RollNo As String
    Public Property Operation As String
    Public Property TemplateId As Integer
    Public Property InspectionId As Integer
    Public Property DefectImage As Byte()
    Public Property DefectImage_Filename As String
    Public Property DefectImage_ContentType As String
    Public Property ButtonTemplateId As Nullable(Of Integer)
    Public Property Inspector As String
    Public Property ItemNumber As String
    Public Property InspectionState As String
    Public Property CasePackConv As Nullable(Of Decimal)
    Public Property WorkRoom As String
    Public Property InspectionJobSummaryId As Nullable(Of Integer)
    Public Property WeaverShiftId As Nullable(Of Integer)

    Public Overridable Property TemplateName As TemplateName
    Public Overridable Property DefectTimers As ICollection(Of DefectTimer) = New HashSet(Of DefectTimer)

End Class
Partial Public Class DefectTimer
    Public Property id As Integer
    Public Property StatusValue As String
    Public Property InspectionJobSummaryId As Integer
    Public Property ButtonTemplateId As Integer
    Public Property DefectID As Integer
    Public Property SessionId As String
    Public Property Timestamp As Date
    Public Property ButtonLocationId As Integer
    Public Property StopTimestamp As Nullable(Of Date)

    Public Overridable Property ButtonTemplate As ButtonTemplate
    Public Overridable Property DefectMaster As DefectMaster
    Public Overridable Property InspectionJobSummary As InspectionJobSummary

End Class
Partial Public Class EmployeeNo
    Public Property Id As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Initials As String
    Public Property CID As String
    Public Property Type As String

    Public Overridable Property WeaverProductions As ICollection(Of WeaverProduction) = New HashSet(Of WeaverProduction)

End Class
Partial Public Class INS_Summary_VW
    Public Property id As Integer
    Public Property JobType As String
    Public Property JobNumber As String
    Public Property INSDataNum As String
    Public Property LOCCID As String
    Public Property LOCName As String
    Public Property INStemplateID As Integer
    Public Property TMPName As String
    Public Property ItemPassCount As Integer
    Public Property ItemFailCount As Integer
    Public Property WOQuantity As Nullable(Of Integer)
    Public Property WorkOrderPieces As Nullable(Of Integer)
    Public Property AQL_Level As Nullable(Of Decimal)
    Public Property Standard As String
    Public Property INSSampleSize As Nullable(Of Integer)
    Public Property TotalInspectedItems As Nullable(Of Integer)
    Public Property INSRejectLimiter As Nullable(Of Integer)
    Public Property Technical_PassFail As Nullable(Of Boolean)
    Public Property Technical_PassFail_Timestamp As Nullable(Of Date)
    Public Property UserConfirm_PassFail As Nullable(Of Boolean)
    Public Property UserConfirm_PassFail_Timestamp As Nullable(Of Date)
    Public Property Inspection_Started As Nullable(Of Date)
    Public Property Inspection_Finished As Nullable(Of Date)
    Public Property UnitCost As Nullable(Of Double)
    Public Property UnitDesc As String
    Public Property Comments As String
    Public Property ProdMachineName As String
    Public Property MajorsCount As Nullable(Of Integer)
    Public Property MinorsCount As Nullable(Of Integer)
    Public Property RepairsCount As Nullable(Of Integer)
    Public Property ScrapCount As Nullable(Of Integer)
    Public Property DefectID As Nullable(Of Integer)
    Public Property DefectTime As Nullable(Of Date)
    Public Property DefectDesc As String
    Public Property POnumber As String
    Public Property DataNo As String
    Public Property EmployeeNo As String
    Public Property ThisPieceNo As String
    Public Property SampleSize As String
    Public Property RejectLimiter As Nullable(Of Integer)
    Public Property TotalLotPieces As String
    Public Property Product As String
    Public Property DefectClass As String
    Public Property MergeDate As Nullable(Of Date)
    Public Property Tablet As String
    Public Property WorkOrder As String
    Public Property LotNo As String
    Public Property Location As String
    Public Property DataType As String
    Public Property Dimensions As String
    Public Property Comment As String
    Public Property LoomNo As String
    Public Property DefectPoints As String
    Public Property GriegeNo As String
    Public Property RollNo As String
    Public Property Operation As String
    Public Property TemplateId As Nullable(Of Integer)
    Public Property InspectionId As Nullable(Of Integer)
    Public Property DefectImage As Byte()
    Public Property DefectImage_Filename As String
    Public Property DefectImage_ContentType As String
    Public Property ButtonTemplateId As Nullable(Of Integer)
    Public Property Inspector As String
    Public Property ItemNumber As String
    Public Property InspectionState As String
    Public Property CasePackConv As Nullable(Of Decimal)
    Public Property WorkRoom As String
    Public Property InspectionJobSummaryId As Nullable(Of Integer)
    Public Property TMPTemplateID As Nullable(Of Integer)
    Public Property Name As String
    Public Property Owner As String
    Public Property DateCreated As Nullable(Of Date)
    Public Property Active As Nullable(Of Boolean)
    Public Property LineType As String
    Public Property Ins_GriegeBatch As Nullable(Of Boolean)
    Public Property Ins_WorkOrderInspection As Nullable(Of Boolean)
    Public Property Loc_STT As Nullable(Of Boolean)
    Public Property Loc_CAR As Nullable(Of Boolean)
    Public Property Loc_STJ As Nullable(Of Boolean)
    Public Property Loc_SPA As Nullable(Of Boolean)
    Public Property Loc_CDC As Nullable(Of Boolean)
    Public Property Loc_LINYI As Nullable(Of Boolean)
    Public Property LOCID As Nullable(Of Integer)
    Public Property Abreviation As String
    Public Property DBname As String
    Public Property CID As String
    Public Property ConnectionString As String
    Public Property InspectionResults As Nullable(Of Boolean)
    Public Property ProductionResults As Nullable(Of Boolean)
    Public Property AS400_Connection As Nullable(Of Boolean)
    Public Property AS400_Abr As String
    Public Property Loc_PCE As Nullable(Of Boolean)
    Public Property Loc_FSK As Nullable(Of Boolean)
    Public Property Loc_FNL As Nullable(Of Boolean)
    Public Property Loc_FPC As Nullable(Of Boolean)

End Class
Partial Public Class InspectionJobSummary
    Public Property id As Integer
    Public Property JobType As String
    Public Property JobNumber As String
    Public Property DataNo As String
    Public Property CID As String
    Public Property TemplateId As Integer
    Public Property ItemPassCount As Integer
    Public Property ItemFailCount As Integer
    Public Property WOQuantity As Nullable(Of Integer)
    Public Property WorkOrderPieces As Nullable(Of Integer)
    Public Property AQL_Level As Nullable(Of Decimal)
    Public Property Standard As String
    Public Property SampleSize As Nullable(Of Integer)
    Public Property TotalInspectedItems As Nullable(Of Integer)
    Public Property RejectLimiter As Nullable(Of Integer)
    Public Property Technical_PassFail As Nullable(Of Boolean)
    Public Property Technical_PassFail_Timestamp As Nullable(Of Date)
    Public Property UserConfirm_PassFail As Nullable(Of Boolean)
    Public Property UserConfirm_PassFail_Timestamp As Nullable(Of Date)
    Public Property Inspection_Started As Nullable(Of Date)
    Public Property Inspection_Finished As Nullable(Of Date)
    Public Property PRP_Code As String
    Public Property UnitCost As Nullable(Of Double)
    Public Property UnitDesc As String
    Public Property Comments As String
    Public Property ProdMachineName As String
    Public Property MajorsCount As Nullable(Of Integer)
    Public Property MinorsCount As Nullable(Of Integer)
    Public Property RepairsCount As Nullable(Of Integer)
    Public Property ScrapCount As Nullable(Of Integer)
    Public Property EmployeeNo As String
    Public Property CasePack As String
    Public Property WorkRoom As String

    Public Overridable Property DefectTimers As ICollection(Of DefectTimer) = New HashSet(Of DefectTimer)
    Public Overridable Property SpecMeasurements As ICollection(Of SpecMeasurement) = New HashSet(Of SpecMeasurement)
    Public Overridable Property WeaverProductions As ICollection(Of WeaverProduction) = New HashSet(Of WeaverProduction)

End Class
Partial Public Class InspectionType
    Public Property id As Integer
    Public Property Name As String
    Public Property Abreviation As String
    Public Property Description As String

End Class
Partial Public Class LocationMaster_VW
    Public Property id As Integer
    Public Property Name As String
    Public Property Abreviation As String
    Public Property DBname As String
    Public Property CID As String
    Public Property ConnectionString As String
    Public Property InspectionResults As Nullable(Of Boolean)
    Public Property ProductionResults As Nullable(Of Boolean)
    Public Property AS400_Connection As Nullable(Of Boolean)
    Public Property AS400_Abr As String

End Class
Partial Public Class ProductSpecification
    Public Property SpecId As Integer
    Public Property POM_Row As Nullable(Of Integer)
    Public Property TabTemplateId As Nullable(Of Integer)
    Public Property DataNo As String
    Public Property ProductType As String
    Public Property Spec_Description As String
    Public Property HowTo As String
    Public Property value As Decimal
    Public Property Upper_Spec_Value As Decimal
    Public Property Lower_Spec_Value As Decimal
    Public Property GlobalSpec As Boolean
    Public Property ME_SessionID As String
    Public Property SpecSource As String

    Public Overridable Property SpecMeasurements As ICollection(Of SpecMeasurement) = New HashSet(Of SpecMeasurement)

End Class
Partial Public Class RollInspectionDetail
    Public Property id As Integer
    Public Property RollInspectionSummaryId As Integer
    Public Property TemplateId As Integer
    Public Property ButtonTemplateId As Nullable(Of Integer)
    Public Property ShiftNumber As Integer
    Public Property DHY As Decimal
    Public Property DefectCount As Nullable(Of Integer)

    Public Overridable Property RollInspectionSummary As RollInspectionSummary
    Public Overridable Property TemplateName As TemplateName

End Class
Partial Public Class RollInspectionSummary
    Public Property Id As Integer
    Public Property LoomNo As String
    Public Property RollNumber As String
    Public Property Style As String
    Public Property Yards_Inspected As Decimal
    Public Property DefectiveYards As Integer
    Public Property DHY As Nullable(Of Decimal)
    Public Property RollStartTimestamp As Date

    Public Overridable Property RollInspectionDetails As ICollection(Of RollInspectionDetail) = New HashSet(Of RollInspectionDetail)

End Class
Partial Public Class SpecMeasurement
    Public Property id As Integer
    Public Property TabTemplateId As Nullable(Of Integer)
    Public Property SpecId As Integer
    Public Property DefectId As Nullable(Of Integer)
    Public Property ItemNumber As Nullable(Of Integer)
    Public Property InspectionJobSummaryId As Nullable(Of Integer)
    Public Property InspectionId As Nullable(Of Integer)
    Public Property Timestamp As Date
    Public Property MeasureValue As Decimal
    Public Property SpecDelta As Nullable(Of Decimal)

    Public Overridable Property InspectionJobSummary As InspectionJobSummary
    Public Overridable Property ProductSpecification As ProductSpecification

End Class
Partial Public Class STT_VW
    Public Property ID As Integer
    Public Property Machine As String
    Public Property WorkOrder As String
    Public Property OperatorNo As String
    Public Property StartTime As Nullable(Of Date)
    Public Property FinishTime As Nullable(Of Date)
    Public Property DataNo As String
    Public Property GreigeNo As String
    Public Property CutLengthSpec As String
    Public Property FinishLength As Nullable(Of Decimal)
    Public Property JobYds As Nullable(Of Decimal)
    Public Property JobSheets As Nullable(Of Integer)
    Public Property JobOverLengthInches As Nullable(Of Decimal)
    Public Property ScheduledTime As Nullable(Of Decimal)
    Public Property DownTime As Nullable(Of Decimal)
    Public Property RunTime As Nullable(Of Decimal)
    Public Property Efficiency As Nullable(Of Decimal)
    Public Property AvgSheetsPerHour As Nullable(Of Decimal)
    Public Property RunPass As String
    Public Property PH As Nullable(Of Decimal)
    Public Property Whiteness As Nullable(Of Decimal)
    Public Property ExitWidth As Nullable(Of Decimal)
    Public Property Absorbency As Nullable(Of Decimal)
    Public Property RollTicketYds As Nullable(Of Decimal)
    Public Property YieldYds As Nullable(Of Decimal)
    Public Property WOQUANTITY As Nullable(Of Integer)
    Public Property JDECOMP As Nullable(Of Integer)
    Public Property JDESCRAP As Nullable(Of Integer)
    Public Property JDETOTREC As Nullable(Of Integer)
    Public Property DIFF_OVER_UNDER As Nullable(Of Integer)
    Public Property DIFF_PERC As Nullable(Of Decimal)
    Public Property TimeStamp_Trans As Nullable(Of Date)
    Public Property Updated As Nullable(Of Date)
    Public Property HourID As Integer
    Public Property HourBegin As Nullable(Of Date)
    Public Property ProductCount As Integer
    Public Property OverLengthInches As Nullable(Of Decimal)
    Public Property HP_Cut_Length_Spec As Nullable(Of Decimal)
    Public Property AvgYdsPmin As Nullable(Of Decimal)
    Public Property HourlyYds As Nullable(Of Decimal)
    Public Property Variance As Nullable(Of Decimal)
    Public Property HP_RunTime As Nullable(Of Decimal)
    Public Property HP_DownTime As Nullable(Of Decimal)
    Public Property WorkOrderID As String
    Public Property MaintenanceStatus As Nullable(Of Boolean)
    Public Property Location As String
    Public Property Last_Timestamp As Nullable(Of Date)

End Class
Partial Public Class TabTemplate
    Public Property TabTemplateId As Integer
    Public Property TemplateId As Integer
    Public Property Name As String
    Public Property TabNumber As Integer
    Public Property ProductSpecs As Boolean
    Public Property Updated As Nullable(Of Date)
    Public Property Active As Boolean

    Public Overridable Property ButtonTemplates As ICollection(Of ButtonTemplate) = New HashSet(Of ButtonTemplate)
    Public Overridable Property TemplateName As TemplateName

End Class
Partial Public Class TemplateActivator
    Public Property Id As Integer
    Public Property LocationMasterId As Integer
    Public Property TemplateId As Integer
    Public Property Status As Boolean
    Public Property Inserted_Timestamp As Date

    Public Overridable Property TemplateName As TemplateName

End Class
Partial Public Class TemplateName
    Public Property TemplateId As Integer
    Public Property Name As String
    Public Property Owner As String
    Public Property DateCreated As Nullable(Of Date)
    Public Property Active As Nullable(Of Boolean)
    Public Property LineTypeId As Nullable(Of Integer)
    Public Property LineType As String
    Public Property Ins_GriegeBatch As Nullable(Of Boolean)
    Public Property Ins_WorkOrderInspection As Nullable(Of Boolean)
    Public Property Loc_STT As Nullable(Of Boolean)
    Public Property Loc_CAR As Nullable(Of Boolean)
    Public Property Loc_STJ As Nullable(Of Boolean)
    Public Property Loc_SPA As Nullable(Of Boolean)
    Public Property Loc_CDC As Nullable(Of Boolean)
    Public Property Loc_LINYI As Nullable(Of Boolean)
    Public Property Loc_PCE As Nullable(Of Boolean)
    Public Property Loc_FSK As Nullable(Of Boolean)
    Public Property Loc_FNL As Nullable(Of Boolean)
    Public Property Loc_FPC As Nullable(Of Boolean)

    Public Overridable Property DefectMasters As ICollection(Of DefectMaster) = New HashSet(Of DefectMaster)
    Public Overridable Property RollInspectionDetails As ICollection(Of RollInspectionDetail) = New HashSet(Of RollInspectionDetail)
    Public Overridable Property TabTemplates As ICollection(Of TabTemplate) = New HashSet(Of TabTemplate)
    Public Overridable Property TemplateActivators As ICollection(Of TemplateActivator) = New HashSet(Of TemplateActivator)

End Class
Partial Public Class WeaverProduction
    Public Property Id As Integer
    Public Property EmployeeNoId As Integer
    Public Property JobSummaryId As Integer
    Public Property Yards As Decimal
    Public Property ShiftId As Integer

    Public Overridable Property EmployeeNo As EmployeeNo
    Public Overridable Property InspectionJobSummary As InspectionJobSummary
    Public Overridable Property WeaverShift As WeaverShift

End Class
Partial Public Class WeaverShift
    Public Property Id As Integer
    Public Property Shift As Integer
    Public Property Start As Date
    Public Property Finish As Nullable(Of Date)

    Public Overridable Property WeaverProductions As ICollection(Of WeaverProduction) = New HashSet(Of WeaverProduction)

End Class
