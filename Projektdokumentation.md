# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Mirhan Özden

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ In meinem Programm muss man die zufällig Generierte Zahl erraten.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |                 |      | Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️ |
|      |                 |      |                                    |
| 2    |  muss           | AF   |Als spieler möchte ich dass der Computer eine|
|      |                 |      |   Zahl zwischen 1 und 100 speichert, damit Ich raten kann.  |
|3     |  muss           | AF   |Als Spieler möchte ich dass ich raten kann, damit ich überhaupt spielen kann.|
|      |                 |      |
| 4    |   kann          | QAF  |Als Spieler möchte ich dass mir gezeigt wird ob|
|      |                 |      |   ich zu viel oder zuwenig geraten habe, um zu wissen in welche Richtung ich raten soll.|
|      |                 |      |
|  5   | muss            | AF   | Als Spieler möchte ich dass mir gesagt wird ob|
|      |                 |      |  ich richtig liege, damit ich sicher bin dass ich fertig bin.  |
|  6   |     kann        | QAF  |Als Spieler möchte ich dass mir gesagt wird viele Versuche ich brauchte, um mein Glück zu kennen|                 
|      |                 |      |
|  7   |      kann       | KAF  | Als Spieler möchte ich dass die falsch eingegebenen Zahlen vermieden werden, damit die Website richtig funktioniert|
|  8   |     kann        | QAF  |Als Spieler möchte ich neue Features damit das Programm|
|      |                 |      |spass macht.                                           |


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  projekt gestartet | Play| Erscheinung des Programms|
| 1.2  | eingabe Zahl |  3      |  falsch mehr      |
| 1.3  | eingabe höhrere Zahl| 50 |  falsch weniger     |
| 1.4  | eingabe kleinere Zahl | 43      |  Richtig     |
| 1.5  | Programm fast zuende      | enter   |  Sie haben ... Versuche gebraucht     |
| 1.6  |              |        |                    |
| 1.7  |              |        |                    |


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.




![Screenshot 2022-08-25 090044](https://user-images.githubusercontent.com/111046193/186597295-b20527dc-8f5d-432c-a5f8-5af200c65a3a.png)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 1.9   | ich       | Computer generiert                       |   45 Minuten  |
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

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Ich habe mich entschieden, dass ich zum Beispiel einen farbigen Enterbutton einfüge, damit die Seite anschaulicher wirkt. Ich möchte auch dass ein Text entsteht falls jemand etwas anderes als eine Zahl zwischen 1-100 eingibt. Das wichtigste ist, dass der Computer eine richtige Zahl wählt und falls man richtig ist ein Gratulationstext entseht, sodass man sieht dass man gewonnen hat.

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







✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
