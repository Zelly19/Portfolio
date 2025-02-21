# author: Payton Zellmer
# description: A Shape Class -- designed to be inherited
#              defines attributes common to all shapes:
#               x,y, width, height, color, canvas, and an ID number

import random

class Shape:
    
    # initialization method
    # x -- x position of upper left corner of the shape
    # y -- y poisition of upper left corner of shape
    # width -- the width of the shape
    # height -- the height of the shape
    # color -- string; color of ball to be drawn
    # canvas -- window canvas, part of tkinter
    def __init__(self,x,y,width,height,color, canvas):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.color = color
        self.canvas = canvas
        self.id = random.random()
    
    def overlap(self, s):
        '''
        parameter is another shape object
        overlap returns True if this shape overlaps the shape given in the parameter
        otherwise, returns False
        '''
        l1_x = self.x
        l1_y = self.y
        l2_x = s.x
        l2_y = s.y
        r1_x = self.x + self.width
        r1_y = self.y + self.height
        r2_x = s.x + s.width
        r2_y = s.y + s.height
        
        # If one rectangle is on left side of other
        if l1_x > r2_x or l2_x > r1_x:
            return False
        
        # If one rectangle is above other 
        if(l1_y > r2_y or l2_y > r1_y): 
            return False
    
        return True
    