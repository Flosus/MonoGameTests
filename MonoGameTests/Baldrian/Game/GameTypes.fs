namespace Baldrian.Game

open System

type GameIcon = string
type Weight = float
type Value = int

type ItemType =
    | Unknown
    | Junk
    | Resource
    | Equipment

type Rarity =
    | Common
    | Uncommon
    | Rare
    | Epic
    | Legendary

type Item =
    { Name: string
      Description: string
      Weight: Weight
      Value: Value
      Uuid: Guid
      MaxStackSize: int
      ItemType: ItemType
      Rarity: Rarity
      Icon: GameIcon }

type ItemStack = { Item: Item; StackSize: int }

type Player =
    { Inventory: ItemStack list
      Life: int
      Mana: int }

type NonPlayerCharacter = { Name: string; Uuid: Guid }

type Enemy =
    { Name: string
      Uuid: Guid
      Life: int
      Mana: int }

type Interactiable = { Name: string option; Uuid: Guid }

type WorldStage =
    { Name: string
      Uuid: Guid
      Enemies: Enemy list
      NPCs: NonPlayerCharacter list
      Interactiables: Interactiable list
      LastUpdateTick: int }

type World =
    { Player: Player
      CurrentStage: WorldStage
      LoadedStages: WorldStage list
      LastTick: int }
