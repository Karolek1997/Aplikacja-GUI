# Moje repozytorium
Projekt zawiera aplikacje GUI do obsługi bazy danych sklepu internetowego.

# Główne okno aplikacji
![Example Image](ZdjęciaAplikacji/aplikacjascreen2.JPG)

Okno aplikacji umożliwia:
- dodanie nowych produktów do bazy danych,
- dodanie ceny do produktów w danym modelu, w danej kategorii produktu,
- dodanie klientów do bazy danych,
- wyświetlanie listy klientów oraz ich danych
- wyświetlanie listy produktów
- wyświetlanie zamówień
- widok podsumowania sprzedaży w danym roku (dochód netto, dochód brutto, liczba zamówień 'Zakończonych")

# Okno dodawania produktów do sklepu
![Example Image](ZdjęciaAplikacji/oknododajprodukty.JPG)

Okno Dodaj produkt umożliwia dodawanie produktów do bazy danych sklepu w wyznaczonych kategoriach produktu z listy rozwijanej. 
Po wyborze kategorii produktu można dodać następujące informacje:
- producent,
- model,
- rozmiar,
- kolor,
- dostępna ilość.
Procedura, która obsługuje okno zezwala na wartości null'owe dla niektórych parametrów wejściowych. Dodatkowo istnieje trigger, który korzysta z tabeli walidacyjnej i uzależnia rozmiar od wybranej kategorii produktu
np. nie można dodać rozmiaru 45 do obuwia w kategorii damskiej.
W przypadku, kiedy produkt istnieje już w bazie danych i ma on określoną dostępną ilość to procedura sumuję aktualna i nowo-dodaną ilość produktów - zwiększając zatem dostępną do zamówienia ilość (stan magazynowy).

# Okno dodawania/aktualizowania ceny do wybranych produktów
![Example Image](ZdjęciaAplikacji/oknododajcene.JPG)

Okno Dodaj cenę umożliwia dodanie/aktualizowanie (jeśli istnieje) ceny netto wybranego modelu produktu z listy rozwijanej w wybranej kategorii.

# Okno dodawania klientów
![Example Image](ZdjęciaAplikacji/oknododajklientow.JPG)

Okno Dodaj klientów umożliwia ręczne dodanie klienta do bazy danych sklepu. 
Zastosowane rozwiązania nie zezwalają na duplikaty loginu i emaila. Dodatkowo blokowane jest dodawanie kodu pocztowego w innym formacie niż xx-xxx.

# Okno dodawania opisów
![Example Image](KotWButach/oknododajopis.jpg)

Okno dodawania opisów umożliwia globalne dodanie opisu dla danego modelu dla każdej kategorii produktu jednocześnie. Model należy wybrać z listy rozwijanej.

# Okno do wyświetlania klientów
![Example Image](ZdjęciaAplikacji/oknolistaklientow.JPG)

Okno Lista klientów umożliwia wyświetlanie listy klientów sklepu wraz z ich pełnymi danymi.

# Okno do wyświetlania produktów
![Example Image](ZdjęciaAplikacji/oknolistaproduktow.JPG)

Okno Lista produktów umożliwia wyświetlanie listy produktów sklepu wraz z danymi dotyczącymi koloru, modelu, producenta...

# Okno do wyświetlania zamówien
![Example Image](ZdjęciaAplikacji/oknolistazamowien.JPG)

Okno Sprawdz zamówienia umożliwia przegląd zamówien złozonych w sklepie.

# Okno podsumowania sprzedaży
![Example Image](ZdjęciaAplikacji/podsumowaniesprzedazy.JPG)

Okno Podsumowanie sprzedaży służy do szybkiego podsumowania dochodu netto i brutto oraz w liczby zrealizowanych zamówień w danym roku.
