
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



// Task 1.2:  -----------------------------------------------------------------------------------------
// Deklariere einen Tuple aus 2., "Februar" und "Fruehling"



// Task 1.3:  -----------------------------------------------------------------------------------------
// Greife auf die zweite Variable des Tuples aus 1.1 zu



// Task 1.4:  -----------------------------------------------------------------------------------------
// Greife auf die zweite Variable des Tuples aus 1.2 zu



// Task 1.4:  -----------------------------------------------------------------------------------------
// Bindet 'tuple1' aus Task 1.1 an: (output1,output2)
// Warum kann das sinnvoll sein?

//++++++++++++++++++++++++++++
//      Record Types
//++++++++++++++++++++++++++++

// Task 2.1
// Definiere einen Record Type mit dem Namen 'Person1'. Person1 soll die Felder 'Name'(string) und 'Alter'(int) haben.



// Task 2.2
// Definiere einen weiteren Record Type mit dem Namen 'Person2'. Person2 soll die gleichen Felder wie Person1
// haben, bekommt aber noch das zusaetzliche Feld 'Hobby'. Da man alles zu seinem Hobby machen kann, soll
// 'Hobby' vom Typ generic type sein.



// Task 2.3
// Deklariere eine Funktion die zwei Inputparameter erhaelt und als Rueckgabewert eine Person1 gibt.
// Binde ein Ergebnis dieser Funktion an den Namen 'meinePerson1'



// Task 2.4
// Deklariere eine Funktion die drei Inputparameter erhaelt und als Rueckgabewert eine Person2 gibt.
// Binde ein Ergebnis dieser Funktion an den Namen 'meinePerson2'. Benutze als Input fuer die Felder
// die auch bei Person1 existieren die Werte von meinePerson1.



//++++++++++++++++++++++++++++
//  Functional composition   +
//++++++++++++++++++++++++++++

// Task 3.1
// Die Funktion 'calculate' soll zwei Floats x und y miteinander verrechnen. Dafuer soll zuerst x - y berechnet werden und die
// daraus entstehende Differenz soll verdoppelt werden.
// Aber irgendentwas stimmt mit dem Ergebnis nicht. ueberlege warum und korrigiere die Aufgabe ohne die Operatoren zu aendern.

let calculate x y =
    x
    |> (-) y
    |> (*) 2.

// Task 3.1
// Schreibe die folgende Funktion so um, dass sie den 'Compose' statt dem 'Pipe' Operator verwendet

let chainOfCalculations x =
    x
    |> int
    |> (*) 2

// Task 3.3
// Deklariere eine Funktion mit 3 Inputparametern, zwei generischen Funktionen und einem generischen Wert.
// Die Funktion soll die gleiche Funktionalitaet wie der Compose Operator (>>) besitzen.
// Beispiel: compose fun1 fun2 wert = (fun1 >> fun2) wert



// Task 3.4
// Oh nein, die folgende Funktion ist ja total unleserlich! Schreib sie neu mit Pipe Operatoren!

let unleserlicheFunktion x = (System.Double.Parse ((string (((*) 2. ((fun value -> value * 2.) x))**2.)) + "14"))


//++++++++++++++++++++++++++++
//   Higher Order Functions
//++++++++++++++++++++++++++++

// Task 4.1
// Deklariere eine anonyme Funktion die zwei Parameter bekommt und sie addiert. Binde sie an den Namen 'add'.
// Wende 'add' auf zwei Integer an.



// Task 4.2
// Deklariere eine beliebige Funktion mit der Signatur (int -> int -> (int -> int -> int) -> float).
