open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Common

[<EntryPoint>]
let main _ =
    startWebServer defaultConfig (request (fun r ->
        r.rawForm
        |> System.Text.Encoding.UTF8.GetString
        |> Serializer.deserialize<Message>
        |> Server.handleMessage
        |> Serializer.serialize
        |> OK
        ))
    0 // return an integer exit code

