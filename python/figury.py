from linia import Linia, Punkt

class Figura():
    def __init__(self, kolor):
        self.kolor = kolor

    def getKolor(self):
        return self.kolor

    def setKolor(self, kolor):
        self.kolor = kolor


class Trojkat(Figura):
    def __init__(self, kolor, p1, p2, p3):
        super().__init__(kolor)
        self.l1 = Linia(p1, p2)
        self.l2 = Linia(p2, p3)
        self.l3 = Linia(p3, p1)

    def __str__(self):
        return f"{self.kolor} trojkat: {self.l1} {self.l2} {self.l3}"


class Czworokat(Figura):
    def __init__(self, kolor, p1, p2, p3, p4):
        super().__init__(kolor)
        self.l1 = Linia(p1, p2)
        self.l2 = Linia(p2, p3)
        self.l3 = Linia(p3, p4)
        self.l4 = Linia(p4, p1)

    def __str__(self):
        return f"{self.kolor} czworokat: {self.l1} {self.l2} {self.l3} {self.l4}"


class Prostokat(Czworokat):
    def __init__(self, kolor, p1, p2):
        p3 = Punkt(p1.x, p2.y)
        p4 = Punkt(p2.x, p1.y)
        super().__init__(kolor, p1, p4, p2, p3)

    def __str__(self):
        return f"{self.kolor} prostokat: {self.l1} {self.l2} {self.l3} {self.l4}"


class Kwadrat(Prostokat):
    def __init__(self, kolor, p1, bok):
        p2 = Punkt(p1.x+bok, p1.y+bok)
        super().__init__(kolor, p1, p2)

    def __str__(self):
        return f"{self.kolor} kwadrat: {self.l1} {self.l2} {self.l3} {self.l4}"