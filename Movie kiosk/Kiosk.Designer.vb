<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kiosk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kiosk))
        Me.Browser = New DotNetBrowser.WinForms.WinFormsBrowserView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Youtubebtn = New System.Windows.Forms.Button()
        Me.Shutdownbtn = New System.Windows.Forms.Button()
        Me.Minimizebtn = New System.Windows.Forms.Button()
        Me.Maximizebtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Ziggobtn = New System.Windows.Forms.Button()
        Me.Netflixbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.AcceptLanguage = Nothing
        Me.Browser.AudioMuted = Nothing
        Me.Browser.BrowserType = DotNetBrowser.BrowserType.HEAVYWEIGHT
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Top
        Me.Browser.Location = New System.Drawing.Point(0, 0)
        Me.Browser.Name = "Browser"
        Me.Browser.Preferences = Nothing
        Me.Browser.Size = New System.Drawing.Size(1259, 537)
        Me.Browser.TabIndex = 0
        Me.Browser.URL = "http://www.quirksmode.org/html5/tests/video.html"
        Me.Browser.ZoomLevel = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Youtubebtn)
        Me.Panel1.Controls.Add(Me.Shutdownbtn)
        Me.Panel1.Controls.Add(Me.Minimizebtn)
        Me.Panel1.Controls.Add(Me.Maximizebtn)
        Me.Panel1.Controls.Add(Me.Exitbtn)
        Me.Panel1.Controls.Add(Me.Ziggobtn)
        Me.Panel1.Controls.Add(Me.Netflixbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 543)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 77)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(399, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(399, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Youtubebtn
        '
        Me.Youtubebtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Youtubebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Youtubebtn.Image = Global.Movie_kiosk.My.Resources.Resources.youtube_button_klein
        Me.Youtubebtn.Location = New System.Drawing.Point(273, 0)
        Me.Youtubebtn.Name = "Youtubebtn"
        Me.Youtubebtn.Size = New System.Drawing.Size(99, 77)
        Me.Youtubebtn.TabIndex = 6
        Me.Youtubebtn.UseVisualStyleBackColor = True
        '
        'Shutdownbtn
        '
        Me.Shutdownbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Shutdownbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Shutdownbtn.Image = Global.Movie_kiosk.My.Resources.Resources.Shutdown_button_klein
        Me.Shutdownbtn.Location = New System.Drawing.Point(964, 0)
        Me.Shutdownbtn.Name = "Shutdownbtn"
        Me.Shutdownbtn.Size = New System.Drawing.Size(75, 77)
        Me.Shutdownbtn.TabIndex = 5
        Me.Shutdownbtn.UseVisualStyleBackColor = True
        '
        'Minimizebtn
        '
        Me.Minimizebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizebtn.Image = Global.Movie_kiosk.My.Resources.Resources.minimize_button_klein
        Me.Minimizebtn.Location = New System.Drawing.Point(1039, 0)
        Me.Minimizebtn.Name = "Minimizebtn"
        Me.Minimizebtn.Size = New System.Drawing.Size(75, 77)
        Me.Minimizebtn.TabIndex = 4
        Me.Minimizebtn.UseVisualStyleBackColor = True
        '
        'Maximizebtn
        '
        Me.Maximizebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Maximizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maximizebtn.Image = Global.Movie_kiosk.My.Resources.Resources.maximize_button_klein
        Me.Maximizebtn.Location = New System.Drawing.Point(1114, 0)
        Me.Maximizebtn.Name = "Maximizebtn"
        Me.Maximizebtn.Size = New System.Drawing.Size(75, 77)
        Me.Maximizebtn.TabIndex = 3
        Me.Maximizebtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitbtn.Image = CType(resources.GetObject("Exitbtn.Image"), System.Drawing.Image)
        Me.Exitbtn.Location = New System.Drawing.Point(1189, 0)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(70, 77)
        Me.Exitbtn.TabIndex = 2
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Ziggobtn
        '
        Me.Ziggobtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ziggobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ziggobtn.Image = CType(resources.GetObject("Ziggobtn.Image"), System.Drawing.Image)
        Me.Ziggobtn.Location = New System.Drawing.Point(174, 0)
        Me.Ziggobtn.Name = "Ziggobtn"
        Me.Ziggobtn.Size = New System.Drawing.Size(99, 77)
        Me.Ziggobtn.TabIndex = 1
        Me.Ziggobtn.UseVisualStyleBackColor = True
        '
        'Netflixbtn
        '
        Me.Netflixbtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Netflixbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Netflixbtn.Image = CType(resources.GetObject("Netflixbtn.Image"), System.Drawing.Image)
        Me.Netflixbtn.Location = New System.Drawing.Point(0, 0)
        Me.Netflixbtn.Name = "Netflixbtn"
        Me.Netflixbtn.Size = New System.Drawing.Size(174, 77)
        Me.Netflixbtn.TabIndex = 0
        Me.Netflixbtn.UseVisualStyleBackColor = True
        '
        'Kiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1259, 620)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Browser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kiosk"
        Me.Text = "Movie Kiosk Kids"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Browser As DotNetBrowser.WinForms.WinFormsBrowserView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ziggobtn As Button
    Friend WithEvents Netflixbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Maximizebtn As Button
    Friend WithEvents Minimizebtn As Button
    Friend WithEvents Shutdownbtn As Button
    Friend WithEvents Youtubebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
