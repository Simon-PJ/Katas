module AlphabetCipherTests

open Xunit
open AlphabetCipher

[<Theory>]
[<InlineData("s", "m", "e")>]
[<InlineData("q", "d", "t")>]
[<InlineData("f", "f", "k")>]
[<InlineData("a", "a", "a")>]
[<InlineData("z", "z", "y")>]
[<InlineData("y", "c", "a")>]
let ``Intersect returns the correct value`` x y expected =
    Assert.Equal(expected, GetIntersect x y)

[<Theory>]
[<InlineData("afairlylonginput", "keyword", "keywordkeywordke")>]
[<InlineData("samelength", "samelength", "samelength")>]
let ``Repeat keyword gives then correct result`` input keyword expected =
    Assert.Equal(expected, RepeatKeyword input keyword)

[<Theory>]
[<InlineData("meetmeontuesdayeveningatseven", "vigilance", "hmkbxebpxpmyllyrxiiqtoltfgzzv")>]
[<InlineData("meetmebythetree", "scones", "egsgqwtahuiljgs")>]
let ``Can encode given a secret keyword`` input keyword expected = 
    Assert.Equal(expected, Encode input keyword)
