module Lab4a where

import Data.List 
import Data.Ord ()


-- Exercise set 4a:
-- 
--Helped By: Professor Case, Website
--
-- * using type classes
-- * working with lists
--
-- Type classes you'll need
--  * Eq
--  * Ord
--  * Num
--  * Fractional
--
-- Useful functions:
--  * maximum
--  * minimum
--  * sort



------------------------------------------------------------------------------
-- Ex 1: implement the function allEqual which returns True if all
-- values in the list are equal.
--
-- Examples:
--   allEqual [] ==> True
--   allEqual [1,2,3] ==> False
--   allEqual [1,1,1] ==> True
--
-- PS. check out the error message you get with your implementation if
-- you remove the Eq a => constraint from the type!

allEqual :: Eq a => [a] -> Bool
allEqual [] = True 
allEqual [x] = True 
allEqual (x:y:xs) = x==y && allEqual(y:xs)

------------------------------------------------------------------------------
-- Ex 2: implement the function distinct which returns True if all
-- values in a list are different.
--
-- Hint: a certain function from the lecture material can make this
-- really easy for you.
--
-- Examples:
--   distinct [] ==> True
--   distinct [1,1,2] ==> False
--   distinct [1,2] ==> True

distinct :: Eq a => [a] -> Bool
distinct list = case list of
    []      -> True
    (x:xs)  -> notElem x xs && distinct xs


------------------------------------------------------------------------------
-- Ex 3: implement the function middle that returns the middle value
-- (not the smallest or the largest) out of its three arguments.
--
-- The function should work on all types in the Ord class. Give it a
-- suitable type signature.
--
-- Examples:
--   middle 'b' 'a' 'c'  ==> 'b'
--   middle 1 7 3        ==> 3

middle :: Ord a => a -> a -> a -> a
middle a b c 
    | a > b && a < c = a
    | b > a && b < c = b
    | b < a && b > c = b
    | c > a && c < b = c
    | a > b && a > c = c
    | a == b && b == c = a
    | otherwise = a
 ------------------------------------------------------------------------------
-- Ex 4: return the range of an input list, that is, the difference
-- between the smallest and the largest element.
--
-- Your function should work on all suitable types, like Float and
-- Int. You'll need to add _class constraints_ to the type of range.
--
-- It's fine if your function doesn't work for empty inputs.
--
-- Examples:
--   rangeOf [4,2,1,3]          ==> 3
--   rangeOf [1.5,1.0,1.1,1.2]  ==> 0.5

rangeOf :: (Ord a) => (Num a) => [a] -> a
rangeOf [] = 0
rangeOf [x] = x
rangeOf xs = maximum xs - minimum xs

------------------------------------------------------------------------------
-- Ex 5: given a list of lists, return the longest list. If there
-- are multiple lists of the same length, return the list that has
-- the smallest _first element_.
--
-- (If multiple lists have the same length and same first element,
-- you can return any one of them.)
--
-- Give the longest function a suitable type.
--
-- Examples:
--   longest [[1,2,3],[4,5],[6]] ==> [1,2,3]
--   longest ["bcd","def","ab"] ==> "bcd"

longest :: Ord a => [[a]] -> [a]
longest = foldr longHelp [] 

--early :: Ord a => [a] -> [a] -> [a]
--early xs xss= if head xs < head xss then xs else xss
longHelp :: Ord a => [a] -> [a] -> [a]
longHelp xs ys
    | length xs < length ys = ys
    | length xs > length ys = xs
    | otherwise = if head xs > head ys then ys else xs
--longest2 :: Ord a => [[a]] -> [a]
--longest2 xss = snd $ maximum $ [(length xs, xs) | xs <- xss]
------------------------------------------------------------------------------
-- Ex 6: Implement the function incrementKey, that takes a list of
-- (key,value) pairs, and adds 1 to all the values that have the given key.
--
-- You'll need to add _class constraints_ to the type of incrementKey
-- to make the function work!
--
-- The function needs to be generic and handle all compatible types,
-- see the examples.
--
-- Examples:
--   incrementKey True [(True,1),(False,3),(True,4)] ==> [(True,2),(False,3),(True,5)]
--   incrementKey 'a' [('a',3.4)] ==> [('a',4.4)]

incrementKey :: (Eq k, Num v)=> k -> [(k,v)] -> [(k,v)]
incrementKey ak = map keyHelp  
    where keyHelp (k,v) = if ak == k then (k,v+1) else (k,v)
-- I know what to use and what to do, but i cannot get it syntaxwise to work.

------------------------------------------------------------------------------
-- Ex 7: compute the average of a list of values of the Fractional
-- class.
--
-- There is no need to handle the empty list case.
--
-- Hint! since Fractional is a subclass of Num, you have all
-- arithmetic operations available
--
-- Hint! you can use the function fromIntegral to convert the list
-- length to a Fractional

average :: (Fractional a, Num a) => [a] -> a
average [] = error "Taking average of 0 numbers"
average xs = total / fromIntegral counter where
    (total, counter) = sumAndCount xs

sumAndCount :: (Num a) => [a] -> (a, Int)
sumAndCount  = foldr (\x (s, c) -> (s + x, c + 1)) (0, 0) 

