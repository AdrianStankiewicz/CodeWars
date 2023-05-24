# Kata content:
Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

```i``` increments the value (initially ```0```)  
```d``` decrements the value  
```s``` squares the value  
```o``` outputs the value into the return array  

Invalid characters should be ignored.
```py
parse("iiisdoso")  ==>  [8, 64]
```
___
# Provided tests:
```Py
import codewars_test as test
from solution import parse

@test.describe("Sample tests")
def fixed_tests():
    @test.it("Some examples")
    def tests():
        test.assert_equals(parse("ooo"), [0,0,0])
        test.assert_equals(parse("ioioio"), [1,2,3])
        test.assert_equals(parse("idoiido"), [0,1])
        test.assert_equals(parse("isoisoiso"), [1,4,25])
        test.assert_equals(parse("codewars"), [0])

```