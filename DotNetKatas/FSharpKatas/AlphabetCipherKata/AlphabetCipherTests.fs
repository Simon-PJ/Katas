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

[<Theory>]
[<InlineData("a", "c", "y")>]
[<InlineData("y", "z", "z")>]
[<InlineData("a", "a", "a")>]
[<InlineData("e", "m", "s")>]
[<InlineData("t", "d", "q")>]
[<InlineData("k", "f", "f")>]
let ``DecodeChar give the correct result`` input keyword expected =
    Assert.Equal(expected, DecodeChar input keyword)

[<Theory>]
[<InlineData("hmkbxebpxpmyllyrxiiqtoltfgzzv", "vigilance", "meetmeontuesdayeveningatseven")>]
[<InlineData("egsgqwtahuiljgs", "scones", "meetmebythetree")>]
let ``Can decode given a secret keyword`` input keyword expected = 
    Assert.Equal(expected, Decode input keyword)

[<Theory>]
[<InlineData("s", "e", "m")>]
[<InlineData("q", "t", "d")>]
[<InlineData("f", "k", "f")>]
[<InlineData("a", "a", "a")>]
[<InlineData("z", "y", "z")>]
[<InlineData("y", "a", "c")>]
[<InlineData("m", "h", "v")>]
let ``DecipherChar gives then correct result`` input output expected =
    Assert.Equal(expected, DecipherChar input output)

[<Theory>]
[<InlineData("meetmeontuesdayeveningatseven", "hmkbxebpxpmyllyrxiiqtoltfgzzv", "vigilance")>]
[<InlineData("meetmebythetree", "egsgqwtahuiljgs", "scones")>]
[<InlineData("hellofromrussia", "hfnlphoontutufa", "abcabcx")>]
let ``Can decipher keyword given and input and output`` input output expected = 
    Assert.Equal(expected, Decipher input output)
