open System.Linq

let loadInput day =
    let filename = __SOURCE_DIRECTORY__ + $"/inputs/day{day}.txt"
    printfn "Loading input from %s" filename

    System.IO.File.ReadAllLines filename


let input = loadInput 1

let countElfs input =
    let mutable elfNumber = 0
    let mutable elfs = ResizeArray<int>()
    let mutable elf = ResizeArray<int>()

    for line in input do
        if line = "" then
            elfNumber <- elfNumber + 1
            elfs.Add(elf.Sum())
            elf <- ResizeArray<int>()
        else
            elf.Add(int line)

    elfs |> Array.ofSeq

input |> countElfs |> Array.length |> printfn "Sum of all elfs: %i"
input |> countElfs |> Array.max |> printfn "Elf with the most energy: %i"

input
|> countElfs
|> Array.sortDescending
|> Array.take 3
|> Array.sum
|> printfn "Sum of the three elfs with the most energy: %i"
