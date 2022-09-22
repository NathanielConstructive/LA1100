# Lern-Bericht
Mirhan Özden

## Einleitung

In meinem Projekt ging es darum, einen Zahlenerrater zu coden.

## Was habe ich gelernt?

In meinem Projekt beziehungsweise in meinem Programm habe ich gelernt wie man zufällige Zahlen generieren lässt und wie man den Benutzer fragt, ob er noch eine Runde spielen, möchte.

## Beschreibung

✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

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
![image](https://user-images.githubusercontent.com/111046193/191688671-9eb649c2-4958-45e0-855c-f4afb9e8abf5.png)


## Verifikation

✍️1. In meinem Text wird gezeigt was ich gelernt habe
   
   2. In meinem Code Fetzen wird spezifisch gezeigt was ich programmiert habe.
         
   3. Das Bild zeigt nochmals auf wie mein Code in meinem Programm geschrieben wurde.
   
   
# Reflexion zum Arbeitsprozess

👍 Ich habe die Mindestanforderungen in meinem Code sehr schnell programmieren können.

👎 Was nicht so gut lief, war dass ich oft unmotiviert und verplant war, das heisst ich wusste nicht was ich zu welcher Zeit machen sollte.

**VBV**: Ein Verbesserungsvorschlag wäre, dass ich mir die Zeiten besser einteilen lasse. Wegen der Unmotivation kann man leider nichts machen.
