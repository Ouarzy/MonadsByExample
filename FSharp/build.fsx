// include Fake libs
#r "./packages/FAKE/tools/FakeLib.dll"

open Fake

// Directories
let buildDir  = "./build/"


// Filesets
let appReferences  =
    !! "/**/*.csproj"
    ++ "/**/*.fsproj"

// version info
let version = "0.1"  // or retrieve from CI server

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

Target "Build" (fun _ ->
    MSBuildDebug buildDir "Build" appReferences
    |> Log "AppBuild-Output: "
)

Target "Test" (fun _ ->
    ["build/FSharpMonads.dll"] 
    |> Fake.Testing.XUnit.xUnit 
        (fun a -> { a with ToolPath = "packages/xunit.runner.console/tools/xunit.console.exe"})        
)


// Build order
"Clean"
  ==> "Build"
  ==> "Test"

// start build
RunTargetOrDefault "Build"
