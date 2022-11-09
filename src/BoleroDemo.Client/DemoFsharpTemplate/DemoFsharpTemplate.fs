module BoleroDemo.Client.DemoFsharpTemplate

open Bolero.Html

// type Model = { firstName: string; lastName: string }
// let initModel = { firstName = ""; lastName = "" }

// type Message = SetFirstName of string | SetLastName of string
// let update message model =
//     match message with
//     | SetFirstName n -> { model with firstName = n }
//     | SetLastName n -> { model with lastName = n }

// let viewInput model setValue =
//     input {
//         attr.value model
//         on.change (fun e -> setValue (unbox e.Value))
//     }

// let view model dispatch =
//     div {
//         viewInput model.firstName (fun n -> dispatch (SetFirstName n))
//         viewInput model.lastName (fun n -> dispatch (SetLastName n))
//         $"Hello, {model.firstName} {model.lastName}!"
//     }
let fsharpTemplateElement (title: string) (text: string) model dispatch = 
   div {
       h1 { $"{title}"}
       h1 { $"{text}"}
   }