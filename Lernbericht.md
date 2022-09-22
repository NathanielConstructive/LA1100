# Lern-Bericht
Mirhan Özden

## Einleitung

Im LA hatten wir die Aufgabe ein Programm zu coden, wo der Benutzer die Zahlen erraten muss.

## Was habe ich gelernt?

In meinem Projekt beziehungsweise in meinem Programm habe ich gelernt wie man zufällige Zahlen generieren lässt und wie man den Benutzer fragt, ob er noch eine Runde spielen, möchte.

## Beschreibung


Ich habe gelernt wie man den Benutzer fragt ob er noch eine Runde spielen möchte.


* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme


```Csharp

char eingabe;

Console.WriteLine("Geben Sie j oder J ein um das Programm neuzustarten oder schliesse es mit n oder N");
eingabe = Convert.ToChar(Console.ReadLine());

// Es wird gefragt ob man das Programm wiederholen möchte oder nicht. 
  
if (eingabe == 'J' || eingabe == 'j')
{
    goto start;
}

// Entweder Ja oder Nein je nach dem ob man spielen möchte oder nicht.

if (eingabe == 'N' || eingabe == 'n')
{
    Environment.Exit(0);

}
```
![Alt Text](https://user-images.githubusercontent.com/111046193/191688671-9eb649c2-4958-45e0-855c-f4afb9e8abf5.png)


## Verifikation

✍️
  Text:        1. In meinem Text wird gezeigt was ich gelernt habe
   
  Code:        2. In meinem Code Fetzen wird spezifisch gezeigt was ich programmiert habe.
         
  Bild:        3. Das Bild zeigt nochmals auf wie mein Code in meinem Programm geschrieben wurde.
   
   
# Reflexion zum Arbeitsprozess

***Was lief gut?***
👍
 - Ich habe die Mindestanforderungen in meinem Code sehr schnell programmieren können.

***Was lief schlecht?***
👎
 - Was nicht so gut lief, war dass ich oft unmotiviert und verplant war, das heisst ich wusste nicht was ich zu welcher Zeit machen sollte.

**VBV**:
Ein Verbesserungsvorschlag wäre, dass ich mir die Zeiten besser einteilen lasse. Wegen der Unmotivation kann man leider nichts machen.
