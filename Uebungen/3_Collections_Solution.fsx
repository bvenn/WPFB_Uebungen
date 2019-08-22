// Task 1.1
// Erstelle eine Int Liste mit den Zahlen 1 - 100 und binde sie an einen Namen.
let nList = [ 1 .. 100 ]

// Task 1.2
// Binde das erste und das letzte Element der Liste an je einen Namen.
let headOfL = List.head nList
let lastOfL = List.last nList


// Task 1.3
// Fuege das erste Element dem Ende der Liste, und das letzte Element dem Anfang der Liste hinzu.
// Binde das ganze erneut an einen Namen.
let combinedList = lastOfL::nList@[headOfL]


// Task 2.1
// Erstelle einen Float Array mit den Zahlen von 1. - 100. und binde ihn an einen Namen.
let nArray = [|1. .. 100.|]

// Task 2.2
// Binde das Element mit dem Wert 33. an einen Namen.
let wert33_1 = Array.item 32 nArray
let wert33_2 = nArray.[32]
let wert33_3 = nArray |> Array.find (fun x -> x = 33.)

// Task 2.3
// Addiere das Namebinding mit dem Wert 33. auf jedes Element in dem Array.
Array.map (fun x -> x + wert33_2) nArray



// Task 3.1
// Erstelle Sequenzen aus der Liste und dem Array mit den Werten von 1 - 100. Achte dabei darauf, dass am Ende beide Sequenzen Elemente des selben
// Datentypen (int oder float) enthalten sollen. Binde die Ergebnisse wieder an je einen Namen.

let nList2Seq =
    nList
    |> Seq.ofList
    |> Seq.map float

let nArray2Seq =
    nArray
    |> Seq.ofArray 


// Task 3.2
// Fuege die beiden Sequenzen aus 3.1 zu einer Sequenz zusammen.
Seq.append nList2Seq nArray2Seq

// Task 4.1
// Erstelle eine Map die alle Monate enthaelt. Verwende dafuer die Zahl des Monats (Integer) als Key und den Namen (String) als Value.

let monthMap =
    Map [
            1 ,"Januar"
            2 ,"Februar"
            3 ,"März"
            4 ,"April"
            5 ,"Mai"
            6 ,"Juni"
            7 ,"Juli"
            8 ,"August"
            9 ,"September"
            10,"Oktober"
            11,"November"
            12,"Dezember"
        ]

// Task 4.2
// ueberpruefe anhand des Keys, ob der Monat Maerz in der Map vorhanden ist.
Map.containsKey 3 monthMap
monthMap.ContainsKey 3

// Task 4.3
// Deklariere eine Funktion, mit deren Hilfe du dir einen Value aus einer Map mit Integern als Key ueber den Key holen kannst.
let getValuesFromKey key (map:Map<int,string>) =
    //map.Item key //Version1
    
    //map.[key] //Version2
    
    //Map.tryFind key map //Version3
    //|> fun x -> x.Value
    
    map
    |> Map.find key

// Task 4.4
// ueberpruefe, ob die Map aus 4.1 einen Monat mit mehr als sieben Buchstaben enthaelt.
monthMap
|> Map.filter (fun k v -> v.Length > 7)
|> Map.isEmpty
|> not

monthMap
|> Map.exists (fun _ value -> value.Length > 7)

// Task 4.5
// Teile die Map aus 4.1 in zwei neue Maps, eine mit Monaten die mehr als sieben Buchstaben haben und eine die Monate mit weniger als sieben Buchstaben enthaelt.
let monthsOver7Chars =
    monthMap
    |> Map.filter (fun key value -> value.Length > 7)

let monthsUnder7Chars =
    monthMap
    |> Map.filter (fun key value -> value.Length < 7)

let (m1,m2) =
    monthMap
    |> Map.partition (fun x y -> y.Length < 7)
    |> fun (over,under) ->                                                      // in der Fragestellung wird nach größer und kleiner 7 gefragt (nicht <= )
        let filterOctober = over |> Map.filter(fun _ value -> value.Length < 7) // in der Fragestellung wird nach größer und kleiner 7 gefragt (nicht <= )
        filterOctober,under                                                     // in der Fragestellung wird nach größer und kleiner 7 gefragt (nicht <= )

// Task 5.1
// Erstelle zwei Sets. Eins mit Zahlen von 1 - 10 und eins mit Zahlen von 3 - 7 und binde sie an je einen Namen.
let set1 = Set [1..10]
let set2 = Set [3.. 7]

// Task 5.2
// Erstelle zwei weitere Sets aus den beiden vorher definierten Sets und binde sie an je einen Namen. Ein Set soll alle Elemente enthalten, die in beiden Sets
// vorkommen, das andere alle Elemente die nur in jeweils einem Set vorkommen.

let set1InterSet2 =      Set.intersect  set1 set2
let set1DifferenceSet2 = Set.difference set1 set2

// Task 6.1
// Nimm die Liste aus 1.1 und addiere alle enthaltenen Zahlen aufeinander. Das Ergebnis soll vom Typ Int sein. Verwende dafuer nicht die Funktionen List.Sum oder List.SumBy.
List.fold (fun acc x -> acc + x) 0 nList
List.fold (+)                    0 nList


// Task 6.2
// Nimm wieder die Liste aus 1.1. Gib alle Zahlen in der Liste als einen kontinuierlichen String ohne Separator aus.
nList |> List.fold (fun accString x -> accString + string x) ""

// Task 7.1
// Deklariere eine Funktion die einen String nach allen n Characters unterteilt, so dass der Output ein Array von Strings ist.
// Sollte ein Rest bleiben, soll der letzte String kuerzer sein. 
// Bsp. fuer n=3: "Maiskolben" -> [|"Mai";"sko";"lbe";"n"|]


let getChunks size (str:string) = 
    str
    |> Seq.chunkBySize size
    |> Seq.map System.String.Concat
    |> Array.ofSeq
    
getChunks 3 "Maiskolben"

// Task 7.2
// Deklariere eine Funktion, die als Parameter einen String einer RNA-Sequenz erhaelt. Die Funktion soll die RNA-Sequenz in Proteine
// bueersetzen und die einzelnen Proteine als Array von Strings ausgeben. Um nicht alle Moeglichkeiten verwenden zu muessen, verwende
// die folgende Auswahl an Codons:
// "AUG", "Methionin"
// "UUU", "Phenylalanin"
// "UUC", "Phenylalanin"
// "UUA", "Leucin"
// "UUG", "Leucin"
// "UCU", "Serin"
// "UCC", "Serin"
// "UCA", "Serin"
// "UCG", "Serin"
// "UAU", "Tyrosin"
// "UAC", "Tyrosin"
// "UGU", "Cystein"
// "UGC", "Cystein"
// "UGG", "Tryptophan"
// "UAA", "STOP"
// "UAG", "STOP"
// "UGA", "STOP"
// Teste die Funktion mit dem String "AUGUUUUCUUAA"

let getAminoAcids (rna: string) =

    let codonsToAcids =
        Map [
            "AUG", "Methionin"
            "UUU", "Phenylalanin"
            "UUC", "Phenylalanin"
            "UUA", "Leucin"
            "UUG", "Leucin"
            "UCU", "Serin"
            "UCC", "Serin"
            "UCA", "Serin"
            "UCG", "Serin"
            "UAU", "Tyrosin"
            "UAC", "Tyrosin"
            "UGU", "Cystein"
            "UGC", "Cystein"
            "UGG", "Tryptophan"
            "UAA", "STOP"
            "UAG", "STOP"
            "UGA", "STOP"
            ]
    getChunks 3 rna
    |> Seq.map (fun x -> codonsToAcids.[x])
    
getAminoAcids "AUGUUUUCUUAA"

// Task 7.3
// Erweitere die Funktion aus 8.2 um folgende Funktionalitaet: Beginne mit der Uebersetzung sobald das erste Methionin auftaucht
// und hoere auf zu uebersetzen, sobald ein Stopcodon auftaucht.
// Verwende zum Testen den String "UGGUUUAUGUUUUCUUAAAUGUCG"


let getAminoAcids2 (rna: string) =

    let codonsToAcids =
        Map [
            "AUG", "Methionin"
            "UUU", "Phenylalanin"
            "UUC", "Phenylalanin"
            "UUA", "Leucin"
            "UUG", "Leucin"
            "UCU", "Serin"
            "UCC", "Serin"
            "UCA", "Serin"
            "UCG", "Serin"
            "UAU", "Tyrosin"
            "UAC", "Tyrosin"
            "UGU", "Cystein"
            "UGC", "Cystein"
            "UGG", "Tryptophan"
            "UAA", "STOP"
            "UAG", "STOP"
            "UGA", "STOP"
            ]

    //suche die Sequenz nach dem Startcodon ab und gib die Sequenz ab diesem Codon zurück
    let sequenceFromStartCodon =
        let startCodonIndex = rna.IndexOf ("AUG")
        rna.[startCodonIndex ..]

    //bilde Subsequenzen aus je 3 Basen
    let chunks = 
        getChunks 3 sequenceFromStartCodon

    //suche innerhalb dieser Sequenz den Index des ersten Stopcodons
    let stopIndex = 
        Array.findIndex (fun x -> x = "UAA" || x = "UAG"|| x = "UGA") chunks
    
    //lösche alle Codons, die nach dem ersten Stopcodon auftreten und übersetze sie mittels der Map
    chunks.[0..stopIndex] //wenn das stopcodon schon nicht mehr übersetzt werden soll chunks.[0..stopIndex-1]
    |> Seq.map (fun x -> codonsToAcids.[x])

getAminoAcids2 "UGGUUUAUGUUUUCUUAAAUGUCG"
|> Array.ofSeq

