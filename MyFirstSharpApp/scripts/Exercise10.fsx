// The goal of this exercise is to work with .net dependency (here, WebClient)

open System.Net

let postUsername name (client: WebClient) =
    let res = client.UploadString ("https://httpbin.org/post", "fname=" + name)
    //Do stuff with result
    client

let postAge age (client: WebClient) =
    let res = client.UploadString ("https://httpbin.org/post", "age=" + age)
    //Do stuff with result
    client

let postInformations name age =
    use client = new WebClient (Encoding = System.Text.Encoding.UTF8)

    client
    |> postUsername name
    |> postAge  age

postInformations "flavien" "24"