# Magrin_Orario
# Progetto Orario - Magrin

**Studente:** Magrin Alessandro
**Classe:** 3AII

## Descrizione del Progetto
Il progetto consiste in una classe denominata Orario che può svolgere varie funzionalità
come l'addizione e la sottrazione ma anche per esempio la normalizzazione di un messaggio
e molte altre funzionalità.

## Funzionalità Implementate
- **Campi Privati:**  Ore, minuti e secondi.
- **Costruttori:**
  - Con parametri (ore, minuti, secondi) con normalizzazione.
  - Da secondi totali (conversione da intero a orario).
- **Property:** `Ore`, `Minuti`, `Secondi` con setter che richiamano automaticamente il metodo di normalizzazione.
- **Overload Operatori:**
  - Matematici: `+`, `-`, `*`.
  - Logici/Confronto: `==`, `!=`, `>`, `<`.
- **Metodi di Istanza:**
  - `ToString()`: Formattazione professionale `HH:MM:SS`.
  - `ToSecondi()`: Conversione dell'orario in secondi totali.
  - `Aggiungi(secondi)` e `Aggiungi(ore, min, sec)`: Metodi in overload per sommare tempo.
- **Metodo Statico:**
  - `Confronta(a, b)`: Restituisce l'istanza con l'orario cronologicamente maggiore.

 ##Difficoltà incontrate
 Ho avuto alcune difficoltà soprattutto a impostare l'esercizio e settare tutte le property ai parametri giusti
 e anche a capire come scrivere l'output perchè bisognava scrivere sempre cose differenti e ci ho messo molto a 
 capire come scriverlo
 

## Esempio di Utilizzo ed Output
Il programma principale esegue diversi test di calcolo e confronto. Di seguito un esempio di output generato (come da esecuzione su console):



```text
Tempo 1:
16:12:22
Tempo 2:
13:43:12

Somma:
05:55:34
Sottrazione:
02:29:10

Uguali:
False
Maggiori:
True

AggiungiSecondi(50):
16:13:12
AggiungiTempoTotale(1,5,3):
17:17:25

Confronto:
16:12:22
Aggiunto 70 minuti:
17:10:22
