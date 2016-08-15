# Ravintolaskuri Windows forms - C# / JSON

Työkalut: Visual Studio 2012.

Sovellus on toteutettu vuoden 2014 alussa ja refaktoroitu elokuussa 2016.

Sovellukseen voi tallentaa haluamansa ruoka-aineet ja niiden makroarvot. Ruokia voi sitten lisätä listoista, jolloin sovellus laskee yhteen kaikkien valittujen ruokien arvot. Käyttäjä voi myös pitää makropäiväkirjaa. Ravintojen makroarvot ja päiväkirjatiedot tallennetaan ja ladataan ohjelman sisäisistä Json-tiedostoista. Niistä on myös mahdollista luoda varmuuskopiot, jotka on voidaan ladata ohjelman ulkopuolelta ja korvata ohjelman sisäiset Json-tiedostot. Tällä tavalla vältytään tietojen menetykseltä, jos ohjelma joudutaan esimerkiksi poistamaan koneelta jostain syystä.

Testaajan on muutettava SaveData.cs -tiedostossa tiedostopolut vastaamaan oman ympäristön polkuja, jotta sovellus toimii oikein.

Sovelluksesta on luotu omaan käyttöön asennuspaketti, jonka avulla sovellus asennetaan tietokoneeseen. Vaatii toimiakseen Framework 4.5:n. Käytän tätä sovellusta oman ruokavalion suunnittelussa aina kun tarpeellista. Päiväkirja toteutettiin vain kokemuksen kartuttamiseksi, eikä sitä ole juurikaan käytetty varsinaisena päiväkirjana.
