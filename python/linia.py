class Punkt():
    def __init__(self, *args):
        if len(args) == 0:
            self.x = 0
            self.y = 0
        elif isinstance(args[0], Punkt):
            self.x = args[0].x
            self.y = args[0].y
        else:
            self.x = args[0]
            self.y = args[1]

    def __str__(self):
        return f"({self.x}, {self.y})"


class Linia():
    def __init__(self,*args):
        if(len(args)==0):
            self.p1 = Punkt()
            self.p2 = Punkt()
        elif(len(args)==2):
            self.p1 = Punkt(args[0])
            self.p2 = Punkt(args[1])
        else:
            self.p1 = Punkt(args[0].p1)
            self.p2 = Punkt(args[0].p2)

    def __str__(self):
        return "{" + self.p1.__str__() + ", " + self.p2.__str__() + "}"