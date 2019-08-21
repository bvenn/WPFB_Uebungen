// Task 1.1
// Erstelle eine Int Liste mit den Zahlen 1 - 100 und binde sie an einen Namen.


// Task 1.2
// Binde das erste und das letzte Element der Liste an je einen Namen.


// Task 1.3
// Fuege das erste Element dem Ende der Liste, und das letzte Element dem Anfang der Liste hinzu.
// Binde das ganze erneut an einen Namen.


// Task 2.1
// Erstelle einen Float Array mit den Zahlen von 1. - 100. und binde ihn an einen Namen.


// Task 2.2
// Binde das Element mit dem Wert 33. an einen Namen.


// Task 2.3
// Addiere das Namebinding mit dem Wert 33. auf jedes Element in dem Array.


// Task 3.1
// Erstelle Sequenzen aus der Liste und dem Array mit den Werten von 1 - 100. Achte dabei darauf, dass am Ende beide Sequenzen Elemente des selben
// Datentypen (int oder float) enthalten sollen. Binde die Ergebnisse wieder an je einen Namen.


// Task 3.2
// Fuege die beiden Sequenzen aus 3.1 zu einer Sequenz zusammen.


// Task 4.1
// Erstelle eine Map die alle Monate enthaelt. Verwende dafuer die Zahl des Monats (Integer) als Key und den Namen (String) als Value.


// Task 4.2
// ueberpruefe anhand des Keys, ob der Monat Maerz in der Map vorhanden ist.


// Task 4.3
// Deklariere eine Funktion, mit deren Hilfe du dir einen Value aus einer Map mit Integern als Key ueber den Key holen kannst.


// Task 4.4
// ueberpruefe, ob die Map aus 4.1 einen Monat mit mehr als sieben Buchstaben enthaelt.


// Task 4.5
// Teile die Map aus 4.1 in zwei neue Maps, eine mit Monaten die mehr als sieben Buchstaben haben und eine die Monate mit weniger als sieben Buchstaben enthaelt.


// Task 5.1
// Erstelle zwei Sets. Eins mit Zahlen von 1 - 10 und eins mit Zahlen von 3 - 7 und binde sie an je einen Namen.


// Task 5.2
// Erstelle zwei weitere Sets aus den beiden vorher definierten Sets und binde sie an je einen Namen. Ein Set soll alle Elemente enthalten, die in beiden Sets
// vorkommen, das andere alle Elemente die nur in jeweils einem Set vorkommen.


// Task 6.1
// Nimm die Liste aus 1.1 und addiere alle enthaltenen Zahlen aufeinander. Das Ergebnis soll vom Typ Int sein. Verwende dafuer nicht die Funktionen List.Sum oder List.SumBy.


// Task 6.2
// Nimm wieder die Liste aus 1.1. Gib alle Zahlen in der Liste als einen kontinuierlichen String ohne Separator aus.


// Task 7.1
// Deklariere eine Funktion die einen String nach allen n Characters unterteilt, so dass der Output ein Array von Strings ist.
// Sollte ein Rest bleiben, soll der letzte String kuerzer sein. 
// Bsp. fuer n=3: "Maiskolben" -> [|"Mai";"sko";"lbe";"n"|]


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


// Task 7.3
// Erweitere die Funktion aus 8.2 um folgende Funktionalitaet: Beginne mit der Uebersetzung sobald das erste Methionin auftaucht
// und hoere auf zu uebersetzen, sobald ein Stopcodon auftaucht.
// Verwende zum Testen den String "UGGUUUAUGUUUUCUUAAAUGUCG"