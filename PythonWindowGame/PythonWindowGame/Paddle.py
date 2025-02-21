from Shape import*

class Paddle(Shape):
    def __init__(self,x,y,color,canvas):
        Shape.__init__(self,x,y,180,20,color,canvas)
    def draw(self):
        self.canvas.delete("paddle"+str(self.id))
        self.canvas.create_rectangle(self.x,self.y,self.x + self.width,
                                     self.y +self.height, fill=self.color,
                                     tags="paddle"+str(self.id))