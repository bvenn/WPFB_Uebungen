
//      Excercise 2


//************************************************************************************
//*                                                                                  *
//* Datentypen und Funktionen                                                        * 
//*                                                                                  *
//************************************************************************************


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////      TASKS for Excercise 2       ///////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//++++++++++++++++++++++++++++
//          Tuples
//++++++++++++++++++++++++++++

// Task 1.1:  -----------------------------------------------------------------------------------------
// Deklariere einen Tuple aus 2. und "Februar" und bindet den Tuple an den Namen 'tuple1'

let tuple1 = (2.,"Februar")

// Task 1.2:  -----------------------------------------------------------------------------------------
// Deklariere einen Tuple aus 2., "Februar" und "Fruehling"
let triple = 2.,"Februar","Frühling"


// Task 1.3:  -----------------------------------------------------------------------------------------
// Greife auf die zweite Variable des Tuples aus 1.1 zu

snd tuple1
tuple1 |> fun (a,b) -> b

// Task 1.4:  -----------------------------------------------------------------------------------------
// Greife auf die zweite Variable des Tuples aus 1.2 zu

triple |> fun (_,b,_) -> b

// Task 1.4:  -----------------------------------------------------------------------------------------
// Bindet 'tuple1' aus Task 1.1 an: (output1,output2)
// Warum kann das sinnvoll sein?

let (output1,output2) = tuple1

//++++++++++++++++++++++++++++
//      Record Types
//++++++++++++++++++++++++++++

// Task 2.1
// Definiere einen Record Type mit dem Namen 'Person1'. Person1 soll die Felder 'Name'(string) und 'Alter'(int) haben.
type Person1 = {
    Name : string
    Alter : int
    }


// Task 2.2
// Definiere einen weiteren Record Type mit dem Namen 'Person2'. Person2 soll die gleichen Felder wie Person1
// haben, bekommt aber noch das zusaetzliche Feld 'Hobby'. Da man alles zu seinem Hobby machen kann, soll
// 'Hobby' vom Typ generic type sein.

type Person2<'a> = {
    Name : string
    Alter : int
    Hobby : 'a
    }

// Task 2.3
// Deklariere eine Funktion die zwei Inputparameter erhaelt und als Rueckgabewert eine Person1 gibt.
// Binde ein Ergebnis dieser Funktion an den Namen 'meinePerson1'

let createPerson1 name alter = {
    Name=name
    Alter=alter}

let meinePerson1 = createPerson1 "Hans" 12

// Task 2.4
// Deklariere eine Funktion die drei Inputparameter erhaelt und als Rueckgabewert eine Person2 gibt.
// Binde ein Ergebnis dieser Funktion an den Namen 'meinePerson2'. Benutze als Input fuer die Felder
// die auch bei Person1 existieren die Werte von meinePerson1.

let createPerson2 name alter hobby=
    {
    Name=name
    Alter=alter
    Hobby = hobby}

let meinePerson2 = createPerson2 meinePerson1.Name meinePerson1.Alter ["Tennis";"Schach"]

//++++++++++++++++++++++++++++
//  Functional composition   +
//++++++++++++++++++++++++++++

// Task 3.1
// Die Funktion 'calculate' soll zwei Floats x und y miteinander verrechnen. Dafuer soll zuerst x - y berechnet werden und die
// daraus entstehende Differenz soll verdoppelt werden.
// Aber irgendentwas stimmt mit dem Ergebnis nicht. ueberlege warum und korrigiere die Aufgabe ohne die Operatoren zu aendern.

let calculate x y =
    y
    |> (-) x
    |> (*) 2.

calculate 2. 3.

// Task 3.1
// Schreibe die folgende Funktion so um, dass sie den 'Compose' statt dem 'Pipe' Operator verwendet
let chainOfCalculations x =
    x
    |> int
    |> (*) 2
    
let chainOfCalculations2 =
    int >> (fun x -> x * 2)
    
let chainOfCalculations3 x =
    (int >> (*) 2) x
    

// Task 3.3
// Deklariere eine Funktion mit 3 Inputparametern, zwei generischen Funktionen und einem generischen Wert.
// Die Funktion soll die gleiche Funktionalitaet wie der Compose Operator (>>) besitzen.
// Beispiel: compose fun1 fun2 wert = (fun1 >> fun2) wert

let compose f1 f2 v =    
    f2 (f1 v)
    



// Task 3.4
// Oh nein, die folgende Funktion ist ja total unleserlich! Schreib sie neu mit Pipe Operatoren!

let unleserlicheFunktion x = 
    (System.Double.Parse ((string (((*) 2. ((fun value -> value * 2.) x))**2.)) + "14"))

let leserlicheFunktion x =
    x
    |> fun i -> i * 2. //oder (*) 2.
    |> fun k -> k * 2. //oder (*) 2.
    |> fun g -> g ** 2.
    |> string
    |> fun h -> h + "14"
    |> System.Double.Parse
    
unleserlicheFunktion  12.
leserlicheFunktion 12.

//++++++++++++++++++++++++++++
//   Higher Order Functions
//++++++++++++++++++++++++++++

// Task 4.1
// Deklariere eine anonyme Funktion die zwei Parameter bekommt und sie addiert. Binde sie an den Namen 'add'.
// Wende 'add' auf zwei Integer an.

let add = (fun x y -> x + y)

add 5 6

// Task 4.2
// Deklariere eine beliebige Funktion mit der Signatur 'int -> int -> (int -> int -> int) -> float'.

let foobar (x:int) (y:int) f :float =
    f x y
    |> float


    
