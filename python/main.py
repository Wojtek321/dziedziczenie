from figury import Trojkat, Czworokat, Prostokat, Kwadrat
from linia import Punkt

trojkat = Trojkat("zielony", Punkt(1, 1), Punkt(2, 5), Punkt(3, 4))
print(trojkat)

czworokat = Czworokat("czerwony", Punkt(2, 2), Punkt(3, 5), Punkt(1, 3), Punkt(8, 1))
print(czworokat)

prostokat = Prostokat("fioletowy", Punkt(1, 1), Punkt(5, 5))
print(prostokat)

kwadrat = Kwadrat("zolty", Punkt(5, 5), 2)
print(kwadrat)