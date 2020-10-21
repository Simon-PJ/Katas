;; - [Link](https://github.com/garora/TDD-Katas/blob/master/KatasReadme.md#the-fizzbuzz-kata)
;; - Write a program that prints the numbers from 1 to 100, but for multiples of three print "Fizz"
;;   instead of the number and for the multiples of five print "Buzz". For numbers which are multiples
;;   of both three and five print "FizzBuzz".
;; - Create a method to accept a single number
;; - Create test to verify supplied number within the range 1 to 100

(defn fizzer? [num] (int? (/ num 3)))

(defn buzzer? [num] (int? (/ num 5)))

(defn fizz-buzzer? [num] (and (fizzer? num) (buzzer? num)))

(def conditions [
    { :test fizzer? :text "Fizz" }
    { :test buzzer? :text "Buzz" }
    { :test fizz-buzzer? :text "FizzBuzz" }
])

(defn fizz-buzz-single
    [num]
    (let [lastPassed (last (filter #((:test %) num) conditions))]
        (if lastPassed (:text lastPassed) num)))

(defn fizz-buzz [from to]
    (map fizz-buzz-single (range from (inc to))))

(fizz-buzz 1 100)