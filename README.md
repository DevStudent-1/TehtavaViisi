# TehtavaViisi

Lisätään vielä tähän ajatuspohdinta alkuun:

- Model -> Luokka joka kuvasta jotain esim. Tuotetta
- View -> Pelkkä näkymä jossa näytetään vain sen tuotteen tiedot
- Component -> Paikka mihin tehdään kaikki koodi sen tuotteen muokkaamista/poistamista jne 

View ja Component keskustelevat keskenään kun model kuvastaa jotain

## Harjoitus joka kuuluu Sovellusarkkitehtuuri kurssille.

Tein ProductController.cs -kontrollorin vastaamaan Web -sivuilla olevan Products kutsua. 
Vai miten tämä sanottaisiin. 
_Layout.cshtml tiedostossa lisättiin rivi:
Jossa eritellään seuraavia asioita:
- asp-controller -> mikä kontrolleri -> productController joka löytyy ihan nimellä Product.
- asp-action -> toiminto IAction -> ja sieltä löytyy metodi nimeltä Product ja käyttäjälle näytetään linkkinä Products
  
![a](https://github.com/user-attachments/assets/f29aeb38-e824-41d9-a322-25636fbacc14)

ProductController nyt tässä tapauksessa on eriytetty hoitamaan kaikkea mitä tapahtuu kun painetaan Product. Voin olla väärässäkin mutta näin sen ajattelen.
Löytyy metodi joka aiemassa kuvassa esitettynä ASP .NET osaa itse paikallistaa sen täältä. Eli metodin nimi ei voilla "Röllipeikko" jos asp-action ohjaa etsimään "product" nimistä metodia.
Lisäksi testasin System.Text.Json nimiavaruudesta .NET mukana kulkevaa Jsonserializeria mitä on aiemmilla kurssilla käytetty. En siksi ladannut tähän NewtonSoftin nugettia. 

![b](https://github.com/user-attachments/assets/7000d2b0-e639-4f65-8a05-59311ccf4390)

Product.cs luokka nyt mallintaa tietoa tuotteesta. Mitä ominaisuuksia sillä oletetaan olevan.

![c](https://github.com/user-attachments/assets/6f4a2792-9561-48d8-8cce-66400a7c101b)

products.json nyt kuvaa sitten tietopankkia kyseisistä tuotteista. Nehän voi olla vaikka jossain APIn takana tai tietokannassa suoraan tässä tai vastaava. Tässä ne on nyt JSON muodossa. 

![d](https://github.com/user-attachments/assets/928384ba-de63-4afc-a3b1-c661c0248fc1)
