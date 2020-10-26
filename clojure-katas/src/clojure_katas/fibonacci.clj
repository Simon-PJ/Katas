;; https://www.codewars.com/kata/553e6558e848c5a3180000bc
;; Fibonacci number (Fibonacci sequence), named after mathematician Fibonacci, is a sequence of numbers that looks like this:
;; 0, 1, 1, 2, 3, 5, 8, 13,...
;; You get first two starting numbers, 0 and 1, and the next number in the sequence is always the sum of the previous two numbers. Fibonacci introduced it in 1202, in his book Liber Abaci.
;; So what will be your task? You should write a function fib, that takes one parameter steps, and returns a number from the Fibonacci sequence, based on the parameter steps, which determines the position in Fibonacci number.
;; For example fib(0) returns 0, fib(4) returns 3, fib(15) returns 610.

(defn fib-at
    [step]
    (if (= step 0)
        0
        (:n (reduce
            (fn [tally _] { 
                :n-1 (:n tally)
                :n (+ (:n-1 tally) (:n tally)) })
            { :n-1 0 :n 1 }
            (range 1 step)))))
    

(fib-at 0) ;0
(fib-at 4) ;3
(fib-at 15) ;610