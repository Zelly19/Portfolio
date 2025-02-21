#author:Payton Zellmer
#date: 11/14/19
#description: This is a simple game of paddle with a theme of MLG pro gamer to it. where when you hit the box up on top it will give you bonus points.
#proposed points (15 of 15): i believe that i would gain all 15 points. i have a game unique to pong with a bonus block. I have many sounds along with some images.
#The game shows the score and game over as well.

from Paddle import *
from Ball import *
from tkinter import *
import pygame
from Block import *
class Animation:
    def __init__(self):
        pygame.init()
        self.sound = pygame.mixer.Sound("HITMARKER1.wav")
        self.sound2 = pygame.mixer.Sound("whatcha.wav")
        self.sound3 = pygame.mixer.Sound("wow.wav")
        self.sound4 = pygame.mixer.Sound("upone.wav")
        self.sound5 = pygame.mixer.Sound("Arena.wav")
        #Sets the volume for the sound at 4 times the volume. Don't worry it won't be too loud.
        #volume function is SoundVarible.set_volume(1.0)..... plays at 100% volume.... 0.9 plays at 90% and so on.
        self.sound5.set_volume(4.0)
        window = Tk()
        window.title("CS 65") # Set a title
        pygame.mixer.Sound.play(self.sound5)

        # establish the canvas
        self.width = 600 # Width of the self.canvas
        self.height = 400 # Height of the self.canvas
        self.canvas = Canvas(window, bg = "white",
            width = self.width, height = self.height)
        self.canvas.pack()
        
        #Creates the block in which if the ball hits will add 5 to the score as well as play a sound.
        self.block = Block(280,50,"black",self.canvas)
        
        # create a paddle
        self.paddle = Paddle(200, 380, "black", self.canvas)
        window.bind("<Motion>", self.move_paddle)
        # create an empty list
        self.ball_list = []
        self.add_ball()
        # start the animation loop
        # The call to self.animate() should be the last line in the __init__function.
        self.animate()

    def move_paddle(self, event):
        self.paddle.x = event.x - self.paddle.width/2
        #print("mouse position:", event.x, event.y)
        
    def add_ball(self):
        # create a ball and add it to the list
        diameter = 30
        start_x = random.randint(0,self.width-diameter)
        start_y = random.randint(0,self.height/2) # top half of screen
        ball = Ball(start_x, start_y, "red", diameter, self.canvas)
        self.ball_list.append(ball)
    # animation
    def animate(self):
        frame = 0
        hits = 0
        while True:
            self.canvas.after(20) # Sleep
            self.canvas.update() # Update self.canvas
            #displays the score during the game.
            self.canvas.delete("score")
            self.canvas.create_text(525,40, text="Score: "+ str(hits),
                                    font=("Times New Roman", 25),
                                    fill ="black", tags="score")
            frame += 1
            if len(self.ball_list) == 0:
                # game over
                self.canvas.delete("gameOver")
                self.canvas.create_text(300,200, text="Game Over",
                                        font=("times new roman",60),
                                        fil="red",tags="gameOver")
                pygame.mixer.Sound.play(self.sound2)
                pygame.mixer.Sound.stop(self.sound5)
                break
                
            self.paddle.draw()
            self.block.draw()
            #adds a ball everytime the game hits a hundred frame mark, ex: 100, 200, 300, 400.....
            if frame %100 == 0:
                self.add_ball()
            # loop through all of the items in the list
            # move the ball and draw it
            for b in self.ball_list:
                b.move()
                b.draw()
                
                # if ball hits the paddle, make it bounce off the paddle
                if self.paddle.overlap(b):
                    b.bounce_vert()
                    hits +=1
                    pygame.mixer.Sound.play(self.sound)
                if self.block.overlap(b):
                    b.bounce_vert()
                    hits += 5
                    pygame.mixer.Sound.play(self.sound4)
                # if ball hits the bottom; remove it from the list 
                if b.hit_bottom():
                    self.ball_list.remove(b)
                    pygame.mixer.Sound.play(self.sound3)

                        
                    
                    
            
        
Animation()