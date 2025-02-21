-- Exercise set 5a

module Lab5a where

------------------------------------------------------------------------------
-- Ex 1: Define the type Vehicle that has four constructors: Bike,
-- Bus, Tram and Train.
--
-- The constructors don't need any fields.

data Vehicle = Bike | Bus | Tram | Train  
------------------------------------------------------------------------------
-- Ex 2: Define the type BusTicket that can represent values like these:
--  - SingleTicket
--  - MonthlyTicket "January"
--  - MonthlyTicket "December"

data BusTicket = SingleTicket | MonthlyTicket String 
------------------------------------------------------------------------------
-- Ex 3: define a datatype Person, which should contain the age (an
-- Int) and the name (a String) of a person.
--
-- Also define a Person value fred, and the functions getAge, getName,
-- setAge and setName (see below).

data Person = PersonDefined Int String
  deriving Show

-- fred is a person whose name is Fred and age is 90
fred :: Person
fred = PersonDefined 90 "Fred"

-- getName returns the name of the person
getName :: Person -> String
getName (PersonDefined i s) = s

-- getAge returns the age of the person
getAge :: Person -> Int
getAge (PersonDefined i _) = i

-- setName takes a person and returns a new person with the name changed
setName :: String -> Person -> Person
setName name (PersonDefined _ p) = PersonDefined 1 name

-- setAge does likewise for age
setAge :: Int -> Person -> Person
setAge age (PersonDefined p name) = PersonDefined age name

------------------------------------------------------------------------------
-- Ex 4: define a datatype Position which contains two Int values, x
-- and y. Also define the functions below for operating on a Position.
--
-- Examples:
--   getY (up (up origin))    ==> 2
--   getX (up (right origin)) ==> 1

data Position = Cordinate Int Int

-- origin is a Position value with x and y set to 0
origin :: Position
origin = Cordinate 0 0

-- getX returns the x of a Position
getX :: Position -> Int
getX (Cordinate x _) = x

-- getY returns the y of a position
getY :: Position -> Int
getY (Cordinate _ y) = y

-- up increases the y value of a position by one
up :: Position -> Position
up (Cordinate x y) = Cordinate x (y + 1)

-- right increases the x value of a position by one
right :: Position -> Position
right (Cordinate x y) = Cordinate (x+1) y 

left :: Position -> Position
left (Cordinate x y) = Cordinate (x-100000) y 
------------------------------------------------------------------------------
-- Ex 5: define a parameterized datatype OneOrTwo that contains one or
-- two values of the given type. The constructors should be called One and Two.
--
-- Examples:
--   One True         ::  OneOrTwo Bool
--   Two "cat" "dog"  ::  OneOrTwo String

data OneOrTwo typeBoolString = One typeBoolString | Two typeBoolString typeBoolString
  deriving Show
------------------------------------------------------------------------------
-- Ex 6: define a recursive datatype KeyVals for storing a set of
-- key-value pairs. There should be two constructors: Empty and Pair.
--
-- Empty represents an empty collection. It should have no fields.
--
-- Pair should have three fields, one for the key, one for the value,
-- and one for the rest of the collection (of type KeyVals)
--
-- The KeyVals datatype is parameterized by the key type k and
-- the value type v.
--
-- For example:
--
--  Pair "cat" True (Pair "dog" False Empty)  ::  KeyVals String Bool
--
-- Also define the functions toList and fromList that convert between
-- KeyVals and lists of pairs.

data KeyVals k v = Empty |Pair k v (KeyVals k v)
  deriving Show

toList :: KeyVals k v -> [(k,v)]
toList (Pair k v a) = (k,v):toList a
toList Empty = []

fromList :: [(k,v)] -> KeyVals k v
--fromList [(k,v),(a,s)] = Pair k v (Pair a s Empty)
--fromList [(k,v),(a,s),(d,j)] = Pair k v (Pair a s (Pair d j Empty))
--fromList [(k,v),(a,s),(d,j),(g,h)] = Pair k v (Pair a s (Pair d j (Pair g h Empty)))
--fromList [(k,v),(a,s),(d,j),(g,h),(o,p)] = Pair k v (Pair a s (Pair d j (Pair g h (Pair o p Empty))))
fromList ((a,v):xs) = Pair a v (fromList xs) 
fromList [] = Empty
--fromList [(k,v),(a,s),(d,j),(g,h),(o,p),(b,l)] = Pair k v (Pair a s (Pair d j (Pair g h (Pair o p (Pair b l Empty)))))
