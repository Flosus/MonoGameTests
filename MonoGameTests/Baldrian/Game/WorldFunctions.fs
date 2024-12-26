module Baldrian.Game.WorldFunctions

open System



let updateStage (stage: WorldStage) (world: World) =
    let newTick = world.LastTick + 1

    { stage with LastUpdateTick = newTick }

let preWorldUpdate (world: World) = world

let mainWorldUpdate (world: World) =
    let newTick = world.LastTick + 1
    let newMainStage = updateStage world.CurrentStage world

    let loadedStages =
        match newTick % 10 with
        | 0 -> world.LoadedStages |> List.map (fun s -> updateStage s world)
        | _ -> world.LoadedStages

    { world with
        LastTick = newTick
        CurrentStage = newMainStage
        LoadedStages = loadedStages }

let postWorldUpdate (world: World) = world

let worldUpdate (world: World) =
    world |> preWorldUpdate |> mainWorldUpdate |> postWorldUpdate
