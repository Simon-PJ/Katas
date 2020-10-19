;; - [Link](https://github.com/garora/TDD-Katas/blob/master/KatasReadme.md#the-oddeven-kata)
;; - Write a program that prints numbers within a specified ranges, say 1 to 100. If number
;;  is odd print 'Odd' instead of the number. If the number is even print 'Even' instead of the number.
;;   Else print the number [hint - if number is prime]

;; - Steps
;;     - Prints numbers from 1 to 100
;;     - Print "Even" instead if number if the number is divisible by 2
;;     - Print "Odd" instead of the number if the number is not divisible by two and is not prime
;;     - Print number is it is prime
;;     - Make method accept any number of range instead of 1 to 100
;;     - Create a new method to check odd/even/prime for a single supplied number

; (defn even? [num] (int? (/ num 2)))
; (def odd? (complement even?))

(defn replace-evens
    [num val]
    (if (even? num) "Even" val))

(defn replace-odds
    [num val]
    (if (odd? num) "Odd" val))

(defn prime? [num] (and (not-any? #(int? (/ num %)) (range 2 num)) (> num 2)))

(defn replace-primes
    [num val]
    (if (prime? num) num val))

(defn run-checks
    [num checks]
    (reduce
        (fn [val next-check] (next-check num val))
        num
        checks))

(def replace-numbers #(run-checks % [replace-evens replace-odds replace-primes]))

(def odd-even (map replace-numbers (range 1 101)))
odd-even