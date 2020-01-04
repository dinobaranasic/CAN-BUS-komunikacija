# Primjer CAN BUS komunikacije. 

Jednostavna komunikacija prema unosu korisnika. U izradi...

Komunikacija je zamišljena tako da korisnik upiše CAN ID i Payload te prema vrsti tipke pošalje Payload na drugi CAN ID.

## Unos:

**CAN ID** -> Upisuju se brojke maksimalne dužine 9 koje se kasnije pretvraju i prikazuju kao HEX brojevi.

**Payload** -> Upisuju se HEX brojevi koji su zamišljeni kao payload. Veličine 8 byta. Osam textbox polja za unos sa maksimalnom dužinom jednog polja od 2 znamenke.

**Def. Payload** -> Prilikom pokretanja aplikacije se upisuje početni payload koji se može izmjeniti kako korisnik želi. Upisuje se : 0123456789ABCDEF. Upisuju se HEX brojevi koji su zamišljeni kao payload. Veličine 8 byta. Osam textbox polja za unos sa maksimalnom dužinom jednog polja od 2 znamenke.

**Signal** -> Redni broj bytea unutar payloada. Checkbox je zamišljen tako da potvrdi koji bayt želimo sa tipkom Copysignal kopirati iz Input payloada u Output. Samo označeni checkboxi se kopiraju.

## Button:

**Default** -> Briše dosadašnje podatke i stvara izgled aplikacije kao prilikom pokretanja.

**Send CopyTelegram** -> Kopira Input payload u Output payload.

**Send CopySignal** -> Kopira Input payload ovisno o potvrdi checkboxa u Output payload.

## Output:

**Send** -> Prikazuje se akcija određene tipke. Opisuje se akcija koja se dogodila. Prikazuje prijašnje stanje payloada ovisno o CAN ID te Input ili Otput te stanje nakon pritiska na tipku.

## Greške:

**Greška CAN ID** -> Prikazuje se greška ako nismo upisali CAN ID.

**Greška Payload** -> Prikazuje se greška ako nismo upisali payload.

### U izradi:

**Ciklus slanja poruka** -> Šalje određen broj poruka svakih odabranih ms.

**Broj poslanih poruka** -> Šalje određen broj poruka svakih odabranih ms.
