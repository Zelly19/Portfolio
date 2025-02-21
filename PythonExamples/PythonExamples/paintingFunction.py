def gallons_of_paint(height,width,walls):
    result=((height*width)*walls)/400
    #Typical gallon of paint covers 400 sq ft
    return result

height=int(input("How high are the walls in feet? "))
width=int(input("How wide are the walls in feet? "))
walls=int(input("How many walls are there? "))

gallons=gallons_of_paint(height,width,walls)
print("Painting",walls,"walls that are",height,"ft high and",width,"ft wide will require",gallons,"gallons of paint")