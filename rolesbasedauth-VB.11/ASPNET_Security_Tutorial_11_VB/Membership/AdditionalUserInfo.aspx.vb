﻿
Partial Class Membership_AdditionalUserInfo
    Inherits System.Web.UI.Page

    Protected Sub UserProfileDataSource_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles UserProfileDataSource.Selecting
        ' Get a reference to the currently logged on user
        Dim currentUser As MembershipUser = Membership.GetUser()

        ' Determine the currently logged on user's UserId value
        Dim currentUserId As Guid = CType(currentUser.ProviderUserKey, Guid)

        ' Assign the currently logged on user's UserId to the @UserId parameter
        e.Command.Parameters("@UserId").Value = currentUserId
    End Sub

    Protected Sub UserProfile_ItemUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewUpdatedEventArgs) Handles UserProfile.ItemUpdated
        SettingsUpdatedMessage.Visible = True
    End Sub
End Class
