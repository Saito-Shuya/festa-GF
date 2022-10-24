Namespace PageSettings
    Public Class JsonList
        Public Property Rows As JSONRow()
    End Class

    Public Class JSONRow
        Public Property PrizeAnnouncementPage As PrizeAnnouncementProperties
        Public Property FinalPage As FinalPage
    End Class

    Public Class PrizeAnnouncementProperties
        Public Property imageName As String()
        Public Property prizeImageWidth As Integer
        Public Property prizeImageHeight As Integer
        Public Property fuukunImage As ImageSettings
        Public Property banner As ImageSettings
    End Class

    Public Class FinalPage
        Public Property season As String
    End Class

    Public Class ImageSettings
        Public Property isShow As Boolean
        Public Property x As Integer
        Public Property y As Integer
    End Class
End Namespace

