Public Class Period
    Private period As Integer
    Private isPeriod As Boolean
    Private isEnd As Boolean

    Public Sub New()

    End Sub

    Public Sub New(_period As Integer)
        period = _period
        isPeriod = True
        isEnd = False
    End Sub

    Public Sub New(_isEnd As Boolean)
        isPeriod = _isEnd
        isEnd = _isEnd
    End Sub

    Public Sub New(_period As Period)
        copy(_period)
    End Sub

    Public Sub setPeriod(_period As Integer)
        period = _period
    End Sub
    Public Sub setIsPeriod(_isPeriod As Boolean)
        isPeriod = _isPeriod
    End Sub
    Public Sub setIsEnd(_isEnd As Boolean)
        isEnd = _isEnd
    End Sub

    Public Function getPeriod()
        Return period
    End Function

    Public Function getIsPeriod()
        Return isPeriod
    End Function

    Public Function getIsEnd()
        Return isEnd
    End Function

    Public Sub copy(_period As Period)
        setPeriod(_period.getIsPeriod)
        setIsPeriod(_period.getIsPeriod)
        setIsEnd(_period.getIsEnd)
    End Sub

End Class
