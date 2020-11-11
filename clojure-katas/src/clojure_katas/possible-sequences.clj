;; Given a string (e.g. "aaaa") and a list of possible sub strings (e.g. "a" "aa" "aaa"), find all the
;; possible ways to build the longer string from the smaller components

(defn possible-sequences
    ([str sub-strings]
        (possible-sequences str sub-strings []))
    ([str sub-strings sequence]
    (if (= (count str) 0)
        sequence
        (map 
            (fn [sub-str] (possible-sequences (subs str (count sub-str)) sub-strings (conj sequence sub-str)))
            (filter #(clojure.string/starts-with? str %) sub-strings)))))

;; Should give:
;; a a a a
;; a a aa
;; a aa a
;; aa a a
;; a aaa
;; aaa a
(possible-sequences "aaaa" ["a" "aa" "aaa"])