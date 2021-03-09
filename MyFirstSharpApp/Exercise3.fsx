open System
open System.Net
open System.Windows.Forms

let createForm uri =
    let fsharpOrg =
                let webClient = new WebClient()
                webClient.DownloadString(Uri uri)

    let browser =
        new WebBrowser(ScriptErrorsSuppressed = true,
            Dock = DockStyle.Fill,
            DocumentText = fsharpOrg)

    let form = new Form(Text = "Hello from F#!")

    form.Controls.Add browser
    form.Show()

let uri = "https://www.google.com/"
createForm uri