# String Calculator Kata

- [Link](http://osherove.com/tdd-kata-1/)
- Only test for correct inputs in this kata
- Create a simple String calculator with a method int Add(string numbers)
	- The method can take 0, 1, or 2 numbers, and will return their sum (for an empty string it will return 0)
	  for example "" or "1" or "1,2"
	- Start with the simplest test case of an empty string and move on to 1 and two numbers
	- Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
	- Remember to refactor after each passing test
- Allow the Add method to handle an unknown amount of numbers
- Allow the add method to handle new lines between numbers (instead of commas).
	- The following input is ok: "1\n2,3" (will equal 6)
	- The following input is not ok: "1,\n"
- Support different delimeters
	- To change a delimete, the beginning of the string will contain a separate line that looks like this:
	  "//[delimeter]\n[numbers...]" for example "//;\n1;2" should return three where the default delimeter is ';'.
	- The first line is optional. All existing scenarios should still be supported