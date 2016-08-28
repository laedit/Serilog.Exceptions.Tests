#r "./tools/FAKE/tools/FakeLib.dll"

open Fake

Target "RestorePackages" (fun _ ->
    "./src/Serilog.Exceptions.Tests.sln"
    |> RestoreMSSolutionPackages (fun p -> { p with OutputPath = "src/packages" })
)

Target "All" DoNothing

// Dependencies
"RestorePackages"
  ==> "All"

// start build
RunTargetOrDefault "All"
