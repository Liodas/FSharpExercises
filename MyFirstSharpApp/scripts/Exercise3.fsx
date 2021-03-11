//The goal of this exercise is to fetch the data of a browser page with a given URL and display it in a WinForm

open System
open System.Net
open System.Windows.Forms

let createForm uri =
    let fsharpOrg =
        use webClient = new WebClient()
        webClient.DownloadString(Uri uri)

    use browser =
        new WebBrowser
            ( ScriptErrorsSuppressed = true
            , Dock = DockStyle.Fill
            , DocumentText = fsharpOrg )

    use form = new Form(Text = "Hello from F#!")

    form.Controls.Add browser
    form.Show()

let uri = "https://www.google.com/"
createForm uri
