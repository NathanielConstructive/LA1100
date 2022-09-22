# Projekt-Dokumentation

 Mirhan Özden

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   |                                                              |
| 1.09/8.09| 0.9.0     |  Ich habe mein Programm fertig gecoded                  |
| 22.09.2022| 1.0.0   | Ich arbeite am Punkt 5 weiter.                           |

## 1 Informieren

### 1.1 Ihr Projekt

 In meinem Programm muss man die zufällig Generierte Zahl erraten.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|  0   |                 |      |Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️|
|  1   | muss            | AF   |Als spieler möchte ich dass der Computer eine Zahl zwischen 1 und 100 speichert, damit Ich raten kann.|
|  2   | muss            | AF   |Als Spieler möchte ich dass ich raten kann, damit ich überhaupt spielen kann.|
|  3   | muss            | QAF  |Als Spieler möchte ich dass mir gezeigt wird ob ich zu viel oder zuwenig geraten habe, um zu wissen in welche Richtung ich raten soll.|
|  4   | muss            | AF   | Als Spieler möchte ich dass mir gesagt wird ob ich richtig liege, damit ich sicher bin dass ich fertig bin.|
|  5   | kann            | QAF  |Als Spieler möchte ich dass mir gesagt wird viele Versuche ich brauchte, um mein Glück zu kennen|                 
|  6   | kann            | KAF  | Als Spieler möchte ich dass die falsch eingegebenen Zahlen vermieden werden, damit das Programm richtig funktioniert|      
|  7   | kann            | QAF  |Als Spieler möchte ich neue Features damit das Programm spass macht. Zum Beispiel fabrige Wörter.|





### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  projekt gestartet | Play| Erscheinung des Programms|
| 2.1  | eingabe Zahl |  3      |  falsch mehr      |
| 3.1  | eingabe höhrere Zahl| 50 |  falsch weniger     |
| 4.1  | eingabe kleinere Zahl | 43      |  Richtig     |
| 5.1  | Programm fast zuende      | enter   |  Sie haben ... Versuche gebraucht     |
| 6.1  |  Eingabe Buchstabe |    g    | Erneut fragen           |




### 1.4 Diagramme


![Screenshot 2022-08-25 090044](https://user-images.githubusercontent.com/111046193/186597295-b20527dc-8f5d-432c-a5f8-5af200c65a3a.png)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1    | 1.9   | ich       | Computer generiert Die Frage und mann kann eingeben|   45 Minuten|
| 2.   | 1.9   | ich       |  Computer bestimmt eine Zahl             |   45 Minuten  |
| 3    | 1.9   | ich       | Eine Eingabe                             |   45 Minuten  |
| 4    | 1.9   | ich       | Möglichkeit raten                        |   45 Minuten  |
| 5    | 1.9   | ich       |  angezeigt ob zuwenig                    |   45 Minuten  |
| 6    | 1.9   | ich       |  angezeigt ob zuviel                     |   45 Minuten  |
| 7    | 1.9   | ich       | angezeigt gewonnen                       |   45 Minuten  |
| 8    | 1.9   | ich       | wieviele versuche                        |   45 Minuten  |
| 9    | 1.9   | ich       |  eingaben die nicht mö. sind vermeiden   |   45 Minuten  |
| 10   | 1.9   | ich       |   nochmals wie bei der 9 (verbesserung)  |   45 Minuten  |
| 11   | 1.9   | ich       |   alles anschauen                        |   45 Minuten  |
| 12   | 1.9   | ich       |   Wenn Zeit, fragen ob noch eine Runde   |   45 Minuten  |

Total: 

## 3 Entscheiden

Ich habe mich entschieden, dass ich zum Beispiel einen farbige Buchstane einfüge, damit die Seite anschaulicher wirkt. Ich möchte auch dass ein Text entsteht falls jemand etwas anderes als eine Zahl zwischen 1-100 eingibt. Das wichtigste ist, dass der Computer eine richtige Zahl wählt und falls man richtig ist ein Gratulationstext entseht, sodass man sieht dass man gewonnen hat.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 1.09  |Zahl generieren | 45       |     20            |
| 1.(A)| 1.09  | Nach Zahl fragen  |    50 |     25            |
| 1.B  | 1.09  | Widerholen wenn keine richtige Zahl           |   50          |     30            |
| 1.C  | 1.09  | Wenn zu hoch dies sagen          |  15        | 10                  |
| 1.D  | 1.09  |  Wenn zu niedrig dies sagen      |  10        | 5                  |
| 1.E  | 1.09  | Wenn richtig gratulieren         |  10        | 10                  |
| 1.F  | 1.09  | Wenn fertig die Versüche aufzählen |   20     | 20                 |
| 1.G  | 1.09  | Fragen ob noch eine Runden     |      35      |  20           |
| 1.H  | 8.09  |Neustart   |  50           |  50               |
| 1.I  | 8.09  | Namen Fragen  | 60        |  35               |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.09 | funktioniert | Mirhan Özden |
| 2.1  | 22.09 | funktioniert | Mirhan Özden |
| 3.1  | 22.09 | funktioniert | Mirhan Özden |
| 4.1  | 22.09 | funktioniert | Mirhan Özden |
| 5.1  | 22.09 | funktioniert | Mirhan Özden |
| 6.1  | 22.09 | funktioniert | Mirhan Özden |
| 7.1  | 22.09 | funktioniert | Mirhan Özden |

       

Mein Fazit ist, dass mein Programm so rausgekommen ist wie ich es mir erhofft habe, das Planen versuche ich jedoch zu verbessern, damit ich strukturierter arbeiten kann. 

## 6 Auswerten


