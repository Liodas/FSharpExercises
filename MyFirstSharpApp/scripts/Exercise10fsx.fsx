// The goal of this exercise is to

open System.Net

let postUsername (client: WebClient) name =
    client.UploadString ("https://httpbin.org/post", "fname=" + name);

let postAge (client: WebClient) age =
    client.UploadString ("https://httpbin.org/post", "age=" + age)

let postInformations name age =
    // Can't use 'use' keyword outside of a function
    use client = new WebClient ()
    // <- used to modify value after init
    client.Encoding <- System.Text.Encoding.UTF8;

    postUsername client name |> ignore
    postAge  client age

postInformations "flavien" "24"