;; Write a simple String Sum utility with a function *string Sum(string num1, string num2)*, which can accept 
;; only natural numbers and will return their sum. Replace entered number with 0 (zero) if entered number is
;; not a natural number. A natural number is a positive integer including 0.
;; [Link](https://github.com/garora/TDD-Katas#string-sum-kata)

(defn parse-num
    [str]
    (try (Integer. str)
        (catch Exception ex 0)))

(defn sum
    [num1 num2]
    (apply + (map parse-num [num1 num2])))

(sum "1" "2") ;3
(sum "not a num" "5") ;5