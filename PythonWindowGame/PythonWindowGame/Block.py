from Shape import*

class Block(Shape):
    def __init__(self,x,y,color,canvas):
        Shape.__init__(self,x,y,80,20,color,canvas)
    def draw(self):
        self.canvas.delete("block"+str(self.id))
        self.canvas.create_rectangle(self.x,self.y,self.x + self.width,
                                     self.y +self.height, fill=self.color,
                                     tags="block"+str(self.id))