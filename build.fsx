#r "paket:
nuget Fake.DotNet.Cli
nuget Fake.JavaScript.Yarn
nuget Fake.IO.FileSystem
nuget Fake.Core.Target //"
#load "./.fake/build.fsx/intellisense.fsx"
#if !FAKE
  #r "Facades/netstandard"
#endif

open Fake.Core
open Fake.Core.TargetOperators
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.JavaScript


Target.create "clean" (fun _ ->
    !! "**/bin"
    ++ "**/obj"
    ++ "out"
    -- "node_modules/**"
    |> Seq.iter Shell.cleanDir
)

Target.create "restore" (fun _ ->
    Yarn.install id
)

Target.create "build" (fun _ ->
    ["frontend"]
    |> List.iter (fun name -> Yarn.exec (sprintf "workspace %s build" name) id)
)

Target.create "start" (fun _ ->
    Yarn.exec "workspace frontend start" id
)


"clean"
  ==> "restore"
  ==> "build"

Target.runOrDefault "build"