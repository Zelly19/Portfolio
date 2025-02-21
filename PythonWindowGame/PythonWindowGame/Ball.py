# name: Payton Zellmer
# description: A Ball Class, inherits from Shape
# The Ball class keeps track of position, diameter, speed, and going_up values for a Ball

from Shape import *
import tkinter
class Ball(Shape):

    # initialization method
    # x -- x position of upper left corner of ball
    # y -- y poisition of upper left corner of ball
    # color -- string; color of ball to be drawn
    # diameter -- diameter of ball
    # canvas -- window canvas, part of tkinter
    def __init__(self, x, y, color, diameter, canvas):
        self.img = tkinter.PhotoImage(file="wars.gif")
        Shape.__init__(self,x,y,diameter, diameter, color, canvas)
        self.diameter = diameter
        self.speed_x = 10
        self.speed_y = 10

    def move(self):
        # update ball values for x and y update according to speed
        # bounce ball off of walls
        
        self.x += self.speed_x
        self.y += self.speed_y
        
        if self.x + self.width > self.canvas.winfo_width() or self.x < 0:
            self.speed_x = -self.speed_x
        
        if self.y + self.height > self.canvas.winfo_height() or self.y < 0:
            self.speed_y = -self.speed_y
    
    def bounce_vert(self):
        # bounce vertically
        if self.speed_y > 0: # Add this to fix block go thru # or self.speed_y < 0:
            self.speed_y = -self.speed_y

    def hit_bottom(self):
        # if bottom of ball hit the bottom of the canvas
        #   removes ball from the canvas
        #   returns True
        # otherwise, returns False
        if self.y + self.height > self.canvas.winfo_height():
            self.canvas.delete("ball"+str(self.id))
            return True
        else:
            return False

    def draw(self):
        #draw the ball
        self.canvas.delete("ball"+str(self.id))
        self.canvas.create_image(self.x + self.diameter/2, self.y + self.diameter/2, image=self.img, tags="ball" +str(self.id))
                                