Public Class FEMAP_Pane
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub FEMAP_Pane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim App As femap.model
        Dim rc As femap.zReturnCode
        App = GetObject(, "femap.model")

        App.feAppMessage(0, "I'm attached! Form2")

        rc = App.feAppRegisterAddInPane(True, Handle, Handle, False, False, 2, 0)
    End Sub

    Private Sub FEMAP_Pane_HandleDestroyed(sender As Object, e As EventArgs) Handles MyBase.HandleDestroyed
        Environment.Exit(0)
    End Sub
    Private Sub FEMAP_Pane__FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Dim App As femap.model
        Dim rc As femap.zReturnCode
        App = GetObject(, "femap.model")

        rc = App.feAppRegisterAddInPane(False, Handle, Handle, False, False, 2, 0)
    End Sub
End Class