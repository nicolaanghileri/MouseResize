# Mouse Resizie - Diario di lavoro - Nicola Anghileri
### Centro professionale di Trevano 28.10.2021

## Lavoro

|Orario        |Lavoro svolto                                     
|--------------|------------------------------------------------- |
|10:50 - 14:15 | Prove di lavoro sulla logica di "hotkey premuta allora fai..."  |
|14:15 - 14:45 | Implementazione della soluzione trovata all'interno del codice pricipale "main.ahk" |
|15:00 - 16:30 | Aggiunta della parte di codice già fatta per lo spostamento della finestra, all'interno della logica creata al mattino, da comunque degli errori. |


## Problemi riscontrati

1. Ho auto problemi con la lettura di una variabile all'interno di una funzione, con il sore abbiamo scoperto che le funzioni danno problemi con le Hotkey.

2. Anche se SOLO una volta premuto l'hotkey veniva invocato il label, esso si auto invoca.

## Soluzioni adottate

1. Ho creato un label al posto di una funzione e tutto funzionava correttamente.

2. I label si auto-invocano di default, per evitare questo bisogno suddividere il codice in 2 parti che per adesso sono : la prima parte è di assegnamento di variabili globali ecc.. e nella seconda parte dopo la keyword "RETURN;" non verrà più auto-invocato nulla ma sono se richiamate da un label ecc...

## Punto della situazione rispetto alla pianificazione
Per adesso mi trovo ancora più avanti del previso, se il lavoro continua così avrò tempo in abbondanza per fare tutto il progetto come si deve.

## Programma di massima per la prossima giornata di lavoro
Nessun programma di massima per la prossima lezione ma se si riesce a finire l'implementazione dello spostamento della finestra all'interno del codice principale sarebbe bello, e poi almeno iniziare con il capire la logica per fare il resize della pagina, tanto parte della logica che c'è bisogno, già è stata fatta per lo spostamento della pagina quindi basterà riutilizzare il codice scritto in precedenza.