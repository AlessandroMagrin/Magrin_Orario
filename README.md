# PARTE 1

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



# PARTE 2

  <img width="1919" height="1028" alt="Screenshot 2026-05-17 163124" src="https://github.com/user-attachments/assets/fd8c24d1-c62f-48c2-bdc1-c7f1db40e4e1" />


### Struttura della GUI e Gruppi di Controlli

L'interfaccia grafica è stata progettata seguendo un flusso logico e gerarchico dall'alto verso il basso per facilitare l'esperienza d'uso:

1. **Display Digitale Superiore (`lblDigitale`)**: Una Label di grandi dimensioni con font monospaced (*Consolas*, minimo 36pt) posizionata in primo piano. Mostra l'orario dinamico o statico con i due punti (`:`) che si alternano a uno spazio vuoto ogni secondo per simulare l'effetto lampeggiante degli orologi digitali.
2. **Gruppo A — Gestione Orario Principale**:
   * **Controlli di Input**: Tre caselle di testo separate (`txtOreA`, `txtMinutiA`, `txtSecondiA`) dedicate alla configurazione manuale.
   * **Pulsanti di Controllo**: 
     * `btnImposta`: Legge i dati inseriti, disattiva temporaneamente il Timer e fissa l'orario sul display sfruttando la normalizzazione automatica dei fuori range prevista dalla classe `COrario`.
     * `btnOraCorrente`: Ripristina l'ora reale del computer leggendo il modulo `DateTime.Now` e riavvia il Timer di aggiornamento.
     * `btnAzzeraOra`: Blocca l'orologio reimpostando l'oggetto principale a `00:00:00`.
   * **Timer di Sistema (`timer1`)**: Componente in background configurato con `Interval = 1000` (1 secondo) che agisce come generatore di eventi continui per aggiornare lo stato del display in tempo reale.
3. **Gruppo B — Operazioni e Confronti (GroupBox)**:
   * **Controlli di Input**: Tre caselle di testo dedicate al secondo orario (`txtOreB`, `txtMinutiB`, `txtSecondiB`) e una casella singola (`txtMoltiplica`) per accogliere il fattore intero di moltiplicazione.
   * **Pulsanti di Calcolo**: Quattro pulsanti dedicati (`btnSomma`, `btnDifferenza`, `btnMoltiplica`, `btnMaggiore`) che applicano gli operatori matematici e di confronto sovraccaricati della classe logica.
   * **Output dei Risultati (`lblRisultato`)**: Label informativa dinamica che stampa a schermo il risultato formattato dell'operazione matematica o le stringhe testuali di confronto e di errore.

### ⚠️ Difficoltà Incontrate e Soluzioni

 
 **Sincronizzazione del Lampeggio senza alterazione dei Dati Puri**:
   * *Difficoltà*: Realizzare il lampeggio intermittente dei due punti senza sporcare o mutare i dati temporali memorizzati nell'istanza dell'oggetto `_orarioA`.
   * *Soluzione*: È stata creata una variabile di stato booleana `_lampeggio` interna alla Form. Ad ogni evento `Tick`, la variabile inverte il suo valore logico     e, tramite l'operatore ternario, decide se stampare il carattere `:` o lo spazio vuoto `" "`, preservando intatta la struttura dei numeri nell'oggetto.


