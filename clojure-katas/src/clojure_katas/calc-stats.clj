;; - [Link](https://github.com/garora/TDD-Katas/blob/master/KatasReadme.md#kata---coming-next-httpwwwcyber-dojocom)
;; - Your task is to process a sequence of integer numbers to determine the following statistics:
;;     - Minimum value
;;     - Maximum value
;;     - Number of elements in the sequence
;;     - Average value
;; - For example [6, 9, 15, -2, 92, 11]
;;     - Minimum value = -2
;;     - Maximum value = 92
;;     - Number of elements in the sequence = 6
;;     - Average value = 18.166666

(defn mean
    [ints]
    (/ (reduce + ints) (count ints)))

(defn calc-stats
    [ints]
    {
        :min (apply min ints)
        :max (apply max ints)
        :count (count ints)
        :average (mean ints)
    })

(calc-stats [6 9 15 -2 92 11])