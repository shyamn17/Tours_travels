

Imports System.Windows.Forms

Public Class TTDBMDI
    Dim temp As VariantType

    Private Sub CompanyDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyDetailsToolStripMenuItem.Click
        Companydetails.MdiParent = Me
        Companydetails.Show()
    End Sub



    Private Sub TRAINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RulesRegulation.MdiParent = Me
        RulesRegulation.Show()
    End Sub
    Private Sub RulesAndRegulationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RulesAndRegulationsToolStripMenuItem.Click
        RulesRegulation.MdiParent = Me
        RulesRegulation.Show()
    End Sub

    Private Sub AllPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub SouthIndiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SouthIndiaToolStripMenuItem.Click
        South_india.MdiParent = Me
        South_india.Show()

    End Sub

    Private Sub MasterPagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterPagesToolStripMenuItem.Click

    End Sub

    Private Sub PackageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackageToolStripMenuItem.Click

    End Sub

    Private Sub NorthIndiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NorthIndiaToolStripMenuItem.Click
        North_india.MdiParent = Me
        North_india.Show()
    End Sub

    Private Sub DevotionalPackageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevotionalPackageToolStripMenuItem.Click
        Devotional.MdiParent = Me
        Devotional.Show()
    End Sub

    Private Sub GoaPackageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoaPackageToolStripMenuItem.Click
        Goa_Package.MdiParent = Me
        Goa_Package.Show()
    End Sub



    Private Sub NorthIndiaPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NorthIndiaPackagesToolStripMenuItem.Click
        North_India_Packages.MdiParent = Me
        North_India_Packages.Show()
    End Sub

    Private Sub GoaPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoaPackagesToolStripMenuItem.Click
        Goa_Packages.MdiParent = Me
        Goa_Packages.Show()
    End Sub

    Private Sub DevotionalPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevotionalPackagesToolStripMenuItem.Click
        Devotional_Packages.MdiParent = Me
        Devotional_Packages.Show()
    End Sub

    Private Sub SouthIndiaPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SouthIndiaPackagesToolStripMenuItem.Click
        South_India_Packages.MdiParent = Me
        South_India_Packages.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SearchToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SearchAndModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAndModifyToolStripMenuItem.Click
        SearchForm.MdiParent = Me
        SearchForm.Show()
    End Sub

 

    Private Sub NorthIndiaPackagesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NorthIndiaPackagesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchNI.MdiParent = Me
        SearchNI.Show()
    End Sub

    Private Sub GoaPackagesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchGOA.MdiParent = Me
        SearchGOA.Show()
    End Sub

    Private Sub DevotionalPackagesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchDV.MdiParent = Me
        SearchDV.Show()
    End Sub

    Private Sub GoaPackagesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DevotionalPackagesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SouthIndiaPackagesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ShowNIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowNIToolStripMenuItem.Click
        NORTH_INDIA_TOUR.MdiParent = Me
        NORTH_INDIA_TOUR.Show()
    End Sub


    Private Sub ShowGoaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowGoaToolStripMenuItem.Click
        GOA_TOUR.MdiParent = Me
        GOA_TOUR.Show()

    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        DEVOTIONAL_TOUR.MdiParent = Me
        DEVOTIONAL_TOUR.Show()

    End Sub

    Private Sub ShowSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSIToolStripMenuItem.Click
        SOUTH_INDIA_TOUR.MdiParent = Me
        SOUTH_INDIA_TOUR.Show()

    End Sub

    Private Sub NorthIndiaCancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NorthIndiaCancellationToolStripMenuItem.Click
        NorthIndia_Cancellation.MdiParent = Me
        NorthIndia_Cancellation.Show()

    End Sub

    Private Sub SouthIndiaCancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SouthIndiaCancellationToolStripMenuItem.Click
        SouthIndia_Cancellation.MdiParent = Me
        SouthIndia_Cancellation.Show()

    End Sub



    Private Sub DevotionalCancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevotionalCancellationToolStripMenuItem.Click
        Devotional_Cancellation.MdiParent = Me
        Devotional_Cancellation.Show()

    End Sub


    Private Sub GoaCancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoaCancellationToolStripMenuItem.Click
        Goa_Cancellation.MdiParent = Me
        Goa_Cancellation.Show()
    End Sub

    Private Sub DevotionalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevotionalReportToolStripMenuItem.Click
        Devotional_Report.MdiParent = Me
        Devotional_Report.Show()

    End Sub

    Private Sub NorthIndiaReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NorthIndiaReportToolStripMenuItem.Click
        North_India_Report.MdiParent = Me
        North_India_Report.Show()
    End Sub

    Private Sub GoaReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoaReportToolStripMenuItem.Click
        Goa_Report.MdiParent = Me
        Goa_Report.Show()
    End Sub






    Private Sub SouthIndiaReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SouthIndiaReportToolStripMenuItem.Click
        South_India_Report.MdiParent = Me
        South_India_Report.Show()

    End Sub

    Private Sub ShortTripToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShortTripToolStripMenuItem.Click
        Car_Rentals.MdiParent = Me
        Car_Rentals.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        temp = MsgBox("Do You Want To Log out!(Yes/No)", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Exit")
        If temp = vbYes Then
            MsgBox("Thank You ", MsgBoxStyle.Information, "best wishes")
            loginpage.Show()
            Me.Hide()
        End If

    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        temp = MsgBox("Do You Want To EXIT (Yes/No)", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Exit")
        If temp = vbYes Then
            MsgBox("Thank You ", MsgBoxStyle.Information, "best wishes")
            End
        End If

    End Sub

    Private Sub ModifyToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem4.Click
        Modify.MdiParent = Me
        Modify.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PRINT.MdiParent = Me
        PRINT.Show()
    End Sub
End Class
